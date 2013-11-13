using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyBenhVien.Control;


namespace QuanLyBenhVien.View.personnel.login
{
    public partial class dangnhap : System.Web.UI.Page
    {
        connectData data = new connectData(); // Khởi tạo đối tượng connect
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                load_data();
        }
        // Sử dụng được class phải có đối tượng ở đây mình khai báo là data. Sau đó tạo hàm load database.
        private void load_data()
        {
            string sql = "select * from taikhoan";
            gvtkhoan.DataSource = data.get(sql);
            gvtkhoan.DataBind();
        }
        //mã hóa pass
        public string mahoa(string pass)
        {
            return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(pass.Trim(), "SHA1");
        }

        protected void btInsert_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO taikhoan(username,pass)values('" + txtU.Text + "' , '" + mahoa(txtP.Text) + "')";
            data.ExeCuteNonQuery(sql);
            load_data();
        }

        ////
        //protected void gvtkhoan_RowUpdating(object sender, GridViewUpdateEventArgs e)
        //{
        //    if (((LinkButton)gvtkhoan.Rows[0].Cells[0].Controls[0]).Text == "Insert")
        //    {
        //        string sql = "INSERT INTO taikhoan(username,pass)values('" + txtU.Text + "' , '" + mahoa(txtP.Text) + "')";
        //        data.ExeCuteNonQuery(sql);
        //        load_data();
        //    }
        //    else
        //    {
        //        string sql = "UPDATE taikhoan SET username=@username WHERE id=@id";
        //        data.ExeCuteNonQuery(sql);
        //        load_data();
        //    }


        //    gvtkhoan.EditIndex = -1;
        //    load_data();
        //}

        protected void gvtkhoan_Editing(object sender, GridViewEditEventArgs e)
        {
            gvtkhoan.EditIndex = e.NewEditIndex;
            load_data();
        }

        protected void gvtkhoan_Deleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = ((Label)gvtkhoan.Rows[e.RowIndex].FindControl("lbId")).Text;
            string sql = "delete from  taikhoan where id='"+id+"'";
            data.ExeCuteNonQuery(sql);
            load_data();
        }

        protected void gvtkhoan_CancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvtkhoan.EditIndex = -1;
            load_data();
        }

        protected void gvtkhoan_Updateing(object sender, GridViewUpdateEventArgs e)
        {
            string id = ((Label)gvtkhoan.Rows[e.RowIndex].FindControl("lbId")).Text;
            string us = ((TextBox)gvtkhoan.Rows[e.RowIndex].FindControl("txtUS")).Text;
            string p = ((TextBox)gvtkhoan.Rows[e.RowIndex].FindControl("txtPass")).Text;
            string sql = "update taikhoan set username='"+us+"',pass='"+mahoa(p)+"' where id='"+id+"'";
             data.ExeCuteNonQuery(sql);
             load_data();
        }
    }
}