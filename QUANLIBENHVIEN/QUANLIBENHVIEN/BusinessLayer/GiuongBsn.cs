using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QUANLIBENHVIEN.BusinessLayer
{
    class GiuongBsn
    {
        private int maG, maP;
        DataLayer.GiuongData giuongdata=new DataLayer.GiuongData();
        public GiuongBsn()
        { }
        public GiuongBsn(int maG, int maP)
        {
            this.maG = maG;
            this.maP = maP;
        }
        public int MaG
        {
            get { return maG; }
            set { maG = value; }
        }
        public int MaP
        {
            get { return maP; }
            set { maP = value; }
        }
        public DataTable Select()
        {
            giuongdata.openConnect();
            return giuongdata.Select();
        }
        public void Update()
        {
            giuongdata.openConnect();
            giuongdata.Update(this);
        }
        public void Insert()
        {
            giuongdata.openConnect();
            giuongdata.Insert(this);
        }
        public void Delete(int mcv)
        {
            giuongdata.openConnect();
            giuongdata.Delete(mcv);
        }
        public SqlDataAdapter GetDataAdapter()
        {
            return giuongdata.GetDataAdapter();
        }
    }
}