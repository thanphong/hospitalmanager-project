using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QUANLIBENHVIEN.DataLayer
{
    class CTPhongData : Data
    {
        public CTPhongData()
        {
            this.tableName = "CTPhong";
            this.fieldList = "MaPhong";
        }
        public DataTable Select()
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT MaCT, CTPhong.MaPhong, TenPhong FROM "+this.tableName+" , Phong WHERE Phong.MaPhong=CTPhong.MaPhong";
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
        public void Update(BusinessLayer.CTPhongBsn ctphong)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE " + this.tableName
                    + " SET MaPhong = '" + ctphong.MaP + "' WHERE MaCT= '"
                    + ctphong.MaCT + "' ";
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
        public void Insert(BusinessLayer.CTPhongBsn ctphong)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO " + this.tableName
                    + "(" + this.fieldList + ") VALUES ('"
                    + ctphong.MaP + "')";
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
                    + " WHERE MaCT='" + ma + "'";
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

