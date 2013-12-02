namespace QUANLIBENHVIEN.PresentationLayer
{
    partial class LoaiVatTu
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
            this.lbTieudeLoaivattu = new System.Windows.Forms.Label();
            this.grbCapnhattenloaivattu = new System.Windows.Forms.GroupBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lbTenloai = new System.Windows.Forms.Label();
            this.grbTTvattu = new System.Windows.Forms.GroupBox();
            this.dgrvLoaivattu = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtMaVT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbCapnhattenloaivattu.SuspendLayout();
            this.grbTTvattu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvLoaivattu)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTieudeLoaivattu
            // 
            this.lbTieudeLoaivattu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTieudeLoaivattu.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieudeLoaivattu.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbTieudeLoaivattu.Location = new System.Drawing.Point(0, 0);
            this.lbTieudeLoaivattu.Name = "lbTieudeLoaivattu";
            this.lbTieudeLoaivattu.Size = new System.Drawing.Size(912, 85);
            this.lbTieudeLoaivattu.TabIndex = 0;
            this.lbTieudeLoaivattu.Text = "LOẠI VẬT TƯ";
            this.lbTieudeLoaivattu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbCapnhattenloaivattu
            // 
            this.grbCapnhattenloaivattu.Controls.Add(this.txtMaVT);
            this.grbCapnhattenloaivattu.Controls.Add(this.label1);
            this.grbCapnhattenloaivattu.Controls.Add(this.txtTen);
            this.grbCapnhattenloaivattu.Controls.Add(this.lbTenloai);
            this.grbCapnhattenloaivattu.Location = new System.Drawing.Point(39, 88);
            this.grbCapnhattenloaivattu.Name = "grbCapnhattenloaivattu";
            this.grbCapnhattenloaivattu.Size = new System.Drawing.Size(405, 257);
            this.grbCapnhattenloaivattu.TabIndex = 1;
            this.grbCapnhattenloaivattu.TabStop = false;
            this.grbCapnhattenloaivattu.Text = "Thông tin loại vật tư";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(128, 136);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(254, 26);
            this.txtTen.TabIndex = 1;
            // 
            // lbTenloai
            // 
            this.lbTenloai.AutoSize = true;
            this.lbTenloai.Location = new System.Drawing.Point(24, 136);
            this.lbTenloai.Name = "lbTenloai";
            this.lbTenloai.Size = new System.Drawing.Size(63, 19);
            this.lbTenloai.TabIndex = 0;
            this.lbTenloai.Text = "Tên loại";
            // 
            // grbTTvattu
            // 
            this.grbTTvattu.Controls.Add(this.dgrvLoaivattu);
            this.grbTTvattu.Location = new System.Drawing.Point(462, 88);
            this.grbTTvattu.Name = "grbTTvattu";
            this.grbTTvattu.Size = new System.Drawing.Size(412, 257);
            this.grbTTvattu.TabIndex = 7;
            this.grbTTvattu.TabStop = false;
            this.grbTTvattu.Text = "Danh sách loại vật tư";
            // 
            // dgrvLoaivattu
            // 
            this.dgrvLoaivattu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvLoaivattu.Location = new System.Drawing.Point(6, 25);
            this.dgrvLoaivattu.Name = "dgrvLoaivattu";
            this.dgrvLoaivattu.Size = new System.Drawing.Size(393, 226);
            this.dgrvLoaivattu.TabIndex = 0;
            this.dgrvLoaivattu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTTLoaiVattu_CellContentClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(462, 375);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 37);
            this.btnCancel.TabIndex = 126;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(228, 375);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 37);
            this.btnAdd.TabIndex = 122;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(384, 375);
            this.btnSave.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 37);
            this.btnSave.TabIndex = 125;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(306, 375);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(79, 37);
            this.btnEdit.TabIndex = 123;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(540, 375);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 37);
            this.btnDelete.TabIndex = 124;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(618, 375);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(79, 37);
            this.btnThoat.TabIndex = 121;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtMaVT
            // 
            this.txtMaVT.Enabled = false;
            this.txtMaVT.Location = new System.Drawing.Point(128, 78);
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Size = new System.Drawing.Size(254, 26);
            this.txtMaVT.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã loại vật tư";
            // 
            // LoaiVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(912, 456);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grbTTvattu);
            this.Controls.Add(this.grbCapnhattenloaivattu);
            this.Controls.Add(this.lbTieudeLoaivattu);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoaiVatTu";
            this.Text = "Loại vật tư";
            this.Load += new System.EventHandler(this.LoaiVatTu_Load);
            this.grbCapnhattenloaivattu.ResumeLayout(false);
            this.grbCapnhattenloaivattu.PerformLayout();
            this.grbTTvattu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvLoaivattu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTieudeLoaivattu;
        private System.Windows.Forms.GroupBox grbCapnhattenloaivattu;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lbTenloai;
        private System.Windows.Forms.GroupBox grbTTvattu;
        private System.Windows.Forms.DataGridView dgrvLoaivattu;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtMaVT;
        private System.Windows.Forms.Label label1;
    }
}