using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QUANLIBENHVIEN.BusinessLayer
{
    class LoaiThuocBsn
    {
        private int maLT;
        private string tenLT;
        DataLayer.LoaiThuocData loaithuocdata = new DataLayer.LoaiThuocData();
        public LoaiThuocBsn() { }
        public LoaiThuocBsn(string tenLT)
        {
            this.tenLT = tenLT;
        }
        public int MaLT
        {
            get { return maLT; }
            set { maLT = value; }
        }
        public string TenLT
        {
            get { return tenLT; }
            set { tenLT = value; }
        }

        public DataTable Select()
        {
            loaithuocdata.openConnect();
            return loaithuocdata.Select();
        }
        public void Update()
        {
            loaithuocdata.openConnect();
            loaithuocdata.Update(this);
        }
        public void Insert()
        {
            loaithuocdata.openConnect();
            loaithuocdata.Insert(this);
        }
        public void Delete(int m)
        {
            loaithuocdata.openConnect();
            loaithuocdata.Delete(m);
        }
        public SqlDataAdapter GetDataAdapter()
        {
            return loaithuocdata.GetDataAdapter();
        }
    }
}
