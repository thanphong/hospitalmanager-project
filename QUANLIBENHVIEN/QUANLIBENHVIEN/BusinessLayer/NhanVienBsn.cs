using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QUANLIBENHVIEN.BusinessLayer
{
    class NhanVienBsn
    {

        int maNV, maCV, maLuong, maPhong, maCM, maTD;
        string tenNV, diachi, dienthoai, soBH;
        Boolean gioitinh;
        DateTime ngaysinh;
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

    //    public ChucVuBsn()
    //    {
    //    }
    //    public ChucVuBsn(int maCV)
    //    {
    //    }
    //    public ChucVuBsn(int maCV, string tenCV)
    //    {
    //        this.maCV = maCV;
    //        this.tenCV = tenCV;
    //    }

    //    public ChucVuBsn(string tenCV)
    //    {
    //        this.tenCV = tenCV;
    //    }
    //    public int MaCV
    //    {
    //        get { return maCV; }
    //        set { maCV = value; }
    //    }
    //    public String TenCV
    //    {
    //        get { return tenCV; }
    //        set { tenCV = value; }
    //    }
    //    public DataTable Select()
    //    {
    //        DataLayer.ChucVuData chucvudata = new DataLayer.ChucVuData();
    //        //chucvudata.connect();
    //        chucvudata.openConnect();
    //        return chucvudata.Select();
    //    }
    //    public void Update()
    //    {
    //        DataLayer.ChucVuData chucvudata = new DataLayer.ChucVuData();
    //        chucvudata.openConnect();
    //        chucvudata.Update(this);
    //    }
    //    public void Insert()
    //    {
    //        DataLayer.ChucVuData chucvudata = new DataLayer.ChucVuData();
    //        chucvudata.openConnect();
    //        chucvudata.Insert(this);
    //    }
    //    public void Delete(int  mcv)
    //    {
    //        DataLayer.ChucVuData chucvudata = new DataLayer.ChucVuData();
    //        chucvudata.openConnect();
    //        chucvudata.Delete(mcv);
    //    }
    }
}

