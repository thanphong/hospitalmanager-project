namespace QUANLIBENHVIEN.PresentationLayer
{
    partial class Phong
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.grbThongtin = new System.Windows.Forms.GroupBox();
            this.dgrvPhong = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grbCapnhat = new System.Windows.Forms.GroupBox();
            this.txtTenphong = new System.Windows.Forms.TextBox();
            this.txtGiuongtrong = new System.Windows.Forms.TextBox();
            this.txtTongsogiuong = new System.Windows.Forms.TextBox();
            this.lbSogiuongtrong = new System.Windows.Forms.Label();
            this.lbTenphong = new System.Windows.Forms.Label();
            this.cbbTenCM = new System.Windows.Forms.ComboBox();
            this.lbTongsogiuong = new System.Windows.Forms.Label();
            this.lbVitri = new System.Windows.Forms.Label();
            this.lbTieude = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbChitietphong = new System.Windows.Forms.GroupBox();
            this.cbbTenNV = new System.Windows.Forms.ComboBox();
            this.lbPhong = new System.Windows.Forms.Label();
            this.cbbTenphong = new System.Windows.Forms.ComboBox();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.btnAddCTP = new System.Windows.Forms.Button();
            this.btnSaveCTP = new System.Windows.Forms.Button();
            this.btnEditCTP = new System.Windows.Forms.Button();
            this.btnDeleteCTP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgrvCTPhong = new System.Windows.Forms.DataGridView();
            this.grbThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvPhong)).BeginInit();
            this.grbCapnhat.SuspendLayout();
            this.grbChitietphong.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvCTPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(446, 104);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(71, 37);
            this.btnAdd.TabIndex = 53;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // grbThongtin
            // 
            this.grbThongtin.Controls.Add(this.dgrvPhong);
            this.grbThongtin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbThongtin.Location = new System.Drawing.Point(529, 97);
            this.grbThongtin.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.grbThongtin.Name = "grbThongtin";
            this.grbThongtin.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.grbThongtin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbThongtin.Size = new System.Drawing.Size(598, 205);
            this.grbThongtin.TabIndex = 51;
            this.grbThongtin.TabStop = false;
            this.grbThongtin.Text = "Thông tin phòng";
            // 
            // dgrvPhong
            // 
            this.dgrvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvPhong.Location = new System.Drawing.Point(13, 25);
            this.dgrvPhong.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.dgrvPhong.Name = "dgrvPhong";
            this.dgrvPhong.Size = new System.Drawing.Size(573, 163);
            this.dgrvPhong.TabIndex = 7;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(446, 144);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(70, 35);
            this.btnEdit.TabIndex = 54;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(446, 219);
            this.btnSave.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 37);
            this.btnSave.TabIndex = 56;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(446, 181);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 36);
            this.btnDelete.TabIndex = 55;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // grbCapnhat
            // 
            this.grbCapnhat.Controls.Add(this.txtTenphong);
            this.grbCapnhat.Controls.Add(this.txtGiuongtrong);
            this.grbCapnhat.Controls.Add(this.txtTongsogiuong);
            this.grbCapnhat.Controls.Add(this.lbSogiuongtrong);
            this.grbCapnhat.Controls.Add(this.lbTenphong);
            this.grbCapnhat.Controls.Add(this.cbbTenCM);
            this.grbCapnhat.Controls.Add(this.lbTongsogiuong);
            this.grbCapnhat.Controls.Add(this.lbVitri);
            this.grbCapnhat.Location = new System.Drawing.Point(15, 97);
            this.grbCapnhat.Margin = new System.Windows.Forms.Padding(6);
            this.grbCapnhat.Name = "grbCapnhat";
            this.grbCapnhat.Padding = new System.Windows.Forms.Padding(6);
            this.grbCapnhat.Size = new System.Drawing.Size(414, 183);
            this.grbCapnhat.TabIndex = 58;
            this.grbCapnhat.TabStop = false;
            this.grbCapnhat.Text = "Cập nhật phòng";
            // 
            // txtTenphong
            // 
            this.txtTenphong.Location = new System.Drawing.Point(142, 29);
            this.txtTenphong.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.txtTenphong.Name = "txtTenphong";
            this.txtTenphong.Size = new System.Drawing.Size(261, 26);
            this.txtTenphong.TabIndex = 31;
            // 
            // txtGiuongtrong
            // 
            this.txtGiuongtrong.Location = new System.Drawing.Point(142, 133);
            this.txtGiuongtrong.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.txtGiuongtrong.Name = "txtGiuongtrong";
            this.txtGiuongtrong.Size = new System.Drawing.Size(261, 26);
            this.txtGiuongtrong.TabIndex = 30;
            // 
            // txtTongsogiuong
            // 
            this.txtTongsogiuong.Location = new System.Drawing.Point(142, 100);
            this.txtTongsogiuong.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.txtTongsogiuong.Name = "txtTongsogiuong";
            this.txtTongsogiuong.Size = new System.Drawing.Size(261, 26);
            this.txtTongsogiuong.TabIndex = 29;
            // 
            // lbSogiuongtrong
            // 
            this.lbSogiuongtrong.AutoSize = true;
            this.lbSogiuongtrong.Location = new System.Drawing.Point(15, 136);
            this.lbSogiuongtrong.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbSogiuongtrong.Name = "lbSogiuongtrong";
            this.lbSogiuongtrong.Size = new System.Drawing.Size(116, 19);
            this.lbSogiuongtrong.TabIndex = 28;
            this.lbSogiuongtrong.Text = "Số giường trống";
            // 
            // lbTenphong
            // 
            this.lbTenphong.AutoSize = true;
            this.lbTenphong.Location = new System.Drawing.Point(15, 32);
            this.lbTenphong.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbTenphong.Name = "lbTenphong";
            this.lbTenphong.Size = new System.Drawing.Size(79, 19);
            this.lbTenphong.TabIndex = 26;
            this.lbTenphong.Text = "Tên phòng";
            // 
            // cbbTenCM
            // 
            this.cbbTenCM.FormattingEnabled = true;
            this.cbbTenCM.Location = new System.Drawing.Point(142, 65);
            this.cbbTenCM.Name = "cbbTenCM";
            this.cbbTenCM.Size = new System.Drawing.Size(261, 27);
            this.cbbTenCM.TabIndex = 25;
            // 
            // lbTongsogiuong
            // 
            this.lbTongsogiuong.AutoSize = true;
            this.lbTongsogiuong.Location = new System.Drawing.Point(15, 103);
            this.lbTongsogiuong.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbTongsogiuong.Name = "lbTongsogiuong";
            this.lbTongsogiuong.Size = new System.Drawing.Size(113, 19);
            this.lbTongsogiuong.TabIndex = 22;
            this.lbTongsogiuong.Text = "Tổng số giường";
            // 
            // lbVitri
            // 
            this.lbVitri.AutoSize = true;
            this.lbVitri.Location = new System.Drawing.Point(15, 68);
            this.lbVitri.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbVitri.Name = "lbVitri";
            this.lbVitri.Size = new System.Drawing.Size(43, 19);
            this.lbVitri.TabIndex = 21;
            this.lbVitri.Text = "Vị trí";
            // 
            // lbTieude
            // 
            this.lbTieude.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTieude.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTieude.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbTieude.Location = new System.Drawing.Point(0, 0);
            this.lbTieude.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbTieude.Name = "lbTieude";
            this.lbTieude.Size = new System.Drawing.Size(1150, 91);
            this.lbTieude.TabIndex = 59;
            this.lbTieude.Text = "PHÒNG";
            this.lbTieude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(15, 457);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 43);
            this.btnThoat.TabIndex = 57;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // grbChitietphong
            // 
            this.grbChitietphong.Controls.Add(this.cbbTenNV);
            this.grbChitietphong.Controls.Add(this.lbPhong);
            this.grbChitietphong.Controls.Add(this.cbbTenphong);
            this.grbChitietphong.Controls.Add(this.lbTenNV);
            this.grbChitietphong.Location = new System.Drawing.Point(15, 315);
            this.grbChitietphong.Margin = new System.Windows.Forms.Padding(6);
            this.grbChitietphong.Name = "grbChitietphong";
            this.grbChitietphong.Padding = new System.Windows.Forms.Padding(6);
            this.grbChitietphong.Size = new System.Drawing.Size(414, 123);
            this.grbChitietphong.TabIndex = 60;
            this.grbChitietphong.TabStop = false;
            this.grbChitietphong.Text = "Cập nhật chi tiết phòng";
            // 
            // cbbTenNV
            // 
            this.cbbTenNV.FormattingEnabled = true;
            this.cbbTenNV.Location = new System.Drawing.Point(144, 68);
            this.cbbTenNV.Name = "cbbTenNV";
            this.cbbTenNV.Size = new System.Drawing.Size(261, 27);
            this.cbbTenNV.TabIndex = 27;
            // 
            // lbPhong
            // 
            this.lbPhong.AutoSize = true;
            this.lbPhong.Location = new System.Drawing.Point(15, 32);
            this.lbPhong.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbPhong.Name = "lbPhong";
            this.lbPhong.Size = new System.Drawing.Size(79, 19);
            this.lbPhong.TabIndex = 26;
            this.lbPhong.Text = "Tên phòng";
            // 
            // cbbTenphong
            // 
            this.cbbTenphong.FormattingEnabled = true;
            this.cbbTenphong.Location = new System.Drawing.Point(142, 32);
            this.cbbTenphong.Name = "cbbTenphong";
            this.cbbTenphong.Size = new System.Drawing.Size(261, 27);
            this.cbbTenphong.TabIndex = 25;
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Location = new System.Drawing.Point(15, 68);
            this.lbTenNV.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(103, 19);
            this.lbTenNV.TabIndex = 21;
            this.lbTenNV.Text = "Tên nhân viên";
            // 
            // btnAddCTP
            // 
            this.btnAddCTP.Location = new System.Drawing.Point(443, 315);
            this.btnAddCTP.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnAddCTP.Name = "btnAddCTP";
            this.btnAddCTP.Size = new System.Drawing.Size(71, 37);
            this.btnAddCTP.TabIndex = 61;
            this.btnAddCTP.Text = "Thêm";
            this.btnAddCTP.UseVisualStyleBackColor = true;
            // 
            // btnSaveCTP
            // 
            this.btnSaveCTP.Location = new System.Drawing.Point(443, 430);
            this.btnSaveCTP.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnSaveCTP.Name = "btnSaveCTP";
            this.btnSaveCTP.Size = new System.Drawing.Size(68, 37);
            this.btnSaveCTP.TabIndex = 64;
            this.btnSaveCTP.Text = "Lưu";
            this.btnSaveCTP.UseVisualStyleBackColor = true;
            // 
            // btnEditCTP
            // 
            this.btnEditCTP.Location = new System.Drawing.Point(443, 355);
            this.btnEditCTP.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnEditCTP.Name = "btnEditCTP";
            this.btnEditCTP.Size = new System.Drawing.Size(70, 35);
            this.btnEditCTP.TabIndex = 62;
            this.btnEditCTP.Text = "Sửa";
            this.btnEditCTP.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCTP
            // 
            this.btnDeleteCTP.Location = new System.Drawing.Point(443, 392);
            this.btnDeleteCTP.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnDeleteCTP.Name = "btnDeleteCTP";
            this.btnDeleteCTP.Size = new System.Drawing.Size(70, 36);
            this.btnDeleteCTP.TabIndex = 63;
            this.btnDeleteCTP.Text = "Xóa";
            this.btnDeleteCTP.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgrvCTPhong);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(529, 315);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(598, 166);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết phòng";
            // 
            // dgrvCTPhong
            // 
            this.dgrvCTPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvCTPhong.Location = new System.Drawing.Point(13, 25);
            this.dgrvCTPhong.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.dgrvCTPhong.Name = "dgrvCTPhong";
            this.dgrvCTPhong.Size = new System.Drawing.Size(573, 127);
            this.dgrvCTPhong.TabIndex = 7;
            // 
            // Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1150, 509);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddCTP);
            this.Controls.Add(this.btnSaveCTP);
            this.Controls.Add(this.btnEditCTP);
            this.Controls.Add(this.btnDeleteCTP);
            this.Controls.Add(this.grbChitietphong);
            this.Controls.Add(this.lbTieude);
            this.Controls.Add(this.grbCapnhat);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grbThongtin);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Phong";
            this.Text = "Phong";
            this.Load += new System.EventHandler(this.Phong_Load);
            this.grbThongtin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvPhong)).EndInit();
            this.grbCapnhat.ResumeLayout(false);
            this.grbCapnhat.PerformLayout();
            this.grbChitietphong.ResumeLayout(false);
            this.grbChitietphong.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvCTPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grbThongtin;
        private System.Windows.Forms.DataGridView dgrvPhong;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grbCapnhat;
        private System.Windows.Forms.TextBox txtGiuongtrong;
        private System.Windows.Forms.TextBox txtTongsogiuong;
        private System.Windows.Forms.Label lbSogiuongtrong;
        private System.Windows.Forms.Label lbTenphong;
        private System.Windows.Forms.ComboBox cbbTenCM;
        private System.Windows.Forms.Label lbTongsogiuong;
        private System.Windows.Forms.Label lbVitri;
        private System.Windows.Forms.Label lbTieude;
        private System.Windows.Forms.TextBox txtTenphong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grbChitietphong;
        private System.Windows.Forms.Label lbPhong;
        private System.Windows.Forms.ComboBox cbbTenphong;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.ComboBox cbbTenNV;
        private System.Windows.Forms.Button btnAddCTP;
        private System.Windows.Forms.Button btnSaveCTP;
        private System.Windows.Forms.Button btnEditCTP;
        private System.Windows.Forms.Button btnDeleteCTP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgrvCTPhong;
    }
}