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
    public partial class Giuong : Form
    {
        BusinessLayer.GiuongBsn giuong = new BusinessLayer.GiuongBsn();
        BusinessLayer.PhongBsn phong = new BusinessLayer.PhongBsn();
        DataTable dt;
        DataSet ds = new DataSet();
        int curRecord = 0;
        int totalRecord = 0;
        String tv = "";
        public Giuong()
        {
            InitializeComponent();
        }
        private void fillControls(DataTable dataTable, int curRec)
        {
            if (dataTable.Rows.Count != 0)
            {
                txtMaG.Text = dataTable.Rows[curRec][0].ToString();
                cbbTenphong.Text = dataTable.Rows[curRec][2].ToString();
            }
        }
        private void Giuong_Load(object sender, EventArgs e)
        {
            txtMaG.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            SqlDataAdapter da;
           da = phong.GetDataAdapter();
            da.Fill(ds, "Phong");

            cbbTenphong.DataSource = ds;
            //Nội dung sẽ hiển thị lên combobox
            cbbTenphong.DisplayMember = "Phong.TenPhong";
            //Giá trị nhận được ứng với từng nội dung được chọn trên combobox
            cbbTenphong.ValueMember = "Phong.MaPhong";

            dt = giuong.Select();
            curRecord = 0;
            totalRecord = dt.Rows.Count - 1;
            fillControls(dt, 0);
            //txtTenCM.Text = cbbTenCM.SelectedValue.ToString();
            dgrvGiuong.DataSource = dt.DefaultView;

            this.Cursor = Cursors.Default;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow row = dt.NewRow();
            dt.Rows.Add(row);
            fillControls(dt, 0);     
            cbbTenphong.Text = "";
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            tv = "Add";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((cbbTenphong.Text == "") || giuong.MaP== 0)
            {
                MessageBox.Show("Mời bạn nhập đầy đủ thông tin!", "Thông báo");
            }
            else
            {               
                giuong.Insert();
                dt = giuong.Select();
                dgrvGiuong.DataSource = dt.DefaultView;
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                tv = "";

            }
        }

        private void cbbTenP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tv.Equals("Add"))
            {
                giuong.MaP= Convert.ToInt32(cbbTenphong.SelectedValue.ToString());
                MessageBox.Show("" + giuong.MaP);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa dòng này? ",
               "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                giuong.Delete(int.Parse(txtMaG.Text));
                totalRecord--;
                fillControls(dt, 0);
                dt = giuong.Select();
                dgrvGiuong.DataSource = dt.DefaultView;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            removeEmptyrow(dgrvGiuong);
            int curRow = dgrvGiuong.RowCount - 2;
            fillControls(dt, curRow);
        }

        private void dgrvGiuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaG.DataBindings.Clear();
            txtMaG.DataBindings.Add("Text", dgrvGiuong.DataSource, "MaGiuong");
            cbbTenphong.DataBindings.Clear();
            cbbTenphong.DataBindings.Add("Text", dgrvGiuong.DataSource, "TenPhong");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn sửa dòng này? ",
                "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                giuong = new BusinessLayer.GiuongBsn( int.Parse(cbbTenphong.ValueMember));
                giuong.Update();
                dt = giuong.Select();
                dgrvGiuong.DataSource = dt.DefaultView;
            }
            if (dr == DialogResult.No)
            {
                dt = giuong.Select();
                dgrvGiuong.DataSource = dt.DefaultView;
            }
        }
    }
}
