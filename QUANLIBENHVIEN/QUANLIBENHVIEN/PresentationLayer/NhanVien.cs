using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace QUANLIBENHVIEN.PresentationLayer
{
    public partial class NhanVien : Form
    {
        BusinessLayer.NhanVienBsn nhanvien;
        BusinessLayer.TrinhDoBsn trinhdo;
        BusinessLayer.PhongBsn phong;
        BusinessLayer.ChuyenMonBsn chuyenmon;
        BusinessLayer.ChucVuBsn chucvu;
        BusinessLayer.LuongBns luong;
        Dictionary<string, int> gioitinh = new Dictionary<string, int>();
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        DataTable dt;
        
        public NhanVien()
        {
            InitializeComponent();
        }
        private void processControlsEnable(Control ctrl,Boolean en)
        {
            if ((ctrl.GetType() == typeof(TextBox) || ctrl.GetType() == typeof(ComboBox))&& (ctrl.Name.Equals("txtMaNV")==false))
            {
                ctrl.Enabled = en;
            }
            //xu ly cac dieu khien theo phuong phap de quy
            foreach (Control ctrlChild in ctrl.Controls)
            {
                processControlsEnable(ctrlChild,en);
            }
        }
        private void processControlsSetText(Control ctrl)
        {
            if ((ctrl.GetType() == typeof(TextBox) || ctrl.GetType() == typeof(ComboBox)))
            {
                ctrl.Text = ""; ;
            }
            //xu ly cac dieu khien theo phuong phap de quy
            foreach (Control ctrlChild in ctrl.Controls)
            {
                processControlsSetText(ctrlChild);
            }
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            gioitinh.Add("Nam",1);
            gioitinh.Add("Nữ", 0);
            nhanvien = new BusinessLayer.NhanVienBsn();
            dt = nhanvien.Select();
            processControlsEnable(this,false);
            fillDataControl(this);
            dgrvNhanvien.DataSource = dt.DefaultView;
            fillControls();
            this.Cursor = Cursors.Default;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            processControlsEnable(this, true);
            processControlsSetText(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDiachi.Text.Equals("") || txtSobaohiem.Text.Equals("") || txtSodt.Text.Equals("") || txtTenNV.Text.Equals(""))
            {
                MessageBox.Show("nhập đầy đủ thông tin");
            }
            else
            {
                nhanvien = new BusinessLayer.NhanVienBsn(Convert.ToInt32(cbbChucvu.SelectedValue), Convert.ToInt32(cbbMucluong.SelectedValue), Convert.ToInt32(cbbMaphong.SelectedValue), Convert.ToInt32(cmbChuyenMon.SelectedValue), Convert.ToInt32(cbbTrinhdo.SelectedValue), txtTenNV.Text.ToString(), txtDiachi.Text.ToString(), txtSodt.Text.ToString(), txtSobaohiem.Text.ToString(), Convert.ToBoolean(cbbGioitinh.SelectedValue), dTimePNgaysinh.Value.Date);
                nhanvien.Insert();
                dt = nhanvien.Select();
                dgrvNhanvien.DataSource = dt.DefaultView;
                processControlsEnable(this, false);
            }
            
        }
        
        //
        private void fillControls()
        {
           
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", dgrvNhanvien.DataSource, "MaNhanVien");
            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("Text", dgrvNhanvien.DataSource, "DiaChi");
            txtSobaohiem.DataBindings.Clear();
            txtSobaohiem.DataBindings.Add("Text", dgrvNhanvien.DataSource, "SoBaoHiem");
            txtSodt.DataBindings.Clear();
            txtSodt.DataBindings.Add("Text", dgrvNhanvien.DataSource, "DienThoai");
            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add("Text", dgrvNhanvien.DataSource, "Ten");
            dTimePNgaysinh.DataBindings.Clear();
            dTimePNgaysinh.DataBindings.Add("Value", dgrvNhanvien.DataSource, "NgaySinh");
            cmbChuyenMon.DataBindings.Clear();
            cmbChuyenMon.DataBindings.Add("Text", dgrvNhanvien.DataSource, "TenChuyenMon");
            cbbChucvu.DataBindings.Clear();
            cbbChucvu.DataBindings.Add("Text", dgrvNhanvien.DataSource, "TenCV");
            cbbMaphong.DataBindings.Clear();
            cbbMaphong.DataBindings.Add("Text", dgrvNhanvien.DataSource, "TenPhong");
            cbbMucluong.DataBindings.Clear();
            cbbMucluong.DataBindings.Add("Text", dgrvNhanvien.DataSource, "Luong");
            cbbTrinhdo.DataBindings.Clear();
            cbbTrinhdo.DataBindings.Add("Text", dgrvNhanvien.DataSource, "LoaiTrinhDo");
            cbbGioitinh.DataBindings.Add("Text", dgrvNhanvien.DataSource, "Gioitinh");
            
            
          
        }
        //
        public void fillDataControl(Control ctrl)
        {            
            foreach (Control ctrlChild in ctrl.Controls)
            {
                if (ctrlChild.Name.Equals("cbbChucvu"))
                {
                    chucvu = new BusinessLayer.ChucVuBsn();
                    da = chucvu.GetDataAdapter();
                    da.Fill(ds, "ChucVu");
                    cbbChucvu.DataSource = ds;
                    cbbChucvu.DisplayMember = "ChucVu.TenCV";
                    cbbChucvu.ValueMember = "ChucVu.MaCv";
                }
                if (ctrlChild.Name.Equals("cbbMucluong"))
                {
                    luong = new BusinessLayer.LuongBns();
                    da = luong.GetDataAdapter();
                    da.Fill(ds, "Luong");
                    cbbMucluong.DataSource = ds;
                    cbbMucluong.DisplayMember = "Luong.Luong";
                    cbbMucluong.ValueMember = "Luong.MaLuong";
                }
                if (ctrlChild.Name.Equals("cbbTrinhdo"))
                {
                    trinhdo = new BusinessLayer.TrinhDoBsn() ;
                    da = trinhdo.GetDataAdapter();
                    da.Fill(ds, "TrinhDo");
                    cbbTrinhdo.DataSource = ds;
                    cbbTrinhdo.DisplayMember = "TrinhDo.LoaiTrinhDo";
                    cbbTrinhdo.ValueMember = "TrinhDo.MaTrinhDo";
                }
                if (ctrlChild.Name.Equals("cmbChuyenMon"))
                {
                    chuyenmon = new BusinessLayer.ChuyenMonBsn() ;
                    da = chuyenmon.GetDataAdapter();
                    da.Fill(ds, "ChuyenMon");
                    cmbChuyenMon.DataSource = ds;
                    cmbChuyenMon.DisplayMember = "ChuyenMon.TenChuyenMon";
                    cmbChuyenMon.ValueMember = "ChuyenMon.MaChuyenMon";
                }
                if (ctrlChild.Name.Equals("cbbMaphong"))
                {
                    phong = new BusinessLayer.PhongBsn();
                    da = phong.GetDataAdapter();
                    da.Fill(ds, "Phong");
                    cbbMaphong.DataSource = ds;
                    cbbMaphong.DisplayMember = "Phong.TenPhong";
                    cbbMaphong.ValueMember = "Phong.MaPhong";
                }
                if (ctrlChild.Name.Equals("cbbGioitinh"))
                {
                    cbbGioitinh.DataSource = new BindingSource(gioitinh, null);
                    cbbGioitinh.DisplayMember = "key";
                    cbbGioitinh.ValueMember = "value";
                    
                    
                }
                fillDataControl(ctrlChild);
            }
        }

        private void dgrvNhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fillControls();
            //int Rcur=dgrvNhanvien.Rows.
        }
        
        
    }
}
