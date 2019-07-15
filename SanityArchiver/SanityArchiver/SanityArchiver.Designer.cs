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
            this.SuspendLayout();
            // 
            // ArchiveButton
            // 
            this.ArchiveButton.Location = new System.Drawing.Point(97, 105);
            this.ArchiveButton.Name = "ArchiveButton";
            this.ArchiveButton.Size = new System.Drawing.Size(75, 23);
            this.ArchiveButton.TabIndex = 1;
            this.ArchiveButton.Text = "Archive";
            this.ArchiveButton.UseVisualStyleBackColor = true;
            // 
            // ExtractButton
            // 
            this.ExtractButton.Location = new System.Drawing.Point(178, 105);
            this.ExtractButton.Name = "ExtractButton";
            this.ExtractButton.Size = new System.Drawing.Size(75, 23);
            this.ExtractButton.TabIndex = 2;
            this.ExtractButton.Text = "Extract";
            this.ExtractButton.UseVisualStyleBackColor = true;
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(259, 105);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(75, 23);
            this.EncryptButton.TabIndex = 3;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            // 
            // FileSearchBox
            // 
            this.FileSearchBox.Location = new System.Drawing.Point(12, 26);
            this.FileSearchBox.Name = "FileSearchBox";
            this.FileSearchBox.Size = new System.Drawing.Size(510, 20);
            this.FileSearchBox.TabIndex = 4;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(9, 10);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(44, 13);
            this.SearchLabel.TabIndex = 5;
            this.SearchLabel.Text = "Search:";
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(340, 105);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(75, 23);
            this.DecryptButton.TabIndex = 6;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            // 
            // AttributesButton
            // 
            this.AttributesButton.Location = new System.Drawing.Point(421, 105);
            this.AttributesButton.Name = "AttributesButton";
            this.AttributesButton.Size = new System.Drawing.Size(101, 23);
            this.AttributesButton.TabIndex = 7;
            this.AttributesButton.Text = "Manage Attributes";
            this.AttributesButton.UseVisualStyleBackColor = true;
            // 
            // SelectedFileName
            // 
            this.SelectedFileName.Location = new System.Drawing.Point(12, 67);
            this.SelectedFileName.Name = "SelectedFileName";
            this.SelectedFileName.Size = new System.Drawing.Size(510, 20);
            this.SelectedFileName.TabIndex = 8;
            // 
            // SelectedFileLabel
            // 
            this.SelectedFileLabel.AutoSize = true;
            this.SelectedFileLabel.Location = new System.Drawing.Point(9, 50);
            this.SelectedFileLabel.Name = "SelectedFileLabel";
            this.SelectedFileLabel.Size = new System.Drawing.Size(71, 13);
            this.SelectedFileLabel.TabIndex = 9;
            this.SelectedFileLabel.Text = "Selected File:";
            // 
            // BrowseFilesButton
            // 
            this.BrowseFilesButton.Location = new System.Drawing.Point(12, 105);
            this.BrowseFilesButton.Name = "BrowseFilesButton";
            this.BrowseFilesButton.Size = new System.Drawing.Size(79, 23);
            this.BrowseFilesButton.TabIndex = 10;
            this.BrowseFilesButton.Text = "Browse Files";
            this.BrowseFilesButton.UseVisualStyleBackColor = true;
            this.BrowseFilesButton.Click += new System.EventHandler(this.BrowseFilesButton_Click);
            // 
            // SanityArchiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 140);
            this.Controls.Add(this.BrowseFilesButton);
            this.Controls.Add(this.SelectedFileLabel);
            this.Controls.Add(this.SelectedFileName);
            this.Controls.Add(this.AttributesButton);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.FileSearchBox);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.ExtractButton);
            this.Controls.Add(this.ArchiveButton);
            this.Name = "SanityArchiver";
            this.Text = "SanityArchiver";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

