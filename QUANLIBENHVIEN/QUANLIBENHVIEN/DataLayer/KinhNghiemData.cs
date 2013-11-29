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
    class nhanvienData :Data
    {
        Data data = new Data(); // Khởi tạo đối tượng connect
        //DataTable dt;
        //SqlCommand cmd;
        public nhanvienData()
        {
            this.tableName = "nhanvien";
            this.fieldList = "MaNhanVien, MaChuyenMon, MaTrinhDo, NgayBatDau, NgayKetthuc";
        }
        public DataTable Select()
        {
            try
            {   
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM nhanvien";
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

        public void Update(BusinessLayer.nhanvienBsn nhanvien)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE " + this.tableName
                    + " SET MaNhanVien = " + nhanvien.MaNV + ",MaChuyenMon="+nhanvien.MaCM+",MaTrinhDo="+nhanvien.MaTD+",NgayBatDau="+nhanvien.NgayBD+",NgayKetthuc="+nhanvien.NgayKT+"  WHERE MaNhanVien = "
                    + nhanvien.MaNV ;
                dt = new DataTable();
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
        public void Insert(BusinessLayer.nhanvienBsn nhanvien)
        {
            try
            {                 
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO " + this.tableName
                    + "(" + this.fieldList + ") VALUES ("
                    + nhanvien.MaNV + ","+nhanvien.MaCM+","+nhanvien.MaTD+","+nhanvien.NgayBD+","+nhanvien.NgayKT+")";
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
                cmd.CommandText = "DELETE FROM " + this.tableName
                    + " WHERE MaKN ='" + ma + "'";
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
