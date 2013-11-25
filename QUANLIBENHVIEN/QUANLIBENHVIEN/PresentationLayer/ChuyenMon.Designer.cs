namespace QUANLIBENHVIEN.PresentationLayer
{
    partial class ChuyenMon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbUdCM = new System.Windows.Forms.GroupBox();
            this.txtMaCM = new System.Windows.Forms.TextBox();
            this.txtTenCM = new System.Windows.Forms.TextBox();
            this.lbMaCM = new System.Windows.Forms.Label();
            this.lbTenCM = new System.Windows.Forms.Label();
            this.grbChuyenmon = new System.Windows.Forms.GroupBox();
            this.dgrvChuyenmon = new System.Windows.Forms.DataGridView();
            this.lbTieudeCM = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grbUdCM.SuspendLayout();
            this.grbChuyenmon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvChuyenmon)).BeginInit();
            this.SuspendLayout();
            // 
            // grbUdCM
            // 
            this.grbUdCM.Controls.Add(this.txtMaCM);
            this.grbUdCM.Controls.Add(this.txtTenCM);
            this.grbUdCM.Controls.Add(this.lbMaCM);
            this.grbUdCM.Controls.Add(this.lbTenCM);
            this.grbUdCM.Location = new System.Drawing.Point(14, 107);
            this.grbUdCM.Margin = new System.Windows.Forms.Padding(4);
            this.grbUdCM.Name = "grbUdCM";
            this.grbUdCM.Padding = new System.Windows.Forms.Padding(4);
            this.grbUdCM.Size = new System.Drawing.Size(302, 219);
            this.grbUdCM.TabIndex = 28;
            this.grbUdCM.TabStop = false;
            this.grbUdCM.Text = "Thông tin chuyên môn";
            // 
            // txtMaCM
            // 
            this.txtMaCM.Location = new System.Drawing.Point(17, 63);
            this.txtMaCM.Margin = new System.Windows.Forms.Padding(9);
            this.txtMaCM.Name = "txtMaCM";
            this.txtMaCM.Size = new System.Drawing.Size(270, 26);
            this.txtMaCM.TabIndex = 20;
            // 
            // txtTenCM
            // 
            this.txtTenCM.Location = new System.Drawing.Point(17, 134);
            this.txtTenCM.Margin = new System.Windows.Forms.Padding(9);
            this.txtTenCM.Name = "txtTenCM";
            this.txtTenCM.Size = new System.Drawing.Size(270, 26);
            this.txtTenCM.TabIndex = 20;
            // 
            // lbMaCM
            // 
            this.lbMaCM.AutoSize = true;
            this.lbMaCM.Location = new System.Drawing.Point(13, 35);
            this.lbMaCM.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lbMaCM.Name = "lbMaCM";
            this.lbMaCM.Size = new System.Drawing.Size(116, 19);
            this.lbMaCM.TabIndex = 19;
            this.lbMaCM.Text = "Mã chuyên môn";
            // 
            // lbTenCM
            // 
            this.lbTenCM.AutoSize = true;
            this.lbTenCM.Location = new System.Drawing.Point(13, 103);
            this.lbTenCM.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lbTenCM.Name = "lbTenCM";
            this.lbTenCM.Size = new System.Drawing.Size(118, 19);
            this.lbTenCM.TabIndex = 19;
            this.lbTenCM.Text = "Tên chuyên môn";
            // 
            // grbChuyenmon
            // 
            this.grbChuyenmon.Controls.Add(this.dgrvChuyenmon);
            this.grbChuyenmon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbChuyenmon.Location = new System.Drawing.Point(427, 107);
            this.grbChuyenmon.Margin = new System.Windows.Forms.Padding(9);
            this.grbChuyenmon.Name = "grbChuyenmon";
            this.grbChuyenmon.Padding = new System.Windows.Forms.Padding(9);
            this.grbChuyenmon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbChuyenmon.Size = new System.Drawing.Size(454, 268);
            this.grbChuyenmon.TabIndex = 27;
            this.grbChuyenmon.TabStop = false;
            this.grbChuyenmon.Text = "Danh sách chuyên môn";
            // 
            // dgrvChuyenmon
            // 
            this.dgrvChuyenmon.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgrvChuyenmon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgrvChuyenmon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvChuyenmon.Location = new System.Drawing.Point(10, 28);
            this.dgrvChuyenmon.Margin = new System.Windows.Forms.Padding(9);
            this.dgrvChuyenmon.Name = "dgrvChuyenmon";
            this.dgrvChuyenmon.Size = new System.Drawing.Size(435, 226);
            this.dgrvChuyenmon.TabIndex = 7;
            this.dgrvChuyenmon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrvChuyenmon_CellContentClick);
            // 
            // lbTieudeCM
            // 
            this.lbTieudeCM.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTieudeCM.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTieudeCM.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbTieudeCM.Location = new System.Drawing.Point(0, 0);
            this.lbTieudeCM.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lbTieudeCM.Name = "lbTieudeCM";
            this.lbTieudeCM.Size = new System.Drawing.Size(899, 98);
            this.lbTieudeCM.TabIndex = 26;
            this.lbTieudeCM.Text = "CHUYÊN MÔN";
            this.lbTieudeCM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(329, 299);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(9);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(81, 38);
            this.btnThoat.TabIndex = 33;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(329, 233);
            this.btnSave.Margin = new System.Windows.Forms.Padding(9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 35);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(329, 267);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 33);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(329, 167);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(9);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 33);
            this.btnEdit.TabIndex = 30;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(329, 135);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 33);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(329, 199);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 35);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ChuyenMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(899, 413);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grbUdCM);
            this.Controls.Add(this.grbChuyenmon);
            this.Controls.Add(this.lbTieudeCM);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChuyenMon";
            this.Text = "Chuyên môn";
            this.Load += new System.EventHandler(this.ChuyenMon_Load);
            this.grbUdCM.ResumeLayout(false);
            this.grbUdCM.PerformLayout();
            this.grbChuyenmon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvChuyenmon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbUdCM;
        private System.Windows.Forms.TextBox txtTenCM;
        private System.Windows.Forms.Label lbTenCM;
        private System.Windows.Forms.GroupBox grbChuyenmon;
        private System.Windows.Forms.DataGridView dgrvChuyenmon;
        private System.Windows.Forms.Label lbTieudeCM;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtMaCM;
        private System.Windows.Forms.Label lbMaCM;
        private System.Windows.Forms.Button btnCancel;
    }
}