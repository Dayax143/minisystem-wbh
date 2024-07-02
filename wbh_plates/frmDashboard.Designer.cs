namespace wbh_plates
{
    partial class frmDashboard
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
            this.btnLora = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlReader = new System.Windows.Forms.Panel();
            this.pnlRFM = new System.Windows.Forms.Panel();
            this.pnlPlates = new System.Windows.Forms.Panel();
            this.pnlLora = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReader = new System.Windows.Forms.Button();
            this.btnRFM = new System.Windows.Forms.Button();
            this.btnPlates = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.uRFM1 = new wbh_plates.uRFM();
            this.uMReaders1 = new wbh_plates.uMReaders();
            this.u_Plates1 = new wbh_plates.uPlates();
            this.u_RefLora1 = new wbh_plates.uRefLora();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLora
            // 
            this.btnLora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLora.ForeColor = System.Drawing.Color.White;
            this.btnLora.Location = new System.Drawing.Point(170, 42);
            this.btnLora.Name = "btnLora";
            this.btnLora.Size = new System.Drawing.Size(107, 26);
            this.btnLora.TabIndex = 0;
            this.btnLora.Text = "Lora";
            this.btnLora.UseVisualStyleBackColor = true;
            this.btnLora.Click += new System.EventHandler(this.btnLora_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Controls.Add(this.pnlReader);
            this.panel3.Controls.Add(this.pnlRFM);
            this.panel3.Controls.Add(this.pnlPlates);
            this.panel3.Controls.Add(this.pnlLora);
            this.panel3.Controls.Add(this.btnLogout);
            this.panel3.Controls.Add(this.btnReader);
            this.panel3.Controls.Add(this.btnRFM);
            this.panel3.Controls.Add(this.btnPlates);
            this.panel3.Controls.Add(this.lblUsername);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblDate);
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Controls.Add(this.btnLora);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(865, 102);
            this.panel3.TabIndex = 8;
            // 
            // pnlReader
            // 
            this.pnlReader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlReader.BackColor = System.Drawing.Color.White;
            this.pnlReader.Location = new System.Drawing.Point(509, 70);
            this.pnlReader.Name = "pnlReader";
            this.pnlReader.Size = new System.Drawing.Size(107, 10);
            this.pnlReader.TabIndex = 3;
            // 
            // pnlRFM
            // 
            this.pnlRFM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlRFM.BackColor = System.Drawing.Color.White;
            this.pnlRFM.Location = new System.Drawing.Point(396, 70);
            this.pnlRFM.Name = "pnlRFM";
            this.pnlRFM.Size = new System.Drawing.Size(107, 10);
            this.pnlRFM.TabIndex = 3;
            // 
            // pnlPlates
            // 
            this.pnlPlates.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlPlates.BackColor = System.Drawing.Color.White;
            this.pnlPlates.Location = new System.Drawing.Point(283, 70);
            this.pnlPlates.Name = "pnlPlates";
            this.pnlPlates.Size = new System.Drawing.Size(107, 10);
            this.pnlPlates.TabIndex = 3;
            // 
            // pnlLora
            // 
            this.pnlLora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlLora.BackColor = System.Drawing.Color.White;
            this.pnlLora.Location = new System.Drawing.Point(170, 70);
            this.pnlLora.Name = "pnlLora";
            this.pnlLora.Size = new System.Drawing.Size(107, 10);
            this.pnlLora.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(785, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(77, 32);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReader
            // 
            this.btnReader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReader.ForeColor = System.Drawing.Color.White;
            this.btnReader.Location = new System.Drawing.Point(509, 42);
            this.btnReader.Name = "btnReader";
            this.btnReader.Size = new System.Drawing.Size(107, 26);
            this.btnReader.TabIndex = 0;
            this.btnReader.Text = "M.Reader";
            this.btnReader.UseVisualStyleBackColor = true;
            this.btnReader.Click += new System.EventHandler(this.btnReader_Click);
            // 
            // btnRFM
            // 
            this.btnRFM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRFM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRFM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRFM.ForeColor = System.Drawing.Color.White;
            this.btnRFM.Location = new System.Drawing.Point(396, 42);
            this.btnRFM.Name = "btnRFM";
            this.btnRFM.Size = new System.Drawing.Size(107, 26);
            this.btnRFM.TabIndex = 0;
            this.btnRFM.Text = "RFM";
            this.btnRFM.UseVisualStyleBackColor = true;
            this.btnRFM.Click += new System.EventHandler(this.btnRFM_Click);
            // 
            // btnPlates
            // 
            this.btnPlates.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPlates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlates.ForeColor = System.Drawing.Color.White;
            this.btnPlates.Location = new System.Drawing.Point(283, 42);
            this.btnPlates.Name = "btnPlates";
            this.btnPlates.Size = new System.Drawing.Size(107, 26);
            this.btnPlates.TabIndex = 0;
            this.btnPlates.Text = "Plates";
            this.btnPlates.UseVisualStyleBackColor = true;
            this.btnPlates.Click += new System.EventHandler(this.btnPlates_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(86, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(24, 18);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "@";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome ";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(734, 50);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 18);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date:";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(271, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(232, 18);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Welcome to plates management";
            // 
            // uRFM1
            // 
            this.uRFM1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uRFM1.Location = new System.Drawing.Point(0, 102);
            this.uRFM1.Name = "uRFM1";
            this.uRFM1.Size = new System.Drawing.Size(865, 469);
            this.uRFM1.TabIndex = 12;
            // 
            // uMReaders1
            // 
            this.uMReaders1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uMReaders1.Location = new System.Drawing.Point(0, 102);
            this.uMReaders1.Name = "uMReaders1";
            this.uMReaders1.Size = new System.Drawing.Size(865, 469);
            this.uMReaders1.TabIndex = 11;
            // 
            // u_Plates1
            // 
            this.u_Plates1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.u_Plates1.Location = new System.Drawing.Point(0, 102);
            this.u_Plates1.Name = "u_Plates1";
            this.u_Plates1.Size = new System.Drawing.Size(865, 469);
            this.u_Plates1.TabIndex = 10;
            // 
            // u_RefLora1
            // 
            this.u_RefLora1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.u_RefLora1.Location = new System.Drawing.Point(0, 102);
            this.u_RefLora1.Name = "u_RefLora1";
            this.u_RefLora1.Size = new System.Drawing.Size(865, 469);
            this.u_RefLora1.TabIndex = 9;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 571);
            this.Controls.Add(this.uRFM1);
            this.Controls.Add(this.uMReaders1);
            this.Controls.Add(this.u_Plates1);
            this.Controls.Add(this.u_RefLora1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLora;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPlates;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        private uRefLora u_RefLora1;
        private uPlates u_Plates1;
        private System.Windows.Forms.Panel pnlLora;
        private System.Windows.Forms.Panel pnlPlates;
        private uMReaders uMReaders1;
        private System.Windows.Forms.Panel pnlRFM;
        private System.Windows.Forms.Button btnRFM;
        private System.Windows.Forms.Panel pnlReader;
        private System.Windows.Forms.Button btnReader;
        private uRFM uRFM1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblUsername;
    }
}

