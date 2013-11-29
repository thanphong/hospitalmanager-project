namespace QUANLIBENHVIEN.PresentationLayer
{
    partial class DonThuoc
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
            this.lbTieudeDonthuoc = new System.Windows.Forms.Label();
            this.grbCapnhatdonthuoc = new System.Windows.Forms.GroupBox();
            this.lbMabenhnhan = new System.Windows.Forms.Label();
            this.cbMabenhnhan = new System.Windows.Forms.ComboBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.grbTTdonthuoc = new System.Windows.Forms.GroupBox();
            this.dgvDonthuoc = new System.Windows.Forms.DataGridView();
            this.grbCapnhatdonthuoc.SuspendLayout();
            this.grbTTdonthuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonthuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTieudeDonthuoc
            // 
            this.lbTieudeDonthuoc.AutoSize = true;
            this.lbTieudeDonthuoc.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieudeDonthuoc.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbTieudeDonthuoc.Location = new System.Drawing.Point(257, 47);
            this.lbTieudeDonthuoc.Name = "lbTieudeDonthuoc";
            this.lbTieudeDonthuoc.Size = new System.Drawing.Size(182, 31);
            this.lbTieudeDonthuoc.TabIndex = 0;
            this.lbTieudeDonthuoc.Text = "ĐƠN THUỐC";
            // 
            // grbCapnhatdonthuoc
            // 
            this.grbCapnhatdonthuoc.Controls.Add(this.cbMabenhnhan);
            this.grbCapnhatdonthuoc.Controls.Add(this.lbMabenhnhan);
            this.grbCapnhatdonthuoc.Location = new System.Drawing.Point(128, 112);
            this.grbCapnhatdonthuoc.Name = "grbCapnhatdonthuoc";
            this.grbCapnhatdonthuoc.Size = new System.Drawing.Size(370, 120);
            this.grbCapnhatdonthuoc.TabIndex = 1;
            this.grbCapnhatdonthuoc.TabStop = false;
            this.grbCapnhatdonthuoc.Text = "Cập nhật đơn thuốc";
            // 
            // lbMabenhnhan
            // 
            this.lbMabenhnhan.AutoSize = true;
            this.lbMabenhnhan.Location = new System.Drawing.Point(60, 58);
            this.lbMabenhnhan.Name = "lbMabenhnhan";
            this.lbMabenhnhan.Size = new System.Drawing.Size(105, 19);
            this.lbMabenhnhan.TabIndex = 0;
            this.lbMabenhnhan.Text = "Mã bệnh nhân";
            // 
            // cbMabenhnhan
            // 
            this.cbMabenhnhan.FormattingEnabled = true;
            this.cbMabenhnhan.Location = new System.Drawing.Point(190, 50);
            this.cbMabenhnhan.Name = "cbMabenhnhan";
            this.cbMabenhnhan.Size = new System.Drawing.Size(121, 27);
            this.cbMabenhnhan.TabIndex = 1;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(69, 258);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 30);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(171, 258);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 30);
            this.btSua.TabIndex = 3;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(279, 258);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 30);
            this.btXoa.TabIndex = 4;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(387, 258);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 30);
            this.btLuu.TabIndex = 5;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(499, 258);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 30);
            this.btThoat.TabIndex = 6;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // grbTTdonthuoc
            // 
            this.grbTTdonthuoc.Controls.Add(this.dgvDonthuoc);
            this.grbTTdonthuoc.Location = new System.Drawing.Point(82, 324);
            this.grbTTdonthuoc.Name = "grbTTdonthuoc";
            this.grbTTdonthuoc.Size = new System.Drawing.Size(473, 214);
            this.grbTTdonthuoc.TabIndex = 7;
            this.grbTTdonthuoc.TabStop = false;
            this.grbTTdonthuoc.Text = "Thông tin đơn thuốc";
            // 
            // dgvDonthuoc
            // 
            this.dgvDonthuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonthuoc.Location = new System.Drawing.Point(15, 25);
            this.dgvDonthuoc.Name = "dgvDonthuoc";
            this.dgvDonthuoc.Size = new System.Drawing.Size(452, 183);
            this.dgvDonthuoc.TabIndex = 0;
            // 
            // DonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(666, 618);
            this.Controls.Add(this.grbTTdonthuoc);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.grbCapnhatdonthuoc);
            this.Controls.Add(this.lbTieudeDonthuoc);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DonThuoc";
            this.Text = "DonThuoc";
            this.grbCapnhatdonthuoc.ResumeLayout(false);
            this.grbCapnhatdonthuoc.PerformLayout();
            this.grbTTdonthuoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonthuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTieudeDonthuoc;
        private System.Windows.Forms.GroupBox grbCapnhatdonthuoc;
        private System.Windows.Forms.ComboBox cbMabenhnhan;
        private System.Windows.Forms.Label lbMabenhnhan;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.GroupBox grbTTdonthuoc;
        private System.Windows.Forms.DataGridView dgvDonthuoc;
    }
}