using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QUANLIBENHVIEN.DataLayer
{
    class nhanvienData : Data
    {
        public nhanvienData()
        {
            this.tableName = "CTNhanVien";
            this.fieldList = "Ten,DiaChi,NgaySinh,Gioitinh,DienThoai,MaCv,MaLuong,SoBaoHiem,MaPhong,MaChuyenMon, MaTrinhDo";
        }
        //
        public DataTable Select()
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM '" + this.tableName + "'";
                dt = new DataTable();
                dt = GetData(cmd);
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
        //
        public void Update(BusinessLayer.NhanVienBsn nhanvien)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE " + this.tableName
                    + " SET Ten='" + nhanvien.TeNV + "',DiaChi='" + nhanvien.Diachi + "',NgaySinh=" + nhanvien.Ngaysinh + ",Gioitinh=" + nhanvien.Giotinh + ",DienThoai='" + nhanvien.Dienthoai + "',MaCv=" + nhanvien.MaCV + ",MaLuong=" + nhanvien.MaLuong + ",SoBaoHiem='" + nhanvien.SoBH + "',MaPhong=" + nhanvien.MaPhong + ",MaChuyenMon=" + nhanvien.MaCM + ",MaTrinhDo=" + nhanvien.MaTD + "WHERE (select MaCT from NhanVien where MaNhanVien="+nhanvien.MaNV+")=MaCT";
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
        public void InsertDetail(BusinessLayer.NhanVienBsn nhanvien)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO " + this.tableName
                    + "(" + this.fieldList + ") VALUES ('"
                    + nhanvien.TeNV + "','" + nhanvien.Diachi + "','" + nhanvien.Ngaysinh + "'," + nhanvien.Giotinh + ",'" + nhanvien.Dienthoai + "'," + nhanvien.MaCV + "," + nhanvien.MaLuong + ",'" + nhanvien.SoBH + "'," + nhanvien.MaCM + "," + nhanvien.MaTD + ")";
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
                closeConnect();
                // conn.Close();
            }
        }
        /*public void Insert(BusinessLayer.NhanVienBsn nhanvien)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO " + this.tableName
                    + "(" + this.fieldList + ") VALUES ('"
                    + nhanvien.TeNV + "','" + nhanvien.Diachi + "','" + nhanvien.Ngaysinh + "'," + nhanvien.Giotinh+ ",'" + nhanvien.Dienthoai + "',"+nhanvien.MaCV+","+nhanvien.MaLuong+",'"+nhanvien.SoBH+"',"+nhanvien.MaCM+","+nhanvien.MaTD+")";
                dt = new DataTable();
                dt = data.GetData(cmd);
                //cmd.CommandText="insert into NhanVien (MaCT) values("
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
        }*/
    }
}
