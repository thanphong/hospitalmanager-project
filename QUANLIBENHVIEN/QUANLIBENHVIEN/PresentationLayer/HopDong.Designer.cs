namespace QUANLIBENHVIEN.PresentationLayer
{
    partial class HopDong
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
            this.lbLoaiNV = new System.Windows.Forms.Label();
            this.cbbTenNV = new System.Windows.Forms.ComboBox();
            this.lbTieude = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grbThongtin = new System.Windows.Forms.GroupBox();
            this.dgrvHopdong = new System.Windows.Forms.DataGridView();
            this.lbLuong = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lbSogio = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grbCapnhat = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grbThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvHopdong)).BeginInit();
            this.grbCapnhat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLoaiNV
            // 
            this.lbLoaiNV.AutoSize = true;
            this.lbLoaiNV.Location = new System.Drawing.Point(9, 167);
            this.lbLoaiNV.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbLoaiNV.Name = "lbLoaiNV";
            this.lbLoaiNV.Size = new System.Drawing.Size(279, 19);
            this.lbLoaiNV.TabIndex = 28;
            this.lbLoaiNV.Text = "Nhân viên Tạm thời/Vĩnh viễn(nhập T/V)";
            // 
            // cbbTenNV
            // 
            this.cbbTenNV.FormattingEnabled = true;
            this.cbbTenNV.Location = new System.Drawing.Point(136, 39);
            this.cbbTenNV.Name = "cbbTenNV";
            this.cbbTenNV.Size = new System.Drawing.Size(252, 27);
            this.cbbTenNV.TabIndex = 27;
            // 
            // lbTieude
            // 
            this.lbTieude.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTieude.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTieude.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbTieude.Location = new System.Drawing.Point(0, 0);
            this.lbTieude.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbTieude.Name = "lbTieude";
            this.lbTieude.Size = new System.Drawing.Size(1139, 106);
            this.lbTieude.TabIndex = 50;
            this.lbTieude.Text = "HỢP ĐỒNG";
            this.lbTieude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(428, 332);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 40);
            this.btnThoat.TabIndex = 57;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Location = new System.Drawing.Point(9, 39);
            this.lbTenNV.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(103, 19);
            this.lbTenNV.TabIndex = 26;
            this.lbTenNV.Text = "Tên nhân viên";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(428, 152);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 34);
            this.btnAdd.TabIndex = 53;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // grbThongtin
            // 
            this.grbThongtin.Controls.Add(this.dgrvHopdong);
            this.grbThongtin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbThongtin.Location = new System.Drawing.Point(534, 113);
            this.grbThongtin.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.grbThongtin.Name = "grbThongtin";
            this.grbThongtin.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.grbThongtin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbThongtin.Size = new System.Drawing.Size(593, 228);
            this.grbThongtin.TabIndex = 51;
            this.grbThongtin.TabStop = false;
            this.grbThongtin.Text = "Thông tin hợp đồng";
            // 
            // dgrvHopdong
            // 
            this.dgrvHopdong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvHopdong.Location = new System.Drawing.Point(14, 26);
            this.dgrvHopdong.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.dgrvHopdong.Name = "dgrvHopdong";
            this.dgrvHopdong.Size = new System.Drawing.Size(568, 188);
            this.dgrvHopdong.TabIndex = 7;
            // 
            // lbLuong
            // 
            this.lbLuong.AutoSize = true;
            this.lbLuong.Location = new System.Drawing.Point(9, 127);
            this.lbLuong.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbLuong.Name = "lbLuong";
            this.lbLuong.Size = new System.Drawing.Size(251, 19);
            this.lbLuong.TabIndex = 22;
            this.lbLuong.Text = "Lương theo Tháng/Tuần(nhập M/W)";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(428, 293);
            this.btnSave.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 39);
            this.btnSave.TabIndex = 56;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(428, 186);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 35);
            this.btnEdit.TabIndex = 54;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lbSogio
            // 
            this.lbSogio.AutoSize = true;
            this.lbSogio.Location = new System.Drawing.Point(9, 81);
            this.lbSogio.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbSogio.Name = "lbSogio";
            this.lbSogio.Size = new System.Drawing.Size(143, 19);
            this.lbSogio.TabIndex = 21;
            this.lbSogio.Text = "Số giờ làm việc/tuần";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(428, 258);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 36);
            this.btnDelete.TabIndex = 55;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // grbCapnhat
            // 
            this.grbCapnhat.Controls.Add(this.textBox3);
            this.grbCapnhat.Controls.Add(this.textBox2);
            this.grbCapnhat.Controls.Add(this.textBox1);
            this.grbCapnhat.Controls.Add(this.lbLoaiNV);
            this.grbCapnhat.Controls.Add(this.cbbTenNV);
            this.grbCapnhat.Controls.Add(this.lbTenNV);
            this.grbCapnhat.Controls.Add(this.lbLuong);
            this.grbCapnhat.Controls.Add(this.lbSogio);
            this.grbCapnhat.Location = new System.Drawing.Point(15, 113);
            this.grbCapnhat.Margin = new System.Windows.Forms.Padding(6);
            this.grbCapnhat.Name = "grbCapnhat";
            this.grbCapnhat.Padding = new System.Windows.Forms.Padding(6);
            this.grbCapnhat.Size = new System.Drawing.Size(399, 227);
            this.grbCapnhat.TabIndex = 52;
            this.grbCapnhat.TabStop = false;
            this.grbCapnhat.Text = "Cập nhật hợp đồng";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(290, 164);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(98, 26);
            this.textBox3.TabIndex = 29;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(288, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 29;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 26);
            this.textBox1.TabIndex = 29;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(428, 222);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 37);
            this.btnCancel.TabIndex = 105;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // HopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1139, 404);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbTieude);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grbThongtin);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grbCapnhat);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HopDong";
            this.Text = "Hợp đồng";
            this.grbThongtin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvHopdong)).EndInit();
            this.grbCapnhat.ResumeLayout(false);
            this.grbCapnhat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbLoaiNV;
        private System.Windows.Forms.ComboBox cbbTenNV;
        private System.Windows.Forms.Label lbTieude;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grbThongtin;
        private System.Windows.Forms.DataGridView dgrvHopdong;
        private System.Windows.Forms.Label lbLuong;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lbSogio;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grbCapnhat;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCancel;
    }
}