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
    class PhongData:Data
    {
        public PhongData()
        {
            this.tableName = "Phong";
            this.fieldList = "TenPhong,TongSoGiuong,SoGiuongTrong,Vitri";
        }

        public DataTable Select()
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM" + this.tableName;
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
        public void Update(BusinessLayer.PhongBsn phong)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE " + this.tableName
                    + " SET TenPhong = '" + phong.TenP + "',TongSoGiuong = '" + phong.TongGiuong + "',SoGiuongTrong = '" + phong.TongGiuong
                    + "',ViTri = '" + phong.Vitri + "' WHERE MaPhong = '"
                    + phong.MaP + "' ";
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
        public void Insert(BusinessLayer.PhongBsn phong)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO " + this.tableName
                    + "(" + this.fieldList + ") VALUES ('"
                    + phong.TenP + "','"+phong.TongGiuong+"','"+phong.SoGT+ "','"+phong.Vitri+ "')";
                dt = new DataTable();
                dt = GetData(cmd);
                MessageBox.Show("thêm mới thành công", "Thông báo");
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
                    + " WHERE MaP ='" + ma + "'";
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
