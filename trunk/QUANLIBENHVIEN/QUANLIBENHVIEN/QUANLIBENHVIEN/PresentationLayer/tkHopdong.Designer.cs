namespace QUANLIBENHVIEN.PresentationLayer
{
    partial class tkHopdong
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
            this.grbCapnhat = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbLoaiNV = new System.Windows.Forms.Label();
            this.cbbTenNV = new System.Windows.Forms.ComboBox();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.lbLuong = new System.Windows.Forms.Label();
            this.lbSogio = new System.Windows.Forms.Label();
            this.lbTieude = new System.Windows.Forms.Label();
            this.grbThongtin = new System.Windows.Forms.GroupBox();
            this.dgrvHopdong = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grbCapnhat.SuspendLayout();
            this.grbThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvHopdong)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCapnhat
            // 
            this.grbCapnhat.Controls.Add(this.textBox3);
            this.grbCapnhat.Controls.Add(this.textBox2);
            this.grbCapnhat.Controls.Add(this.textBox1);
            this.grbCapnhat.Controls.Add(this.btnCancel);
            this.grbCapnhat.Controls.Add(this.button1);
            this.grbCapnhat.Controls.Add(this.lbLoaiNV);
            this.grbCapnhat.Controls.Add(this.cbbTenNV);
            this.grbCapnhat.Controls.Add(this.lbTenNV);
            this.grbCapnhat.Controls.Add(this.lbLuong);
            this.grbCapnhat.Controls.Add(this.lbSogio);
            this.grbCapnhat.Location = new System.Drawing.Point(15, 314);
            this.grbCapnhat.Margin = new System.Windows.Forms.Padding(6);
            this.grbCapnhat.Name = "grbCapnhat";
            this.grbCapnhat.Padding = new System.Windows.Forms.Padding(6);
            this.grbCapnhat.Size = new System.Drawing.Size(954, 135);
            this.grbCapnhat.TabIndex = 53;
            this.grbCapnhat.TabStop = false;
            this.grbCapnhat.Text = "Nhập tìm kiếm";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(686, 88);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(98, 26);
            this.textBox3.TabIndex = 29;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(288, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 29;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(556, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 26);
            this.textBox1.TabIndex = 29;
            // 
            // lbLoaiNV
            // 
            this.lbLoaiNV.AutoSize = true;
            this.lbLoaiNV.Location = new System.Drawing.Point(405, 91);
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
            // lbLuong
            // 
            this.lbLuong.AutoSize = true;
            this.lbLuong.Location = new System.Drawing.Point(9, 91);
            this.lbLuong.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbLuong.Name = "lbLuong";
            this.lbLuong.Size = new System.Drawing.Size(251, 19);
            this.lbLuong.TabIndex = 22;
            this.lbLuong.Text = "Lương theo Tháng/Tuần(nhập M/W)";
            // 
            // lbSogio
            // 
            this.lbSogio.AutoSize = true;
            this.lbSogio.Location = new System.Drawing.Point(405, 42);
            this.lbSogio.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbSogio.Name = "lbSogio";
            this.lbSogio.Size = new System.Drawing.Size(143, 19);
            this.lbSogio.TabIndex = 21;
            this.lbSogio.Text = "Số giờ làm việc/tuần";
            // 
            // lbTieude
            // 
            this.lbTieude.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTieude.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTieude.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbTieude.Location = new System.Drawing.Point(0, 0);
            this.lbTieude.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbTieude.Name = "lbTieude";
            this.lbTieude.Size = new System.Drawing.Size(984, 83);
            this.lbTieude.TabIndex = 54;
            this.lbTieude.Text = "TÌM KIẾM HỢP ĐỒNG";
            this.lbTieude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbThongtin
            // 
            this.grbThongtin.Controls.Add(this.dgrvHopdong);
            this.grbThongtin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbThongtin.Location = new System.Drawing.Point(15, 81);
            this.grbThongtin.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.grbThongtin.Name = "grbThongtin";
            this.grbThongtin.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.grbThongtin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbThongtin.Size = new System.Drawing.Size(954, 228);
            this.grbThongtin.TabIndex = 55;
            this.grbThongtin.TabStop = false;
            this.grbThongtin.Text = "Thông tin hợp đồng";
            // 
            // dgrvHopdong
            // 
            this.dgrvHopdong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvHopdong.Location = new System.Drawing.Point(14, 26);
            this.dgrvHopdong.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.dgrvHopdong.Name = "dgrvHopdong";
            this.dgrvHopdong.Size = new System.Drawing.Size(932, 188);
            this.dgrvHopdong.TabIndex = 7;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(857, 468);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 36);
            this.btnThoat.TabIndex = 62;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(669, 468);
            this.btnSave.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 35);
            this.btnSave.TabIndex = 61;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(764, 468);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(92, 36);
            this.btnPrint.TabIndex = 60;
            this.btnPrint.Text = "In báo cáo";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(574, 469);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 35);
            this.btnEdit.TabIndex = 59;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(796, 58);
            this.button1.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 36);
            this.button1.TabIndex = 60;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(479, 469);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(92, 35);
            this.btnRefresh.TabIndex = 59;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(866, 58);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 36);
            this.btnCancel.TabIndex = 60;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tkHopdong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(984, 539);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.grbThongtin);
            this.Controls.Add(this.lbTieude);
            this.Controls.Add(this.grbCapnhat);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "tkHopdong";
            this.Text = "Tìm kiếm hợp đồng";
            this.grbCapnhat.ResumeLayout(false);
            this.grbCapnhat.PerformLayout();
            this.grbThongtin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvHopdong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCapnhat;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbLoaiNV;
        private System.Windows.Forms.ComboBox cbbTenNV;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.Label lbLuong;
        private System.Windows.Forms.Label lbSogio;
        private System.Windows.Forms.Label lbTieude;
        private System.Windows.Forms.GroupBox grbThongtin;
        private System.Windows.Forms.DataGridView dgrvHopdong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCancel;
    }
}