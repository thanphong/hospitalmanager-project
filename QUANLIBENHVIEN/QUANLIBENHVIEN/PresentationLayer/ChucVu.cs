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
            btnSaveCV.Enabled = false;
            btnCancel.Enabled = false;
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
            txtMaCV.Text = dataTable.Rows[curRec][0].ToString();
            txtTenCV.Text = dataTable.Rows[curRec][1].ToString();
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
            DialogResult dr = MessageBox.Show("Bạn có muốn sửa dòng này? ",
                "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                chucvu = new BusinessLayer.ChucVuBsn(int.Parse(txtMaCV.Text), txtTenCV.Text);
                chucvu.Update();
                dt = chucvu.Select();
                dgrvChucVu.DataSource = dt.DefaultView;
            }
            if (dr == DialogResult.No)
            {
                dt = chucvu.Select();
                dgrvChucVu.DataSource = dt.DefaultView;
            }
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
            //thêm 1 dòng mới cho datagrid
            DataRow row = dt.NewRow();
            dt.Rows.Add(row);
            totalRecord = dt.Rows.Count - 1;
            curRecord = totalRecord - 1;
            btnAddCV.Enabled = false;
            btnEditCV.Enabled = false;
            btnDeleteCV.Enabled = false;
            btnSaveCV.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnSaveCV_Click(object sender, EventArgs e)
        {
            if (txtTenCV.Text == "" || txtTenCV.Text == " ")
            {
                MessageBox.Show("Mời bạn nhập tên chức vụ!", "Thông báo");
            }
            else
            {
                chucvu = new BusinessLayer.ChucVuBsn(txtTenCV.Text);
                chucvu.Insert();
                dt = chucvu.Select();
                dgrvChucVu.DataSource = dt.DefaultView;
                btnAddCV.Enabled = true;
                btnEditCV.Enabled = true;
                btnDeleteCV.Enabled = true;
                btnSaveCV.Enabled = false;
                btnCancel.Enabled = false;
            }
        }

        public void removeEmptyrow(DataGridView dgv)
        {
            for (int i = 1; i < dgv.RowCount - 1; i++)
            {
                if (dgv.Rows[i].Cells[0].Value.ToString() == "")
                {
                    dgv.Rows.RemoveAt(i);
                    i--;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnEditCV.Enabled = true;
            btnAddCV.Enabled = true;
            btnDeleteCV.Enabled = true;
            btnSaveCV.Enabled = false;
            removeEmptyrow(dgrvChucVu);
            int curRow=dgrvChucVu.RowCount - 2;
            fillControls(dt, curRow);
        }

        private void btnDeleteCV_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa dòng này? ",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) 
            {
                chucvu = new BusinessLayer.ChucVuBsn();
                chucvu.Delete(int.Parse(txtMaCV.Text));
                totalRecord--;
                fillControls(dt, 0);
                dt = chucvu.Select();
                dgrvChucVu.DataSource = dt.DefaultView;
            }
        }
        private void btnThoatCV_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
  
    }
}
