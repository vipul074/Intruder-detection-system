namespace FileSplitter
{
    partial class Master
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.splitMultimediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharetootherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadReceivedFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(719, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.splitMultimediaToolStripMenuItem,
            this.encryptToolStripMenuItem,
            this.zipToolStripMenuItem,
            this.sharetootherToolStripMenuItem,
            this.downloadReceivedFilesToolStripMenuItem,
            this.signoutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(719, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // splitMultimediaToolStripMenuItem
            // 
            this.splitMultimediaToolStripMenuItem.Name = "splitMultimediaToolStripMenuItem";
            this.splitMultimediaToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.splitMultimediaToolStripMenuItem.Text = "Split";
            this.splitMultimediaToolStripMenuItem.Click += new System.EventHandler(this.splitMultimediaToolStripMenuItem_Click);
            // 
            // encryptToolStripMenuItem
            // 
            this.encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
            this.encryptToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.encryptToolStripMenuItem.Text = "Encrypt";
            this.encryptToolStripMenuItem.Click += new System.EventHandler(this.encryptToolStripMenuItem_Click_1);
            // 
            // zipToolStripMenuItem
            // 
            this.zipToolStripMenuItem.Name = "zipToolStripMenuItem";
            this.zipToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.zipToolStripMenuItem.Text = "Zip";
            this.zipToolStripMenuItem.Visible = false;
            this.zipToolStripMenuItem.Click += new System.EventHandler(this.zipToolStripMenuItem_Click);
            // 
            // sharetootherToolStripMenuItem
            // 
            this.sharetootherToolStripMenuItem.Name = "sharetootherToolStripMenuItem";
            this.sharetootherToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.sharetootherToolStripMenuItem.Text = "Share";
            this.sharetootherToolStripMenuItem.Click += new System.EventHandler(this.sharetootherToolStripMenuItem_Click);
            // 
            // downloadReceivedFilesToolStripMenuItem
            // 
            this.downloadReceivedFilesToolStripMenuItem.Name = "downloadReceivedFilesToolStripMenuItem";
            this.downloadReceivedFilesToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.downloadReceivedFilesToolStripMenuItem.Text = "Download received files";
            this.downloadReceivedFilesToolStripMenuItem.Click += new System.EventHandler(this.downloadReceivedFilesToolStripMenuItem_Click);
            // 
            // signoutToolStripMenuItem
            // 
            this.signoutToolStripMenuItem.Name = "signoutToolStripMenuItem";
            this.signoutToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.signoutToolStripMenuItem.Text = "Signout";
            this.signoutToolStripMenuItem.Click += new System.EventHandler(this.signoutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(719, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Master";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem splitMultimediaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem signoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharetootherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadReceivedFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem;
    }
}



