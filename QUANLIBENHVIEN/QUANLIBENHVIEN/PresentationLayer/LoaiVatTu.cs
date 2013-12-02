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
    public partial class LoaiVatTu : Form
    {
        BusinessLayer.LoaiVattuBsn loaivattu = new BusinessLayer.LoaiVattuBsn();
        DataTable dt;
        int curRecord = 0;
        int totalRecord = 0;

        public LoaiVatTu()
        {
            InitializeComponent();
        }

        private void fillControls(DataTable dataTable, int curRec)
        {
            if (dataTable.Rows.Count != 0)
            {
                txtMaVT.Text = dataTable.Rows[0][0].ToString();
                txtMaVT.Text = dataTable.Rows[0][1].ToString();
            }
        }
        private void LoaiVatTu_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            dt = loaivattu.Select();
            curRecord = 0;
            totalRecord = dt.Rows.Count - 1;
            fillControls(dt, 0);
            dgrvLoaivattu.DataSource = dt.DefaultView;
            this.Cursor = Cursors.Default;
        }

        private void dgvTTLoaiVattu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaVT.DataBindings.Clear();
            txtMaVT.DataBindings.Add("Text", dgrvLoaivattu.DataSource, "MaLoai");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", dgrvLoaivattu.DataSource, "Ten");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn sửa dòng này? ",
               "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                loaivattu = new BusinessLayer.LoaiVattuBsn(txtTen.Text);
                loaivattu.Update();
                dt = loaivattu.Select();
                dgrvLoaivattu.DataSource = dt.DefaultView;
            }
            if (dr == DialogResult.No)
            {
                dt = loaivattu.Select();
                dgrvLoaivattu.DataSource = dt.DefaultView;
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
            if (txtTen.Text == "")
            {
                MessageBox.Show("Mời bạn nhập dữ liệu!", "Thông báo");
            }
            else
            {
                loaivattu = new BusinessLayer.LoaiVattuBsn(txtTen.Text);
                loaivattu.Insert();
                dt = loaivattu.Select();
                dgrvLoaivattu.DataSource = dt.DefaultView;
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = false;
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
            removeEmptyrow(dgrvLoaivattu);
            int curRow = dgrvLoaivattu.RowCount - 2;
            fillControls(dt, curRow);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa dòng này? ",
              "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) //if 
            {
                loaivattu.Delete(int.Parse(txtMaVT.Text));
                totalRecord--;
                fillControls(dt, 0);
                dt = loaivattu.Select();
                dgrvLoaivattu.DataSource = dt.DefaultView;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
