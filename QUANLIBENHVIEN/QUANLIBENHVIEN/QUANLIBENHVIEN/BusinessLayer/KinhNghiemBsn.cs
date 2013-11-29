using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QUANLIBENHVIEN.BusinessLayer
{
    class KinhNghiemBsn
    {
        private int maKN, maNV, maCM, maTD;
        private DateTime ngayBD, ngayKT;
        DataLayer.KinhNghiemData kinhnghiemdata = new DataLayer.KinhNghiemData();
        public KinhNghiemBsn()
        { }
        public KinhNghiemBsn(int maKN, int maNV, int maCM, int maTD, DateTime ngayBD, DateTime ngayKT)
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

        public DataTable Select()
        {
            DataLayer.KinhNghiemData kinhnghiemdata = new DataLayer.KinhNghiemData();
            kinhnghiemdata.openConnect();
            return kinhnghiemdata.Select();
        }
        //public void Update()
        //{
        //    DataLayer.KinhNghiemData kinhnghiemdata = new DataLayer.KinhNghiemData();
        //    kinhnghiemdata.openConnect();
        //    kinhnghiemdata.Update(this);
        //}
        //public void Insert()
        //{
        //    DataLayer.KinhNghiemData kinhnghiemdata = new DataLayer.KinhNghiemData();
        //    kinhnghiemdata.openConnect();
        //    kinhnghiemdata.Insert(this);
        //}
        //public void Delete(int mcv)
        //{
        //    DataLayer.KinhNghiemData kinhnghiemdata = new DataLayer.KinhNghiemData();
        //    kinhnghiemdata.openConnect();
        //    kinhnghiemdata.Delete(mcv);
        //}
        public SqlDataAdapter GetDataAdapter()
        {
            return kinhnghiemdata.GetDataAdapter();
        }
    }
}

