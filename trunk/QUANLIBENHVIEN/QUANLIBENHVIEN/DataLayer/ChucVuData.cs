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
    class ChucVuData:Data
    {
        Data data = new Data(); // Khởi tạo đối tượng connect

        public ChucVuData()
        {
            this.tableName = "ChucVu";
            this.fieldList = "MaCV,TenCV";
        }
        public DataTable SelectChucvu()
        {
            //DataSet ds = null;
            //try
            //{
            //    data.openConnect();
            //        //conn.Open();
            //    string command = "select " + this.fieldList + " from " + this.tableName;
            //    SqlDataAdapter dataAdapter = new SqlDataAdapter(command, con);
            //    ds = new DataSet();
            //    dataAdapter.Fill(ds, "ChucVu");
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Loi");
            //}
            //finally
            //{
            //   data.closeConnect();
            //     //       conn.Close();
            //}
            //return ds.Tables["ChucVu"];
            string sql = "SELECT * FROM ChucVu";
            DataTable dt = new DataTable();
            dt=data.get(sql);
            return dt;
        }
        public void UpdateChucvu(BusinessLayer.ChucVuBsn chucvu)
        {
            try{
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "update " + this.tableName
                    + " set TenCV = '" + chucvu.TenCV + "' where MaCV = '"
                    + chucvu.MaCV + "' ";
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
        public void Insert(BusinessLayer.ChucVuBsn chucvu)
        {
            try
            {
                    data.openConnect();
               // conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO" + this.tableName
                    + "(" + this.fieldList + ") values ('"
                    + chucvu.MaCV + "','" + chucvu.TenCV + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("thêm mới thành công", "Thông báo");
                       data.closeConnect();
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
    }
}
