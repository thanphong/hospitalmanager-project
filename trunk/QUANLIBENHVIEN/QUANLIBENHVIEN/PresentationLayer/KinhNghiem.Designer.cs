namespace QUANLIBENHVIEN.PresentationLayer
{
    partial class KinhNghiem
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
            this.cbbTenCM = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grbThongtin = new System.Windows.Forms.GroupBox();
            this.dgrvKinhnghiem = new System.Windows.Forms.DataGridView();
            this.txtTenTochuc = new System.Windows.Forms.TextBox();
            this.lbNgayBD = new System.Windows.Forms.Label();
            this.lbTenCM = new System.Windows.Forms.Label();
            this.lbTieude = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbTenTochuc = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grbCapnhat = new System.Windows.Forms.GroupBox();
            this.dTimePNgayKT = new System.Windows.Forms.DateTimePicker();
            this.dTimePNgayBT = new System.Windows.Forms.DateTimePicker();
            this.lbNgayKT = new System.Windows.Forms.Label();
            this.cbbTenNV = new System.Windows.Forms.ComboBox();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grbThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvKinhnghiem)).BeginInit();
            this.grbCapnhat.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbTenCM
            // 
            this.cbbTenCM.FormattingEnabled = true;
            this.cbbTenCM.Location = new System.Drawing.Point(136, 78);
            this.cbbTenCM.Name = "cbbTenCM";
            this.cbbTenCM.Size = new System.Drawing.Size(252, 27);
            this.cbbTenCM.TabIndex = 25;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(449, 136);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 34);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // grbThongtin
            // 
            this.grbThongtin.Controls.Add(this.dgrvKinhnghiem);
            this.grbThongtin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbThongtin.Location = new System.Drawing.Point(555, 112);
            this.grbThongtin.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.grbThongtin.Name = "grbThongtin";
            this.grbThongtin.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.grbThongtin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbThongtin.Size = new System.Drawing.Size(582, 264);
            this.grbThongtin.TabIndex = 43;
            this.grbThongtin.TabStop = false;
            this.grbThongtin.Text = "Thông tin kinh nghiệm";
            // 
            // dgrvKinhnghiem
            // 
            this.dgrvKinhnghiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvKinhnghiem.Location = new System.Drawing.Point(14, 21);
            this.dgrvKinhnghiem.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.dgrvKinhnghiem.Name = "dgrvKinhnghiem";
            this.dgrvKinhnghiem.Size = new System.Drawing.Size(558, 225);
            this.dgrvKinhnghiem.TabIndex = 7;
            // 
            // txtTenTochuc
            // 
            this.txtTenTochuc.Location = new System.Drawing.Point(15, 220);
            this.txtTenTochuc.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.txtTenTochuc.Name = "txtTenTochuc";
            this.txtTenTochuc.Size = new System.Drawing.Size(373, 26);
            this.txtTenTochuc.TabIndex = 24;
            // 
            // lbNgayBD
            // 
            this.lbNgayBD.AutoSize = true;
            this.lbNgayBD.Location = new System.Drawing.Point(9, 120);
            this.lbNgayBD.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbNgayBD.Name = "lbNgayBD";
            this.lbNgayBD.Size = new System.Drawing.Size(98, 19);
            this.lbNgayBD.TabIndex = 22;
            this.lbNgayBD.Text = "Ngày bắt đầu";
            // 
            // lbTenCM
            // 
            this.lbTenCM.AutoSize = true;
            this.lbTenCM.Location = new System.Drawing.Point(9, 81);
            this.lbTenCM.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbTenCM.Name = "lbTenCM";
            this.lbTenCM.Size = new System.Drawing.Size(118, 19);
            this.lbTenCM.TabIndex = 21;
            this.lbTenCM.Text = "Tên chuyên môn";
            // 
            // lbTieude
            // 
            this.lbTieude.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTieude.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTieude.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbTieude.Location = new System.Drawing.Point(0, 0);
            this.lbTieude.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbTieude.Name = "lbTieude";
            this.lbTieude.Size = new System.Drawing.Size(1150, 106);
            this.lbTieude.TabIndex = 42;
            this.lbTieude.Text = "KINH NGHIỆM";
            this.lbTieude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(449, 317);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 40);
            this.btnThoat.TabIndex = 49;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(449, 170);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 35);
            this.btnEdit.TabIndex = 46;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(449, 241);
            this.btnSave.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 39);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lbTenTochuc
            // 
            this.lbTenTochuc.AutoSize = true;
            this.lbTenTochuc.Location = new System.Drawing.Point(11, 194);
            this.lbTenTochuc.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbTenTochuc.Name = "lbTenTochuc";
            this.lbTenTochuc.Size = new System.Drawing.Size(151, 19);
            this.lbTenTochuc.TabIndex = 19;
            this.lbTenTochuc.Text = "Tên tổ chức cấp bằng";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(449, 280);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 36);
            this.btnDelete.TabIndex = 47;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // grbCapnhat
            // 
            this.grbCapnhat.Controls.Add(this.dTimePNgayKT);
            this.grbCapnhat.Controls.Add(this.dTimePNgayBT);
            this.grbCapnhat.Controls.Add(this.lbNgayKT);
            this.grbCapnhat.Controls.Add(this.cbbTenNV);
            this.grbCapnhat.Controls.Add(this.lbTenNV);
            this.grbCapnhat.Controls.Add(this.cbbTenCM);
            this.grbCapnhat.Controls.Add(this.txtTenTochuc);
            this.grbCapnhat.Controls.Add(this.lbNgayBD);
            this.grbCapnhat.Controls.Add(this.lbTenCM);
            this.grbCapnhat.Controls.Add(this.lbTenTochuc);
            this.grbCapnhat.Location = new System.Drawing.Point(27, 112);
            this.grbCapnhat.Margin = new System.Windows.Forms.Padding(6);
            this.grbCapnhat.Name = "grbCapnhat";
            this.grbCapnhat.Padding = new System.Windows.Forms.Padding(6);
            this.grbCapnhat.Size = new System.Drawing.Size(399, 260);
            this.grbCapnhat.TabIndex = 44;
            this.grbCapnhat.TabStop = false;
            this.grbCapnhat.Text = "Cập nhật kinh nghiệm";
            // 
            // dTimePNgayKT
            // 
            this.dTimePNgayKT.Location = new System.Drawing.Point(136, 149);
            this.dTimePNgayKT.Name = "dTimePNgayKT";
            this.dTimePNgayKT.Size = new System.Drawing.Size(250, 26);
            this.dTimePNgayKT.TabIndex = 30;
            // 
            // dTimePNgayBT
            // 
            this.dTimePNgayBT.Location = new System.Drawing.Point(136, 114);
            this.dTimePNgayBT.Name = "dTimePNgayBT";
            this.dTimePNgayBT.Size = new System.Drawing.Size(250, 26);
            this.dTimePNgayBT.TabIndex = 29;
            // 
            // lbNgayKT
            // 
            this.lbNgayKT.AutoSize = true;
            this.lbNgayKT.Location = new System.Drawing.Point(11, 155);
            this.lbNgayKT.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbNgayKT.Name = "lbNgayKT";
            this.lbNgayKT.Size = new System.Drawing.Size(103, 19);
            this.lbNgayKT.TabIndex = 28;
            this.lbNgayKT.Text = "Ngày kết thúc";
            // 
            // cbbTenNV
            // 
            this.cbbTenNV.FormattingEnabled = true;
            this.cbbTenNV.Location = new System.Drawing.Point(136, 39);
            this.cbbTenNV.Name = "cbbTenNV";
            this.cbbTenNV.Size = new System.Drawing.Size(252, 27);
            this.cbbTenNV.TabIndex = 27;
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
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(449, 204);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 37);
            this.btnCancel.TabIndex = 104;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // KinhNghiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1150, 404);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grbThongtin);
            this.Controls.Add(this.lbTieude);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grbCapnhat);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KinhNghiem";
            this.Text = "KinhNghiem";
            this.grbThongtin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvKinhnghiem)).EndInit();
            this.grbCapnhat.ResumeLayout(false);
            this.grbCapnhat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbTenCM;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grbThongtin;
        private System.Windows.Forms.DataGridView dgrvKinhnghiem;
        private System.Windows.Forms.TextBox txtTenTochuc;
        private System.Windows.Forms.Label lbNgayBD;
        private System.Windows.Forms.Label lbTenCM;
        private System.Windows.Forms.Label lbTieude;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbTenTochuc;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grbCapnhat;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.ComboBox cbbTenNV;
        private System.Windows.Forms.DateTimePicker dTimePNgayKT;
        private System.Windows.Forms.DateTimePicker dTimePNgayBT;
        private System.Windows.Forms.Label lbNgayKT;
        private System.Windows.Forms.Button btnCancel;
    }
}