using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QUANLIBENHVIEN.BusinessLayer
{
    class LuongBns
    {
        private int maLuong;
        private float mucLuong;
        public LuongBns()
        {
        }
        public LuongBns(int maLuong, float mucLuong)
        {
            this.maLuong = maLuong;
            this.mucLuong = mucLuong;
        }
        public int MaLuong
        {
            get { return maLuong;}
            set {
                try
                {
                    maLuong = Convert.ToInt16(value.ToString());
                }
                catch (Exception)
                {

                    throw new Exception("loi");
                }
                }
        }
        public float MucLuong
        {
            get {return mucLuong;}
            set {
                
                    mucLuong = value;
            }
        }
        
        //
        public DataTable Select()
        {
            DataLayer.LuongData LuongData = new DataLayer.LuongData();
            LuongData.openConnect();
            return LuongData.Select();
        }
        public void Update()
        {
            DataLayer.LuongData LuongData = new DataLayer.LuongData();
            LuongData.openConnect();
            LuongData.Update(this);
        }
        public void Insert()
        {
            DataLayer.LuongData LuongData = new DataLayer.LuongData();
            LuongData.openConnect();
            LuongData.Insert(this);
        }
        public void Delete(int mcv)
        {
            DataLayer.LuongData LuongData = new DataLayer.LuongData();
            LuongData.openConnect();
            LuongData.Delete(this);
        }
        public SqlDataAdapter GetDataAdapter()
        {
            DataLayer.LuongData LuongData = new DataLayer.LuongData();
            return LuongData.GetDataAdapter();
        }
    }
}
