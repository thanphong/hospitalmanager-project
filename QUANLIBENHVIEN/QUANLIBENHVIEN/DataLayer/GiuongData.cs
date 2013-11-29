using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QUANLIBENHVIEN.DataLayer
{
    class GiuongData:Data
    {
        public GiuongData()
        {
            this.tableName = "Giuong";
            this.fieldList = "MaPhong";
        }
        public DataTable Select()
        {
            try
            {
                //string sql = "SELECT * FROM ChucVu";
                //dt = new DataTable();
                //dt = data.get(sql);        
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM"+ this.tableName;
                dt = new DataTable();
                dt = GetData(cmd);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");
            }
            finally
            {
                closeConnect();
                //       conn.Close();
            }
            return dt;
        }
        public void Update(BusinessLayer.GiuongBsn giuong)
        {
            try{
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE " + this.tableName
                    + " SET MaPhong = '" + giuong.MaP + "' WHERE MaGiuong = '"
                    + giuong.MaG + "' ";
                dt = new DataTable();
                dt = GetData(cmd);
                MessageBox.Show("Sửa thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa thất bại");
            }
            finally
            {
                closeConnect();
            }
        }
        public void Insert(BusinessLayer.GiuongBsn giuong)
        {
            try
            {                 
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO " + this.tableName
                    + "(" + this.fieldList + ") VALUES ('"
                    + giuong.MaP+ "')";
                dt = new DataTable();
                dt = GetData(cmd);
                MessageBox.Show("Thêm mới thành công", "Thông báo");
                //conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm mới thất bại", "Thông báo");
            }
            finally
            {
                  closeConnect();
            }
        }
        public void Delete(int ma)
        {
            try
            {                
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM " + this.tableName
                    + " WHERE MaGiuong='" + ma + "'";
                 dt = new DataTable();
                dt = GetData(cmd);
            }
            catch (Exception )
            {
                MessageBox.Show("Dữ liệu đang được sử dụng");
            }
            finally
            {
                 closeConnect();
            }
        }
    }
}
