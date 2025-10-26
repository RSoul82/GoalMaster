namespace GoalMaster
{
    partial class ExportWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportWindow));
            this.btnExport = new System.Windows.Forms.Button();
            this.chkCMD = new System.Windows.Forms.CheckBox();
            this.chkGoals = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(12, 58);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(120, 24);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // chkCMD
            // 
            this.chkCMD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCMD.AutoSize = true;
            this.chkCMD.Checked = true;
            this.chkCMD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCMD.Location = new System.Drawing.Point(12, 12);
            this.chkCMD.Name = "chkCMD";
            this.chkCMD.Size = new System.Drawing.Size(72, 17);
            this.chkCMD.TabIndex = 3;
            this.chkCMD.Text = "CMD file: ";
            this.chkCMD.UseVisualStyleBackColor = true;
            // 
            // chkGoals
            // 
            this.chkGoals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkGoals.AutoSize = true;
            this.chkGoals.Checked = true;
            this.chkGoals.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGoals.Location = new System.Drawing.Point(12, 35);
            this.chkGoals.Name = "chkGoals";
            this.chkGoals.Size = new System.Drawing.Size(73, 17);
            this.chkGoals.TabIndex = 4;
            this.chkGoals.Text = "Goals.str: ";
            this.chkGoals.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(223, 58);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 24);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ExportWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(355, 93);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.chkGoals);
            this.Controls.Add(this.chkCMD);
            this.Controls.Add(this.btnExport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExportWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.CheckBox chkCMD;
        private System.Windows.Forms.CheckBox chkGoals;
        private System.Windows.Forms.Button btnCancel;
    }
}