using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QUANLIBENHVIEN.BusinessLayer
{
    class PhongBsn
    {
        private int maP, tongGiuong,soGT;
        private string tenP,viTri;
        DataLayer.PhongData phongdata = new DataLayer.PhongData();
        public PhongBsn()
        {
        }
        public PhongBsn(string tenP, int tongGiuong,string viTri)
        {
            this.tenP = tenP;
            this.tongGiuong = tongGiuong;
            this.viTri = viTri;
        }
        public int MaP
        {
            get { return maP; }
            set { maP = value; }
        }
        public String TenP
        {
            get { return tenP; }
            set { tenP = value; }
        }
        public int TongGiuong
        {
            get { return tongGiuong; }
            set { tongGiuong = value; }
        }
        public int SoGT
        {
            get { return soGT; }
            set { soGT = value; }
        }
        public String Vitri
        {
            get { return viTri; }
            set { viTri = value; }
        }
        public DataTable Select()
        {
            phongdata.openConnect();
            return phongdata.Select();
        }
        public void Update()
        {
            phongdata.openConnect();
            phongdata.Update(this);
        }
        public void Insert()
        {
            phongdata.openConnect();
            phongdata.Insert(this);
        }
        public void Delete(int mcv)
        {
            phongdata.openConnect();
            phongdata.Delete(mcv);
        }
        public SqlDataAdapter GetDataAdapter()
        {            
            return phongdata.GetDataAdapter();
        }
    }
}
