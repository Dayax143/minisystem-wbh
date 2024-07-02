namespace wbh_plates
{
    partial class uRefLora
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.chbToday = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblCheck = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSupply = new System.Windows.Forms.TextBox();
            this.txtLora_id = new System.Windows.Forms.TextBox();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.chbStatus = new System.Windows.Forms.CheckBox();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.chbPlate = new System.Windows.Forms.CheckBox();
            this.txtRV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(577, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(142, 26);
            this.txtSearch.TabIndex = 39;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(502, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Search";
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.chbToday);
            this.pnlData.Controls.Add(this.dataGridView1);
            this.pnlData.Controls.Add(this.txtSearch);
            this.pnlData.Controls.Add(this.label3);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlData.Location = new System.Drawing.Point(0, 294);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(815, 181);
            this.pnlData.TabIndex = 42;
            // 
            // chbToday
            // 
            this.chbToday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbToday.AutoSize = true;
            this.chbToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbToday.Location = new System.Drawing.Point(732, 4);
            this.chbToday.Name = "chbToday";
            this.chbToday.Size = new System.Drawing.Size(71, 24);
            this.chbToday.TabIndex = 56;
            this.chbToday.Text = "Today";
            this.chbToday.UseVisualStyleBackColor = true;
            this.chbToday.CheckedChanged += new System.EventHandler(this.chbToday_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(815, 146);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(720, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 26);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(720, 40);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 26);
            this.btnUpdate.TabIndex = 44;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(720, 72);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 26);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(720, 133);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 27);
            this.btnCheck.TabIndex = 42;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // lblCheck
            // 
            this.lblCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCheck.AutoSize = true;
            this.lblCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheck.Location = new System.Drawing.Point(721, 172);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(76, 20);
            this.lblCheck.TabIndex = 46;
            this.lblCheck.Text = "Duplicate";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Lora_Supply";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "Lora_id";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Refference";
            // 
            // cmbSupply
            // 
            this.cmbSupply.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupply.Location = new System.Drawing.Point(290, 84);
            this.cmbSupply.Name = "cmbSupply";
            this.cmbSupply.Size = new System.Drawing.Size(221, 26);
            this.cmbSupply.TabIndex = 52;
            // 
            // txtLora_id
            // 
            this.txtLora_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLora_id.Enabled = false;
            this.txtLora_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLora_id.Location = new System.Drawing.Point(290, 53);
            this.txtLora_id.Name = "txtLora_id";
            this.txtLora_id.Size = new System.Drawing.Size(221, 26);
            this.txtLora_id.TabIndex = 51;
            // 
            // txtRef
            // 
            this.txtRef.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRef.Enabled = false;
            this.txtRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRef.Location = new System.Drawing.Point(290, 115);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(221, 26);
            this.txtRef.TabIndex = 50;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(246, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(306, 20);
            this.lblTitle.TabIndex = 53;
            this.lblTitle.Text = "Welcome to Lora Reference Management";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(173, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Serial";
            // 
            // txtSerial
            // 
            this.txtSerial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.Location = new System.Drawing.Point(290, 150);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(188, 26);
            this.txtSerial.TabIndex = 55;
            // 
            // chbStatus
            // 
            this.chbStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chbStatus.AutoSize = true;
            this.chbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbStatus.Location = new System.Drawing.Point(517, 117);
            this.chbStatus.Name = "chbStatus";
            this.chbStatus.Size = new System.Drawing.Size(72, 24);
            this.chbStatus.TabIndex = 56;
            this.chbStatus.Text = "Taken";
            this.chbStatus.UseVisualStyleBackColor = true;
            this.chbStatus.CheckedChanged += new System.EventHandler(this.chbStatus_CheckedChanged);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.chbPlate);
            this.pnlControls.Controls.Add(this.chbStatus);
            this.pnlControls.Controls.Add(this.txtRV);
            this.pnlControls.Controls.Add(this.txtSerial);
            this.pnlControls.Controls.Add(this.label6);
            this.pnlControls.Controls.Add(this.label5);
            this.pnlControls.Controls.Add(this.lblTitle);
            this.pnlControls.Controls.Add(this.txtRef);
            this.pnlControls.Controls.Add(this.txtLora_id);
            this.pnlControls.Controls.Add(this.cmbSupply);
            this.pnlControls.Controls.Add(this.label2);
            this.pnlControls.Controls.Add(this.label4);
            this.pnlControls.Controls.Add(this.label1);
            this.pnlControls.Controls.Add(this.lblCheck);
            this.pnlControls.Controls.Add(this.btnCheck);
            this.pnlControls.Controls.Add(this.btnDelete);
            this.pnlControls.Controls.Add(this.btnUpdate);
            this.pnlControls.Controls.Add(this.btnSave);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControls.Location = new System.Drawing.Point(0, 42);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(815, 252);
            this.pnlControls.TabIndex = 43;
            // 
            // chbPlate
            // 
            this.chbPlate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chbPlate.AutoSize = true;
            this.chbPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPlate.Location = new System.Drawing.Point(517, 152);
            this.chbPlate.Name = "chbPlate";
            this.chbPlate.Size = new System.Drawing.Size(64, 24);
            this.chbPlate.TabIndex = 56;
            this.chbPlate.Text = "Plate";
            this.chbPlate.UseVisualStyleBackColor = true;
            this.chbPlate.CheckedChanged += new System.EventHandler(this.chbStatus_CheckedChanged);
            // 
            // txtRV
            // 
            this.txtRV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRV.Location = new System.Drawing.Point(290, 182);
            this.txtRV.Name = "txtRV";
            this.txtRV.Size = new System.Drawing.Size(105, 26);
            this.txtRV.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(173, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 54;
            this.label6.Text = "RV";
            // 
            // btnList
            // 
            this.btnList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(378, 3);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 27);
            this.btnList.TabIndex = 42;
            this.btnList.Text = "View";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnList);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(815, 42);
            this.pnlHeader.TabIndex = 44;
            // 
            // uRefLora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlHeader);
            this.Name = "uRefLora";
            this.Size = new System.Drawing.Size(815, 475);
            this.Load += new System.EventHandler(this.uRefLora_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cmbSupply;
        private System.Windows.Forms.TextBox txtLora_id;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.CheckBox chbStatus;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.TextBox txtRV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chbToday;
        private System.Windows.Forms.CheckBox chbPlate;
    }
}
