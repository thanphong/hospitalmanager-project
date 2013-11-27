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
                cbbTenphong.Text = dataTable.Rows[curRec][1].ToString();
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
            cbbTenphong.DisplayMember = "Phong.MaPhong";
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
    }
}
