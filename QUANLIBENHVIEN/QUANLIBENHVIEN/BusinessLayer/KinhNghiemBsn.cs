using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QUANLIBENHVIEN.BusinessLayer
{
    class nhanvienBsn
    {
        private int maKN, maNV, maCM, maTD;
        private DateTime ngayBD, ngayKT;
        DataLayer.nhanvienData nhanviendata = new DataLayer.nhanvienData();
        public nhanvienBsn()
        { }
        public nhanvienBsn(int maKN, int maNV, int maCM, int maTD, DateTime ngayBD, DateTime ngayKT)
        {
            this.maKN = maKN;
            this.maNV = maNV;
            this.maCM = maCM;
            this.maTD = maTD;
            this.ngayBD = ngayBD;
            this.ngayKT = ngayKT;
        }
        public int MaKN
        {
            get { return maKN; }
            set { maKN = value; }
        }
        public int MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        public int MaCM
        {
            get { return maCM; }
            set { maCM = value; }
        }
        public int MaTD
        {
            get { return maTD; }
            set { maTD = value; }
        }
        public DateTime NgayBD
        {
            get { return ngayBD; }
            set { ngayBD = value; }
        }
        public DateTime NgayKT
        {
            get { return ngayKT; }
            set { ngayKT = value; }
        }

        /*public DataTable Select()
        {
            DataLayer. nhanviendata = new DataLayer.n();
            nhanviendata.openConnect();
            return nhanviendata.Select();
        }*/
/*<<<<<<< .mine

        public void Update()
        {
            DataLayer.nhanvienData nhanviendata = new DataLayer.nhanvienData();
            nhanviendata.openConnect();
            nhanviendata.Update(this);
        }
       public void Insert()
        {
            DataLayer.nhanvienData nhanviendata = new DataLayer.nhanvienData();
            nhanviendata.openConnect();
            nhanviendata.Insert(this);
        }
        public void Delete(int mcv)
        {
            DataLayer.nhanvienData nhanviendata = new DataLayer.nhanvienData();
            nhanviendata.openConnect();
            nhanviendata.Delete(mcv);
        }
        public SqlDataAdapter GetDataAdapter()
        {
            DataLayer.nhanvienData nhanviendata = new DataLayer.nhanvienData();
            return nhanviendata.GetDataAdapter();
        }
=======
        //public void Update()
        //{
        //    DataLayer.nhanvienData nhanviendata = new DataLayer.nhanvienData();
        //    nhanviendata.openConnect();
        //    nhanviendata.Update(this);
        //}
        //public void Insert()
        //{
        //    DataLayer.nhanvienData nhanviendata = new DataLayer.nhanvienData();
        //    nhanviendata.openConnect();
        //    nhanviendata.Insert(this);
        //}
        //public void Delete(int mcv)
        //{
        //    DataLayer.nhanvienData nhanviendata = new DataLayer.nhanvienData();
        //    nhanviendata.openConnect();
        //    nhanviendata.Delete(mcv);
        //}
        public SqlDataAdapter GetDataAdapter()
        {
            return nhanviendata.GetDataAdapter();
        }
>>>>>>> .r34*/
    }
}

