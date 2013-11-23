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
    public partial class ChucVu : Form
    {
        BusinessLayer.ChucVuBsn chucvu;
        DataTable dt;
        int curRecord = 0;
        int totalRecord = 0;
        public ChucVu()
        {
            InitializeComponent();
        }

        private void ChucVu_Load(object sender, EventArgs e)
        {
            txtMaCV.Enabled = false;
            chucvu = new BusinessLayer.ChucVuBsn();
            dt = chucvu.Select();
            curRecord = 0;
            totalRecord = dt.Rows.Count - 1;
            fillControls(dt, 0);
            dgrvChucVu.DataSource = dt.DefaultView;
            this.Cursor = Cursors.Default;
        }
        private void fillControls(DataTable dataTable, int curRec)
        {
            txtMaCV.Text = dataTable.Rows[0][0].ToString();
            txtTenCV.Text = dataTable.Rows[0][1].ToString();

        }
        private void dgrvChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ChucVu cv = new ChucVu();
            txtMaCV.DataBindings.Clear();
            txtMaCV.DataBindings.Add("Text", dgrvChucVu.DataSource, "MaCV");
            txtTenCV.DataBindings.Clear();
            txtTenCV.DataBindings.Add("Text", dgrvChucVu.DataSource, "TenCV");
        }

        private void btnEditCV_Click(object sender, EventArgs e)
        {
            chucvu = new BusinessLayer.ChucVuBsn(int.Parse(txtMaCV.Text),txtTenCV.Text);
            chucvu.Update();
            dt = chucvu.Select();
            dgrvChucVu.DataSource = dt.DefaultView;
        }
        private void processControls(Control ctrl)
        {
            if (ctrl.GetType() == typeof(TextBox))
            {
                ctrl.Text = "";
            }
            //xu ly cac dieu khien theo phuong phap de quy
            foreach (Control ctrlChild in ctrl.Controls)
            {
                processControls(ctrlChild);
            }
        }
        private void btnAddCV_Click(object sender, EventArgs e)
        {
           
            processControls(this);
            DataRow row = dt.NewRow();
            dt.Rows.Add(row);
            totalRecord = dt.Rows.Count - 1;
            curRecord = totalRecord - 1;
        }

        private void btnSaveCV_Click(object sender, EventArgs e)
        {
            if (txtTenCV.Text == "")
            {
                MessageBox.Show("Mời bạn nhập tên chức vụ!", "Thông báo");
            }
            else
            {
                chucvu = new BusinessLayer.ChucVuBsn(txtTenCV.Text);
                chucvu.Insert();
                dt = chucvu.Select();
                dgrvChucVu.DataSource = dt.DefaultView;
            }
        }

        private void btnDeleteCV_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Ban co muon xoa dong nay khong? ",
                "Xac nhan viec xoa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) //if 
            {
                chucvu = new BusinessLayer.ChucVuBsn();
                chucvu.Delete(int.Parse(txtMaCV.Text));
                totalRecord--;
                fillControls(dt, 0);
                dt = chucvu.Select();
                dgrvChucVu.DataSource = dt.DefaultView;
            }
        }
  
    }
}
