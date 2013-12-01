namespace QUANLIBENHVIEN.PresentationLayer
{
    partial class LoaiThuoc
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
            this.lbLoaithuoc = new System.Windows.Forms.Label();
            this.grbCapnhatLoaithuoc = new System.Windows.Forms.GroupBox();
            this.txtTenLT = new System.Windows.Forms.TextBox();
            this.lbtenloaithuoc = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.grbTTLoaithuoc = new System.Windows.Forms.GroupBox();
            this.dgvLoaithuoc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLT = new System.Windows.Forms.TextBox();
            this.grbCapnhatLoaithuoc.SuspendLayout();
            this.grbTTLoaithuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaithuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLoaithuoc
            // 
            this.lbLoaithuoc.AutoSize = true;
            this.lbLoaithuoc.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaithuoc.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbLoaithuoc.Location = new System.Drawing.Point(289, 53);
            this.lbLoaithuoc.Name = "lbLoaithuoc";
            this.lbLoaithuoc.Size = new System.Drawing.Size(189, 31);
            this.lbLoaithuoc.TabIndex = 0;
            this.lbLoaithuoc.Text = "LOẠI THUỐC";
            // 
            // grbCapnhatLoaithuoc
            // 
            this.grbCapnhatLoaithuoc.Controls.Add(this.txtMaLT);
            this.grbCapnhatLoaithuoc.Controls.Add(this.txtTenLT);
            this.grbCapnhatLoaithuoc.Controls.Add(this.label1);
            this.grbCapnhatLoaithuoc.Controls.Add(this.lbtenloaithuoc);
            this.grbCapnhatLoaithuoc.Location = new System.Drawing.Point(63, 117);
            this.grbCapnhatLoaithuoc.Name = "grbCapnhatLoaithuoc";
            this.grbCapnhatLoaithuoc.Size = new System.Drawing.Size(509, 127);
            this.grbCapnhatLoaithuoc.TabIndex = 1;
            this.grbCapnhatLoaithuoc.TabStop = false;
            this.grbCapnhatLoaithuoc.Text = "Cập nhật loại thuốc";
            // 
            // txtTenLT
            // 
            this.txtTenLT.Location = new System.Drawing.Point(183, 72);
            this.txtTenLT.Name = "txtTenLT";
            this.txtTenLT.Size = new System.Drawing.Size(100, 26);
            this.txtTenLT.TabIndex = 1;
            // 
            // lbtenloaithuoc
            // 
            this.lbtenloaithuoc.AutoSize = true;
            this.lbtenloaithuoc.Location = new System.Drawing.Point(28, 79);
            this.lbtenloaithuoc.Name = "lbtenloaithuoc";
            this.lbtenloaithuoc.Size = new System.Drawing.Size(103, 19);
            this.lbtenloaithuoc.TabIndex = 0;
            this.lbtenloaithuoc.Text = "Tên loại thuốc";
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(100, 276);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 30);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(218, 276);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 30);
            this.btSua.TabIndex = 3;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(346, 276);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 30);
            this.btXoa.TabIndex = 4;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(468, 276);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 30);
            this.btLuu.TabIndex = 5;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(580, 276);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 30);
            this.btThoat.TabIndex = 6;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // grbTTLoaithuoc
            // 
            this.grbTTLoaithuoc.Controls.Add(this.dgvLoaithuoc);
            this.grbTTLoaithuoc.Location = new System.Drawing.Point(121, 343);
            this.grbTTLoaithuoc.Name = "grbTTLoaithuoc";
            this.grbTTLoaithuoc.Size = new System.Drawing.Size(497, 176);
            this.grbTTLoaithuoc.TabIndex = 7;
            this.grbTTLoaithuoc.TabStop = false;
            this.grbTTLoaithuoc.Text = "Thông tin loại thuốc";
            // 
            // dgvLoaithuoc
            // 
            this.dgvLoaithuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaithuoc.Location = new System.Drawing.Point(6, 20);
            this.dgvLoaithuoc.Name = "dgvLoaithuoc";
            this.dgvLoaithuoc.Size = new System.Drawing.Size(485, 150);
            this.dgvLoaithuoc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại thuốc";
            // 
            // txtMaLT
            // 
            this.txtMaLT.Location = new System.Drawing.Point(183, 38);
            this.txtMaLT.Name = "txtMaLT";
            this.txtMaLT.Size = new System.Drawing.Size(100, 26);
            this.txtMaLT.TabIndex = 1;
            // 
            // LoaiThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(888, 584);
            this.Controls.Add(this.grbTTLoaithuoc);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.grbCapnhatLoaithuoc);
            this.Controls.Add(this.lbLoaithuoc);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoaiThuoc";
            this.Text = "Loại Thuốc";
            this.grbCapnhatLoaithuoc.ResumeLayout(false);
            this.grbCapnhatLoaithuoc.PerformLayout();
            this.grbTTLoaithuoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaithuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLoaithuoc;
        private System.Windows.Forms.GroupBox grbCapnhatLoaithuoc;
        private System.Windows.Forms.TextBox txtTenLT;
        private System.Windows.Forms.Label lbtenloaithuoc;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.GroupBox grbTTLoaithuoc;
        private System.Windows.Forms.DataGridView dgvLoaithuoc;
        private System.Windows.Forms.TextBox txtMaLT;
        private System.Windows.Forms.Label label1;
    }
}