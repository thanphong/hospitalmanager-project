using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QUANLIBENHVIEN.BusinessLayer
{
    class NhaCungCapBsn
    {
        private int maNCC;
        private string tenNCC, diachi, sodt, sofax;
        DataLayer.NhaCungCapData nhacungcap = new DataLayer.NhaCungCapData();
        public NhaCungCapBsn()
        {
        }
        public NhaCungCapBsn(string tenNCC, string diachi, string sodt, string sofax)
        {
            this.tenNCC = tenNCC;
            this.diachi = diachi;
            this. sodt = sodt;
            this.sofax = sofax;
        }
        public int MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }
        public string TenNCC
        {
            get { return tenNCC; }
            set { tenNCC = value; }
        }
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string Sodt
        {
            get { return sodt; }
            set { sodt = value; }
        }
        public string Sofax
        {
            get { return sofax; }
            set { sofax = value; }
        }
        public DataTable Select()
        {
            nhacungcap.openConnect();
            return nhacungcap.Select();
        }
        public void Update()
        {
            nhacungcap.openConnect();
            nhacungcap.Update(this);
        }
        public void Insert()
        {
            nhacungcap.openConnect();
            nhacungcap.Insert(this);
        }
        public void Delete(int mcv)
        {
            nhacungcap.openConnect();
            nhacungcap.Delete(mcv);
        }
        public SqlDataAdapter GetDataAdapter()
        {
            return nhacungcap.GetDataAdapter();
        }
    }
}
