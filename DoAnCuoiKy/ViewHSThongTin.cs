using DoAnCuoiKy.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public partial class ViewHSThongTin : Form
    {
<<<<<<< HEAD
        string mhv;
        BindingSource bsCR;
        ReportDataSource rdsCR;
        public ViewHSThongTin(string MaHV)
        {
            mhv = MaHV;
=======
        BindingSource bsCR;
        ReportDataSource rdsCR;
        public ViewHSThongTin()
        {
>>>>>>> 039aabb594da4f7bf48bbfa2abcdd34f8ed84fcb
            InitializeComponent();
            LoadThongTin();
            bsCR = new BindingSource();
            rdsCR = new ReportDataSource();
        }

        private void LoadThongTin()
        {
            using (var db = new LTUDQL1DataContext())
            {
<<<<<<< HEAD
                var temp = db.USERs.SingleOrDefault(u => u.f_MaSo == mhv);
                if (temp != null)
                {
                    
=======
                var temp = db.USERs.SingleOrDefault(u => u.f_MaSo == "HV01");
                if (temp != null)
                {
                    //txtMaSo.Text = from hv in HocVien
                    //               where hv.Email = "tranthanhson299@gmail.com"
                    //               select hv.MaHV;
>>>>>>> 039aabb594da4f7bf48bbfa2abcdd34f8ed84fcb
                    txtMaSo.Text = temp.f_MaSo.ToString();
                    txtHoTen.Text = temp.f_HoTen.ToString();
                    //txtDiaChi.Text = temp.DiaChi.ToString();
                    txtEmail.Text = temp.f_Email.ToString();
<<<<<<< HEAD
                    txtSdt.Text = temp.f_Phone.ToString();
=======
                    //txtSdt.Text = temp.Sdt.ToString();
>>>>>>> 039aabb594da4f7bf48bbfa2abcdd34f8ed84fcb
                    txtNgaySinh.Text = temp.f_NgaySinh.ToString();
                    txtGioiTinh.Text = temp.f_GioiTinh.ToString();
                }
            }
        }

        private void ViewHSThongTin_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LTUDQL1DataContext updateHS = new LTUDQL1DataContext();
            USER hv = new USER();
<<<<<<< HEAD
            hv = updateHS.USERs.Where(u => u.f_MaSo == mhv).Single();
=======
            hv = updateHS.USERs.Where(u => u.f_MaSo == "HV01").Single();
>>>>>>> 039aabb594da4f7bf48bbfa2abcdd34f8ed84fcb
            hv.f_MaSo = txtMaSo.Text;
            //hv.DiaChi = txtDiaChi.Text;
            hv.f_Email = txtEmail.Text;
            hv.f_GioiTinh = txtGioiTinh.Text;
            hv.f_HoTen = txtHoTen.Text;
            hv.f_NgaySinh = txtNgaySinh.Text;
<<<<<<< HEAD
            hv.f_Phone = txtSdt.Text;
=======
            //hv.SoDT = txtSdt.Text;
>>>>>>> 039aabb594da4f7bf48bbfa2abcdd34f8ed84fcb

            updateHS.SubmitChanges();
            MessageBox.Show("Thêm Thành Công!!!");
            LoadThongTin();
            MessageBox.Show(hv.f_MaSo);
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            using (var db = new LTUDQL1DataContext())
            {
                bsCR.DataSource = from n in db.KyThis
<<<<<<< HEAD
                                  where n.MaHV == mhv
=======
                                  where n.MaHV == "HV01"
>>>>>>> 039aabb594da4f7bf48bbfa2abcdd34f8ed84fcb
                                  select new { MaKyThi = n.MaKT, NgayThi = n.Ngay, ThoiGianThi = n.ThoiGian };
            }
            rdsCR.Value = bsCR;
            rdsCR.Name = "DataSet1";
            reportViewer1.LocalReport.DataSources.Add(rdsCR);
        }
<<<<<<< HEAD
=======

       
>>>>>>> 039aabb594da4f7bf48bbfa2abcdd34f8ed84fcb
    }
}
