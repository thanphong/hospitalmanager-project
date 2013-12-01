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
            this.txtVitri = new System.Windows.Forms.TextBox();
            this.txtMaP = new System.Windows.Forms.TextBox();
            this.txtTenP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTonggiuong = new System.Windows.Forms.TextBox();
            this.lbTenphong = new System.Windows.Forms.Label();
            this.lbTongsogiuong = new System.Windows.Forms.Label();
            this.lbVitri = new System.Windows.Forms.Label();
            this.lbTieude = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grbThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvPhong)).BeginInit();
            this.grbCapnhat.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(360, 257);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 37);
            this.btnAdd.TabIndex = 53;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grbThongtin
            // 
            this.grbThongtin.Controls.Add(this.dgrvPhong);
            this.grbThongtin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbThongtin.Location = new System.Drawing.Point(15, 320);
            this.grbThongtin.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.grbThongtin.Name = "grbThongtin";
            this.grbThongtin.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.grbThongtin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbThongtin.Size = new System.Drawing.Size(834, 178);
            this.grbThongtin.TabIndex = 51;
            this.grbThongtin.TabStop = false;
            this.grbThongtin.Text = "Danh sách phòng";
            // 
            // dgrvPhong
            // 
            this.dgrvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvPhong.Location = new System.Drawing.Point(13, 25);
            this.dgrvPhong.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.dgrvPhong.Name = "dgrvPhong";
            this.dgrvPhong.Size = new System.Drawing.Size(809, 142);
            this.dgrvPhong.TabIndex = 7;
            this.dgrvPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrvPhong_CellContentClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(438, 257);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(79, 37);
            this.btnEdit.TabIndex = 54;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(516, 257);
            this.btnSave.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 37);
            this.btnSave.TabIndex = 56;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(672, 257);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 37);
            this.btnDelete.TabIndex = 55;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grbCapnhat
            // 
            this.grbCapnhat.Controls.Add(this.txtVitri);
            this.grbCapnhat.Controls.Add(this.txtMaP);
            this.grbCapnhat.Controls.Add(this.txtTenP);
            this.grbCapnhat.Controls.Add(this.label1);
            this.grbCapnhat.Controls.Add(this.txtTonggiuong);
            this.grbCapnhat.Controls.Add(this.lbTenphong);
            this.grbCapnhat.Controls.Add(this.lbTongsogiuong);
            this.grbCapnhat.Controls.Add(this.lbVitri);
            this.grbCapnhat.Location = new System.Drawing.Point(28, 97);
            this.grbCapnhat.Margin = new System.Windows.Forms.Padding(6);
            this.grbCapnhat.Name = "grbCapnhat";
            this.grbCapnhat.Padding = new System.Windows.Forms.Padding(6);
            this.grbCapnhat.Size = new System.Drawing.Size(821, 141);
            this.grbCapnhat.TabIndex = 58;
            this.grbCapnhat.TabStop = false;
            this.grbCapnhat.Text = "Thông tin phòng";
            // 
            // txtVitri
            // 
            this.txtVitri.Location = new System.Drawing.Point(540, 38);
            this.txtVitri.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.txtVitri.Name = "txtVitri";
            this.txtVitri.Size = new System.Drawing.Size(261, 26);
            this.txtVitri.TabIndex = 32;
            // 
            // txtMaP
            // 
            this.txtMaP.Location = new System.Drawing.Point(137, 42);
            this.txtMaP.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.txtMaP.Name = "txtMaP";
            this.txtMaP.Size = new System.Drawing.Size(261, 26);
            this.txtMaP.TabIndex = 31;
            // 
            // txtTenP
            // 
            this.txtTenP.Location = new System.Drawing.Point(137, 76);
            this.txtTenP.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.txtTenP.Name = "txtTenP";
            this.txtTenP.Size = new System.Drawing.Size(261, 26);
            this.txtTenP.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã phòng";
            // 
            // txtTonggiuong
            // 
            this.txtTonggiuong.Location = new System.Drawing.Point(540, 73);
            this.txtTonggiuong.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.txtTonggiuong.Name = "txtTonggiuong";
            this.txtTonggiuong.Size = new System.Drawing.Size(261, 26);
            this.txtTonggiuong.TabIndex = 29;
            // 
            // lbTenphong
            // 
            this.lbTenphong.AutoSize = true;
            this.lbTenphong.Location = new System.Drawing.Point(20, 79);
            this.lbTenphong.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbTenphong.Name = "lbTenphong";
            this.lbTenphong.Size = new System.Drawing.Size(79, 19);
            this.lbTenphong.TabIndex = 26;
            this.lbTenphong.Text = "Tên phòng";
            // 
            // lbTongsogiuong
            // 
            this.lbTongsogiuong.AutoSize = true;
            this.lbTongsogiuong.Location = new System.Drawing.Point(423, 76);
            this.lbTongsogiuong.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbTongsogiuong.Name = "lbTongsogiuong";
            this.lbTongsogiuong.Size = new System.Drawing.Size(113, 19);
            this.lbTongsogiuong.TabIndex = 22;
            this.lbTongsogiuong.Text = "Tổng số giường";
            // 
            // lbVitri
            // 
            this.lbVitri.AutoSize = true;
            this.lbVitri.Location = new System.Drawing.Point(423, 44);
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
            this.lbTieude.Size = new System.Drawing.Size(876, 84);
            this.lbTieude.TabIndex = 59;
            this.lbTieude.Text = "PHÒNG";
            this.lbTieude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(750, 257);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(79, 37);
            this.btnThoat.TabIndex = 57;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(594, 257);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 37);
            this.btnCancel.TabIndex = 105;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(876, 521);
            this.Controls.Add(this.btnCancel);
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
            this.Text = "Phòng";
            this.Load += new System.EventHandler(this.Phong_Load);
            this.grbThongtin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvPhong)).EndInit();
            this.grbCapnhat.ResumeLayout(false);
            this.grbCapnhat.PerformLayout();
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
        private System.Windows.Forms.TextBox txtTonggiuong;
        private System.Windows.Forms.Label lbTenphong;
        private System.Windows.Forms.Label lbTongsogiuong;
        private System.Windows.Forms.Label lbVitri;
        private System.Windows.Forms.Label lbTieude;
        private System.Windows.Forms.TextBox txtTenP;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtVitri;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtMaP;
        private System.Windows.Forms.Label label1;
    }
}