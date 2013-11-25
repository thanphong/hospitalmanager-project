using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QUANLIBENHVIEN.DataLayer
{
    class ChuyenMonData:Data
    {
        Data data = new Data(); // Khởi tạo đối tượng connect
        DataTable dt;
        SqlCommand cmd;
        public ChuyenMonData()
        {
            this.tableName = "ChuyenMon";
            this.fieldList = "TenChuyenMon";
        }
        public DataTable Select()
        {
            try
            {
                //string sql = "SELECT * FROM ChuyenMon";
                //dt = new DataTable();
                //dt = data.get(sql);
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM ChuyenMon";
                dt = new DataTable();
                dt = data.GetData(cmd);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");
            }
            finally
            {
                data.closeConnect();
                //       conn.Close();
            }
            return dt;
        }
        public void Update(BusinessLayer.KinhNghiemBsn chuyenmon)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update " + this.tableName
                    + " set TenChuyenMon= '" + chuyenmon.TenCM + "' where MaChuyenMon = '"
                    + chuyenmon.MaCM+ "' ";
                DataTable dt = new DataTable();
                dt = data.GetData(cmd);
                MessageBox.Show("Sửa thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa thất bại");
            }
            finally
            {
                data.closeConnect();
            }
        }
        public void Insert(BusinessLayer.KinhNghiemBsn chuyenmon)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into " + this.tableName
                    + "(" + this.fieldList + ") values ('"
                    + chuyenmon.TenCM + "')";
                dt = new DataTable();
                dt = data.GetData(cmd);
                MessageBox.Show("thêm mới thành công", "Thông báo");
                //conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Bị trùng khóa, thêm mới thất bại", "Thông báo");
            }
            finally
            {
                data.closeConnect();
                // conn.Close();
            }
        }
        public void Delete(int ma)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from " + this.tableName
                    + " where MaChuyenMon='" + ma + "'";
                dt = new DataTable();
                dt = data.GetData(cmd);
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu đang được sử dụng");
            }
            finally
            {
                data.closeConnect();
            }
        }
      
    }
}
