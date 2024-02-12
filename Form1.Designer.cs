
namespace SimConnect2Matric2
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textLog = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAppDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.retrySimConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retryMatricToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceDataSyncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSimVarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusSimConnect = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarSimConnect = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusMatric = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarMatric = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(415, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(580, 419);
            this.dataGridView1.TabIndex = 10;
            // 
            // textLog
            // 
            this.textLog.Location = new System.Drawing.Point(12, 27);
            this.textLog.MaxLength = 1024;
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.ReadOnly = true;
            this.textLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textLog.Size = new System.Drawing.Size(397, 404);
            this.textLog.TabIndex = 15;
            this.textLog.WordWrap = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1001, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.openAppDirectoryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.openToolStripMenuItem.Text = "Reload Data Items";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.saveToolStripMenuItem.Text = "Save Data Items";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openAppDirectoryToolStripMenuItem
            // 
            this.openAppDirectoryToolStripMenuItem.Name = "openAppDirectoryToolStripMenuItem";
            this.openAppDirectoryToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.openAppDirectoryToolStripMenuItem.Text = "Open App Directory";
            this.openAppDirectoryToolStripMenuItem.Click += new System.EventHandler(this.openAppDirectoryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.retrySimConnectToolStripMenuItem,
            this.retryMatricToolStripMenuItem,
            this.forceDataSyncToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(59, 20);
            this.toolStripMenuItem2.Text = "Actions";
            // 
            // retrySimConnectToolStripMenuItem
            // 
            this.retrySimConnectToolStripMenuItem.Name = "retrySimConnectToolStripMenuItem";
            this.retrySimConnectToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.retrySimConnectToolStripMenuItem.Text = "Retry SimConnect";
            this.retrySimConnectToolStripMenuItem.Click += new System.EventHandler(this.retrySimConnectToolStripMenuItem_Click);
            // 
            // retryMatricToolStripMenuItem
            // 
            this.retryMatricToolStripMenuItem.Name = "retryMatricToolStripMenuItem";
            this.retryMatricToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.retryMatricToolStripMenuItem.Text = "Retry Matric";
            this.retryMatricToolStripMenuItem.Click += new System.EventHandler(this.retryMatricToolStripMenuItem_Click);
            // 
            // forceDataSyncToolStripMenuItem
            // 
            this.forceDataSyncToolStripMenuItem.Name = "forceDataSyncToolStripMenuItem";
            this.forceDataSyncToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.forceDataSyncToolStripMenuItem.Text = "Force Data Sync";
            this.forceDataSyncToolStripMenuItem.Click += new System.EventHandler(this.forceDataSyncToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.viewSimVarsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem1.Text = "Help";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.helpToolStripMenuItem.Text = "View Documentation";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // viewSimVarsToolStripMenuItem
            // 
            this.viewSimVarsToolStripMenuItem.Name = "viewSimVarsToolStripMenuItem";
            this.viewSimVarsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.viewSimVarsToolStripMenuItem.Text = "View SimVars";
            this.viewSimVarsToolStripMenuItem.Click += new System.EventHandler(this.viewSimVarsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.aboutToolStripMenuItem.Text = "Open Discord";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusSimConnect,
            this.toolStripProgressBarSimConnect,
            this.toolStripStatusMatric,
            this.toolStripProgressBarMatric});
            this.statusStrip1.Location = new System.Drawing.Point(0, 435);
            this.statusStrip1.Margin = new System.Windows.Forms.Padding(5);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1001, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusSimConnect
            // 
            this.toolStripStatusSimConnect.Name = "toolStripStatusSimConnect";
            this.toolStripStatusSimConnect.Size = new System.Drawing.Size(110, 17);
            this.toolStripStatusSimConnect.Text = "SimConnect Status:";
            // 
            // toolStripProgressBarSimConnect
            // 
            this.toolStripProgressBarSimConnect.BackColor = System.Drawing.Color.Silver;
            this.toolStripProgressBarSimConnect.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.toolStripProgressBarSimConnect.ForeColor = System.Drawing.Color.Black;
            this.toolStripProgressBarSimConnect.Name = "toolStripProgressBarSimConnect";
            this.toolStripProgressBarSimConnect.Size = new System.Drawing.Size(37, 17);
            this.toolStripProgressBarSimConnect.Text = "          ";
            // 
            // toolStripStatusMatric
            // 
            this.toolStripStatusMatric.Name = "toolStripStatusMatric";
            this.toolStripStatusMatric.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusMatric.Text = "Matric Status:";
            // 
            // toolStripProgressBarMatric
            // 
            this.toolStripProgressBarMatric.BackColor = System.Drawing.Color.Silver;
            this.toolStripProgressBarMatric.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.toolStripProgressBarMatric.ForeColor = System.Drawing.Color.Black;
            this.toolStripProgressBarMatric.Name = "toolStripProgressBarMatric";
            this.toolStripProgressBarMatric.Size = new System.Drawing.Size(37, 17);
            this.toolStripProgressBarMatric.Text = "          ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 457);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textLog);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SimConnect 2 Matric 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox textLog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openAppDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem retrySimConnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retryMatricToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusMatric;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusSimConnect;
        private System.Windows.Forms.ToolStripMenuItem forceDataSyncToolStripMenuItem;
        public System.Windows.Forms.ToolStripStatusLabel toolStripProgressBarSimConnect;
        public System.Windows.Forms.ToolStripStatusLabel toolStripProgressBarMatric;
        private System.Windows.Forms.ToolStripMenuItem viewSimVarsToolStripMenuItem;
    }
}

