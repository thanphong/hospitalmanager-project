using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QUANLIBENHVIEN.DataLayer
{
    class NhaCungCapData : Data
    {
        public NhaCungCapData()
        {
            this.tableName = "NhaCungCap";
            this.fieldList = "Ten,DiaChi,DienThoai,SoFax";
        }

        public DataTable Select()
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM " + this.tableName ;
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
            }
            return dt;
        }
        public void Update(BusinessLayer.NhaCungCapBsn nhacungcap)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE " + this.tableName
                    + " SET Ten = '" + nhacungcap.TenNCC + "' ,DiaChi = '" + nhacungcap.Diachi + "' ,DienThoai = '" + nhacungcap.Sodt
                    + "' ,SoFax = '" + nhacungcap.Sofax + "'   WHERE MaNhaCungCap= '"
                    + nhacungcap.MaNCC + "' ";
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
        public void Insert(BusinessLayer.NhaCungCapBsn nhacungcap)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO " + this.tableName
                    + "(" + this.fieldList + ") VALUES ('"
                    + nhacungcap.MaNCC + "')";
                dt = new DataTable();
                dt = GetData(cmd);
                MessageBox.Show("Thêm mới thành công", "Thông báo");
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
                    + " WHERE MaNhaCungCap='" + ma + "'";
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

