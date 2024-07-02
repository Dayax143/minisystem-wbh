namespace wbh_plates
{
    partial class uRFM
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlControls = new System.Windows.Forms.Panel();
            this.txtAssigned = new System.Windows.Forms.ComboBox();
            this.chbStatus = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtRFM_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnList = new System.Windows.Forms.Button();
            this.txtRFM_mac = new System.Windows.Forms.ComboBox();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlData.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.txtRFM_mac);
            this.pnlControls.Controls.Add(this.txtAssigned);
            this.pnlControls.Controls.Add(this.chbStatus);
            this.pnlControls.Controls.Add(this.lblTitle);
            this.pnlControls.Controls.Add(this.txtRFM_id);
            this.pnlControls.Controls.Add(this.label4);
            this.pnlControls.Controls.Add(this.btnUpdate);
            this.pnlControls.Controls.Add(this.label6);
            this.pnlControls.Controls.Add(this.lblStatus);
            this.pnlControls.Controls.Add(this.label2);
            this.pnlControls.Controls.Add(this.label1);
            this.pnlControls.Controls.Add(this.btnDelete);
            this.pnlControls.Controls.Add(this.btnSave);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControls.Location = new System.Drawing.Point(0, 42);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(797, 232);
            this.pnlControls.TabIndex = 27;
            // 
            // txtAssigned
            // 
            this.txtAssigned.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAssigned.FormattingEnabled = true;
            this.txtAssigned.Location = new System.Drawing.Point(474, 87);
            this.txtAssigned.Name = "txtAssigned";
            this.txtAssigned.Size = new System.Drawing.Size(141, 21);
            this.txtAssigned.TabIndex = 37;
            // 
            // chbStatus
            // 
            this.chbStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chbStatus.AutoSize = true;
            this.chbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbStatus.Location = new System.Drawing.Point(543, 114);
            this.chbStatus.Name = "chbStatus";
            this.chbStatus.Size = new System.Drawing.Size(72, 24);
            this.chbStatus.TabIndex = 36;
            this.chbStatus.Text = "Taken";
            this.chbStatus.UseVisualStyleBackColor = true;
            this.chbStatus.CheckedChanged += new System.EventHandler(this.chbStatus_CheckedChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(289, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(222, 20);
            this.lblTitle.TabIndex = 35;
            this.lblTitle.Text = "Welcome to RFM Registartion";
            // 
            // txtRFM_id
            // 
            this.txtRFM_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRFM_id.Enabled = false;
            this.txtRFM_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRFM_id.Location = new System.Drawing.Point(59, 84);
            this.txtRFM_id.Name = "txtRFM_id";
            this.txtRFM_id.Size = new System.Drawing.Size(188, 26);
            this.txtRFM_id.TabIndex = 32;
            this.txtRFM_id.TextChanged += new System.EventHandler(this.txtRFM_id_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "RFM_id";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(700, 55);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 26);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(271, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Status : ";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(365, 120);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(18, 20);
            this.lblStatus.TabIndex = 29;
            this.lblStatus.Text = "=";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(470, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Assigned MReader";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "RFM_Mac";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(700, 87);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 26);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(700, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 26);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(797, 235);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(606, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(188, 26);
            this.txtSearch.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(540, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Search";
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.dataGridView1);
            this.pnlData.Controls.Add(this.txtSearch);
            this.pnlData.Controls.Add(this.label3);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlData.Location = new System.Drawing.Point(0, 274);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(797, 269);
            this.pnlData.TabIndex = 26;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnList);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(797, 42);
            this.pnlHeader.TabIndex = 45;
            // 
            // btnList
            // 
            this.btnList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(369, 3);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 27);
            this.btnList.TabIndex = 42;
            this.btnList.Text = "View";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtRFM_mac
            // 
            this.txtRFM_mac.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRFM_mac.FormattingEnabled = true;
            this.txtRFM_mac.Location = new System.Drawing.Point(253, 84);
            this.txtRFM_mac.Name = "txtRFM_mac";
            this.txtRFM_mac.Size = new System.Drawing.Size(191, 21);
            this.txtRFM_mac.TabIndex = 38;
            // 
            // uRFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlData);
            this.Name = "uRFM";
            this.Size = new System.Drawing.Size(797, 543);
            this.Load += new System.EventHandler(this.uRFM_Load);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtRFM_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chbStatus;
        private System.Windows.Forms.ComboBox txtAssigned;
        private System.Windows.Forms.ComboBox txtRFM_mac;
    }
}
