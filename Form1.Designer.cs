
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSimConnect = new System.Windows.Forms.Button();
            this.btnMatric = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSync = new System.Windows.Forms.Button();
            this.buttonOpenSaveFile = new System.Windows.Forms.Button();
            this.textLog = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSimConnectStatus = new System.Windows.Forms.Label();
            this.labelMatricStatus = new System.Windows.Forms.Label();
            this.labelMatricEnabled = new System.Windows.Forms.Label();
            this.labelSimConnectEnabled = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SimConnect:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matric:";
            // 
            // btnSimConnect
            // 
            this.btnSimConnect.Location = new System.Drawing.Point(211, 15);
            this.btnSimConnect.Name = "btnSimConnect";
            this.btnSimConnect.Size = new System.Drawing.Size(124, 23);
            this.btnSimConnect.TabIndex = 2;
            this.btnSimConnect.Text = "Enable SimConnect";
            this.btnSimConnect.UseVisualStyleBackColor = true;
            this.btnSimConnect.Click += new System.EventHandler(this.BtnSimConnect_Click);
            // 
            // btnMatric
            // 
            this.btnMatric.Location = new System.Drawing.Point(211, 44);
            this.btnMatric.Name = "btnMatric";
            this.btnMatric.Size = new System.Drawing.Size(124, 23);
            this.btnMatric.TabIndex = 3;
            this.btnMatric.Text = "Enable Matric";
            this.btnMatric.UseVisualStyleBackColor = true;
            this.btnMatric.Click += new System.EventHandler(this.BtnMatric_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(327, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(668, 326);
            this.dataGridView1.TabIndex = 10;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(508, 15);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(127, 52);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save Data Items";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(661, 15);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(127, 52);
            this.buttonLoad.TabIndex = 12;
            this.buttonLoad.Text = "Load Data Items";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // buttonSync
            // 
            this.buttonSync.Location = new System.Drawing.Point(352, 15);
            this.buttonSync.Name = "buttonSync";
            this.buttonSync.Size = new System.Drawing.Size(127, 52);
            this.buttonSync.TabIndex = 13;
            this.buttonSync.Text = "Force Data Sync";
            this.buttonSync.UseVisualStyleBackColor = true;
            this.buttonSync.Click += new System.EventHandler(this.ButtonSync_Click);
            // 
            // buttonOpenSaveFile
            // 
            this.buttonOpenSaveFile.Location = new System.Drawing.Point(508, 73);
            this.buttonOpenSaveFile.Name = "buttonOpenSaveFile";
            this.buttonOpenSaveFile.Size = new System.Drawing.Size(127, 22);
            this.buttonOpenSaveFile.TabIndex = 14;
            this.buttonOpenSaveFile.Text = "Open Data Table XML";
            this.buttonOpenSaveFile.UseVisualStyleBackColor = true;
            this.buttonOpenSaveFile.Click += new System.EventHandler(this.ButtonOpenSaveFile_Click);
            // 
            // textLog
            // 
            this.textLog.Location = new System.Drawing.Point(12, 119);
            this.textLog.MaxLength = 1024;
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.ReadOnly = true;
            this.textLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textLog.Size = new System.Drawing.Size(309, 326);
            this.textLog.TabIndex = 15;
            this.textLog.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Enabled?";
            // 
            // labelSimConnectStatus
            // 
            this.labelSimConnectStatus.AutoSize = true;
            this.labelSimConnectStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSimConnectStatus.Location = new System.Drawing.Point(87, 25);
            this.labelSimConnectStatus.Name = "labelSimConnectStatus";
            this.labelSimConnectStatus.Size = new System.Drawing.Size(11, 13);
            this.labelSimConnectStatus.TabIndex = 18;
            this.labelSimConnectStatus.Text = "-";
            this.labelSimConnectStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMatricStatus
            // 
            this.labelMatricStatus.AutoSize = true;
            this.labelMatricStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatricStatus.Location = new System.Drawing.Point(87, 49);
            this.labelMatricStatus.Name = "labelMatricStatus";
            this.labelMatricStatus.Size = new System.Drawing.Size(11, 13);
            this.labelMatricStatus.TabIndex = 19;
            this.labelMatricStatus.Text = "-";
            this.labelMatricStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMatricEnabled
            // 
            this.labelMatricEnabled.AutoSize = true;
            this.labelMatricEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatricEnabled.Location = new System.Drawing.Point(140, 49);
            this.labelMatricEnabled.Name = "labelMatricEnabled";
            this.labelMatricEnabled.Size = new System.Drawing.Size(11, 13);
            this.labelMatricEnabled.TabIndex = 21;
            this.labelMatricEnabled.Text = "-";
            this.labelMatricEnabled.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSimConnectEnabled
            // 
            this.labelSimConnectEnabled.AutoSize = true;
            this.labelSimConnectEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSimConnectEnabled.Location = new System.Drawing.Point(140, 25);
            this.labelSimConnectEnabled.Name = "labelSimConnectEnabled";
            this.labelSimConnectEnabled.Size = new System.Drawing.Size(11, 13);
            this.labelSimConnectEnabled.TabIndex = 20;
            this.labelSimConnectEnabled.Text = "-";
            this.labelSimConnectEnabled.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 457);
            this.Controls.Add(this.labelMatricEnabled);
            this.Controls.Add(this.labelSimConnectEnabled);
            this.Controls.Add(this.labelMatricStatus);
            this.Controls.Add(this.labelSimConnectStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textLog);
            this.Controls.Add(this.buttonOpenSaveFile);
            this.Controls.Add(this.buttonSync);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMatric);
            this.Controls.Add(this.btnSimConnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SimConnect 2 Matric 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSimConnect;
        private System.Windows.Forms.Button btnMatric;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSync;
        private System.Windows.Forms.Button buttonOpenSaveFile;
        public System.Windows.Forms.TextBox textLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label labelSimConnectStatus;
        public System.Windows.Forms.Label labelMatricStatus;
        public System.Windows.Forms.Label labelMatricEnabled;
        public System.Windows.Forms.Label labelSimConnectEnabled;
    }
}

