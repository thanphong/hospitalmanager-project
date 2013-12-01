using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QUANLIBENHVIEN.DataLayer
{

    class NhanVienData:Data
    {

        public NhanVienData()
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
                cmd.CommandText = "select NhanVien.MaNhanVien,Ten,DiaChi,NgaySinh,Gioitinh,DienThoai,TenCV,Luong,SoBaoHiem,TenPhong,TenChuyenMon,LoaiTrinhDo "
                + " from CTNhanVien, Luong, Phong, ChuyenMon, TrinhDo,ChucVu,NhanVien"
                + " where CTNhanVien.MaCv=ChucVu.MaCv and CTNhanVien.MaLuong=Luong.MaLuong and CTNhanVien.MaPhong=Phong.MaPhong "
                +" and CTNhanVien.MaChuyenMon=ChuyenMon.MaChuyenMon and CTNhanVien.MaTrinhDo=TrinhDo.MaTrinhDo and NhanVien.MaCT=CTNhanVien.MaCT ";
                dt = new DataTable();
                dt = GetData(cmd);
            }
            catch (Exception)
            {
                MessageBox.Show("Lô~i");
            }
            finally
            {
                closeConnect();
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
                MessageBox.Show("S?a thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("S?a th?t b?i");
            }
            finally
            {
                closeConnect();
            }
        }
        //
        public int InsertDetail(BusinessLayer.NhanVienBsn nhanvien)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO " + this.tableName
                    + "(" + this.fieldList + ") VALUES ('"
                    + nhanvien.TeNV + "','" + nhanvien.Diachi + "','" + nhanvien.Ngaysinh.ToShortDateString() + "'," + Convert.ToInt32(nhanvien.Giotinh) + ",'" + nhanvien.Dienthoai + "'," + nhanvien.MaCV + "," + nhanvien.MaLuong + ",'" + nhanvien.SoBH + "',"+nhanvien.MaPhong+"," + nhanvien.MaCM + "," + nhanvien.MaTD + ")";
                dt = new DataTable();
                dt = GetData(cmd);
                cmd.CommandText = "select MaCT from " + this.tableName + " where DienThoai='" + nhanvien.Dienthoai+"' and SoBaoHiem='"+nhanvien.SoBH+"'";
                dt = GetData(cmd);
                int mnv = Convert.ToInt32(dt.Rows[0][0].ToString());
                
                return mnv;
                //conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("B? trùng khóa, thêm m?i chi tiêt th?t b?i", "Thông báo");
            }
            finally
            {
                closeConnect();
                // conn.Close();
            }
            return -1;
        }
        public void insert(BusinessLayer.NhanVienBsn nhanvien)
        {
            int mnv = InsertDetail(nhanvien);
            if (mnv > 0)
            {
                try
                {
                    cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO NhanVien (MaCT) values(" + mnv + ")";
                    dt = new DataTable();
                    dt = GetData(cmd);
                    MessageBox.Show("thêm m?i thành công", "Thông báo");
                }
                catch (Exception)
                {
                    MessageBox.Show("B? trùng khóa, thêm m?i th?t b?i", "Thông báo");
                }
                finally
                {
                    closeConnect();
                    // conn.Close();
                }
                
            }
        }
    }
}
