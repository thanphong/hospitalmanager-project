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

        private void đơnThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       
    }
}
