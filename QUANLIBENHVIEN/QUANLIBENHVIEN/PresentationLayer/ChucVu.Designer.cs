namespace QUANLIBENHVIEN.PresentationLayer
{
    partial class ChucVu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbTieudeCV = new System.Windows.Forms.Label();
            this.btnThoatCV = new System.Windows.Forms.Button();
            this.btnSaveCV = new System.Windows.Forms.Button();
            this.btnDeleteCV = new System.Windows.Forms.Button();
            this.btnEditCV = new System.Windows.Forms.Button();
            this.dgrvChucVu = new System.Windows.Forms.DataGridView();
            this.btnAddCV = new System.Windows.Forms.Button();
            this.grbChucvu = new System.Windows.Forms.GroupBox();
            this.grbUdChucvu = new System.Windows.Forms.GroupBox();
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.lbMaCV = new System.Windows.Forms.Label();
            this.lbTenCV = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvChucVu)).BeginInit();
            this.grbChucvu.SuspendLayout();
            this.grbUdChucvu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTieudeCV
            // 
            this.lbTieudeCV.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTieudeCV.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTieudeCV.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbTieudeCV.Location = new System.Drawing.Point(0, 0);
            this.lbTieudeCV.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTieudeCV.Name = "lbTieudeCV";
            this.lbTieudeCV.Size = new System.Drawing.Size(899, 95);
            this.lbTieudeCV.TabIndex = 1;
            this.lbTieudeCV.Text = "CHỨC VỤ";
            this.lbTieudeCV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThoatCV
            // 
            this.btnThoatCV.Location = new System.Drawing.Point(353, 301);
            this.btnThoatCV.Margin = new System.Windows.Forms.Padding(6);
            this.btnThoatCV.Name = "btnThoatCV";
            this.btnThoatCV.Size = new System.Drawing.Size(86, 37);
            this.btnThoatCV.TabIndex = 24;
            this.btnThoatCV.Text = "Thoát";
            this.btnThoatCV.UseVisualStyleBackColor = true;
            this.btnThoatCV.Click += new System.EventHandler(this.btnThoatCV_Click);
            // 
            // btnSaveCV
            // 
            this.btnSaveCV.Location = new System.Drawing.Point(353, 228);
            this.btnSaveCV.Margin = new System.Windows.Forms.Padding(6);
            this.btnSaveCV.Name = "btnSaveCV";
            this.btnSaveCV.Size = new System.Drawing.Size(86, 37);
            this.btnSaveCV.TabIndex = 23;
            this.btnSaveCV.Text = "Lưu";
            this.btnSaveCV.UseVisualStyleBackColor = true;
            this.btnSaveCV.Click += new System.EventHandler(this.btnSaveCV_Click);
            // 
            // btnDeleteCV
            // 
            this.btnDeleteCV.Location = new System.Drawing.Point(353, 264);
            this.btnDeleteCV.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeleteCV.Name = "btnDeleteCV";
            this.btnDeleteCV.Size = new System.Drawing.Size(86, 38);
            this.btnDeleteCV.TabIndex = 22;
            this.btnDeleteCV.Text = "Xóa";
            this.btnDeleteCV.UseVisualStyleBackColor = true;
            this.btnDeleteCV.Click += new System.EventHandler(this.btnDeleteCV_Click);
            // 
            // btnEditCV
            // 
            this.btnEditCV.Location = new System.Drawing.Point(353, 156);
            this.btnEditCV.Margin = new System.Windows.Forms.Padding(6);
            this.btnEditCV.Name = "btnEditCV";
            this.btnEditCV.Size = new System.Drawing.Size(86, 37);
            this.btnEditCV.TabIndex = 21;
            this.btnEditCV.Text = "Sửa";
            this.btnEditCV.UseVisualStyleBackColor = true;
            this.btnEditCV.Click += new System.EventHandler(this.btnEditCV_Click);
            // 
            // dgrvChucVu
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgrvChucVu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgrvChucVu.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgrvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvChucVu.Location = new System.Drawing.Point(12, 30);
            this.dgrvChucVu.Margin = new System.Windows.Forms.Padding(6);
            this.dgrvChucVu.Name = "dgrvChucVu";
            this.dgrvChucVu.Size = new System.Drawing.Size(377, 205);
            this.dgrvChucVu.TabIndex = 7;
            this.dgrvChucVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrvChucVu_CellContentClick);
            // 
            // btnAddCV
            // 
            this.btnAddCV.Location = new System.Drawing.Point(353, 123);
            this.btnAddCV.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddCV.Name = "btnAddCV";
            this.btnAddCV.Size = new System.Drawing.Size(86, 34);
            this.btnAddCV.TabIndex = 20;
            this.btnAddCV.Text = "Thêm";
            this.btnAddCV.UseVisualStyleBackColor = true;
            this.btnAddCV.Click += new System.EventHandler(this.btnAddCV_Click);
            // 
            // grbChucvu
            // 
            this.grbChucvu.Controls.Add(this.dgrvChucVu);
            this.grbChucvu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbChucvu.Location = new System.Drawing.Point(471, 101);
            this.grbChucvu.Margin = new System.Windows.Forms.Padding(6);
            this.grbChucvu.Name = "grbChucvu";
            this.grbChucvu.Padding = new System.Windows.Forms.Padding(6);
            this.grbChucvu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbChucvu.Size = new System.Drawing.Size(401, 247);
            this.grbChucvu.TabIndex = 19;
            this.grbChucvu.TabStop = false;
            this.grbChucvu.Text = "Thông tin chức vụ";
            // 
            // grbUdChucvu
            // 
            this.grbUdChucvu.Controls.Add(this.txtMaCV);
            this.grbUdChucvu.Controls.Add(this.txtTenCV);
            this.grbUdChucvu.Controls.Add(this.lbMaCV);
            this.grbUdChucvu.Controls.Add(this.lbTenCV);
            this.grbUdChucvu.Location = new System.Drawing.Point(30, 98);
            this.grbUdChucvu.Name = "grbUdChucvu";
            this.grbUdChucvu.Size = new System.Drawing.Size(294, 250);
            this.grbUdChucvu.TabIndex = 25;
            this.grbUdChucvu.TabStop = false;
            this.grbUdChucvu.Text = "Cập nhật chức vụ";
            // 
            // txtMaCV
            // 
            this.txtMaCV.Location = new System.Drawing.Point(13, 65);
            this.txtMaCV.Margin = new System.Windows.Forms.Padding(6);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(245, 26);
            this.txtMaCV.TabIndex = 20;
            // 
            // txtTenCV
            // 
            this.txtTenCV.Location = new System.Drawing.Point(13, 132);
            this.txtTenCV.Margin = new System.Windows.Forms.Padding(6);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(245, 26);
            this.txtTenCV.TabIndex = 20;
            // 
            // lbMaCV
            // 
            this.lbMaCV.AutoSize = true;
            this.lbMaCV.Location = new System.Drawing.Point(9, 40);
            this.lbMaCV.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbMaCV.Name = "lbMaCV";
            this.lbMaCV.Size = new System.Drawing.Size(89, 19);
            this.lbMaCV.TabIndex = 19;
            this.lbMaCV.Text = "Mã chức vụ";
            // 
            // lbTenCV
            // 
            this.lbTenCV.AutoSize = true;
            this.lbTenCV.Location = new System.Drawing.Point(9, 107);
            this.lbTenCV.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTenCV.Name = "lbTenCV";
            this.lbTenCV.Size = new System.Drawing.Size(91, 19);
            this.lbTenCV.TabIndex = 19;
            this.lbTenCV.Text = "Tên chức vụ";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(353, 192);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 37);
            this.btnCancel.TabIndex = 105;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(899, 413);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grbUdChucvu);
            this.Controls.Add(this.btnThoatCV);
            this.Controls.Add(this.btnSaveCV);
            this.Controls.Add(this.btnDeleteCV);
            this.Controls.Add(this.btnEditCV);
            this.Controls.Add(this.btnAddCV);
            this.Controls.Add(this.grbChucvu);
            this.Controls.Add(this.lbTieudeCV);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChucVu";
            this.Text = "Chức vụ";
            this.Load += new System.EventHandler(this.ChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvChucVu)).EndInit();
            this.grbChucvu.ResumeLayout(false);
            this.grbUdChucvu.ResumeLayout(false);
            this.grbUdChucvu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTieudeCV;
        private System.Windows.Forms.Button btnThoatCV;
        private System.Windows.Forms.Button btnSaveCV;
        private System.Windows.Forms.Button btnDeleteCV;
        private System.Windows.Forms.Button btnEditCV;
        private System.Windows.Forms.DataGridView dgrvChucVu;
        private System.Windows.Forms.Button btnAddCV;
        private System.Windows.Forms.GroupBox grbChucvu;
        private System.Windows.Forms.GroupBox grbUdChucvu;
        private System.Windows.Forms.TextBox txtTenCV;
        private System.Windows.Forms.Label lbTenCV;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.Label lbMaCV;
    }
}