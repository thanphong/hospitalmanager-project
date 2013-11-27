using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QUANLIBENHVIEN.DataLayer
{
    class LuongData:Data
    {
        public LuongData()
        {
            this.tableName = "Luong";
            this.fieldList = "Luong";
        }
        //
        public DataTable Select()
        {
            try
            {

                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM "+this.tableName;
                dt = new DataTable();
                dt = GetData(cmd);
            }
            catch
            {
                throw new Exception("Loi");
            }
            finally
            {
                closeConnect();
            }
            return dt;
        }
        //
        public void Insert(BusinessLayer.LuongBns luong)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO " + this.tableName
                    + "(" + this.fieldList + ") values ('" + luong.MucLuong.ToString() + "')";
                dt = new DataTable();
                dt = GetData(cmd);
                MessageBox.Show("thêm mới thành công", "Thông báo");
                //conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Bị trùng khóa, thêm mới thất bại", "Thông báo");
            }
            finally
            {
                closeConnect();
                // conn.Close();
            }
        }
        //
        public void Update(BusinessLayer.LuongBns luong)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE " + this.tableName
                    + " SET MaLuong= " + luong.MaLuong + ", luong= " + luong.MucLuong;
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
        //
        public void Delete(BusinessLayer.LuongBns luong)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM " + this.tableName
                    + " where  MaLuong=" + luong.MaLuong;
                dt = new DataTable();
                dt = GetData(cmd);
            }
            catch (Exception)
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
