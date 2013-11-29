namespace QUANLIBENHVIEN.PresentationLayer
{
    partial class TrinhDo
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbTieude = new System.Windows.Forms.Label();
            this.grbUdTD = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtTenTochuc = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbMaTD = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lbLoaiTD = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtMaTD = new System.Windows.Forms.TextBox();
            this.txtLoaiTD = new System.Windows.Forms.TextBox();
            this.lbTenTochuc = new System.Windows.Forms.Label();
            this.grbChuyenmon = new System.Windows.Forms.GroupBox();
            this.dgrvTrinhdo = new System.Windows.Forms.DataGridView();
            this.grbUdTD.SuspendLayout();
            this.grbChuyenmon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvTrinhdo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(720, 144);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 37);
            this.btnThoat.TabIndex = 41;
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
            this.lbTieude.Size = new System.Drawing.Size(860, 68);
            this.lbTieude.TabIndex = 34;
            this.lbTieude.Text = "TRÌNH ĐỘ";
            this.lbTieude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbUdTD
            // 
            this.grbUdTD.Controls.Add(this.btnCancel);
            this.grbUdTD.Controls.Add(this.btnDelete);
            this.grbUdTD.Controls.Add(this.txtTenTochuc);
            this.grbUdTD.Controls.Add(this.btnSave);
            this.grbUdTD.Controls.Add(this.lbMaTD);
            this.grbUdTD.Controls.Add(this.btnEdit);
            this.grbUdTD.Controls.Add(this.lbLoaiTD);
            this.grbUdTD.Controls.Add(this.btnAdd);
            this.grbUdTD.Controls.Add(this.btnThoat);
            this.grbUdTD.Controls.Add(this.txtMaTD);
            this.grbUdTD.Controls.Add(this.txtLoaiTD);
            this.grbUdTD.Controls.Add(this.lbTenTochuc);
            this.grbUdTD.Location = new System.Drawing.Point(15, 74);
            this.grbUdTD.Margin = new System.Windows.Forms.Padding(6);
            this.grbUdTD.Name = "grbUdTD";
            this.grbUdTD.Padding = new System.Windows.Forms.Padding(6);
            this.grbUdTD.Size = new System.Drawing.Size(830, 188);
            this.grbUdTD.TabIndex = 36;
            this.grbUdTD.TabStop = false;
            this.grbUdTD.Text = "Thông tin trình độ";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(447, 144);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 37);
            this.btnCancel.TabIndex = 117;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(629, 144);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 37);
            this.btnDelete.TabIndex = 115;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtTenTochuc
            // 
            this.txtTenTochuc.Location = new System.Drawing.Point(148, 74);
            this.txtTenTochuc.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.txtTenTochuc.Name = "txtTenTochuc";
            this.txtTenTochuc.Size = new System.Drawing.Size(659, 26);
            this.txtTenTochuc.TabIndex = 24;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(538, 144);
            this.btnSave.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 37);
            this.btnSave.TabIndex = 116;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbMaTD
            // 
            this.lbMaTD.AutoSize = true;
            this.lbMaTD.Location = new System.Drawing.Point(20, 29);
            this.lbMaTD.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbMaTD.Name = "lbMaTD";
            this.lbMaTD.Size = new System.Drawing.Size(88, 19);
            this.lbMaTD.TabIndex = 22;
            this.lbMaTD.Text = "Mã trình độ";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(356, 144);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 37);
            this.btnEdit.TabIndex = 114;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lbLoaiTD
            // 
            this.lbLoaiTD.AutoSize = true;
            this.lbLoaiTD.Location = new System.Drawing.Point(432, 39);
            this.lbLoaiTD.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbLoaiTD.Name = "lbLoaiTD";
            this.lbLoaiTD.Size = new System.Drawing.Size(94, 19);
            this.lbLoaiTD.TabIndex = 22;
            this.lbLoaiTD.Text = "Loại trình độ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(265, 144);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 37);
            this.btnAdd.TabIndex = 113;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtMaTD
            // 
            this.txtMaTD.Location = new System.Drawing.Point(148, 29);
            this.txtMaTD.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.txtMaTD.Name = "txtMaTD";
            this.txtMaTD.Size = new System.Drawing.Size(250, 26);
            this.txtMaTD.TabIndex = 20;
            // 
            // txtLoaiTD
            // 
            this.txtLoaiTD.Location = new System.Drawing.Point(554, 32);
            this.txtLoaiTD.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.txtLoaiTD.Name = "txtLoaiTD";
            this.txtLoaiTD.Size = new System.Drawing.Size(253, 26);
            this.txtLoaiTD.TabIndex = 20;
            // 
            // lbTenTochuc
            // 
            this.lbTenTochuc.AutoSize = true;
            this.lbTenTochuc.Location = new System.Drawing.Point(20, 81);
            this.lbTenTochuc.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbTenTochuc.Name = "lbTenTochuc";
            this.lbTenTochuc.Size = new System.Drawing.Size(126, 19);
            this.lbTenTochuc.TabIndex = 19;
            this.lbTenTochuc.Text = "Tổ chức cấp bằng";
            // 
            // grbChuyenmon
            // 
            this.grbChuyenmon.Controls.Add(this.dgrvTrinhdo);
            this.grbChuyenmon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbChuyenmon.Location = new System.Drawing.Point(15, 281);
            this.grbChuyenmon.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.grbChuyenmon.Name = "grbChuyenmon";
            this.grbChuyenmon.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.grbChuyenmon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbChuyenmon.Size = new System.Drawing.Size(830, 253);
            this.grbChuyenmon.TabIndex = 107;
            this.grbChuyenmon.TabStop = false;
            this.grbChuyenmon.Text = "Danh sách trình độ";
            // 
            // dgrvTrinhdo
            // 
            this.dgrvTrinhdo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvTrinhdo.Location = new System.Drawing.Point(12, 36);
            this.dgrvTrinhdo.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.dgrvTrinhdo.Name = "dgrvTrinhdo";
            this.dgrvTrinhdo.Size = new System.Drawing.Size(808, 205);
            this.dgrvTrinhdo.TabIndex = 7;
            // 
            // TrinhDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(860, 544);
            this.Controls.Add(this.grbChuyenmon);
            this.Controls.Add(this.lbTieude);
            this.Controls.Add(this.grbUdTD);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TrinhDo";
            this.Text = "Trình độ";
            this.Load += new System.EventHandler(this.TrinhDo_Load);
            this.grbUdTD.ResumeLayout(false);
            this.grbUdTD.PerformLayout();
            this.grbChuyenmon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvTrinhdo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lbTieude;
        private System.Windows.Forms.GroupBox grbUdTD;
        private System.Windows.Forms.TextBox txtLoaiTD;
        private System.Windows.Forms.Label lbTenTochuc;
        private System.Windows.Forms.TextBox txtTenTochuc;
        private System.Windows.Forms.Label lbLoaiTD;
        private System.Windows.Forms.Label lbMaTD;
        private System.Windows.Forms.TextBox txtMaTD;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grbChuyenmon;
        private System.Windows.Forms.DataGridView dgrvTrinhdo;
    }
}