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
            this.txtMaLT = new System.Windows.Forms.TextBox();
            this.txtTenLT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbtenloaithuoc = new System.Windows.Forms.Label();
            this.grbTTLoaithuoc = new System.Windows.Forms.GroupBox();
            this.dgvLoaithuoc = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbCapnhatLoaithuoc.SuspendLayout();
            this.grbTTLoaithuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaithuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLoaithuoc
            // 
            this.lbLoaithuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbLoaithuoc.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaithuoc.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbLoaithuoc.Location = new System.Drawing.Point(0, 0);
            this.lbLoaithuoc.Name = "lbLoaithuoc";
            this.lbLoaithuoc.Size = new System.Drawing.Size(888, 91);
            this.lbLoaithuoc.TabIndex = 0;
            this.lbLoaithuoc.Text = "LOẠI THUỐC";
            this.lbLoaithuoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbCapnhatLoaithuoc
            // 
            this.grbCapnhatLoaithuoc.Controls.Add(this.txtMaLT);
            this.grbCapnhatLoaithuoc.Controls.Add(this.txtTenLT);
            this.grbCapnhatLoaithuoc.Controls.Add(this.label1);
            this.grbCapnhatLoaithuoc.Controls.Add(this.lbtenloaithuoc);
            this.grbCapnhatLoaithuoc.Location = new System.Drawing.Point(43, 107);
            this.grbCapnhatLoaithuoc.Name = "grbCapnhatLoaithuoc";
            this.grbCapnhatLoaithuoc.Size = new System.Drawing.Size(382, 193);
            this.grbCapnhatLoaithuoc.TabIndex = 1;
            this.grbCapnhatLoaithuoc.TabStop = false;
            this.grbCapnhatLoaithuoc.Text = "Thông tin loại thuốc";
            // 
            // txtMaLT
            // 
            this.txtMaLT.Enabled = false;
            this.txtMaLT.Location = new System.Drawing.Point(128, 69);
            this.txtMaLT.Name = "txtMaLT";
            this.txtMaLT.Size = new System.Drawing.Size(218, 26);
            this.txtMaLT.TabIndex = 1;
            // 
            // txtTenLT
            // 
            this.txtTenLT.Location = new System.Drawing.Point(128, 112);
            this.txtTenLT.Name = "txtTenLT";
            this.txtTenLT.Size = new System.Drawing.Size(218, 26);
            this.txtTenLT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại thuốc";
            // 
            // lbtenloaithuoc
            // 
            this.lbtenloaithuoc.AutoSize = true;
            this.lbtenloaithuoc.Location = new System.Drawing.Point(24, 115);
            this.lbtenloaithuoc.Name = "lbtenloaithuoc";
            this.lbtenloaithuoc.Size = new System.Drawing.Size(103, 19);
            this.lbtenloaithuoc.TabIndex = 0;
            this.lbtenloaithuoc.Text = "Tên loại thuốc";
            // 
            // grbTTLoaithuoc
            // 
            this.grbTTLoaithuoc.Controls.Add(this.dgvLoaithuoc);
            this.grbTTLoaithuoc.Location = new System.Drawing.Point(439, 107);
            this.grbTTLoaithuoc.Name = "grbTTLoaithuoc";
            this.grbTTLoaithuoc.Size = new System.Drawing.Size(408, 193);
            this.grbTTLoaithuoc.TabIndex = 7;
            this.grbTTLoaithuoc.TabStop = false;
            this.grbTTLoaithuoc.Text = "Danh sách loại thuốc";
            // 
            // dgvLoaithuoc
            // 
            this.dgvLoaithuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaithuoc.Location = new System.Drawing.Point(6, 25);
            this.dgvLoaithuoc.Name = "dgvLoaithuoc";
            this.dgvLoaithuoc.Size = new System.Drawing.Size(396, 162);
            this.dgvLoaithuoc.TabIndex = 0;
            this.dgvLoaithuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaithuoc_CellContentClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(441, 326);
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
            this.btnAdd.Location = new System.Drawing.Point(207, 326);
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
            this.btnSave.Location = new System.Drawing.Point(363, 326);
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
            this.btnEdit.Location = new System.Drawing.Point(285, 326);
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
            this.btnDelete.Location = new System.Drawing.Point(519, 326);
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
            this.btnThoat.Location = new System.Drawing.Point(597, 326);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(79, 37);
            this.btnThoat.TabIndex = 121;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // LoaiThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(888, 406);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grbTTLoaithuoc);
            this.Controls.Add(this.grbCapnhatLoaithuoc);
            this.Controls.Add(this.lbLoaithuoc);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoaiThuoc";
            this.Text = "Loại Thuốc";
            this.Load += new System.EventHandler(this.LoaiThuoc_Load);
            this.grbCapnhatLoaithuoc.ResumeLayout(false);
            this.grbCapnhatLoaithuoc.PerformLayout();
            this.grbTTLoaithuoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaithuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbLoaithuoc;
        private System.Windows.Forms.GroupBox grbCapnhatLoaithuoc;
        private System.Windows.Forms.TextBox txtTenLT;
        private System.Windows.Forms.Label lbtenloaithuoc;
        private System.Windows.Forms.GroupBox grbTTLoaithuoc;
        private System.Windows.Forms.DataGridView dgvLoaithuoc;
        private System.Windows.Forms.TextBox txtMaLT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnThoat;
    }
}