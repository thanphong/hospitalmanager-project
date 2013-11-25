using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QUANLIBENHVIEN.BusinessLayer
{
    class TrinhDoBsn
    {
        private int maTD,maCM;
        private string loaiTD, tenTochuc;
        public TrinhDoBsn() 
        { }
        public TrinhDoBsn(int maTD, int maCM, string loaiTD, string tenTochuc)
        {
            this.maTD = maTD;
            this.maCM = maCM;
            this.loaiTD = loaiTD;
            this.tenTochuc = tenTochuc;
        }
        //public TrinhDoBsn(int maCM, string loaiTD, string tenTochuc)
        //{
        //    this.maCM = maCM;
        //    this.loaiTD = loaiTD;
        //    this.tenTochuc = tenTochuc;
        //}
        public int MaTD
        {
            get { return maTD;}
            set { maTD = value;}
        }
        public int MaCM
        {
            get { return maCM;}
            set { maCM = value; }
        }
        public string LoaiTD
        {
            get { return loaiTD; }
            set { loaiTD = value; }
        }
        public string TenTochuc
        {
            get { return tenTochuc; }
            set { tenTochuc = value; }
        }
        public DataTable Select()
        {
            DataLayer.TrinhDoData trinhdodata = new DataLayer.TrinhDoData();
            trinhdodata.openConnect();
            return trinhdodata.Select();
        }
        public void Update()
        {
            DataLayer.TrinhDoData trinhdodata = new DataLayer.TrinhDoData();
            trinhdodata.openConnect();
            trinhdodata.Update(this);
        }
        public void Insert()
        {
            DataLayer.TrinhDoData trinhdodata = new DataLayer.TrinhDoData();
            trinhdodata.openConnect();
            trinhdodata.Insert(this);
        }
        public void Delete(int mcv)
        {
            DataLayer.TrinhDoData trinhdodata = new DataLayer.TrinhDoData();
            trinhdodata.openConnect();
            trinhdodata.Delete(mcv);
        }
        public SqlDataAdapter GetDataAdapter()
        {
            DataLayer.TrinhDoData trinhdodata = new DataLayer.TrinhDoData();
            return trinhdodata.GetDataAdapter();
        }
    }
}
