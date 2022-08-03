namespace GO_Launcher_UpdateGen
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.selectFilesPath = new System.Windows.Forms.FolderBrowserDialog();
            this.selectOutputPath = new System.Windows.Forms.FolderBrowserDialog();
            this.selectFilePathInput = new System.Windows.Forms.TextBox();
            this.selectFilesPathLabel = new System.Windows.Forms.Label();
            this.selectFilePathBrowse = new System.Windows.Forms.Button();
            this.selectOutputPathInput = new System.Windows.Forms.TextBox();
            this.selectOutputPathBrowse = new System.Windows.Forms.Button();
            this.selectOutputPathLabel = new System.Windows.Forms.Label();
            this.startUpdateGenButton = new System.Windows.Forms.Button();
            this.resultString = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.versionInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // selectFilePathInput
            // 
            this.selectFilePathInput.Enabled = false;
            this.selectFilePathInput.Location = new System.Drawing.Point(12, 79);
            this.selectFilePathInput.Name = "selectFilePathInput";
            this.selectFilePathInput.Size = new System.Drawing.Size(189, 20);
            this.selectFilePathInput.TabIndex = 0;
            // 
            // selectFilesPathLabel
            // 
            this.selectFilesPathLabel.AutoSize = true;
            this.selectFilesPathLabel.Location = new System.Drawing.Point(12, 63);
            this.selectFilesPathLabel.Name = "selectFilesPathLabel";
            this.selectFilesPathLabel.Size = new System.Drawing.Size(154, 13);
            this.selectFilesPathLabel.TabIndex = 1;
            this.selectFilesPathLabel.Text = "Select folder with updated files:";
            // 
            // selectFilePathBrowse
            // 
            this.selectFilePathBrowse.Location = new System.Drawing.Point(207, 77);
            this.selectFilePathBrowse.Name = "selectFilePathBrowse";
            this.selectFilePathBrowse.Size = new System.Drawing.Size(75, 23);
            this.selectFilePathBrowse.TabIndex = 2;
            this.selectFilePathBrowse.Text = "Browse";
            this.selectFilePathBrowse.UseVisualStyleBackColor = true;
            this.selectFilePathBrowse.Click += new System.EventHandler(this.selectFilePathBrowse_Click);
            // 
            // selectOutputPathInput
            // 
            this.selectOutputPathInput.Enabled = false;
            this.selectOutputPathInput.Location = new System.Drawing.Point(12, 128);
            this.selectOutputPathInput.Name = "selectOutputPathInput";
            this.selectOutputPathInput.Size = new System.Drawing.Size(189, 20);
            this.selectOutputPathInput.TabIndex = 3;
            // 
            // selectOutputPathBrowse
            // 
            this.selectOutputPathBrowse.Location = new System.Drawing.Point(207, 125);
            this.selectOutputPathBrowse.Name = "selectOutputPathBrowse";
            this.selectOutputPathBrowse.Size = new System.Drawing.Size(75, 23);
            this.selectOutputPathBrowse.TabIndex = 4;
            this.selectOutputPathBrowse.Text = "Browse";
            this.selectOutputPathBrowse.UseVisualStyleBackColor = true;
            this.selectOutputPathBrowse.Click += new System.EventHandler(this.selectOutputPathBrowse_Click);
            // 
            // selectOutputPathLabel
            // 
            this.selectOutputPathLabel.AutoSize = true;
            this.selectOutputPathLabel.Location = new System.Drawing.Point(9, 112);
            this.selectOutputPathLabel.Name = "selectOutputPathLabel";
            this.selectOutputPathLabel.Size = new System.Drawing.Size(145, 13);
            this.selectOutputPathLabel.TabIndex = 5;
            this.selectOutputPathLabel.Text = "Select folder for output result:";
            // 
            // startUpdateGenButton
            // 
            this.startUpdateGenButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.startUpdateGenButton.Location = new System.Drawing.Point(0, 202);
            this.startUpdateGenButton.Name = "startUpdateGenButton";
            this.startUpdateGenButton.Size = new System.Drawing.Size(291, 38);
            this.startUpdateGenButton.TabIndex = 6;
            this.startUpdateGenButton.Text = "Start";
            this.startUpdateGenButton.UseVisualStyleBackColor = true;
            this.startUpdateGenButton.Click += new System.EventHandler(this.startUpdateGenButton_Click);
            // 
            // resultString
            // 
            this.resultString.Location = new System.Drawing.Point(12, 151);
            this.resultString.Name = "resultString";
            this.resultString.Size = new System.Drawing.Size(270, 32);
            this.resultString.TabIndex = 7;
            this.resultString.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(12, 17);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(218, 13);
            this.versionLabel.TabIndex = 8;
            this.versionLabel.Text = "Input version (not needed for additional files):";
            // 
            // versionInput
            // 
            this.versionInput.Location = new System.Drawing.Point(12, 33);
            this.versionInput.MaxLength = 24;
            this.versionInput.Name = "versionInput";
            this.versionInput.Size = new System.Drawing.Size(186, 20);
            this.versionInput.TabIndex = 9;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 240);
            this.Controls.Add(this.versionInput);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.resultString);
            this.Controls.Add(this.startUpdateGenButton);
            this.Controls.Add(this.selectOutputPathLabel);
            this.Controls.Add(this.selectOutputPathBrowse);
            this.Controls.Add(this.selectOutputPathInput);
            this.Controls.Add(this.selectFilePathBrowse);
            this.Controls.Add(this.selectFilesPathLabel);
            this.Controls.Add(this.selectFilePathInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Launcher Update Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog selectFilesPath;
        private System.Windows.Forms.FolderBrowserDialog selectOutputPath;
        private System.Windows.Forms.TextBox selectFilePathInput;
        private System.Windows.Forms.Label selectFilesPathLabel;
        private System.Windows.Forms.Button selectFilePathBrowse;
        private System.Windows.Forms.TextBox selectOutputPathInput;
        private System.Windows.Forms.Button selectOutputPathBrowse;
        private System.Windows.Forms.Label selectOutputPathLabel;
        private System.Windows.Forms.Button startUpdateGenButton;
        private System.Windows.Forms.Label resultString;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.TextBox versionInput;
    }
}

