namespace QUANLIBENHVIEN.PresentationLayer
{
    partial class Giuong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbCapnhat = new System.Windows.Forms.GroupBox();
            this.txtMaG = new System.Windows.Forms.TextBox();
            this.lbMagiuong = new System.Windows.Forms.Label();
            this.cbbTenphong = new System.Windows.Forms.ComboBox();
            this.lbTenphong = new System.Windows.Forms.Label();
            this.dgrvGiuong = new System.Windows.Forms.DataGridView();
            this.grbThongtin = new System.Windows.Forms.GroupBox();
            this.lbTieude = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grbCapnhat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvGiuong)).BeginInit();
            this.grbThongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbCapnhat
            // 
            this.grbCapnhat.Controls.Add(this.txtMaG);
            this.grbCapnhat.Controls.Add(this.lbMagiuong);
            this.grbCapnhat.Controls.Add(this.cbbTenphong);
            this.grbCapnhat.Controls.Add(this.lbTenphong);
            this.grbCapnhat.Location = new System.Drawing.Point(15, 97);
            this.grbCapnhat.Margin = new System.Windows.Forms.Padding(6);
            this.grbCapnhat.Name = "grbCapnhat";
            this.grbCapnhat.Padding = new System.Windows.Forms.Padding(6);
            this.grbCapnhat.Size = new System.Drawing.Size(389, 225);
            this.grbCapnhat.TabIndex = 44;
            this.grbCapnhat.TabStop = false;
            this.grbCapnhat.Text = "Thông tin giường";
            // 
            // txtMaG
            // 
            this.txtMaG.Location = new System.Drawing.Point(122, 65);
            this.txtMaG.Name = "txtMaG";
            this.txtMaG.Size = new System.Drawing.Size(243, 26);
            this.txtMaG.TabIndex = 26;
            // 
            // lbMagiuong
            // 
            this.lbMagiuong.AutoSize = true;
            this.lbMagiuong.Location = new System.Drawing.Point(20, 67);
            this.lbMagiuong.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbMagiuong.Name = "lbMagiuong";
            this.lbMagiuong.Size = new System.Drawing.Size(84, 19);
            this.lbMagiuong.TabIndex = 21;
            this.lbMagiuong.Text = "Mã giường";
            // 
            // cbbTenphong
            // 
            this.cbbTenphong.FormattingEnabled = true;
            this.cbbTenphong.Location = new System.Drawing.Point(123, 112);
            this.cbbTenphong.Name = "cbbTenphong";
            this.cbbTenphong.Size = new System.Drawing.Size(242, 27);
            this.cbbTenphong.TabIndex = 25;
            this.cbbTenphong.SelectedIndexChanged += new System.EventHandler(this.cbbTenP_SelectedIndexChanged);
            // 
            // lbTenphong
            // 
            this.lbTenphong.AutoSize = true;
            this.lbTenphong.Location = new System.Drawing.Point(20, 112);
            this.lbTenphong.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbTenphong.Name = "lbTenphong";
            this.lbTenphong.Size = new System.Drawing.Size(79, 19);
            this.lbTenphong.TabIndex = 21;
            this.lbTenphong.Text = "Tên phòng";
            // 
            // dgrvGiuong
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrvGiuong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrvGiuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvGiuong.Location = new System.Drawing.Point(10, 32);
            this.dgrvGiuong.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.dgrvGiuong.Name = "dgrvGiuong";
            this.dgrvGiuong.Size = new System.Drawing.Size(375, 179);
            this.dgrvGiuong.TabIndex = 7;
            // 
            // grbThongtin
            // 
            this.grbThongtin.Controls.Add(this.dgrvGiuong);
            this.grbThongtin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbThongtin.Location = new System.Drawing.Point(510, 97);
            this.grbThongtin.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.grbThongtin.Name = "grbThongtin";
            this.grbThongtin.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.grbThongtin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbThongtin.Size = new System.Drawing.Size(394, 225);
            this.grbThongtin.TabIndex = 43;
            this.grbThongtin.TabStop = false;
            this.grbThongtin.Text = "Danh sách giường";
            // 
            // lbTieude
            // 
            this.lbTieude.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTieude.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTieude.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbTieude.Location = new System.Drawing.Point(0, 0);
            this.lbTieude.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbTieude.Name = "lbTieude";
            this.lbTieude.Size = new System.Drawing.Size(922, 84);
            this.lbTieude.TabIndex = 42;
            this.lbTieude.Text = "GIƯỜNG";
            this.lbTieude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(424, 287);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 35);
            this.btnThoat.TabIndex = 54;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(423, 148);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(72, 35);
            this.btnEdit.TabIndex = 51;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(424, 182);
            this.btnSave.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 36);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(424, 252);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 36);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(424, 115);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(71, 34);
            this.btnAdd.TabIndex = 50;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(424, 217);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 36);
            this.btnCancel.TabIndex = 105;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Giuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(922, 386);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grbCapnhat);
            this.Controls.Add(this.grbThongtin);
            this.Controls.Add(this.lbTieude);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Giuong";
            this.Text = "Nhập thông tin giường";
            this.Load += new System.EventHandler(this.Giuong_Load);
            this.grbCapnhat.ResumeLayout(false);
            this.grbCapnhat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvGiuong)).EndInit();
            this.grbThongtin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCapnhat;
        private System.Windows.Forms.ComboBox cbbTenphong;
        private System.Windows.Forms.Label lbTenphong;
        private System.Windows.Forms.DataGridView dgrvGiuong;
        private System.Windows.Forms.GroupBox grbThongtin;
        private System.Windows.Forms.Label lbTieude;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbMagiuong;
        private System.Windows.Forms.TextBox txtMaG;
    }
}