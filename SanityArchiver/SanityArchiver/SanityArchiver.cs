using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanityArchiver
{
    public partial class SanityArchiver : Form
    {
        public FileInfo SelectedFile { get; set; }

        public SanityArchiver()
        {
            InitializeComponent();
        }

        private void SetText(string text, TextBox textBox)
        {
            textBox.Text = text;
        }

        private void BrowseFilesButton_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                SetText(openFileDialog.FileName, SelectedFileName);
            }
        }

        private void SelectedFileChanged(object sender, EventArgs e)
        {
            Button[] buttons = { EncryptButton, DecryptButton, ArchiveButton, ExtractButton,
                                 OpenSelectedFileButton, AttributesButton };

            foreach (Button button in buttons)
            {
                button.Enabled = true;
            }

            if (SelectedFileName != null)
            {
                try
                {
                    SelectedFile = new FileInfo(SelectedFileName.Text);
                    if (SelectedFile.Attributes.HasFlag(FileAttributes.Encrypted))
                    {
                        EncryptButton.Enabled = false;
                        DecryptButton.Enabled = true;
                    }
                    if (SelectedFile.Attributes.HasFlag(FileAttributes.Archive))
                    {
                        ArchiveButton.Enabled = false;
                        ExtractButton.Enabled = true;
                    }
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show($"Error locating file.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");

                    foreach (Button button in buttons)
                    {
                        button.Enabled = false;
                    }
                }
            }
        }

        private void OpenSelectedFileButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(SelectedFile.FullName);
        }
    }
}
