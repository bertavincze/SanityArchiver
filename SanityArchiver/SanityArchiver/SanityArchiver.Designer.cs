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
            this.ArchiveButton = new System.Windows.Forms.Button();
            this.ExtractButton = new System.Windows.Forms.Button();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.FileSearchBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.AttributesButton = new System.Windows.Forms.Button();
            this.SelectedFileName = new System.Windows.Forms.TextBox();
            this.SelectedFileLabel = new System.Windows.Forms.Label();
            this.BrowseFilesButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.OptionsLabel = new System.Windows.Forms.Label();
            this.OpenSelectedFileButton = new System.Windows.Forms.Button();
            this.FileOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.FileOptionsGroupBox.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ArchiveButton
            // 
            this.ArchiveButton.Location = new System.Drawing.Point(9, 84);
            this.ArchiveButton.Name = "ArchiveButton";
            this.ArchiveButton.Size = new System.Drawing.Size(75, 23);
            this.ArchiveButton.TabIndex = 1;
            this.ArchiveButton.Text = "Archive";
            this.ArchiveButton.UseVisualStyleBackColor = true;
            // 
            // ExtractButton
            // 
            this.ExtractButton.Location = new System.Drawing.Point(9, 113);
            this.ExtractButton.Name = "ExtractButton";
            this.ExtractButton.Size = new System.Drawing.Size(75, 23);
            this.ExtractButton.TabIndex = 2;
            this.ExtractButton.Text = "Extract";
            this.ExtractButton.UseVisualStyleBackColor = true;
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(90, 84);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(75, 23);
            this.EncryptButton.TabIndex = 3;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            // 
            // FileSearchBox
            // 
            this.FileSearchBox.Location = new System.Drawing.Point(9, 32);
            this.FileSearchBox.Name = "FileSearchBox";
            this.FileSearchBox.Size = new System.Drawing.Size(370, 20);
            this.FileSearchBox.TabIndex = 4;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(6, 16);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(44, 13);
            this.SearchLabel.TabIndex = 5;
            this.SearchLabel.Text = "Search:";
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(90, 113);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(75, 23);
            this.DecryptButton.TabIndex = 6;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            // 
            // AttributesButton
            // 
            this.AttributesButton.Location = new System.Drawing.Point(171, 84);
            this.AttributesButton.Name = "AttributesButton";
            this.AttributesButton.Size = new System.Drawing.Size(75, 23);
            this.AttributesButton.TabIndex = 7;
            this.AttributesButton.Text = "Attributes";
            this.AttributesButton.UseVisualStyleBackColor = true;
            // 
            // SelectedFileName
            // 
            this.SelectedFileName.Location = new System.Drawing.Point(9, 32);
            this.SelectedFileName.Name = "SelectedFileName";
            this.SelectedFileName.Size = new System.Drawing.Size(370, 20);
            this.SelectedFileName.TabIndex = 8;
            this.SelectedFileName.TextChanged += new System.EventHandler(this.SelectedFileChanged);
            // 
            // SelectedFileLabel
            // 
            this.SelectedFileLabel.AutoSize = true;
            this.SelectedFileLabel.Location = new System.Drawing.Point(6, 16);
            this.SelectedFileLabel.Name = "SelectedFileLabel";
            this.SelectedFileLabel.Size = new System.Drawing.Size(71, 13);
            this.SelectedFileLabel.TabIndex = 9;
            this.SelectedFileLabel.Text = "Selected File:";
            // 
            // BrowseFilesButton
            // 
            this.BrowseFilesButton.Location = new System.Drawing.Point(94, 62);
            this.BrowseFilesButton.Name = "BrowseFilesButton";
            this.BrowseFilesButton.Size = new System.Drawing.Size(79, 23);
            this.BrowseFilesButton.TabIndex = 10;
            this.BrowseFilesButton.Text = "Browse Files";
            this.BrowseFilesButton.UseVisualStyleBackColor = true;
            this.BrowseFilesButton.Click += new System.EventHandler(this.BrowseFilesButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(9, 62);
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
            this.OptionsLabel.Size = new System.Drawing.Size(43, 13);
            this.OptionsLabel.TabIndex = 12;
            this.OptionsLabel.Text = "Options";
            // 
            // OpenSelectedFileButton
            // 
            this.OpenSelectedFileButton.Location = new System.Drawing.Point(171, 113);
            this.OpenSelectedFileButton.Name = "OpenSelectedFileButton";
            this.OpenSelectedFileButton.Size = new System.Drawing.Size(75, 23);
            this.OpenSelectedFileButton.TabIndex = 13;
            this.OpenSelectedFileButton.Text = "Open File";
            this.OpenSelectedFileButton.UseVisualStyleBackColor = true;
            this.OpenSelectedFileButton.Click += new System.EventHandler(this.OpenSelectedFileButton_Click);
            // 
            // FileOptionsGroupBox
            // 
            this.FileOptionsGroupBox.Controls.Add(this.SelectedFileLabel);
            this.FileOptionsGroupBox.Controls.Add(this.OpenSelectedFileButton);
            this.FileOptionsGroupBox.Controls.Add(this.ArchiveButton);
            this.FileOptionsGroupBox.Controls.Add(this.OptionsLabel);
            this.FileOptionsGroupBox.Controls.Add(this.ExtractButton);
            this.FileOptionsGroupBox.Controls.Add(this.EncryptButton);
            this.FileOptionsGroupBox.Controls.Add(this.DecryptButton);
            this.FileOptionsGroupBox.Controls.Add(this.AttributesButton);
            this.FileOptionsGroupBox.Controls.Add(this.SelectedFileName);
            this.FileOptionsGroupBox.Location = new System.Drawing.Point(12, 147);
            this.FileOptionsGroupBox.Name = "FileOptionsGroupBox";
            this.FileOptionsGroupBox.Size = new System.Drawing.Size(385, 162);
            this.FileOptionsGroupBox.TabIndex = 14;
            this.FileOptionsGroupBox.TabStop = false;
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.SearchLabel);
            this.SearchGroupBox.Controls.Add(this.FileSearchBox);
            this.SearchGroupBox.Controls.Add(this.OpenFileButton);
            this.SearchGroupBox.Controls.Add(this.BrowseFilesButton);
            this.SearchGroupBox.Location = new System.Drawing.Point(12, 31);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(385, 110);
            this.SearchGroupBox.TabIndex = 15;
            this.SearchGroupBox.TabStop = false;
            // 
            // SanityArchiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 461);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.FileOptionsGroupBox);
            this.Name = "SanityArchiver";
            this.Text = "SanityArchiver";
            this.FileOptionsGroupBox.ResumeLayout(false);
            this.FileOptionsGroupBox.PerformLayout();
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ArchiveButton;
        private System.Windows.Forms.Button ExtractButton;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.TextBox FileSearchBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Button AttributesButton;
        private System.Windows.Forms.TextBox SelectedFileName;
        private System.Windows.Forms.Label SelectedFileLabel;
        private System.Windows.Forms.Button BrowseFilesButton;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Label OptionsLabel;
        private System.Windows.Forms.Button OpenSelectedFileButton;
        private System.Windows.Forms.GroupBox FileOptionsGroupBox;
        private System.Windows.Forms.GroupBox SearchGroupBox;
    }
}

