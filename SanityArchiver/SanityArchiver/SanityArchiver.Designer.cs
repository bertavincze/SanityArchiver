namespace SanityArchiver
{
    partial class SanityArchiver
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanityArchiver));
            this.ArchiveButton = new System.Windows.Forms.Button();
            this.ExtractButton = new System.Windows.Forms.Button();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.FileSearchBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new MetroFramework.Controls.MetroLabel();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.AttributesButton = new System.Windows.Forms.Button();
            this.SelectedFileName = new System.Windows.Forms.TextBox();
            this.SelectedFileLabel = new MetroFramework.Controls.MetroLabel();
            this.BrowseFilesButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.OptionsLabel = new MetroFramework.Controls.MetroLabel();
            this.OpenSelectedFileButton = new System.Windows.Forms.Button();
            this.FileOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.MoveButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.FileImageList = new System.Windows.Forms.ImageList(this.components);
            this.BackButton = new System.Windows.Forms.Button();
            this.CurrentLocationGroupBox = new System.Windows.Forms.GroupBox();
            this.CurrentLocationLabel = new MetroFramework.Controls.MetroLabel();
            this.CurrentLocationBox = new System.Windows.Forms.TextBox();
            this.FileListView = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExtensionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AttrColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LoadProgressBar = new System.Windows.Forms.ProgressBar();
            this.FileOptionsGroupBox.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            this.CurrentLocationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ArchiveButton
            // 
            this.ArchiveButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ArchiveButton.Location = new System.Drawing.Point(9, 86);
            this.ArchiveButton.Name = "ArchiveButton";
            this.ArchiveButton.Size = new System.Drawing.Size(75, 23);
            this.ArchiveButton.TabIndex = 1;
            this.ArchiveButton.Text = "Archive";
            this.ArchiveButton.UseVisualStyleBackColor = true;
            this.ArchiveButton.Click += new System.EventHandler(this.ArchiveButton_Click);
            // 
            // ExtractButton
            // 
            this.ExtractButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ExtractButton.Location = new System.Drawing.Point(9, 115);
            this.ExtractButton.Name = "ExtractButton";
            this.ExtractButton.Size = new System.Drawing.Size(75, 23);
            this.ExtractButton.TabIndex = 2;
            this.ExtractButton.Text = "Extract";
            this.ExtractButton.UseVisualStyleBackColor = true;
            this.ExtractButton.Click += new System.EventHandler(this.ExtractButton_Click);
            // 
            // EncryptButton
            // 
            this.EncryptButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.EncryptButton.Location = new System.Drawing.Point(90, 86);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(75, 23);
            this.EncryptButton.TabIndex = 3;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // FileSearchBox
            // 
            this.FileSearchBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FileSearchBox.Location = new System.Drawing.Point(9, 36);
            this.FileSearchBox.Name = "FileSearchBox";
            this.FileSearchBox.Size = new System.Drawing.Size(315, 22);
            this.FileSearchBox.TabIndex = 4;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(6, 16);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(51, 19);
            this.SearchLabel.TabIndex = 5;
            this.SearchLabel.Text = "Search:";
            // 
            // DecryptButton
            // 
            this.DecryptButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.DecryptButton.Location = new System.Drawing.Point(90, 115);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(75, 23);
            this.DecryptButton.TabIndex = 6;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            // 
            // AttributesButton
            // 
            this.AttributesButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AttributesButton.Location = new System.Drawing.Point(252, 115);
            this.AttributesButton.Name = "AttributesButton";
            this.AttributesButton.Size = new System.Drawing.Size(75, 23);
            this.AttributesButton.TabIndex = 7;
            this.AttributesButton.Text = "Attributes";
            this.AttributesButton.UseVisualStyleBackColor = true;
            // 
            // SelectedFileName
            // 
            this.SelectedFileName.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.SelectedFileName.Location = new System.Drawing.Point(9, 38);
            this.SelectedFileName.Name = "SelectedFileName";
            this.SelectedFileName.Size = new System.Drawing.Size(315, 22);
            this.SelectedFileName.TabIndex = 8;
            // 
            // SelectedFileLabel
            // 
            this.SelectedFileLabel.AutoSize = true;
            this.SelectedFileLabel.Location = new System.Drawing.Point(6, 16);
            this.SelectedFileLabel.Name = "SelectedFileLabel";
            this.SelectedFileLabel.Size = new System.Drawing.Size(85, 19);
            this.SelectedFileLabel.TabIndex = 9;
            this.SelectedFileLabel.Text = "Selected File:";
            // 
            // BrowseFilesButton
            // 
            this.BrowseFilesButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.BrowseFilesButton.Location = new System.Drawing.Point(94, 64);
            this.BrowseFilesButton.Name = "BrowseFilesButton";
            this.BrowseFilesButton.Size = new System.Drawing.Size(79, 23);
            this.BrowseFilesButton.TabIndex = 10;
            this.BrowseFilesButton.Text = "Browse Files";
            this.BrowseFilesButton.UseVisualStyleBackColor = true;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.BackColor = System.Drawing.Color.White;
            this.OpenFileButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OpenFileButton.Location = new System.Drawing.Point(9, 64);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(79, 23);
            this.OpenFileButton.TabIndex = 11;
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            // 
            // OptionsLabel
            // 
            this.OptionsLabel.AutoSize = true;
            this.OptionsLabel.Location = new System.Drawing.Point(9, 64);
            this.OptionsLabel.Name = "OptionsLabel";
            this.OptionsLabel.Size = new System.Drawing.Size(55, 19);
            this.OptionsLabel.TabIndex = 12;
            this.OptionsLabel.Text = "Options";
            // 
            // OpenSelectedFileButton
            // 
            this.OpenSelectedFileButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.OpenSelectedFileButton.Location = new System.Drawing.Point(252, 86);
            this.OpenSelectedFileButton.Name = "OpenSelectedFileButton";
            this.OpenSelectedFileButton.Size = new System.Drawing.Size(75, 23);
            this.OpenSelectedFileButton.TabIndex = 13;
            this.OpenSelectedFileButton.Text = "Open File";
            this.OpenSelectedFileButton.UseVisualStyleBackColor = true;
            this.OpenSelectedFileButton.Click += new System.EventHandler(this.OpenSelectedFileButton_Click);
            // 
            // FileOptionsGroupBox
            // 
            this.FileOptionsGroupBox.Controls.Add(this.MoveButton);
            this.FileOptionsGroupBox.Controls.Add(this.CopyButton);
            this.FileOptionsGroupBox.Controls.Add(this.SelectedFileLabel);
            this.FileOptionsGroupBox.Controls.Add(this.OpenSelectedFileButton);
            this.FileOptionsGroupBox.Controls.Add(this.ArchiveButton);
            this.FileOptionsGroupBox.Controls.Add(this.OptionsLabel);
            this.FileOptionsGroupBox.Controls.Add(this.ExtractButton);
            this.FileOptionsGroupBox.Controls.Add(this.EncryptButton);
            this.FileOptionsGroupBox.Controls.Add(this.DecryptButton);
            this.FileOptionsGroupBox.Controls.Add(this.AttributesButton);
            this.FileOptionsGroupBox.Controls.Add(this.SelectedFileName);
            this.FileOptionsGroupBox.Location = new System.Drawing.Point(589, 187);
            this.FileOptionsGroupBox.Name = "FileOptionsGroupBox";
            this.FileOptionsGroupBox.Size = new System.Drawing.Size(335, 162);
            this.FileOptionsGroupBox.TabIndex = 14;
            this.FileOptionsGroupBox.TabStop = false;
            // 
            // MoveButton
            // 
            this.MoveButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MoveButton.Location = new System.Drawing.Point(171, 115);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(75, 23);
            this.MoveButton.TabIndex = 15;
            this.MoveButton.Text = "Move";
            this.MoveButton.UseVisualStyleBackColor = true;
            // 
            // CopyButton
            // 
            this.CopyButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.CopyButton.Location = new System.Drawing.Point(171, 86);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(75, 23);
            this.CopyButton.TabIndex = 14;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.SearchLabel);
            this.SearchGroupBox.Controls.Add(this.FileSearchBox);
            this.SearchGroupBox.Controls.Add(this.OpenFileButton);
            this.SearchGroupBox.Controls.Add(this.BrowseFilesButton);
            this.SearchGroupBox.Location = new System.Drawing.Point(589, 57);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(335, 110);
            this.SearchGroupBox.TabIndex = 15;
            this.SearchGroupBox.TabStop = false;
            // 
            // FileImageList
            // 
            this.FileImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("FileImageList.ImageStream")));
            this.FileImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.FileImageList.Images.SetKeyName(0, "Folder.png");
            this.FileImageList.Images.SetKeyName(1, "file.png");
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.BackButton.Location = new System.Drawing.Point(9, 66);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 16;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CurrentLocationGroupBox
            // 
            this.CurrentLocationGroupBox.Controls.Add(this.CurrentLocationLabel);
            this.CurrentLocationGroupBox.Controls.Add(this.BackButton);
            this.CurrentLocationGroupBox.Controls.Add(this.CurrentLocationBox);
            this.CurrentLocationGroupBox.Location = new System.Drawing.Point(589, 371);
            this.CurrentLocationGroupBox.Name = "CurrentLocationGroupBox";
            this.CurrentLocationGroupBox.Size = new System.Drawing.Size(335, 110);
            this.CurrentLocationGroupBox.TabIndex = 17;
            this.CurrentLocationGroupBox.TabStop = false;
            // 
            // CurrentLocationLabel
            // 
            this.CurrentLocationLabel.AutoSize = true;
            this.CurrentLocationLabel.Location = new System.Drawing.Point(6, 16);
            this.CurrentLocationLabel.Name = "CurrentLocationLabel";
            this.CurrentLocationLabel.Size = new System.Drawing.Size(109, 19);
            this.CurrentLocationLabel.TabIndex = 5;
            this.CurrentLocationLabel.Text = "Current Location:";
            // 
            // CurrentLocationBox
            // 
            this.CurrentLocationBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.CurrentLocationBox.Location = new System.Drawing.Point(9, 38);
            this.CurrentLocationBox.Name = "CurrentLocationBox";
            this.CurrentLocationBox.Size = new System.Drawing.Size(315, 22);
            this.CurrentLocationBox.TabIndex = 4;
            // 
            // FileListView
            // 
            this.FileListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.FileListView.BackgroundImageTiled = true;
            this.FileListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.ExtensionColumn,
            this.SizeColumn,
            this.DateColumn,
            this.AttrColumn});
            this.FileListView.Font = new System.Drawing.Font("Segoe UI Semilight", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FileListView.FullRowSelect = true;
            this.FileListView.HideSelection = false;
            this.FileListView.LabelWrap = false;
            this.FileListView.LargeImageList = this.FileImageList;
            this.FileListView.Location = new System.Drawing.Point(23, 63);
            this.FileListView.MultiSelect = false;
            this.FileListView.Name = "FileListView";
            this.FileListView.ShowItemToolTips = true;
            this.FileListView.Size = new System.Drawing.Size(543, 418);
            this.FileListView.SmallImageList = this.FileImageList;
            this.FileListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.FileListView.TabIndex = 0;
            this.FileListView.UseCompatibleStateImageBehavior = false;
            this.FileListView.View = System.Windows.Forms.View.Details;
            this.FileListView.ItemActivate += new System.EventHandler(this.FileListView_ItemActivate);
            this.FileListView.SelectedIndexChanged += new System.EventHandler(this.FileListView_SelectedIndexChanged);
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 195;
            // 
            // ExtensionColumn
            // 
            this.ExtensionColumn.Text = "Extension";
            this.ExtensionColumn.Width = 65;
            // 
            // SizeColumn
            // 
            this.SizeColumn.Text = "Size";
            this.SizeColumn.Width = 90;
            // 
            // DateColumn
            // 
            this.DateColumn.Text = "Date";
            this.DateColumn.Width = 100;
            // 
            // AttrColumn
            // 
            this.AttrColumn.Text = "Attributes";
            this.AttrColumn.Width = 92;
            // 
            // LoadProgressBar
            // 
            this.LoadProgressBar.Location = new System.Drawing.Point(23, 494);
            this.LoadProgressBar.Name = "LoadProgressBar";
            this.LoadProgressBar.Size = new System.Drawing.Size(543, 23);
            this.LoadProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.LoadProgressBar.TabIndex = 19;
            // 
            // SanityArchiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 540);
            this.Controls.Add(this.FileListView);
            this.Controls.Add(this.LoadProgressBar);
            this.Controls.Add(this.CurrentLocationGroupBox);
            this.Controls.Add(this.FileOptionsGroupBox);
            this.Controls.Add(this.SearchGroupBox);
            this.MaximumSize = new System.Drawing.Size(945, 540);
            this.MinimumSize = new System.Drawing.Size(945, 540);
            this.Name = "SanityArchiver";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Sanity Archiver";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.SanityArchiver_Load);
            this.FileOptionsGroupBox.ResumeLayout(false);
            this.FileOptionsGroupBox.PerformLayout();
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.CurrentLocationGroupBox.ResumeLayout(false);
            this.CurrentLocationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ArchiveButton;
        private System.Windows.Forms.Button ExtractButton;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.TextBox FileSearchBox;
        private MetroFramework.Controls.MetroLabel SearchLabel;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Button AttributesButton;
        private System.Windows.Forms.TextBox SelectedFileName;
        private MetroFramework.Controls.MetroLabel SelectedFileLabel;
        private System.Windows.Forms.Button BrowseFilesButton;
        private System.Windows.Forms.Button OpenFileButton;
        private MetroFramework.Controls.MetroLabel OptionsLabel;
        private System.Windows.Forms.Button OpenSelectedFileButton;
        private System.Windows.Forms.GroupBox FileOptionsGroupBox;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.ImageList FileImageList;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.GroupBox CurrentLocationGroupBox;
        private MetroFramework.Controls.MetroLabel CurrentLocationLabel;
        private System.Windows.Forms.TextBox CurrentLocationBox;
        private System.Windows.Forms.ListView FileListView;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader ExtensionColumn;
        private System.Windows.Forms.ColumnHeader SizeColumn;
        private System.Windows.Forms.ColumnHeader DateColumn;
        private System.Windows.Forms.ColumnHeader AttrColumn;
        private System.Windows.Forms.ProgressBar LoadProgressBar;
        private System.Windows.Forms.Button MoveButton;
        private System.Windows.Forms.Button CopyButton;
    }
}

