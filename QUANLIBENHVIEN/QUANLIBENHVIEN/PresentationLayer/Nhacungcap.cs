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
    public partial class Nhacungcap : Form
    {
        BusinessLayer.NhaCungCapBsn nhacungcap = new BusinessLayer.NhaCungCapBsn();
        DataTable dt;
        DataSet ds = new DataSet();
        int curRecord = 0;
        int totalRecord = 0;
        String tv = "";
        public Nhacungcap()
        {
            InitializeComponent();
        }

        private void fillControls(DataTable dataTable, int curRec)
        {
            if (dataTable.Rows.Count != 0)
            {
                txtMaNCC.Text = dataTable.Rows[curRec][0].ToString();
                txtTenNCC.Text = dataTable.Rows[curRec][1].ToString();
                txtDiachi.Text = dataTable.Rows[curRec][2].ToString();
                txtSodt.Text = dataTable.Rows[curRec][3].ToString();
                txtSofax.Text = dataTable.Rows[curRec][4].ToString();
            }
        }
        private void Nhacungcap_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            dt = nhacungcap.Select();
            totalRecord = dt.Rows.Count - 1;
            fillControls(dt, 0);
            //txtTenCM.Text = cbbTenCM.SelectedValue.ToString();
            dgrvNhacungcap.DataSource = dt.DefaultView;

            this.Cursor = Cursors.Default;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn sửa dòng này? ",
               "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                nhacungcap = new BusinessLayer.NhaCungCapBsn(txtTenNCC.Text, txtDiachi.Text, txtSodt.Text, txtSofax.Text);
                nhacungcap.Update();
                dt = nhacungcap.Select();
                dgrvNhacungcap.DataSource = dt.DefaultView;
            }
            if (dr == DialogResult.No)
            {
                dt = nhacungcap.Select();
                dgrvNhacungcap.DataSource = dt.DefaultView;
            }
        }

        private void dgrvNhacungcap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNCC.DataBindings.Clear();
            txtMaNCC.DataBindings.Add("Text", dgrvNhacungcap.DataSource, "MaNhaCungCap");
            txtTenNCC.DataBindings.Clear();
            txtTenNCC.DataBindings.Add("Text", dgrvNhacungcap.DataSource, "Ten");
            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("Text", dgrvNhacungcap.DataSource, "DiaChi");
            txtSodt.DataBindings.Clear();
            txtSodt.DataBindings.Add("Text", dgrvNhacungcap.DataSource, "DIenThoai");
            txtSofax.DataBindings.Clear();
            txtSofax.DataBindings.Add("Text", dgrvNhacungcap.DataSource, "SoFax");
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
            if (txtTenNCC.Text == "" || txtDiachi.Text == "" || txtSodt.Text == "" || txtSofax.Text == "")
            {
                MessageBox.Show("Mời bạn nhập tên chức vụ!", "Thông báo");
            }
            else
            {
                nhacungcap = new BusinessLayer.NhaCungCapBsn(txtTenNCC.Text, txtDiachi.Text, txtSodt.Text, txtSofax.Text);
                nhacungcap.Insert();
                dt = nhacungcap.Select();
                dgrvNhacungcap.DataSource = dt.DefaultView;
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa dòng này? ",
               "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                nhacungcap = new BusinessLayer.NhaCungCapBsn();
                nhacungcap.Delete(int.Parse(txtMaNCC.Text));
                totalRecord--;
                fillControls(dt, 0);
                dt = nhacungcap.Select();
                dgrvNhacungcap.DataSource = dt.DefaultView;
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
            removeEmptyrow(dgrvNhacungcap);
            int curRow = dgrvNhacungcap.RowCount - 2;
            fillControls(dt, curRow);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
