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
            DataLayer.ChuyenMonData chuyenmondata = new DataLayer.ChuyenMonData();
            //chuyenmondata.connect();
            chuyenmondata.openConnect();
            return chuyenmondata.Select();
        }
        public void Update()
        {
            DataLayer.ChuyenMonData ChuyenMonData = new DataLayer.ChuyenMonData();
            ChuyenMonData.openConnect();
            ChuyenMonData.Update(this);
        }
        public void Insert()
        {
            DataLayer.ChuyenMonData ChuyenMonData = new DataLayer.ChuyenMonData();
            ChuyenMonData.openConnect();
            ChuyenMonData.Insert(this);
        }
        public void Delete(int  mcv)
        {
            DataLayer.ChuyenMonData ChuyenMonData = new DataLayer.ChuyenMonData();
            ChuyenMonData.openConnect();
            ChuyenMonData.Delete(mcv);
        }
        public SqlDataAdapter GetDataAdapter()
        {
            DataLayer.ChuyenMonData chuyenmondata = new DataLayer.ChuyenMonData();
            return chuyenmondata.GetDataAdapter();
        }
    }
}
