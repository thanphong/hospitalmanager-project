using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QUANLIBENHVIEN.BusinessLayer
{
    class ChuyenMonBsn
    {
        private int maCM;
        private string tenCM;
        DataLayer.ChuyenMonData chuyenmondata = new DataLayer.ChuyenMonData();
        public ChuyenMonBsn()
        { }
        public ChuyenMonBsn(int maCM, string tenCM)
        {
            this.maCM = maCM;
            this.tenCM = tenCM;
        }
        public ChuyenMonBsn(string tenCM)
        {
            this.tenCM = tenCM;
        }
        public int MaCM
        {
            get { return maCM; }
            set { maCM = value; }
        }
        public String TenCM
        {
            get { return tenCM; }
            set { tenCM = value; }
        }
        public DataTable Select()
        {
            chuyenmondata.openConnect();
            return chuyenmondata.Select();
        }
        public void Update()
        {
            chuyenmondata.openConnect();
            chuyenmondata.Update(this);
        }
        public void Insert()
        {
            chuyenmondata.openConnect();
            chuyenmondata.Insert(this);
        }
        public void Delete(int  mcv)
        {
            chuyenmondata.openConnect();
            chuyenmondata.Delete(mcv);
        }
        public SqlDataAdapter GetDataAdapter()
        {
            return chuyenmondata.GetDataAdapter();
        }
    }
}
