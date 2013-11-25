namespace QUANLIBENHVIEN.PresentationLayer
{
    partial class Timkiemdungcu
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
            this.lbTieudeTimkiemdungcu = new System.Windows.Forms.Label();
            this.grbTTTimkiem = new System.Windows.Forms.GroupBox();
            this.lbTenvattu = new System.Windows.Forms.Label();
            this.cbTenvattu = new System.Windows.Forms.ComboBox();
            this.lbGia = new System.Windows.Forms.Label();
            this.cbGia = new System.Windows.Forms.ComboBox();
            this.lbManhacungcap = new System.Windows.Forms.Label();
            this.cbManhacungcap = new System.Windows.Forms.ComboBox();
            this.btTimkiem = new System.Windows.Forms.Button();
            this.gbtimkiemdungcu = new System.Windows.Forms.GroupBox();
            this.dgvTimkiemdungcuvattu = new System.Windows.Forms.DataGridView();
            this.grbTTTimkiem.SuspendLayout();
            this.gbtimkiemdungcu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimkiemdungcuvattu)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTieudeTimkiemdungcu
            // 
            this.lbTieudeTimkiemdungcu.AutoSize = true;
            this.lbTieudeTimkiemdungcu.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieudeTimkiemdungcu.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbTieudeTimkiemdungcu.Location = new System.Drawing.Point(258, 55);
            this.lbTieudeTimkiemdungcu.Name = "lbTieudeTimkiemdungcu";
            this.lbTieudeTimkiemdungcu.Size = new System.Drawing.Size(283, 31);
            this.lbTieudeTimkiemdungcu.TabIndex = 0;
            this.lbTieudeTimkiemdungcu.Text = "TÌM KIẾM DỤNG CỤ";
            // 
            // grbTTTimkiem
            // 
            this.grbTTTimkiem.Controls.Add(this.cbManhacungcap);
            this.grbTTTimkiem.Controls.Add(this.lbManhacungcap);
            this.grbTTTimkiem.Controls.Add(this.cbGia);
            this.grbTTTimkiem.Controls.Add(this.lbGia);
            this.grbTTTimkiem.Controls.Add(this.cbTenvattu);
            this.grbTTTimkiem.Controls.Add(this.lbTenvattu);
            this.grbTTTimkiem.Location = new System.Drawing.Point(187, 116);
            this.grbTTTimkiem.Name = "grbTTTimkiem";
            this.grbTTTimkiem.Size = new System.Drawing.Size(380, 195);
            this.grbTTTimkiem.TabIndex = 1;
            this.grbTTTimkiem.TabStop = false;
            this.grbTTTimkiem.Text = "Thông tin tìm kiếm";
            // 
            // lbTenvattu
            // 
            this.lbTenvattu.AutoSize = true;
            this.lbTenvattu.Location = new System.Drawing.Point(50, 40);
            this.lbTenvattu.Name = "lbTenvattu";
            this.lbTenvattu.Size = new System.Drawing.Size(79, 19);
            this.lbTenvattu.TabIndex = 0;
            this.lbTenvattu.Text = "Tên vật tư";
            // 
            // cbTenvattu
            // 
            this.cbTenvattu.FormattingEnabled = true;
            this.cbTenvattu.Location = new System.Drawing.Point(202, 37);
            this.cbTenvattu.Name = "cbTenvattu";
            this.cbTenvattu.Size = new System.Drawing.Size(121, 27);
            this.cbTenvattu.TabIndex = 1;
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Location = new System.Drawing.Point(50, 86);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(33, 19);
            this.lbGia.TabIndex = 2;
            this.lbGia.Text = "Giá";
            // 
            // cbGia
            // 
            this.cbGia.FormattingEnabled = true;
            this.cbGia.Location = new System.Drawing.Point(202, 78);
            this.cbGia.Name = "cbGia";
            this.cbGia.Size = new System.Drawing.Size(121, 27);
            this.cbGia.TabIndex = 3;
            // 
            // lbManhacungcap
            // 
            this.lbManhacungcap.AutoSize = true;
            this.lbManhacungcap.Location = new System.Drawing.Point(50, 135);
            this.lbManhacungcap.Name = "lbManhacungcap";
            this.lbManhacungcap.Size = new System.Drawing.Size(123, 19);
            this.lbManhacungcap.TabIndex = 4;
            this.lbManhacungcap.Text = "Mã nhà cung cấp";
            // 
            // cbManhacungcap
            // 
            this.cbManhacungcap.FormattingEnabled = true;
            this.cbManhacungcap.Location = new System.Drawing.Point(202, 124);
            this.cbManhacungcap.Name = "cbManhacungcap";
            this.cbManhacungcap.Size = new System.Drawing.Size(121, 27);
            this.cbManhacungcap.TabIndex = 5;
            // 
            // btTimkiem
            // 
            this.btTimkiem.Location = new System.Drawing.Point(313, 352);
            this.btTimkiem.Name = "btTimkiem";
            this.btTimkiem.Size = new System.Drawing.Size(93, 28);
            this.btTimkiem.TabIndex = 2;
            this.btTimkiem.Text = "Tìm kiếm";
            this.btTimkiem.UseVisualStyleBackColor = true;
            // 
            // gbtimkiemdungcu
            // 
            this.gbtimkiemdungcu.Controls.Add(this.dgvTimkiemdungcuvattu);
            this.gbtimkiemdungcu.Location = new System.Drawing.Point(101, 396);
            this.gbtimkiemdungcu.Name = "gbtimkiemdungcu";
            this.gbtimkiemdungcu.Size = new System.Drawing.Size(551, 181);
            this.gbtimkiemdungcu.TabIndex = 3;
            this.gbtimkiemdungcu.TabStop = false;
            this.gbtimkiemdungcu.Text = "Kết quả tìm kiếm";
            // 
            // dgvTimkiemdungcuvattu
            // 
            this.dgvTimkiemdungcuvattu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimkiemdungcuvattu.Location = new System.Drawing.Point(16, 35);
            this.dgvTimkiemdungcuvattu.Name = "dgvTimkiemdungcuvattu";
            this.dgvTimkiemdungcuvattu.Size = new System.Drawing.Size(520, 132);
            this.dgvTimkiemdungcuvattu.TabIndex = 0;
            // 
            // Timkiemdungcu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(774, 683);
            this.Controls.Add(this.gbtimkiemdungcu);
            this.Controls.Add(this.btTimkiem);
            this.Controls.Add(this.grbTTTimkiem);
            this.Controls.Add(this.lbTieudeTimkiemdungcu);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Timkiemdungcu";
            this.Text = "Timkiemdungcu";
            this.grbTTTimkiem.ResumeLayout(false);
            this.grbTTTimkiem.PerformLayout();
            this.gbtimkiemdungcu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimkiemdungcuvattu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTieudeTimkiemdungcu;
        private System.Windows.Forms.GroupBox grbTTTimkiem;
        private System.Windows.Forms.ComboBox cbManhacungcap;
        private System.Windows.Forms.Label lbManhacungcap;
        private System.Windows.Forms.ComboBox cbGia;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.ComboBox cbTenvattu;
        private System.Windows.Forms.Label lbTenvattu;
        private System.Windows.Forms.Button btTimkiem;
        private System.Windows.Forms.GroupBox gbtimkiemdungcu;
        private System.Windows.Forms.DataGridView dgvTimkiemdungcuvattu;
    }
}