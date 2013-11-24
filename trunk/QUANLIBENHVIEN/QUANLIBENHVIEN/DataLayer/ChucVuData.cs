using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QUANLIBENHVIEN.DataLayer;

namespace QUANLIBENHVIEN.DataLayer
{
    class ChucVuData:Data
    {
        Data data = new Data(); // Khởi tạo đối tượng connect
        DataTable dt;
        public ChucVuData()
        {
            this.tableName = "ChucVu";
            this.fieldList = "TenCV";
        }
        public DataTable Select()
        {
            try
            {
                string sql = "SELECT * FROM ChucVu";
                dt = new DataTable();
                dt = data.get(sql);        
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
        public void Update(BusinessLayer.ChucVuBsn chucvu)
        {
            try{
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update " + this.tableName
                    + " set TenCV = '" + chucvu.TenCV + "' where MaCV = '"
                    + chucvu.MaCV + "' ";
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
        public void Insert(BusinessLayer.ChucVuBsn chucvu)
        {
            try
            {                 
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into " + this.tableName
                    + "(" + this.fieldList + ") values ('"
                    + chucvu.TenCV + "')";
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
                    + " where MaCV ='" +ma+"'";
                 dt = new DataTable();
                dt = data.GetData(cmd);
            }
            catch (Exception )
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
