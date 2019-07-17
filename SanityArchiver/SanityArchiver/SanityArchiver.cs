using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanityArchiver
{
    public partial class SanityArchiver : MetroFramework.Forms.MetroForm
    {
        public FileInfo SelectedFile { get; set; }
        public DirectoryInfo SelectedDirectory { get; set; }
        public string SourcePath { get; set; }

        public SanityArchiver()
        {
            InitializeComponent();
            SourcePath = @"C:\Users\Tulajdonos\Desktop";
        }

        private void OpenSelectedFileButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(SelectedFile.FullName);
        }

        private void ArchiveButton_Click(object sender, EventArgs e)
        {
            FileUtils fileUtils = new FileUtils();
            fileUtils.Archive(SelectedFile, SourcePath);
            MessageBox.Show($"Successfully archived file to: {SelectedFile.Name}.gz");
        }

        private void ExtractButton_Click(object sender, EventArgs e)
        {
            FileUtils fileUtils = new FileUtils();
            fileUtils.Extract(SelectedFile, SourcePath);
            MessageBox.Show($"Successfully extracted file to: {SelectedFile.Name.Substring(0, SelectedFile.Name.Length - 3)}");
        }

        private void SanityArchiver_Load(object sender, EventArgs e)
        {
            ShowFileList(SourcePath);
            CurrentLocationBox.Text = SourcePath;
        }

        private void ShowFileList(string path)
        {
            FileListView.Items.Clear();
            LoadProgressBar.Value = 0;

            try
            {
                FileExplorer fileExplorer = new FileExplorer(path);
                int maxFilesCount = fileExplorer.Files.Length + fileExplorer.Directories.Length;
                LoadProgressBar.Maximum = maxFilesCount;
                int currentFileCount = 0;
                string currentNum = "";
                Graphics gr = LoadProgressBar.CreateGraphics();


                foreach (var item in fileExplorer.Directories)
                {
                    string[] details = { item.Name, "DIR", fileExplorer.FormatFileSize(fileExplorer.GetDirectorySize(item)), item.LastAccessTime.ToShortDateString(), item.Attributes.ToString() };
                    ListViewItem listViewItem = new ListViewItem(details);
                    FileListView.Items.Add(listViewItem);
                    listViewItem.ImageIndex = 0;
                    currentFileCount += 1;
                    currentNum = currentFileCount + " of " + maxFilesCount + " files loaded.";
                    gr.Clear(LoadProgressBar.BackColor);
                    gr.DrawString(currentNum, SystemFonts.DefaultFont, Brushes.Black, new PointF(
                        (LoadProgressBar.Width / 2) - (gr.MeasureString(currentNum, SystemFonts.DefaultFont).Width / 2.0F),
                        (LoadProgressBar.Height / 2) - gr.MeasureString(currentNum, SystemFonts.DefaultFont).Height / 2.0F));
                    LoadProgressBar.Increment(1);
                }

                foreach (var item in fileExplorer.Files)
                {
                    string[] details = { item.Name, item.Extension, fileExplorer.FormatFileSize(item.Length), item.LastAccessTime.ToShortDateString(), item.Attributes.ToString() };
                    ListViewItem listViewItem = new ListViewItem(details);
                    FileListView.Items.Add(listViewItem);
                    listViewItem.ImageIndex = 1;
                    currentFileCount += 1;
                    currentNum = currentFileCount + " of " + maxFilesCount + " files loaded.";
                    gr.Clear(LoadProgressBar.BackColor);
                    gr.DrawString(currentNum, SystemFonts.DefaultFont, Brushes.Black, new PointF(
                        (LoadProgressBar.Width / 2) - (gr.MeasureString(currentNum, SystemFonts.DefaultFont).Width / 2.0F),
                        (LoadProgressBar.Height / 2) - gr.MeasureString(currentNum, SystemFonts.DefaultFont).Height / 2.0F));
                    LoadProgressBar.Increment(1);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"File or folder cannot be accessed.\n\nError message: {ex.Message}\n\n" +
                        $"Details:\n\n{ex.StackTrace}");
            }
        }

        private ListViewItem SelectedItem { get { return FileListView.SelectedItems.Count > 0 ? FileListView.SelectedItems[0] : null; } }

        private void FileListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Button[] buttons = { EncryptButton, DecryptButton, ArchiveButton, ExtractButton,
                                 OpenSelectedFileButton, AttributesButton };

            foreach (Button button in buttons)
            {
                button.Enabled = true;
            }

            if (SelectedItem != null)
            {
                if (SelectedItem.SubItems[1].Text != "DIR")
                {
                    SelectedFileName.Text = SourcePath + @"\" + SelectedItem.Text;

                    try
                    {
                        SelectedFile = new FileInfo(SourcePath + @"\" + SelectedItem.Text);
                        if (SelectedFile.Attributes.HasFlag(FileAttributes.Encrypted))
                        {
                            EncryptButton.Enabled = false;
                            DecryptButton.Enabled = true;
                        }
                        if (SelectedFile.Extension.Equals("zip") || SelectedFile.Extension.Equals("gz"))
                        {
                            ArchiveButton.Enabled = false;
                            ExtractButton.Enabled = true;
                        }
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show($"Error locating file.\n\nError message: {ex.Message}\n\n" +
                        $"Details:\n\n{ex.StackTrace}");

                        foreach (Button button in buttons)
                        {
                            button.Enabled = false;
                        }
                    }
                }
                else
                {
                    SelectedFileName.Text = SourcePath + @"\" + SelectedItem.Text;

                    try
                    {
                        SelectedDirectory = new DirectoryInfo(SourcePath + SelectedItem.Text + @"\");
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }

        private void FileListView_ItemActivate(object sender, EventArgs e)
        {
            if (SelectedItem != null)
            {
                if (SelectedItem.SubItems[1].Text == "DIR")
                {
                    SelectedDirectory = new DirectoryInfo(SourcePath + @"\" + SelectedItem.Text);
                    SourcePath = SourcePath + @"\" + SelectedItem.Text;
                    ShowFileList(SourcePath);
                }
                else
                {
                    SelectedFile = new FileInfo(SourcePath + @"\" + SelectedItem.Text);
                    System.Diagnostics.Process.Start(SelectedFile.FullName);
                }
                CurrentLocationBox.Text = SourcePath;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (SourcePath != Path.GetPathRoot(Environment.SystemDirectory))
            {
                if (SelectedDirectory != null && new DirectoryInfo(SelectedDirectory.Parent.FullName) != null)
                {
                    SelectedDirectory = new DirectoryInfo(SelectedDirectory.Parent.FullName);
                    SourcePath = SelectedDirectory.FullName;
                    ShowFileList(SourcePath);

                }
                else
                {
                    string[] pathArray = SourcePath.Split(@"\".ToCharArray());
                    SourcePath = SourcePath.Trim(pathArray[pathArray.Length - 1].ToCharArray());
                    ShowFileList(SourcePath);
                }
            }
            CurrentLocationBox.Text = SourcePath;
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {

        }
    }
}
