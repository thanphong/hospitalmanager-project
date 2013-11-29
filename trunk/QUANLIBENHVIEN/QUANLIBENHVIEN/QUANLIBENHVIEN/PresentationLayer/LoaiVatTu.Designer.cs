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
            this.lbTenloai = new System.Windows.Forms.Label();
            this.tbTenloai = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.grbTTvattu = new System.Windows.Forms.GroupBox();
            this.dgvTTLoaiVattu = new System.Windows.Forms.DataGridView();
            this.grbCapnhattenloaivattu.SuspendLayout();
            this.grbTTvattu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTLoaiVattu)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTieudeLoaivattu
            // 
            this.lbTieudeLoaivattu.AutoSize = true;
            this.lbTieudeLoaivattu.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieudeLoaivattu.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbTieudeLoaivattu.Location = new System.Drawing.Point(181, 51);
            this.lbTieudeLoaivattu.Name = "lbTieudeLoaivattu";
            this.lbTieudeLoaivattu.Size = new System.Drawing.Size(191, 31);
            this.lbTieudeLoaivattu.TabIndex = 0;
            this.lbTieudeLoaivattu.Text = "LOẠI VẬT TƯ";
            // 
            // grbCapnhattenloaivattu
            // 
            this.grbCapnhattenloaivattu.Controls.Add(this.tbTenloai);
            this.grbCapnhattenloaivattu.Controls.Add(this.lbTenloai);
            this.grbCapnhattenloaivattu.Location = new System.Drawing.Point(151, 123);
            this.grbCapnhattenloaivattu.Name = "grbCapnhattenloaivattu";
            this.grbCapnhattenloaivattu.Size = new System.Drawing.Size(283, 100);
            this.grbCapnhattenloaivattu.TabIndex = 1;
            this.grbCapnhattenloaivattu.TabStop = false;
            this.grbCapnhattenloaivattu.Text = "Cập nhật tên loại vật tư";
            // 
            // lbTenloai
            // 
            this.lbTenloai.AutoSize = true;
            this.lbTenloai.Location = new System.Drawing.Point(33, 47);
            this.lbTenloai.Name = "lbTenloai";
            this.lbTenloai.Size = new System.Drawing.Size(63, 19);
            this.lbTenloai.TabIndex = 0;
            this.lbTenloai.Text = "Tên loại";
            // 
            // tbTenloai
            // 
            this.tbTenloai.Location = new System.Drawing.Point(142, 40);
            this.tbTenloai.Name = "tbTenloai";
            this.tbTenloai.Size = new System.Drawing.Size(100, 26);
            this.tbTenloai.TabIndex = 1;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(71, 259);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 26);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(174, 259);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 26);
            this.btSua.TabIndex = 3;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(280, 259);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(79, 26);
            this.btxoa.TabIndex = 4;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(393, 259);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 26);
            this.btLuu.TabIndex = 5;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(500, 259);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 26);
            this.btThoat.TabIndex = 6;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // grbTTvattu
            // 
            this.grbTTvattu.Controls.Add(this.dgvTTLoaiVattu);
            this.grbTTvattu.Location = new System.Drawing.Point(98, 338);
            this.grbTTvattu.Name = "grbTTvattu";
            this.grbTTvattu.Size = new System.Drawing.Size(405, 143);
            this.grbTTvattu.TabIndex = 7;
            this.grbTTvattu.TabStop = false;
            this.grbTTvattu.Text = "Thông tin vật tư";
            // 
            // dgvTTLoaiVattu
            // 
            this.dgvTTLoaiVattu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTLoaiVattu.Location = new System.Drawing.Point(6, 25);
            this.dgvTTLoaiVattu.Name = "dgvTTLoaiVattu";
            this.dgvTTLoaiVattu.Size = new System.Drawing.Size(393, 112);
            this.dgvTTLoaiVattu.TabIndex = 0;
            // 
            // LoaiVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(626, 525);
            this.Controls.Add(this.grbTTvattu);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.grbCapnhattenloaivattu);
            this.Controls.Add(this.lbTieudeLoaivattu);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoaiVatTu";
            this.Text = "LoaiVatTu";
            this.grbCapnhattenloaivattu.ResumeLayout(false);
            this.grbCapnhattenloaivattu.PerformLayout();
            this.grbTTvattu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTLoaiVattu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTieudeLoaivattu;
        private System.Windows.Forms.GroupBox grbCapnhattenloaivattu;
        private System.Windows.Forms.TextBox tbTenloai;
        private System.Windows.Forms.Label lbTenloai;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.GroupBox grbTTvattu;
        private System.Windows.Forms.DataGridView dgvTTLoaiVattu;
    }
}