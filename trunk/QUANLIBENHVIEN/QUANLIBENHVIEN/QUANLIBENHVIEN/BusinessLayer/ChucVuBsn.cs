using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QUANLIBENHVIEN.BusinessLayer
{
    class ChucVuBsn
    {
        private int maCV;
        private string tenCV;
        DataLayer.ChucVuData chucvudata = new DataLayer.ChucVuData();
        public ChucVuBsn()
        {
        }
        public ChucVuBsn(int maCV)
        {
        }
        public ChucVuBsn(int maCV, string tenCV)
        {
            this.maCV = maCV;
            this.tenCV = tenCV;
        }

        public ChucVuBsn(string tenCV)
        {
            this.tenCV = tenCV;
        }
        public int MaCV
        {
            get { return maCV; }
            set { maCV = value; }
        }
        public String TenCV
        {
            get { return tenCV; }
            set { tenCV = value; }
        }
        public DataTable Select()
        {
            chucvudata.openConnect();
            return chucvudata.Select();
        }
        public void Update()
        {
            chucvudata.openConnect();
            chucvudata.Update(this);
        }
        public void Insert()
        {
            chucvudata.openConnect();
            chucvudata.Insert(this);
        }
        public void Delete(int  mcv)
        {
            chucvudata.openConnect();
            chucvudata.Delete(mcv);
        }
        public SqlDataAdapter GetDataAdapter()
        {
            return chucvudata.GetDataAdapter();
        }
    }
}
