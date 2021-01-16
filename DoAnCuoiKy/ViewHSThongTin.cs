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
        BindingSource bsCR;
        ReportDataSource rdsCR;
        public ViewHSThongTin()
        {
            InitializeComponent();
            LoadThongTin();
            bsCR = new BindingSource();
            rdsCR = new ReportDataSource();
        }

        private void LoadThongTin()
        {
            using (var db = new LTUDQL1DataContext())
            {
                var temp = db.USERs.SingleOrDefault(u => u.f_MaSo == "HV01");
                if (temp != null)
                {
                    //txtMaSo.Text = from hv in HocVien
                    //               where hv.Email = "tranthanhson299@gmail.com"
                    //               select hv.MaHV;
                    txtMaSo.Text = temp.f_MaSo.ToString();
                    txtHoTen.Text = temp.f_HoTen.ToString();
                    //txtDiaChi.Text = temp.DiaChi.ToString();
                    txtEmail.Text = temp.f_Email.ToString();
                    //txtSdt.Text = temp.Sdt.ToString();
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
            hv = updateHS.USERs.Where(u => u.f_MaSo == "HV01").Single();
            hv.f_MaSo = txtMaSo.Text;
            //hv.DiaChi = txtDiaChi.Text;
            hv.f_Email = txtEmail.Text;
            hv.f_GioiTinh = txtGioiTinh.Text;
            hv.f_HoTen = txtHoTen.Text;
            hv.f_NgaySinh = txtNgaySinh.Text;
            //hv.SoDT = txtSdt.Text;

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
                                  where n.MaHV == "HV01"
                                  select new { MaKyThi = n.MaKT, NgayThi = n.Ngay, ThoiGianThi = n.ThoiGian };
            }
            rdsCR.Value = bsCR;
            rdsCR.Name = "DataSet1";
            reportViewer1.LocalReport.DataSources.Add(rdsCR);
        }

       
    }
}
