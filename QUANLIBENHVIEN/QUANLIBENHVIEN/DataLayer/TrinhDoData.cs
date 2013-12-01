using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QUANLIBENHVIEN.DataLayer
{
    class TrinhDoData:Data
    {
        public TrinhDoData()
        {
            this.tableName = "TrinhDo";
            this.fieldList = "LoaiTrinhDo, TenToChuc, MaChuyenMon";
        }
  
        public DataTable Select()
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
          //      cmd.CommandText = "SELECT MaTrinhDo,TenChuyenMon,LoaiTrinhDo,TenToChuc FROM TrinhDo,ChuyenMon Where TrinhDo.MaChuyenMon=ChuyenMon.MaChuyenMon";
                cmd.CommandText = "SELECT * FROM TrinhDo";
                dt = GetData(cmd);
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
            finally
            {
                closeConnect();
            }
            return dt;
        }
        public void Update(BusinessLayer.TrinhDoBsn trinhdo)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE " + this.tableName
                    + " SET MaChuyenMon= '" + trinhdo.MaCM+"', LoaiTrinhDo= '"+trinhdo.LoaiTD+"' , TenToChuc ='"+trinhdo.TenTochuc+"' WHERE MaTrinhDo = '"
                    + trinhdo.MaTD+ "' ";
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
        public void Insert(BusinessLayer.TrinhDoBsn trinhdo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO " + this.tableName
                    + "(" + this.fieldList + ") values ( '"+trinhdo.LoaiTD+"','"+trinhdo.TenTochuc+"',"+trinhdo.MaCM+")";
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
            }
        }
        public void Delete(int ma)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM " + this.tableName
                    + " where MaTrinhDo ='" + ma + "'";
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
