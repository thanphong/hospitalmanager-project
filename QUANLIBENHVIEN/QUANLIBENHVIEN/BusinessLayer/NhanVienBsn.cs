using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QUANLIBENHVIEN.BusinessLayer
{
    class NhanVienBsn
    {
        int maNV, maCV, maLuong, maPhong, maCM, maTD;
        string tenNV, diachi, dienthoai, soBH;
        Boolean gioitinh;
        DateTime ngaysinh;
        DataLayer.NhanVienData nhanvien=new DataLayer.NhanVienData();
        public NhanVienBsn()
        {
        }
        public NhanVienBsn(int macv,int maLuong,int maPhong,int maCM,int maTD,string tenNV,string diachi,string dienthoai,string soBH,Boolean gioitinh,DateTime ngaysinh)
        {
            this.maCV = macv;
            this.maLuong = maLuong;
            this.maPhong = maPhong;
            this.maCM = maCM;
            this.maTD = maTD;
            this.tenNV = tenNV;
            this.diachi = diachi;
            this.dienthoai = dienthoai;
            this.soBH = soBH;
            this.gioitinh = gioitinh;
            this.ngaysinh = ngaysinh;

        }
        public int MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        public int MaCV
        {
            get { return maCV; }
            set { maCV = value; }
        }
        public int MaLuong
        {
            get { return maLuong; }
            set { maLuong = value; }
        }
        public int MaPhong
        {
            get { return maPhong; }
            set { maPhong = value; }
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
        public string TeNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }
        public Boolean Giotinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        public DateTime Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string Dienthoai
        {
            get { return dienthoai; }
            set { dienthoai = value; }
        }
        public string SoBH
        {
            get { return soBH; }
            set { soBH = value; }
        }
        //
        public DataTable Select()
        {
            nhanvien.openConnect();
            return nhanvien.Select();
        }

        public void Update()
        {
            nhanvien.openConnect();
            nhanvien.Update(this);
        }
        public void Insert()
        {
            nhanvien.openConnect();
            nhanvien.insert(this);
        }
       /* public void Delete(int mcv)
        {
            nhanvien.openConnect();
            nhanvien.Delete(mcv);
        }*/
        public SqlDataAdapter GetDataAdapter()
        {
            return nhanvien.GetDataAdapter();
        }
   
    }
}

