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
    public partial class TrinhDo : Form
    {
        BusinessLayer.TrinhDoBsn trinhdo;
        BusinessLayer.ChuyenMonBsn chuyenmon;
        DataTable dt;
        DataSet ds  = new DataSet();
        int curRecord = 0;
        int totalRecord = 0;
        public TrinhDo()
        {
            InitializeComponent();
   
        }

        private void dgrvTrinhdo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void fillControls(DataTable dataTable, int curRec)
        {
            txtMaTD.Text = dataTable.Rows[curRec][0].ToString();
            txtTenCM.Text = dataTable.Rows[curRec][1].ToString();
            cbbTenCM.Text = dataTable.Rows[curRec][1].ToString();
            txtLoaiTD.Text = dataTable.Rows[curRec][2].ToString();
            txtTenTochuc.Text = dataTable.Rows[curRec][3].ToString();
        }
        private void TrinhDo_Load(object sender, EventArgs e)
        {
            txtMaTD.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            SqlDataAdapter da;
            chuyenmon =new BusinessLayer.ChuyenMonBsn();
            da = chuyenmon.GetDataAdapter();
            da.Fill(ds, "ChuyenMon");
            cbbTenCM.DataSource = ds;
            //Nội dung sẽ hiển thị lên combobox
            cbbTenCM.DisplayMember = "ChuyenMon.TenChuyenMon";
            //Giá trị nhận được ứng với từng nội dung được chọn trên combobox
            cbbTenCM.ValueMember = "ChuyenMon.MaChuyenMon";

            trinhdo = new BusinessLayer.TrinhDoBsn();
            dt = trinhdo.Select();
            curRecord = 0;
            totalRecord = dt.Rows.Count - 1;
            fillControls(dt, 0);
     
            dgrvTrinhdo.DataSource = dt.DefaultView;
            this.Cursor = Cursors.Default;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn sửa dòng này? ",
               "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                trinhdo = new BusinessLayer.TrinhDoBsn(int.Parse(txtMaTD.Text), int.Parse(cbbTenCM.ValueMember), txtLoaiTD.Text, txtTenTochuc.Text);
                trinhdo.Update();
                dt = trinhdo.Select();
                dgrvTrinhdo.DataSource = dt.DefaultView;
            }
            if (dr == DialogResult.No)
            {
                dt = trinhdo.Select();
                dgrvTrinhdo.DataSource = dt.DefaultView;
            }
        }

       
    }
}
