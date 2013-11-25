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
    public partial class ChuyenMon : Form
    {
        BusinessLayer.KinhNghiemBsn chuyenmon;
        DataTable dt;
        int curRecord = 0;
        int totalRecord = 0;
        public ChuyenMon()
        {
            InitializeComponent();
        }

        private void dgrvChuyenmon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCM.DataBindings.Clear();
            txtMaCM.DataBindings.Add("Text", dgrvChuyenmon.DataSource, "MaChuyenMon");
            txtTenCM.DataBindings.Clear();
            txtTenCM.DataBindings.Add("Text", dgrvChuyenmon.DataSource, "TenChuyenMon");
        }

        private void ChuyenMon_Load(object sender, EventArgs e)
        {
            txtMaCM.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            chuyenmon = new BusinessLayer.KinhNghiemBsn();
            dt = chuyenmon.Select();
            curRecord = 0;
            totalRecord = dt.Rows.Count - 1;
            fillControls(dt, 0);
            dgrvChuyenmon.DataSource = dt.DefaultView;
            this.Cursor = Cursors.Default;
        }
        private void fillControls(DataTable dataTable, int curRec)
        {
            txtMaCM.Text = dataTable.Rows[0][0].ToString();
            txtTenCM.Text = dataTable.Rows[0][1].ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            chuyenmon = new BusinessLayer.KinhNghiemBsn(int.Parse(txtMaCM.Text),txtTenCM.Text);
            chuyenmon.Update();
            dt = chuyenmon.Select();
            dgrvChuyenmon.DataSource = dt.DefaultView;
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
            if (txtTenCM.Text == "")
            {
                MessageBox.Show("Mời bạn nhập tên chức vụ!", "Thông báo");
            }
            else
            {
                chuyenmon = new BusinessLayer.KinhNghiemBsn(txtTenCM.Text);
                chuyenmon.Insert();
                dt = chuyenmon.Select();
                dgrvChuyenmon.DataSource = dt.DefaultView;
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa dòng này? ",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) //if 
            {
                chuyenmon = new BusinessLayer.KinhNghiemBsn();
                chuyenmon.Delete(int.Parse(txtMaCM.Text));
                totalRecord--;
                fillControls(dt, 0);
                dt = chuyenmon.Select();
                dgrvChuyenmon.DataSource = dt.DefaultView;
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
            removeEmptyrow(dgrvChuyenmon);
            int curRow = dgrvChuyenmon.RowCount - 2;
            fillControls(dt, curRow);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
