using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QUANLIBENHVIEN.BusinessLayer
{
    class CTPhongBsn
    {
        private int maCT, maP;
        DataLayer.CTPhongData ctphongdata = new DataLayer.CTPhongData();
        public CTPhongBsn()
        { }
        public CTPhongBsn(int maP)
        {
            this.maP = maP;
        }
        public int MaCT
        {
            get { return maCT; }
            set { maCT = value; }
        }
        public int MaP
        {
            get { return maP; }
            set { maP = value; }
         }
        public DataTable Select()
        {
            ctphongdata.openConnect();
            return ctphongdata.Select();
        }
        public void Update()
        {
            ctphongdata.openConnect();
            ctphongdata.Update(this);
        }
        public void Insert()
        {
            ctphongdata.openConnect();
            ctphongdata.Insert(this);
        }
        public void Delete(int mcv)
        {
            ctphongdata.openConnect();
            ctphongdata.Delete(mcv);
        }
        public SqlDataAdapter GetDataAdapter()
        {
            return ctphongdata.GetDataAdapter();
        }
    }
}
