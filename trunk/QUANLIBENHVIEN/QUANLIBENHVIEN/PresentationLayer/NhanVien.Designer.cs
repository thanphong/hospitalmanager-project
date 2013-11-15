namespace QUANLIBENHVIEN.PresentationLayer
{
    partial class NhanVien
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
            this.lbTieude = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grbThongtin = new System.Windows.Forms.GroupBox();
            this.dgrvNhanvien = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbNgaysinh = new System.Windows.Forms.Label();
            this.txtSobaohiem = new System.Windows.Forms.TextBox();
            this.cbbGioitinh = new System.Windows.Forms.ComboBox();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.dTimePNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.dTimePThoidiem = new System.Windows.Forms.DateTimePicker();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lbGioitinh = new System.Windows.Forms.Label();
            this.lbChucvu = new System.Windows.Forms.Label();
            this.lbSodt = new System.Windows.Forms.Label();
            this.lbSoBH = new System.Windows.Forms.Label();
            this.lbLuong = new System.Windows.Forms.Label();
            this.lbMucluong = new System.Windows.Forms.Label();
            this.lbThoidiem = new System.Windows.Forms.Label();
            this.lbKinhnghiem = new System.Windows.Forms.Label();
            this.lbTrinhdo = new System.Windows.Forms.Label();
            this.cbbChucvu = new System.Windows.Forms.ComboBox();
            this.txtSodt = new System.Windows.Forms.TextBox();
            this.cbbKinhnghiem = new System.Windows.Forms.ComboBox();
            this.cbbTrinhdo = new System.Windows.Forms.ComboBox();
            this.txtLuonghientai = new System.Windows.Forms.TextBox();
            this.cbbMucluong = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbDiachi = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.grbCapnhat = new System.Windows.Forms.GroupBox();
            this.grbThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvNhanvien)).BeginInit();
            this.grbCapnhat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTieude
            // 
            this.lbTieude.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTieude.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTieude.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbTieude.Location = new System.Drawing.Point(0, 0);
            this.lbTieude.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbTieude.Name = "lbTieude";
            this.lbTieude.Size = new System.Drawing.Size(931, 94);
            this.lbTieude.TabIndex = 50;
            this.lbTieude.Text = "NHÂN VIÊN";
            this.lbTieude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(816, 549);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 34);
            this.btnThoat.TabIndex = 57;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(407, 549);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 34);
            this.btnAdd.TabIndex = 53;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // grbThongtin
            // 
            this.grbThongtin.Controls.Add(this.dgrvNhanvien);
            this.grbThongtin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbThongtin.Location = new System.Drawing.Point(30, 356);
            this.grbThongtin.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.grbThongtin.Name = "grbThongtin";
            this.grbThongtin.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.grbThongtin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbThongtin.Size = new System.Drawing.Size(878, 167);
            this.grbThongtin.TabIndex = 51;
            this.grbThongtin.TabStop = false;
            this.grbThongtin.Text = "Thông tin nhân viên";
            // 
            // dgrvNhanvien
            // 
            this.dgrvNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvNhanvien.Location = new System.Drawing.Point(13, 24);
            this.dgrvNhanvien.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.dgrvNhanvien.Name = "dgrvNhanvien";
            this.dgrvNhanvien.Size = new System.Drawing.Size(855, 129);
            this.dgrvNhanvien.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(713, 549);
            this.btnSave.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 34);
            this.btnSave.TabIndex = 56;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(507, 549);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 35);
            this.btnEdit.TabIndex = 54;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(610, 549);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 34);
            this.btnDelete.TabIndex = 55;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lbNgaysinh
            // 
            this.lbNgaysinh.AutoSize = true;
            this.lbNgaysinh.Location = new System.Drawing.Point(9, 73);
            this.lbNgaysinh.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbNgaysinh.Name = "lbNgaysinh";
            this.lbNgaysinh.Size = new System.Drawing.Size(76, 19);
            this.lbNgaysinh.TabIndex = 21;
            this.lbNgaysinh.Text = "Ngày sinh";
            // 
            // txtSobaohiem
            // 
            this.txtSobaohiem.Location = new System.Drawing.Point(116, 174);
            this.txtSobaohiem.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.txtSobaohiem.Name = "txtSobaohiem";
            this.txtSobaohiem.Size = new System.Drawing.Size(320, 26);
            this.txtSobaohiem.TabIndex = 24;
            // 
            // cbbGioitinh
            // 
            this.cbbGioitinh.FormattingEnabled = true;
            this.cbbGioitinh.Location = new System.Drawing.Point(116, 103);
            this.cbbGioitinh.Name = "cbbGioitinh";
            this.cbbGioitinh.Size = new System.Drawing.Size(75, 27);
            this.cbbGioitinh.TabIndex = 25;
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Location = new System.Drawing.Point(9, 43);
            this.lbTenNV.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(103, 19);
            this.lbTenNV.TabIndex = 26;
            this.lbTenNV.Text = "Tên nhân viên";
            // 
            // dTimePNgaysinh
            // 
            this.dTimePNgaysinh.Location = new System.Drawing.Point(116, 71);
            this.dTimePNgaysinh.Name = "dTimePNgaysinh";
            this.dTimePNgaysinh.Size = new System.Drawing.Size(320, 26);
            this.dTimePNgaysinh.TabIndex = 29;
            // 
            // dTimePThoidiem
            // 
            this.dTimePThoidiem.Location = new System.Drawing.Point(617, 174);
            this.dTimePThoidiem.Name = "dTimePThoidiem";
            this.dTimePThoidiem.Size = new System.Drawing.Size(241, 26);
            this.dTimePThoidiem.TabIndex = 30;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(116, 39);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(320, 26);
            this.txtTenNV.TabIndex = 31;
            // 
            // lbGioitinh
            // 
            this.lbGioitinh.AutoSize = true;
            this.lbGioitinh.Location = new System.Drawing.Point(9, 106);
            this.lbGioitinh.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbGioitinh.Name = "lbGioitinh";
            this.lbGioitinh.Size = new System.Drawing.Size(67, 19);
            this.lbGioitinh.TabIndex = 32;
            this.lbGioitinh.Text = "Giới tính";
            // 
            // lbChucvu
            // 
            this.lbChucvu.AutoSize = true;
            this.lbChucvu.Location = new System.Drawing.Point(199, 107);
            this.lbChucvu.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbChucvu.Name = "lbChucvu";
            this.lbChucvu.Size = new System.Drawing.Size(65, 19);
            this.lbChucvu.TabIndex = 33;
            this.lbChucvu.Text = "Chức vụ";
            // 
            // lbSodt
            // 
            this.lbSodt.AutoSize = true;
            this.lbSodt.Location = new System.Drawing.Point(9, 140);
            this.lbSodt.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbSodt.Name = "lbSodt";
            this.lbSodt.Size = new System.Drawing.Size(95, 19);
            this.lbSodt.TabIndex = 35;
            this.lbSodt.Text = "Số điện thoại";
            // 
            // lbSoBH
            // 
            this.lbSoBH.AutoSize = true;
            this.lbSoBH.Location = new System.Drawing.Point(9, 177);
            this.lbSoBH.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbSoBH.Name = "lbSoBH";
            this.lbSoBH.Size = new System.Drawing.Size(90, 19);
            this.lbSoBH.TabIndex = 36;
            this.lbSoBH.Text = "Số bảo hiểm";
            // 
            // lbLuong
            // 
            this.lbLuong.AutoSize = true;
            this.lbLuong.Location = new System.Drawing.Point(475, 43);
            this.lbLuong.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbLuong.Name = "lbLuong";
            this.lbLuong.Size = new System.Drawing.Size(107, 19);
            this.lbLuong.TabIndex = 37;
            this.lbLuong.Text = "Lương hiện tại";
            // 
            // lbMucluong
            // 
            this.lbMucluong.AutoSize = true;
            this.lbMucluong.Location = new System.Drawing.Point(475, 75);
            this.lbMucluong.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbMucluong.Name = "lbMucluong";
            this.lbMucluong.Size = new System.Drawing.Size(85, 19);
            this.lbMucluong.TabIndex = 38;
            this.lbMucluong.Text = "Mức lương";
            // 
            // lbThoidiem
            // 
            this.lbThoidiem.AutoSize = true;
            this.lbThoidiem.Location = new System.Drawing.Point(475, 174);
            this.lbThoidiem.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbThoidiem.Name = "lbThoidiem";
            this.lbThoidiem.Size = new System.Drawing.Size(135, 19);
            this.lbThoidiem.TabIndex = 39;
            this.lbThoidiem.Text = "Thời điểm làm việc";
            // 
            // lbKinhnghiem
            // 
            this.lbKinhnghiem.AutoSize = true;
            this.lbKinhnghiem.Location = new System.Drawing.Point(475, 140);
            this.lbKinhnghiem.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbKinhnghiem.Name = "lbKinhnghiem";
            this.lbKinhnghiem.Size = new System.Drawing.Size(93, 19);
            this.lbKinhnghiem.TabIndex = 40;
            this.lbKinhnghiem.Text = "Kinh nghiệm";
            // 
            // lbTrinhdo
            // 
            this.lbTrinhdo.AutoSize = true;
            this.lbTrinhdo.Location = new System.Drawing.Point(475, 107);
            this.lbTrinhdo.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbTrinhdo.Name = "lbTrinhdo";
            this.lbTrinhdo.Size = new System.Drawing.Size(64, 19);
            this.lbTrinhdo.TabIndex = 41;
            this.lbTrinhdo.Text = "Trình độ";
            // 
            // cbbChucvu
            // 
            this.cbbChucvu.FormattingEnabled = true;
            this.cbbChucvu.Location = new System.Drawing.Point(263, 103);
            this.cbbChucvu.Name = "cbbChucvu";
            this.cbbChucvu.Size = new System.Drawing.Size(173, 27);
            this.cbbChucvu.TabIndex = 42;
            // 
            // txtSodt
            // 
            this.txtSodt.Location = new System.Drawing.Point(116, 140);
            this.txtSodt.Name = "txtSodt";
            this.txtSodt.Size = new System.Drawing.Size(320, 26);
            this.txtSodt.TabIndex = 44;
            // 
            // cbbKinhnghiem
            // 
            this.cbbKinhnghiem.FormattingEnabled = true;
            this.cbbKinhnghiem.Location = new System.Drawing.Point(587, 140);
            this.cbbKinhnghiem.Name = "cbbKinhnghiem";
            this.cbbKinhnghiem.Size = new System.Drawing.Size(271, 27);
            this.cbbKinhnghiem.TabIndex = 45;
            // 
            // cbbTrinhdo
            // 
            this.cbbTrinhdo.FormattingEnabled = true;
            this.cbbTrinhdo.Location = new System.Drawing.Point(587, 107);
            this.cbbTrinhdo.Name = "cbbTrinhdo";
            this.cbbTrinhdo.Size = new System.Drawing.Size(271, 27);
            this.cbbTrinhdo.TabIndex = 45;
            // 
            // txtLuonghientai
            // 
            this.txtLuonghientai.Location = new System.Drawing.Point(587, 40);
            this.txtLuonghientai.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.txtLuonghientai.Name = "txtLuonghientai";
            this.txtLuonghientai.Size = new System.Drawing.Size(271, 26);
            this.txtLuonghientai.TabIndex = 46;
            // 
            // cbbMucluong
            // 
            this.cbbMucluong.FormattingEnabled = true;
            this.cbbMucluong.Location = new System.Drawing.Point(587, 72);
            this.cbbMucluong.Name = "cbbMucluong";
            this.cbbMucluong.Size = new System.Drawing.Size(271, 27);
            this.cbbMucluong.TabIndex = 45;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1163, 122);
            this.textBox1.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 26);
            this.textBox1.TabIndex = 46;
            // 
            // lbDiachi
            // 
            this.lbDiachi.AutoSize = true;
            this.lbDiachi.Location = new System.Drawing.Point(9, 212);
            this.lbDiachi.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbDiachi.Name = "lbDiachi";
            this.lbDiachi.Size = new System.Drawing.Size(56, 19);
            this.lbDiachi.TabIndex = 47;
            this.lbDiachi.Text = "Địa chỉ";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(116, 209);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(742, 26);
            this.txtDiachi.TabIndex = 48;
            // 
            // grbCapnhat
            // 
            this.grbCapnhat.Controls.Add(this.txtDiachi);
            this.grbCapnhat.Controls.Add(this.lbDiachi);
            this.grbCapnhat.Controls.Add(this.textBox1);
            this.grbCapnhat.Controls.Add(this.cbbMucluong);
            this.grbCapnhat.Controls.Add(this.txtLuonghientai);
            this.grbCapnhat.Controls.Add(this.cbbTrinhdo);
            this.grbCapnhat.Controls.Add(this.cbbKinhnghiem);
            this.grbCapnhat.Controls.Add(this.txtSodt);
            this.grbCapnhat.Controls.Add(this.cbbChucvu);
            this.grbCapnhat.Controls.Add(this.lbTrinhdo);
            this.grbCapnhat.Controls.Add(this.lbKinhnghiem);
            this.grbCapnhat.Controls.Add(this.lbThoidiem);
            this.grbCapnhat.Controls.Add(this.lbMucluong);
            this.grbCapnhat.Controls.Add(this.lbLuong);
            this.grbCapnhat.Controls.Add(this.lbSoBH);
            this.grbCapnhat.Controls.Add(this.lbSodt);
            this.grbCapnhat.Controls.Add(this.lbChucvu);
            this.grbCapnhat.Controls.Add(this.lbGioitinh);
            this.grbCapnhat.Controls.Add(this.txtTenNV);
            this.grbCapnhat.Controls.Add(this.dTimePThoidiem);
            this.grbCapnhat.Controls.Add(this.dTimePNgaysinh);
            this.grbCapnhat.Controls.Add(this.lbTenNV);
            this.grbCapnhat.Controls.Add(this.cbbGioitinh);
            this.grbCapnhat.Controls.Add(this.txtSobaohiem);
            this.grbCapnhat.Controls.Add(this.lbNgaysinh);
            this.grbCapnhat.Location = new System.Drawing.Point(29, 89);
            this.grbCapnhat.Margin = new System.Windows.Forms.Padding(6);
            this.grbCapnhat.Name = "grbCapnhat";
            this.grbCapnhat.Padding = new System.Windows.Forms.Padding(6);
            this.grbCapnhat.Size = new System.Drawing.Size(878, 249);
            this.grbCapnhat.TabIndex = 58;
            this.grbCapnhat.TabStop = false;
            this.grbCapnhat.Text = "Cập nhật thông tin cá nhân";
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(931, 617);
            this.Controls.Add(this.grbCapnhat);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbTieude);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grbThongtin);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NhanVien";
            this.Text = "Nhân viên";
            this.grbThongtin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvNhanvien)).EndInit();
            this.grbCapnhat.ResumeLayout(false);
            this.grbCapnhat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTieude;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grbThongtin;
        private System.Windows.Forms.DataGridView dgrvNhanvien;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbNgaysinh;
        private System.Windows.Forms.TextBox txtSobaohiem;
        private System.Windows.Forms.ComboBox cbbGioitinh;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.DateTimePicker dTimePNgaysinh;
        private System.Windows.Forms.DateTimePicker dTimePThoidiem;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lbGioitinh;
        private System.Windows.Forms.Label lbChucvu;
        private System.Windows.Forms.Label lbSodt;
        private System.Windows.Forms.Label lbSoBH;
        private System.Windows.Forms.Label lbLuong;
        private System.Windows.Forms.Label lbMucluong;
        private System.Windows.Forms.Label lbThoidiem;
        private System.Windows.Forms.Label lbKinhnghiem;
        private System.Windows.Forms.Label lbTrinhdo;
        private System.Windows.Forms.ComboBox cbbChucvu;
        private System.Windows.Forms.TextBox txtSodt;
        private System.Windows.Forms.ComboBox cbbKinhnghiem;
        private System.Windows.Forms.ComboBox cbbTrinhdo;
        private System.Windows.Forms.TextBox txtLuonghientai;
        private System.Windows.Forms.ComboBox cbbMucluong;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbDiachi;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.GroupBox grbCapnhat;
    }
}