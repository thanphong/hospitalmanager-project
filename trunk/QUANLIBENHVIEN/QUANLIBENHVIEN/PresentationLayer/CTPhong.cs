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
    public partial class CTPhong : Form
    {
        BusinessLayer.CTPhongBsn ctphong = new BusinessLayer.CTPhongBsn();
        BusinessLayer.PhongBsn phong = new BusinessLayer.PhongBsn();
        DataTable dt;
        DataSet ds = new DataSet();
        int curRecord = 0;
        int totalRecord = 0;
        String tv = "";

        public CTPhong()
        {
            InitializeComponent();
        }

        private void fillControls(DataTable dataTable, int curRec)
        {
            if (dataTable.Rows.Count != 0)
            {
                txtMaCTP.Text = dataTable.Rows[curRec][0].ToString();
                cbbTenphong.Text = dataTable.Rows[curRec][1].ToString();
            }
        }
        private void ChiTietPhong_Load(object sender, EventArgs e)
        {
            txtMaCTP.Enabled = false;
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

            dt = ctphong.Select();
            totalRecord = dt.Rows.Count - 1;
            fillControls(dt, 0);
            //txtTenCM.Text = cbbTenCM.SelectedValue.ToString();
            dgrvCTPhong.DataSource = dt.DefaultView;

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
            tv = "Add";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn sửa dòng này? ",
               "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                ctphong = new BusinessLayer.CTPhongBsn(int.Parse(cbbTenphong.ValueMember));
                ctphong.Update();
                dt = ctphong.Select();
                dgrvCTPhong.DataSource = dt.DefaultView;
            }
            if (dr == DialogResult.No)
            {
                dt = ctphong.Select();
                dgrvCTPhong.DataSource = dt.DefaultView;
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
            removeEmptyrow(dgrvCTPhong);
            int curRow = dgrvCTPhong.RowCount - 2;
            fillControls(dt, curRow);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa dòng này? ",
               "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                ctphong.Delete(int.Parse(txtMaCTP.Text));
                totalRecord--;
                fillControls(dt, 0);
                dt = ctphong.Select();
                dgrvCTPhong.DataSource = dt.DefaultView;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbbTenphong.Text == "" || cbbTenphong.Text == " ")
            {
                MessageBox.Show("Mời bạn nhập tên chức vụ!", "Thông báo");
            }
            else
            {
                ctphong.Insert();
                dt = ctphong.Select();
                dgrvCTPhong.DataSource = dt.DefaultView;
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                tv = "";
            }
        }

        private void cbbTenphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tv.Equals("Add"))
            {
                ctphong.MaP = Convert.ToInt32(cbbTenphong.SelectedValue.ToString());
            //    MessageBox.Show("" + ctphong.MaP);
            }
        }
    }
}
