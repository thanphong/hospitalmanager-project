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
    public partial class LoaiThuoc : Form
    {
        BusinessLayer.LoaiThuocBsn loaithuoc = new BusinessLayer.LoaiThuocBsn();
        DataTable dt;
        int curRecord = 0;
        int totalRecord = 0;
        public LoaiThuoc()
        {
            InitializeComponent();
        }

        private void dgvLoaithuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLT.DataBindings.Clear();
            txtMaLT.DataBindings.Add("Text", dgvLoaithuoc.DataSource, "MaLoai");
            txtTenLT.DataBindings.Clear();
            txtTenLT.DataBindings.Add("Text", dgvLoaithuoc.DataSource, "Ten");
        }

        private void fillControls(DataTable dataTable, int curRec)
        {
            if (dataTable.Rows.Count != 0)
            {
                txtMaLT.Text = dataTable.Rows[0][0].ToString();
                txtTenLT.Text = dataTable.Rows[0][1].ToString();
            }
        }
        private void LoaiThuoc_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            dt = loaithuoc.Select();
            curRecord = 0;
            totalRecord = dt.Rows.Count - 1;
            fillControls(dt, 0);
            dgvLoaithuoc.DataSource = dt.DefaultView;
            this.Cursor = Cursors.Default;
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
            if (txtTenLT.Text == "")
            {
                MessageBox.Show("Mời bạn nhập dữ liệu!", "Thông báo");
            }
            else
            {
                loaithuoc = new BusinessLayer.LoaiThuocBsn(txtTenLT.Text);
                loaithuoc.Insert();
                dt = loaithuoc.Select();
                dgvLoaithuoc.DataSource = dt.DefaultView;
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn sửa dòng này? ",
                "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                loaithuoc = new BusinessLayer.LoaiThuocBsn(txtTenLT.Text);
                loaithuoc.Update();
                dt = loaithuoc.Select();
                dgvLoaithuoc.DataSource = dt.DefaultView;
            }
            if (dr == DialogResult.No)
            {
                dt = loaithuoc.Select();
                dgvLoaithuoc.DataSource = dt.DefaultView;
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
            btnEdit.Enabled = true;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            removeEmptyrow(dgvLoaithuoc);
            int curRow = dgvLoaithuoc.RowCount - 2;
            fillControls(dt, curRow);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa dòng này? ",
               "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) //if 
            {
                loaithuoc.Delete(int.Parse(txtMaLT.Text));
                totalRecord--;
                fillControls(dt, 0);
                dt = loaithuoc.Select();
                dgvLoaithuoc.DataSource = dt.DefaultView;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
 
    }
}
