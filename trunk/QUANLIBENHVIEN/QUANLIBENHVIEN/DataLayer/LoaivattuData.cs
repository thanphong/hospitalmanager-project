using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QUANLIBENHVIEN.DataLayer
{
    class LoaivattuData : Data
    {
       Data data = new Data(); // Khởi tạo đối tượng connect

       public LoaivattuData()
        {
            this.tableName = "LoaiVatTu";
            this.fieldList = "Ten";
        }
        public DataTable Select()
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM " + this.tableName;
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
            }
            return dt;
        }
        public void Update(BusinessLayer.LoaiVattuBsn loaivattu)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE " + this.tableName
                    + " SET Ten= '" + loaivattu.TenVT + "' WHERE MaLoai = '"
                    + loaivattu.MaVT + "' ";
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
        public void Insert(BusinessLayer.LoaiVattuBsn loaivattu)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO " + this.tableName
                    + "(" + this.fieldList + ") values ('"
                    + loaivattu.TenVT + "')";
                dt = new DataTable();
                dt = data.GetData(cmd);
                MessageBox.Show("Thêm mới thành công", "Thông báo");
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm mới thất bại", "Thông báo");
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
                cmd.CommandText = "DELETE FROM " + this.tableName
                    + " WHERE MaLoai='" + ma + "'";
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
