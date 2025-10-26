namespace GoalMaster
{
    partial class SettingsWindow
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCMDPath = new System.Windows.Forms.TextBox();
            this.tbFMRootPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLanguage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowseCMDLocation = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnBrowseStrLocation = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblCMDNotExistWarning = new System.Windows.Forms.Label();
            this.lblFMRootNotExistWarning = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblOpenSaveNotExistWarning = new System.Windows.Forms.Label();
            this.btnBrowseSaveLoadLocation = new System.Windows.Forms.Button();
            this.tbOpenSavePath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CMD File Export Location";
            // 
            // tbCMDPath
            // 
            this.tbCMDPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCMDPath.Location = new System.Drawing.Point(12, 84);
            this.tbCMDPath.Name = "tbCMDPath";
            this.tbCMDPath.Size = new System.Drawing.Size(675, 20);
            this.tbCMDPath.TabIndex = 2;
            this.tbCMDPath.TextChanged += new System.EventHandler(this.tbCMDPath_TextChanged);
            // 
            // tbFMRootPath
            // 
            this.tbFMRootPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFMRootPath.Location = new System.Drawing.Point(12, 143);
            this.tbFMRootPath.Name = "tbFMRootPath";
            this.tbFMRootPath.Size = new System.Drawing.Size(675, 20);
            this.tbFMRootPath.TabIndex = 4;
            this.tbFMRootPath.TextChanged += new System.EventHandler(this.tbFMRootPath_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(619, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "FM root folder (either <game installation>\\FMs\\<fm-name> or just <game installati" +
    "on> if you\'re still using the old way of making FMs)";
            // 
            // tbLanguage
            // 
            this.tbLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLanguage.Location = new System.Drawing.Point(12, 202);
            this.tbLanguage.Name = "tbLanguage";
            this.tbLanguage.Size = new System.Drawing.Size(675, 20);
            this.tbLanguage.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Language Folder Name (use \"none\", no quotes, or leave empty, to omit this)";
            // 
            // btnBrowseCMDLocation
            // 
            this.btnBrowseCMDLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseCMDLocation.Location = new System.Drawing.Point(693, 81);
            this.btnBrowseCMDLocation.Name = "btnBrowseCMDLocation";
            this.btnBrowseCMDLocation.Size = new System.Drawing.Size(95, 23);
            this.btnBrowseCMDLocation.TabIndex = 3;
            this.btnBrowseCMDLocation.Text = "Browse...";
            this.btnBrowseCMDLocation.UseVisualStyleBackColor = true;
            this.btnBrowseCMDLocation.Click += new System.EventHandler(this.btnBrowseCMDLocation_Click);
            // 
            // btnBrowseStrLocation
            // 
            this.btnBrowseStrLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseStrLocation.Location = new System.Drawing.Point(693, 141);
            this.btnBrowseStrLocation.Name = "btnBrowseStrLocation";
            this.btnBrowseStrLocation.Size = new System.Drawing.Size(95, 22);
            this.btnBrowseStrLocation.TabIndex = 5;
            this.btnBrowseStrLocation.Text = "Browse...";
            this.btnBrowseStrLocation.UseVisualStyleBackColor = true;
            this.btnBrowseStrLocation.Click += new System.EventHandler(this.btnBrowseStrLocation_Click);
            // 
            // lblCMDNotExistWarning
            // 
            this.lblCMDNotExistWarning.AutoSize = true;
            this.lblCMDNotExistWarning.ForeColor = System.Drawing.Color.Red;
            this.lblCMDNotExistWarning.Location = new System.Drawing.Point(12, 107);
            this.lblCMDNotExistWarning.Name = "lblCMDNotExistWarning";
            this.lblCMDNotExistWarning.Size = new System.Drawing.Size(35, 13);
            this.lblCMDNotExistWarning.TabIndex = 8;
            this.lblCMDNotExistWarning.Text = "label4";
            // 
            // lblFMRootNotExistWarning
            // 
            this.lblFMRootNotExistWarning.AutoSize = true;
            this.lblFMRootNotExistWarning.ForeColor = System.Drawing.Color.Red;
            this.lblFMRootNotExistWarning.Location = new System.Drawing.Point(12, 166);
            this.lblFMRootNotExistWarning.Name = "lblFMRootNotExistWarning";
            this.lblFMRootNotExistWarning.Size = new System.Drawing.Size(35, 13);
            this.lblFMRootNotExistWarning.TabIndex = 9;
            this.lblFMRootNotExistWarning.Text = "label5";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(612, 247);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(713, 247);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblOpenSaveNotExistWarning
            // 
            this.lblOpenSaveNotExistWarning.AutoSize = true;
            this.lblOpenSaveNotExistWarning.ForeColor = System.Drawing.Color.Red;
            this.lblOpenSaveNotExistWarning.Location = new System.Drawing.Point(12, 48);
            this.lblOpenSaveNotExistWarning.Name = "lblOpenSaveNotExistWarning";
            this.lblOpenSaveNotExistWarning.Size = new System.Drawing.Size(35, 13);
            this.lblOpenSaveNotExistWarning.TabIndex = 15;
            this.lblOpenSaveNotExistWarning.Text = "label4";
            // 
            // btnBrowseSaveLoadLocation
            // 
            this.btnBrowseSaveLoadLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseSaveLoadLocation.Location = new System.Drawing.Point(693, 22);
            this.btnBrowseSaveLoadLocation.Name = "btnBrowseSaveLoadLocation";
            this.btnBrowseSaveLoadLocation.Size = new System.Drawing.Size(95, 23);
            this.btnBrowseSaveLoadLocation.TabIndex = 1;
            this.btnBrowseSaveLoadLocation.Text = "Browse...";
            this.btnBrowseSaveLoadLocation.UseVisualStyleBackColor = true;
            this.btnBrowseSaveLoadLocation.Click += new System.EventHandler(this.btnBrowseSaveLoadLocation_Click);
            // 
            // tbOpenSavePath
            // 
            this.tbOpenSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOpenSavePath.Location = new System.Drawing.Point(12, 25);
            this.tbOpenSavePath.Name = "tbOpenSavePath";
            this.tbOpenSavePath.Size = new System.Drawing.Size(675, 20);
            this.tbOpenSavePath.TabIndex = 0;
            this.tbOpenSavePath.TextChanged += new System.EventHandler(this.tbSaveLoadPath_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Default GoalMaster Save/Open Location";
            // 
            // SettingsWindow
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(800, 282);
            this.ControlBox = false;
            this.Controls.Add(this.lblOpenSaveNotExistWarning);
            this.Controls.Add(this.btnBrowseSaveLoadLocation);
            this.Controls.Add(this.tbOpenSavePath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblFMRootNotExistWarning);
            this.Controls.Add(this.lblCMDNotExistWarning);
            this.Controls.Add(this.btnBrowseStrLocation);
            this.Controls.Add(this.btnBrowseCMDLocation);
            this.Controls.Add(this.tbLanguage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFMRootPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCMDPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SettingsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCMDPath;
        private System.Windows.Forms.TextBox tbFMRootPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLanguage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowseCMDLocation;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnBrowseStrLocation;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblCMDNotExistWarning;
        private System.Windows.Forms.Label lblFMRootNotExistWarning;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblOpenSaveNotExistWarning;
        private System.Windows.Forms.Button btnBrowseSaveLoadLocation;
        private System.Windows.Forms.TextBox tbOpenSavePath;
        private System.Windows.Forms.Label label5;
    }
}