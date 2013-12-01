namespace QUANLIBENHVIEN.PresentationLayer
{
    partial class CTPhong
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgrvCTPhong = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbTieude = new System.Windows.Forms.Label();
            this.grbChitietphong = new System.Windows.Forms.GroupBox();
            this.txtMaCTP = new System.Windows.Forms.TextBox();
            this.lbMaCT = new System.Windows.Forms.Label();
            this.lbPhong = new System.Windows.Forms.Label();
            this.cbbTenphong = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvCTPhong)).BeginInit();
            this.grbChitietphong.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(389, 357);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 37);
            this.btnCancel.TabIndex = 114;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgrvCTPhong);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(437, 113);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(564, 205);
            this.groupBox1.TabIndex = 113;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách chi tiết phòng";
            // 
            // dgrvCTPhong
            // 
            this.dgrvCTPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvCTPhong.Location = new System.Drawing.Point(12, 25);
            this.dgrvCTPhong.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.dgrvCTPhong.Name = "dgrvCTPhong";
            this.dgrvCTPhong.Size = new System.Drawing.Size(539, 160);
            this.dgrvCTPhong.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(155, 357);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 37);
            this.btnAdd.TabIndex = 109;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(311, 357);
            this.btnSave.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 37);
            this.btnSave.TabIndex = 112;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(233, 357);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(79, 37);
            this.btnEdit.TabIndex = 110;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(467, 357);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 37);
            this.btnDelete.TabIndex = 111;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(545, 357);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(79, 37);
            this.btnThoat.TabIndex = 107;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lbTieude
            // 
            this.lbTieude.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTieude.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTieude.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbTieude.Location = new System.Drawing.Point(0, 0);
            this.lbTieude.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbTieude.Name = "lbTieude";
            this.lbTieude.Size = new System.Drawing.Size(1014, 79);
            this.lbTieude.TabIndex = 115;
            this.lbTieude.Text = "CHI TIẾT PHÒNG";
            this.lbTieude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbChitietphong
            // 
            this.grbChitietphong.Controls.Add(this.txtMaCTP);
            this.grbChitietphong.Controls.Add(this.lbMaCT);
            this.grbChitietphong.Controls.Add(this.lbPhong);
            this.grbChitietphong.Controls.Add(this.cbbTenphong);
            this.grbChitietphong.Location = new System.Drawing.Point(14, 113);
            this.grbChitietphong.Margin = new System.Windows.Forms.Padding(6);
            this.grbChitietphong.Name = "grbChitietphong";
            this.grbChitietphong.Padding = new System.Windows.Forms.Padding(6);
            this.grbChitietphong.Size = new System.Drawing.Size(413, 205);
            this.grbChitietphong.TabIndex = 116;
            this.grbChitietphong.TabStop = false;
            this.grbChitietphong.Text = "Thông tin chi tiết phòng";
            // 
            // txtMaCTP
            // 
            this.txtMaCTP.Location = new System.Drawing.Point(147, 51);
            this.txtMaCTP.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.txtMaCTP.Name = "txtMaCTP";
            this.txtMaCTP.Size = new System.Drawing.Size(259, 26);
            this.txtMaCTP.TabIndex = 33;
            // 
            // lbMaCT
            // 
            this.lbMaCT.AutoSize = true;
            this.lbMaCT.Location = new System.Drawing.Point(20, 54);
            this.lbMaCT.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbMaCT.Name = "lbMaCT";
            this.lbMaCT.Size = new System.Drawing.Size(126, 19);
            this.lbMaCT.TabIndex = 32;
            this.lbMaCT.Text = "Mã chi tiết phòng";
            // 
            // lbPhong
            // 
            this.lbPhong.AutoSize = true;
            this.lbPhong.Location = new System.Drawing.Point(20, 98);
            this.lbPhong.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbPhong.Name = "lbPhong";
            this.lbPhong.Size = new System.Drawing.Size(79, 19);
            this.lbPhong.TabIndex = 26;
            this.lbPhong.Text = "Tên phòng";
            // 
            // cbbTenphong
            // 
            this.cbbTenphong.FormattingEnabled = true;
            this.cbbTenphong.Location = new System.Drawing.Point(147, 93);
            this.cbbTenphong.Name = "cbbTenphong";
            this.cbbTenphong.Size = new System.Drawing.Size(259, 27);
            this.cbbTenphong.TabIndex = 25;
            this.cbbTenphong.SelectedIndexChanged += new System.EventHandler(this.cbbTenphong_SelectedIndexChanged);
            // 
            // ChiTietPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1014, 423);
            this.Controls.Add(this.grbChitietphong);
            this.Controls.Add(this.lbTieude);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnThoat);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChiTietPhong";
            this.Text = "Chi Tiết Phòng";
            this.Load += new System.EventHandler(this.ChiTietPhong_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvCTPhong)).EndInit();
            this.grbChitietphong.ResumeLayout(false);
            this.grbChitietphong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgrvCTPhong;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lbTieude;
        private System.Windows.Forms.GroupBox grbChitietphong;
        private System.Windows.Forms.TextBox txtMaCTP;
        private System.Windows.Forms.Label lbMaCT;
        private System.Windows.Forms.Label lbPhong;
        private System.Windows.Forms.ComboBox cbbTenphong;
    }
}