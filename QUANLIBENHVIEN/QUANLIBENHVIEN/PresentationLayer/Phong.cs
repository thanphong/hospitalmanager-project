using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QUANLIBENHVIEN.PresentationLayer
{
    public partial class Phong : Form
    {
        BusinessLayer.PhongBsn phong = new BusinessLayer.PhongBsn();
        DataTable dt;
        DataSet ds = new DataSet();
        int curRecord = 0;
        int totalRecord = 0;

        public Phong()
        {
            InitializeComponent();
        }

        private void fillControls(DataTable dataTable, int curRec)
        {
            if (dataTable.Rows.Count != 0)
            {
                txtMaP.Text = dataTable.Rows[curRec][0].ToString();
                txtTenP.Text = dataTable.Rows[curRec][1].ToString();
                txtTonggiuong.Text = dataTable.Rows[curRec][2].ToString();
                txtVitri.Text = dataTable.Rows[curRec][2].ToString();
            }
        }

        private void Phong_Load(object sender, EventArgs e)
        {
            txtMaP.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
      //      phong = new BusinessLayer.PhongBsn();
            dt = phong.Select();
            curRecord = 0;
            totalRecord = dt.Rows.Count - 1;
            fillControls(dt, 0);
            dgrvPhong.DataSource = dt.DefaultView;
            this.Cursor = Cursors.Default;
        }

        private void dgrvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaP.DataBindings.Clear();
            txtMaP.DataBindings.Add("Text", dgrvPhong.DataSource, "MaPhong");
            txtTenP.DataBindings.Clear();
            txtTenP.DataBindings.Add("Text", dgrvPhong.DataSource, "TenPhong");
            txtTonggiuong.DataBindings.Clear();
            txtTonggiuong.DataBindings.Add("Text", dgrvPhong.DataSource, "TongSoGiuong");
            txtVitri.DataBindings.Clear();
            txtVitri.DataBindings.Add("Text", dgrvPhong.DataSource, "ViTri");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn sửa dòng này? ",
                "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                phong = new BusinessLayer.PhongBsn(txtTenP.Text, int.Parse(txtTonggiuong.Text),txtVitri.Text);
                phong.Update();
                dt = phong.Select();
                dgrvPhong.DataSource = dt.DefaultView;
            }
            if (dr == DialogResult.No)
            {
                dt = phong.Select();
                dgrvPhong.DataSource = dt.DefaultView;
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            processControls(this);
            //thêm 1 dòng mới cho datagrid
            DataRow row = dt.NewRow();
            dt.Rows.Add(row);
            totalRecord = dt.Rows.Count - 1;
            curRecord = totalRecord - 1;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTenP.Text == "" || txtVitri.Text == "" || txtTonggiuong.Text == "")
            {
                MessageBox.Show("Mời bạn nhập đủ thông tin!", "Thông báo");
            }
            else
            {
                phong = new BusinessLayer.PhongBsn(txtTenP.Text, int.Parse(txtTonggiuong.Text), txtVitri.Text);
                phong.Insert();
                dt = phong.Select();
                dgrvPhong.DataSource = dt.DefaultView;
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
            }
        }
        //xóa dòng trống khi thêm mà hủy
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
            btnEdit.Enabled = true;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            removeEmptyrow(dgrvPhong);
            int curRow = dgrvPhong.RowCount - 2;
            fillControls(dt, curRow);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa dòng này? ",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                phong = new BusinessLayer.PhongBsn();
                phong.Delete(int.Parse(txtMaP.Text));
                totalRecord--;
                fillControls(dt, 0);
                dt = phong.Select();
                dgrvPhong.DataSource = dt.DefaultView;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
