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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbTieude = new System.Windows.Forms.Label();
            this.dgrvTrinhdo = new System.Windows.Forms.DataGridView();
            this.grbUdTD = new System.Windows.Forms.GroupBox();
            this.txtLoaiTD = new System.Windows.Forms.TextBox();
            this.lbTenTochuc = new System.Windows.Forms.Label();
            this.grbChuyenmon = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbTenCM = new System.Windows.Forms.Label();
            this.lbLoaiTD = new System.Windows.Forms.Label();
            this.txtTenTochuc = new System.Windows.Forms.TextBox();
            this.cbbTenCM = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvTrinhdo)).BeginInit();
            this.grbUdTD.SuspendLayout();
            this.grbChuyenmon.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(446, 304);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 40);
            this.btnThoat.TabIndex = 41;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(446, 175);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 35);
            this.btnEdit.TabIndex = 38;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(446, 258);
            this.btnSave.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 39);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(446, 215);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 36);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lbTieude
            // 
            this.lbTieude.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTieude.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTieude.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbTieude.Location = new System.Drawing.Point(0, 0);
            this.lbTieude.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbTieude.Name = "lbTieude";
            this.lbTieude.Size = new System.Drawing.Size(1150, 110);
            this.lbTieude.TabIndex = 34;
            this.lbTieude.Text = "TRÌNH ĐỘ";
            this.lbTieude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgrvTrinhdo
            // 
            this.dgrvTrinhdo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvTrinhdo.Location = new System.Drawing.Point(14, 28);
            this.dgrvTrinhdo.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.dgrvTrinhdo.Name = "dgrvTrinhdo";
            this.dgrvTrinhdo.Size = new System.Drawing.Size(558, 192);
            this.dgrvTrinhdo.TabIndex = 7;
            // 
            // grbUdTD
            // 
            this.grbUdTD.Controls.Add(this.cbbTenCM);
            this.grbUdTD.Controls.Add(this.txtTenTochuc);
            this.grbUdTD.Controls.Add(this.lbLoaiTD);
            this.grbUdTD.Controls.Add(this.lbTenCM);
            this.grbUdTD.Controls.Add(this.txtLoaiTD);
            this.grbUdTD.Controls.Add(this.lbTenTochuc);
            this.grbUdTD.Location = new System.Drawing.Point(27, 116);
            this.grbUdTD.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grbUdTD.Name = "grbUdTD";
            this.grbUdTD.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grbUdTD.Size = new System.Drawing.Size(399, 210);
            this.grbUdTD.TabIndex = 36;
            this.grbUdTD.TabStop = false;
            this.grbUdTD.Text = "Cập nhật trình độ";
            // 
            // txtLoaiTD
            // 
            this.txtLoaiTD.Location = new System.Drawing.Point(24, 99);
            this.txtLoaiTD.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.txtLoaiTD.Name = "txtLoaiTD";
            this.txtLoaiTD.Size = new System.Drawing.Size(359, 26);
            this.txtLoaiTD.TabIndex = 20;
            // 
            // lbTenTochuc
            // 
            this.lbTenTochuc.AutoSize = true;
            this.lbTenTochuc.Location = new System.Drawing.Point(20, 138);
            this.lbTenTochuc.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbTenTochuc.Name = "lbTenTochuc";
            this.lbTenTochuc.Size = new System.Drawing.Size(151, 19);
            this.lbTenTochuc.TabIndex = 19;
            this.lbTenTochuc.Text = "Tên tổ chức cấp bằng";
            // 
            // grbChuyenmon
            // 
            this.grbChuyenmon.Controls.Add(this.dgrvTrinhdo);
            this.grbChuyenmon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbChuyenmon.Location = new System.Drawing.Point(555, 116);
            this.grbChuyenmon.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.grbChuyenmon.Name = "grbChuyenmon";
            this.grbChuyenmon.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.grbChuyenmon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbChuyenmon.Size = new System.Drawing.Size(582, 232);
            this.grbChuyenmon.TabIndex = 35;
            this.grbChuyenmon.TabStop = false;
            this.grbChuyenmon.Text = "Thông tin trình độ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(446, 137);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 34);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lbTenCM
            // 
            this.lbTenCM.AutoSize = true;
            this.lbTenCM.Location = new System.Drawing.Point(20, 45);
            this.lbTenCM.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbTenCM.Name = "lbTenCM";
            this.lbTenCM.Size = new System.Drawing.Size(118, 19);
            this.lbTenCM.TabIndex = 21;
            this.lbTenCM.Text = "Tên chuyên môn";
            // 
            // lbLoaiTD
            // 
            this.lbLoaiTD.AutoSize = true;
            this.lbLoaiTD.Location = new System.Drawing.Point(20, 75);
            this.lbLoaiTD.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbLoaiTD.Name = "lbLoaiTD";
            this.lbLoaiTD.Size = new System.Drawing.Size(94, 19);
            this.lbLoaiTD.TabIndex = 22;
            this.lbLoaiTD.Text = "Loại trình độ";
            // 
            // txtTenTochuc
            // 
            this.txtTenTochuc.Location = new System.Drawing.Point(24, 165);
            this.txtTenTochuc.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.txtTenTochuc.Name = "txtTenTochuc";
            this.txtTenTochuc.Size = new System.Drawing.Size(359, 26);
            this.txtTenTochuc.TabIndex = 24;
            // 
            // cbbTenCM
            // 
            this.cbbTenCM.FormattingEnabled = true;
            this.cbbTenCM.Location = new System.Drawing.Point(148, 42);
            this.cbbTenCM.Name = "cbbTenCM";
            this.cbbTenCM.Size = new System.Drawing.Size(242, 27);
            this.cbbTenCM.TabIndex = 25;
            // 
            // TrinhDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1150, 404);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbTieude);
            this.Controls.Add(this.grbUdTD);
            this.Controls.Add(this.grbChuyenmon);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TrinhDo";
            this.Text = "Trình độ";
            ((System.ComponentModel.ISupportInitialize)(this.dgrvTrinhdo)).EndInit();
            this.grbUdTD.ResumeLayout(false);
            this.grbUdTD.PerformLayout();
            this.grbChuyenmon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbTieude;
        private System.Windows.Forms.DataGridView dgrvTrinhdo;
        private System.Windows.Forms.GroupBox grbUdTD;
        private System.Windows.Forms.TextBox txtLoaiTD;
        private System.Windows.Forms.Label lbTenTochuc;
        private System.Windows.Forms.GroupBox grbChuyenmon;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbbTenCM;
        private System.Windows.Forms.TextBox txtTenTochuc;
        private System.Windows.Forms.Label lbLoaiTD;
        private System.Windows.Forms.Label lbTenCM;
    }
}