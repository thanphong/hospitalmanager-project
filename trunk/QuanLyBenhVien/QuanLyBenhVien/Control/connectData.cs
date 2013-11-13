using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyBenhVien.Control
{
    public class connectData
    {
        SqlConnection con;//Dùng để kết nối vào cơ sở dữ liệu
        SqlDataAdapter da;//Là đối tượng trung gian lấy dữ liệu FIll vào trong các đối tương Data
        DataSet ds;//Kho chứa dữ liệu tạm thời để xử lý
        SqlCommand cmd;// Các xử lý truy vấn SQL thêm, xóa, sửa
        DataTable dt;
        //khởi tạo kêt nối
        //Nếu connection là null thì mới tạo kết nối, và trạng thái kết nối là đóng thì ta sẽ mở nó lên.
        public void openConnect()
        {
            if (con == null)
                con = new SqlConnection("server=WIN-R4LGL0DC68V\\SQL;database=taikhoan;User ID =sa;Password =123;integrated security = true;");
            if (con.State == ConnectionState.Closed)
                con.Open();
        }
        //Sau đó mình thực hiện việc đóng kết nối như sau:
        //Nếu connection là khac null và trang thái là mở thì mình sẽ đóng lại.
        public void closeConnect()
        {
            if ((con != null) && (con.State == ConnectionState.Open))
                con.Close();
        }

        //các công việc thêm xóa sửa trong database chỉ khác nhau chổ truy vấn SQL nên ta sẽ gom chung nó vào một hàm
        //hàm lấy dữ liệu dùng chung khi không có  where trong câu lệnh
        public DataTable get(string sql)
        {
            openConnect();
            da = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            da.Fill(dt);
            closeConnect();
            return dt;
        }
        //hàm lấy dữ liệu dùng chung khi có  where trong câu lệnh
        public DataTable GetData(SqlCommand cmd)
        {
            openConnect();
            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            da.SelectCommand = cmd;
            da.Fill(dt);
            closeConnect();
            return dt;
        }
    
        //public void ExeCuteNonQuery(string sql)
        //{
        //    openConnect();
        //    cmd = new SqlCommand(sql, con);
        //    cmd.ExecuteNonQuery();
        //    closeConnect();
        //}

    }
}