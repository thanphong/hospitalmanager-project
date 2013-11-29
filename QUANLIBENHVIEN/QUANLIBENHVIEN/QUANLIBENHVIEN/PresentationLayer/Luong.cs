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
    public partial class Luong : Form
    {
        BusinessLayer.LuongBns luong;
        DataTable dt;
        DataSet ds = new DataSet();
        string tv = "";
        public Luong()
        {
            InitializeComponent();
        }

        private void Luong_Load(object sender, EventArgs e)
        {
            txtMaluong.Enabled = false;
            txtMucluong.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            //
            luong = new BusinessLayer.LuongBns();
            dt = luong.Select();
            fillControls(dt, 0);
            dgrvLuong.DataSource = dt.DefaultView;
            this.Cursor = Cursors.Default;
        }
        private void fillControls(DataTable dataTable, int curRec)
        {
            if (dataTable.Rows.Count != 0)
            {
                txtMaluong.Text = dataTable.Rows[curRec][0].ToString();
                txtMucluong.Text = dataTable.Rows[curRec][1].ToString();
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
            tv = "Add";
            //thêm 1 dòng mới cho datagrid
            DataRow row = dt.NewRow();
            dt.Rows.Add(row);
            fillControls(dt, 0);
            txtMucluong.Enabled = true;
            txtMucluong.Text = "";
            txtMaluong.Text = "";
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMucluong.Text == "")
            {
                MessageBox.Show("Mời bạn nhập mức lương!", "Thông báo");
            }
            else
            {
                luong = new BusinessLayer.LuongBns();
               
                luong.MucLuong = Convert.ToSingle(txtMucluong.Text.ToString());
                MessageBox.Show("Mời bạn nhập mức lương!", "Thông báo");

               luong.Insert();
                dt = luong.Select();
                dgrvLuong.DataSource = dt.DefaultView;
                txtMucluong.Enabled = false;
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                tv = "";
            }
        }

        private void txtMucluong_MouseClick(object sender, MouseEventArgs e)
        {
            if (tv.Equals("Add"))
            {
                int stt = Convert.ToInt32(dt.Rows[dt.Rows.Count - 2][0]) + 1;
                txtMaluong.Text = stt.ToString();
            }
        }

        private void dgrvLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtMaluong.DataBindings.Clear();
            txtMaluong.DataBindings.Add("Text", dgrvLuong.DataSource, "MaLuong");
            txtMucluong.DataBindings.Clear();
            txtMucluong.DataBindings.Add("Text", dgrvLuong.DataSource, "Luong");
        }
     

       
    }
}
