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
            this.lbMucluong = new System.Windows.Forms.Label();
            this.lbThoidiem = new System.Windows.Forms.Label();
            this.lbKinhnghiem = new System.Windows.Forms.Label();
            this.lbTrinhdo = new System.Windows.Forms.Label();
            this.cbbChucvu = new System.Windows.Forms.ComboBox();
            this.txtSodt = new System.Windows.Forms.TextBox();
            this.cbbKinhnghiem = new System.Windows.Forms.ComboBox();
            this.cbbTrinhdo = new System.Windows.Forms.ComboBox();
            this.cbbMucluong = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbDiachi = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.grbCapnhat = new System.Windows.Forms.GroupBox();
            this.cmbChuyenMon = new System.Windows.Forms.ComboBox();
            this.lbChuyenmon = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
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
            this.lbTieude.Size = new System.Drawing.Size(920, 83);
            this.lbTieude.TabIndex = 50;
            this.lbTieude.Text = "NHÂN VIÊN";
            this.lbTieude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(771, 385);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 37);
            this.btnThoat.TabIndex = 57;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(298, 385);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 37);
            this.btnAdd.TabIndex = 53;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // grbThongtin
            // 
            this.grbThongtin.Controls.Add(this.dgrvNhanvien);
            this.grbThongtin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbThongtin.Location = new System.Drawing.Point(23, 436);
            this.grbThongtin.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.grbThongtin.Name = "grbThongtin";
            this.grbThongtin.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.grbThongtin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbThongtin.Size = new System.Drawing.Size(874, 193);
            this.grbThongtin.TabIndex = 51;
            this.grbThongtin.TabStop = false;
            this.grbThongtin.Text = "Danh sách  nhân viên";
            // 
            // dgrvNhanvien
            // 
            this.dgrvNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvNhanvien.Location = new System.Drawing.Point(10, 24);
            this.dgrvNhanvien.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.dgrvNhanvien.Name = "dgrvNhanvien";
            this.dgrvNhanvien.Size = new System.Drawing.Size(848, 158);
            this.dgrvNhanvien.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(487, 385);
            this.btnSave.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 37);
            this.btnSave.TabIndex = 56;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(392, 385);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 37);
            this.btnEdit.TabIndex = 54;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(676, 385);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 37);
            this.btnDelete.TabIndex = 55;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lbNgaysinh
            // 
            this.lbNgaysinh.AutoSize = true;
            this.lbNgaysinh.Location = new System.Drawing.Point(29, 146);
            this.lbNgaysinh.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbNgaysinh.Name = "lbNgaysinh";
            this.lbNgaysinh.Size = new System.Drawing.Size(76, 19);
            this.lbNgaysinh.TabIndex = 21;
            this.lbNgaysinh.Text = "Ngày sinh";
            // 
            // txtSobaohiem
            // 
            this.txtSobaohiem.Location = new System.Drawing.Point(136, 207);
            this.txtSobaohiem.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.txtSobaohiem.Name = "txtSobaohiem";
            this.txtSobaohiem.Size = new System.Drawing.Size(299, 26);
            this.txtSobaohiem.TabIndex = 24;
            // 
            // cbbGioitinh
            // 
            this.cbbGioitinh.FormattingEnabled = true;
            this.cbbGioitinh.Location = new System.Drawing.Point(136, 110);
            this.cbbGioitinh.Name = "cbbGioitinh";
            this.cbbGioitinh.Size = new System.Drawing.Size(75, 27);
            this.cbbGioitinh.TabIndex = 25;
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Location = new System.Drawing.Point(29, 82);
            this.lbTenNV.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(103, 19);
            this.lbTenNV.TabIndex = 26;
            this.lbTenNV.Text = "Tên nhân viên";
            // 
            // dTimePNgaysinh
            // 
            this.dTimePNgaysinh.Location = new System.Drawing.Point(136, 142);
            this.dTimePNgaysinh.Name = "dTimePNgaysinh";
            this.dTimePNgaysinh.Size = new System.Drawing.Size(299, 26);
            this.dTimePNgaysinh.TabIndex = 29;
            // 
            // dTimePThoidiem
            // 
            this.dTimePThoidiem.Location = new System.Drawing.Point(630, 175);
            this.dTimePThoidiem.Name = "dTimePThoidiem";
            this.dTimePThoidiem.Size = new System.Drawing.Size(210, 26);
            this.dTimePThoidiem.TabIndex = 30;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(136, 74);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(299, 26);
            this.txtTenNV.TabIndex = 31;
            // 
            // lbGioitinh
            // 
            this.lbGioitinh.AutoSize = true;
            this.lbGioitinh.Location = new System.Drawing.Point(29, 113);
            this.lbGioitinh.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbGioitinh.Name = "lbGioitinh";
            this.lbGioitinh.Size = new System.Drawing.Size(67, 19);
            this.lbGioitinh.TabIndex = 32;
            this.lbGioitinh.Text = "Giới tính";
            // 
            // lbChucvu
            // 
            this.lbChucvu.AutoSize = true;
            this.lbChucvu.Location = new System.Drawing.Point(215, 114);
            this.lbChucvu.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbChucvu.Name = "lbChucvu";
            this.lbChucvu.Size = new System.Drawing.Size(65, 19);
            this.lbChucvu.TabIndex = 33;
            this.lbChucvu.Text = "Chức vụ";
            // 
            // lbSodt
            // 
            this.lbSodt.AutoSize = true;
            this.lbSodt.Location = new System.Drawing.Point(28, 178);
            this.lbSodt.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbSodt.Name = "lbSodt";
            this.lbSodt.Size = new System.Drawing.Size(95, 19);
            this.lbSodt.TabIndex = 35;
            this.lbSodt.Text = "Số điện thoại";
            // 
            // lbSoBH
            // 
            this.lbSoBH.AutoSize = true;
            this.lbSoBH.Location = new System.Drawing.Point(29, 210);
            this.lbSoBH.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbSoBH.Name = "lbSoBH";
            this.lbSoBH.Size = new System.Drawing.Size(90, 19);
            this.lbSoBH.TabIndex = 36;
            this.lbSoBH.Text = "Số bảo hiểm";
            // 
            // lbMucluong
            // 
            this.lbMucluong.AutoSize = true;
            this.lbMucluong.Location = new System.Drawing.Point(528, 39);
            this.lbMucluong.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbMucluong.Name = "lbMucluong";
            this.lbMucluong.Size = new System.Drawing.Size(85, 19);
            this.lbMucluong.TabIndex = 38;
            this.lbMucluong.Text = "Mức lương";
            // 
            // lbThoidiem
            // 
            this.lbThoidiem.AutoSize = true;
            this.lbThoidiem.Location = new System.Drawing.Point(527, 180);
            this.lbThoidiem.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbThoidiem.Name = "lbThoidiem";
            this.lbThoidiem.Size = new System.Drawing.Size(104, 19);
            this.lbThoidiem.TabIndex = 39;
            this.lbThoidiem.Text = "Thời điểm làm";
            // 
            // lbKinhnghiem
            // 
            this.lbKinhnghiem.AutoSize = true;
            this.lbKinhnghiem.Location = new System.Drawing.Point(528, 146);
            this.lbKinhnghiem.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbKinhnghiem.Name = "lbKinhnghiem";
            this.lbKinhnghiem.Size = new System.Drawing.Size(93, 19);
            this.lbKinhnghiem.TabIndex = 40;
            this.lbKinhnghiem.Text = "Kinh nghiệm";
            // 
            // lbTrinhdo
            // 
            this.lbTrinhdo.AutoSize = true;
            this.lbTrinhdo.Location = new System.Drawing.Point(529, 77);
            this.lbTrinhdo.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbTrinhdo.Name = "lbTrinhdo";
            this.lbTrinhdo.Size = new System.Drawing.Size(64, 19);
            this.lbTrinhdo.TabIndex = 41;
            this.lbTrinhdo.Text = "Trình độ";
            // 
            // cbbChucvu
            // 
            this.cbbChucvu.FormattingEnabled = true;
            this.cbbChucvu.Location = new System.Drawing.Point(285, 109);
            this.cbbChucvu.Name = "cbbChucvu";
            this.cbbChucvu.Size = new System.Drawing.Size(150, 27);
            this.cbbChucvu.TabIndex = 42;
            // 
            // txtSodt
            // 
            this.txtSodt.Location = new System.Drawing.Point(136, 175);
            this.txtSodt.Name = "txtSodt";
            this.txtSodt.Size = new System.Drawing.Size(299, 26);
            this.txtSodt.TabIndex = 44;
            // 
            // cbbKinhnghiem
            // 
            this.cbbKinhnghiem.FormattingEnabled = true;
            this.cbbKinhnghiem.Location = new System.Drawing.Point(630, 141);
            this.cbbKinhnghiem.Name = "cbbKinhnghiem";
            this.cbbKinhnghiem.Size = new System.Drawing.Size(210, 27);
            this.cbbKinhnghiem.TabIndex = 45;
            // 
            // cbbTrinhdo
            // 
            this.cbbTrinhdo.FormattingEnabled = true;
            this.cbbTrinhdo.Location = new System.Drawing.Point(630, 74);
            this.cbbTrinhdo.Name = "cbbTrinhdo";
            this.cbbTrinhdo.Size = new System.Drawing.Size(210, 27);
            this.cbbTrinhdo.TabIndex = 45;
            // 
            // cbbMucluong
            // 
            this.cbbMucluong.FormattingEnabled = true;
            this.cbbMucluong.Location = new System.Drawing.Point(630, 42);
            this.cbbMucluong.Name = "cbbMucluong";
            this.cbbMucluong.Size = new System.Drawing.Size(210, 27);
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
            this.lbDiachi.Location = new System.Drawing.Point(28, 246);
            this.lbDiachi.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbDiachi.Name = "lbDiachi";
            this.lbDiachi.Size = new System.Drawing.Size(56, 19);
            this.lbDiachi.TabIndex = 47;
            this.lbDiachi.Text = "Địa chỉ";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(136, 239);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(704, 26);
            this.txtDiachi.TabIndex = 48;
            // 
            // grbCapnhat
            // 
            this.grbCapnhat.Controls.Add(this.txtDiachi);
            this.grbCapnhat.Controls.Add(this.lbDiachi);
            this.grbCapnhat.Controls.Add(this.textBox1);
            this.grbCapnhat.Controls.Add(this.cbbMucluong);
            this.grbCapnhat.Controls.Add(this.cmbChuyenMon);
            this.grbCapnhat.Controls.Add(this.cbbTrinhdo);
            this.grbCapnhat.Controls.Add(this.cbbKinhnghiem);
            this.grbCapnhat.Controls.Add(this.txtSodt);
            this.grbCapnhat.Controls.Add(this.cbbChucvu);
            this.grbCapnhat.Controls.Add(this.lbChuyenmon);
            this.grbCapnhat.Controls.Add(this.lbTrinhdo);
            this.grbCapnhat.Controls.Add(this.lbKinhnghiem);
            this.grbCapnhat.Controls.Add(this.lbThoidiem);
            this.grbCapnhat.Controls.Add(this.lbMucluong);
            this.grbCapnhat.Controls.Add(this.lbSoBH);
            this.grbCapnhat.Controls.Add(this.lbSodt);
            this.grbCapnhat.Controls.Add(this.lbChucvu);
            this.grbCapnhat.Controls.Add(this.lbGioitinh);
            this.grbCapnhat.Controls.Add(this.txtMaNV);
            this.grbCapnhat.Controls.Add(this.txtTenNV);
            this.grbCapnhat.Controls.Add(this.dTimePThoidiem);
            this.grbCapnhat.Controls.Add(this.lbMaNV);
            this.grbCapnhat.Controls.Add(this.dTimePNgaysinh);
            this.grbCapnhat.Controls.Add(this.lbTenNV);
            this.grbCapnhat.Controls.Add(this.cbbGioitinh);
            this.grbCapnhat.Controls.Add(this.txtSobaohiem);
            this.grbCapnhat.Controls.Add(this.lbNgaysinh);
            this.grbCapnhat.Location = new System.Drawing.Point(23, 89);
            this.grbCapnhat.Margin = new System.Windows.Forms.Padding(6);
            this.grbCapnhat.Name = "grbCapnhat";
            this.grbCapnhat.Padding = new System.Windows.Forms.Padding(6);
            this.grbCapnhat.Size = new System.Drawing.Size(871, 290);
            this.grbCapnhat.TabIndex = 58;
            this.grbCapnhat.TabStop = false;
            this.grbCapnhat.Text = "Thông tin cá nhân";
            // 
            // cmbChuyenMon
            // 
            this.cmbChuyenMon.FormattingEnabled = true;
            this.cmbChuyenMon.Location = new System.Drawing.Point(630, 107);
            this.cmbChuyenMon.Name = "cmbChuyenMon";
            this.cmbChuyenMon.Size = new System.Drawing.Size(210, 27);
            this.cmbChuyenMon.TabIndex = 45;
            // 
            // lbChuyenmon
            // 
            this.lbChuyenmon.AutoSize = true;
            this.lbChuyenmon.Location = new System.Drawing.Point(528, 111);
            this.lbChuyenmon.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbChuyenmon.Name = "lbChuyenmon";
            this.lbChuyenmon.Size = new System.Drawing.Size(92, 19);
            this.lbChuyenmon.TabIndex = 41;
            this.lbChuyenmon.Text = "Chuyên môn";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(581, 385);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 37);
            this.btnCancel.TabIndex = 103;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(29, 42);
            this.lbMaNV.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(101, 19);
            this.lbMaNV.TabIndex = 26;
            this.lbMaNV.Text = "Mã nhân viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(136, 39);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(299, 26);
            this.txtMaNV.TabIndex = 31;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(920, 640);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grbCapnhat);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbTieude);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grbThongtin);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label lbMucluong;
        private System.Windows.Forms.Label lbThoidiem;
        private System.Windows.Forms.Label lbKinhnghiem;
        private System.Windows.Forms.Label lbTrinhdo;
        private System.Windows.Forms.ComboBox cbbChucvu;
        private System.Windows.Forms.TextBox txtSodt;
        private System.Windows.Forms.ComboBox cbbKinhnghiem;
        private System.Windows.Forms.ComboBox cbbTrinhdo;
        private System.Windows.Forms.ComboBox cbbMucluong;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbDiachi;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.GroupBox grbCapnhat;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbChuyenMon;
        private System.Windows.Forms.Label lbChuyenmon;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lbMaNV;
    }
}