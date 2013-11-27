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
        BusinessLayer.TrinhDoBsn trinhdo = new BusinessLayer.TrinhDoBsn();
        BusinessLayer.ChuyenMonBsn chuyenmon =new BusinessLayer.ChuyenMonBsn();
        DataTable dt;
        DataSet ds  = new DataSet();
        int curRecord = 0;
        int totalRecord = 0;
        String tv = "";
        public TrinhDo()
        {
            InitializeComponent();
   
        }

        private void dgrvTrinhdo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void fillControls(DataTable dataTable, int curRec)
        {
            if (dataTable.Rows.Count!=0)
            {
                txtMaTD.Text = dataTable.Rows[curRec][0].ToString();
               // txtTenCM.Text = dataTable.Rows[curRec][1].ToString();
                cbbTenCM.Text = dataTable.Rows[curRec][1].ToString();
                txtLoaiTD.Text = dataTable.Rows[curRec][2].ToString();
                txtTenTochuc.Text = dataTable.Rows[curRec][3].ToString();
            }
        }
        private void TrinhDo_Load(object sender, EventArgs e)
        {
            trinhdo = new BusinessLayer.TrinhDoBsn();
            txtMaTD.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            SqlDataAdapter da;
            chuyenmon =new BusinessLayer.ChuyenMonBsn();
            da = chuyenmon.GetDataAdapter();
            da.Fill(ds, "ChuyenMon");
            
            cbbTenCM.DataSource =ds;
            //Nội dung sẽ hiển thị lên combobox
            cbbTenCM.DisplayMember = "ChuyenMon.MaChuyenMon";
            //Giá trị nhận được ứng với từng nội dung được chọn trên combobox
            cbbTenCM.ValueMember = "ChuyenMon.MaChuyenMon";

            dt = trinhdo.Select();
            curRecord = 0;
            totalRecord = dt.Rows.Count - 1;
            fillControls(dt, 0);
            //txtTenCM.Text = cbbTenCM.SelectedValue.ToString();
            dgrvTrinhdo.DataSource = dt.DefaultView;

            this.Cursor = Cursors.Default;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow row = dt.NewRow();
            dt.Rows.Add(row);
            fillControls(dt, 0);
            txtLoaiTD.Enabled = true;
            txtTenTochuc.Enabled = true;
            txtTenTochuc.Text = "";
            txtLoaiTD.Text = "";
            btnAdd.Enabled = false;
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

        private void btnSave_Click(object sender, EventArgs e)
        {

            if ((txtLoaiTD.Text == "") || (txtTenTochuc.Text=="") || trinhdo.MaCM==0)
            {
                MessageBox.Show("Mời bạn nhập đầy đủ thông tin!", "Thông báo");
            }
            else
            {

                trinhdo.LoaiTD = txtLoaiTD.Text.ToString();
                trinhdo.TenTochuc = txtTenTochuc.Text.ToString();

                trinhdo.Insert();
                dt = trinhdo.Select();
                dgrvTrinhdo.DataSource = dt.DefaultView;
                txtLoaiTD.Enabled = false;
                txtTenTochuc.Enabled = false;
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                tv = "";
                
            }
        }

        private void cbbTenCM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tv.Equals("Add"))
            {
                trinhdo.MaCM = Convert.ToInt32(cbbTenCM.SelectedValue.ToString());
                MessageBox.Show("" + trinhdo.MaCM);
                //txtTenCM.Text = cbbTenCM.SelectedValue.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa dòng này? ",
               "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                trinhdo.Delete(int.Parse(txtMaTD.Text));
                totalRecord--;
                fillControls(dt, 0);
                dt = trinhdo.Select();
                dgrvTrinhdo.DataSource = dt.DefaultView;
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
            removeEmptyrow(dgrvTrinhdo);
            int curRow = dgrvTrinhdo.RowCount - 2;
            fillControls(dt, curRow);
        }      
    }
}
