namespace wbh_plates
{
    partial class uPlates
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlData = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chbStatus = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSupply = new System.Windows.Forms.TextBox();
            this.txtPlate_id = new System.Windows.Forms.TextBox();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlData.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(532, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(598, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(188, 26);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(789, 205);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.dataGridView1);
            this.pnlData.Controls.Add(this.txtSearch);
            this.pnlData.Controls.Add(this.label3);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlData.Location = new System.Drawing.Point(0, 281);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(789, 240);
            this.pnlData.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(693, 27);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 26);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(693, 91);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 26);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Supply";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(464, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Refference";
            // 
            // chbStatus
            // 
            this.chbStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chbStatus.AutoSize = true;
            this.chbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbStatus.Location = new System.Drawing.Point(584, 107);
            this.chbStatus.Name = "chbStatus";
            this.chbStatus.Size = new System.Drawing.Size(72, 24);
            this.chbStatus.TabIndex = 34;
            this.chbStatus.Text = "Taken";
            this.chbStatus.UseVisualStyleBackColor = true;
            this.chbStatus.CheckedChanged += new System.EventHandler(this.chbStatus_CheckedChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(693, 59);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 26);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Plate ID";
            // 
            // cmbSupply
            // 
            this.cmbSupply.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupply.Location = new System.Drawing.Point(274, 78);
            this.cmbSupply.Name = "cmbSupply";
            this.cmbSupply.Size = new System.Drawing.Size(188, 26);
            this.cmbSupply.TabIndex = 33;
            // 
            // txtPlate_id
            // 
            this.txtPlate_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPlate_id.Enabled = false;
            this.txtPlate_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlate_id.Location = new System.Drawing.Point(59, 78);
            this.txtPlate_id.Name = "txtPlate_id";
            this.txtPlate_id.Size = new System.Drawing.Size(188, 26);
            this.txtPlate_id.TabIndex = 32;
            // 
            // txtRef
            // 
            this.txtRef.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRef.Enabled = false;
            this.txtRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRef.Location = new System.Drawing.Point(468, 78);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(188, 26);
            this.txtRef.TabIndex = 31;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(295, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 20);
            this.lblTitle.TabIndex = 35;
            this.lblTitle.Text = "Welcome to Plates Reference";
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.lblTitle);
            this.pnlControls.Controls.Add(this.txtRef);
            this.pnlControls.Controls.Add(this.txtPlate_id);
            this.pnlControls.Controls.Add(this.txtQty);
            this.pnlControls.Controls.Add(this.cmbSupply);
            this.pnlControls.Controls.Add(this.label4);
            this.pnlControls.Controls.Add(this.btnUpdate);
            this.pnlControls.Controls.Add(this.chbStatus);
            this.pnlControls.Controls.Add(this.label5);
            this.pnlControls.Controls.Add(this.label2);
            this.pnlControls.Controls.Add(this.label1);
            this.pnlControls.Controls.Add(this.btnDelete);
            this.pnlControls.Controls.Add(this.btnSave);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControls.Location = new System.Drawing.Point(0, 42);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(789, 239);
            this.pnlControls.TabIndex = 23;
            this.pnlControls.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlControls_Paint);
            // 
            // txtQty
            // 
            this.txtQty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(344, 110);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(118, 26);
            this.txtQty.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(270, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Quantity";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnList);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(789, 42);
            this.pnlHeader.TabIndex = 45;
            // 
            // btnList
            // 
            this.btnList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(365, 3);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 27);
            this.btnList.TabIndex = 42;
            this.btnList.Text = "View";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // uPlates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlHeader);
            this.Name = "uPlates";
            this.Size = new System.Drawing.Size(789, 521);
            this.Load += new System.EventHandler(this.uPlates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbStatus;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cmbSupply;
        private System.Windows.Forms.TextBox txtPlate_id;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label5;
    }
}
