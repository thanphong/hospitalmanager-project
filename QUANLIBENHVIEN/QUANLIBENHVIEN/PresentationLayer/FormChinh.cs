using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace QUANLIBENHVIEN.PresentationLayer
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        private void câpNhâtChưcVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChucVu cv = new ChucVu();
            cv.Show();
        }

        private void câpNhâtChuyênMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChuyenMon cm = new ChuyenMon();
            cm.Show();
        }

        private void câpNhâtTrinhĐôToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrinhDo td = new TrinhDo();
            td.Show();
        }

        private void câpNhâtHơpĐôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HopDong hd = new HopDong();
            hd.Show();
        }

        private void câpNhâtNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.Show();
        }

        private void câpNhâtPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phong p = new Phong();
            p.Show();
        }

       
    }
}
