using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
 

namespace QUANLIBENHVIEN.BusinessLayer
{
    class LoaiVattuBsn
    {
private int maVT;
        private string tenVT;
        DataLayer.LoaivattuData loaivattu= new DataLayer.LoaivattuData();
        public LoaiVattuBsn() { }
        public LoaiVattuBsn(string tenVT)
        {
            this.tenVT= tenVT;
        }
        public int MaVT
        {
            get { return maVT; }
            set { maVT = value; }
        }
        public string TenVT
        {
            get { return tenVT; }
            set { tenVT = value; }
        }

        public DataTable Select()
        {
            loaivattu.openConnect();
            return loaivattu.Select();
        }
        public void Update()
        {
            loaivattu.openConnect();
            loaivattu.Update(this);
        }
        public void Insert()
        {
            loaivattu.openConnect();
            loaivattu.Insert(this);
        }
        public void Delete(int m)
        {
            loaivattu.openConnect();
            loaivattu.Delete(m);
        }
        public SqlDataAdapter GetDataAdapter()
        {
            return loaivattu.GetDataAdapter();
        }
    }
}

