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
                var temp = db.HocViens.SingleOrDefault(u => u.MaHV == "HV01");
                if (temp != null)
                {
                    //txtMaSo.Text = from hv in HocVien
                    //               where hv.Email = "tranthanhson299@gmail.com"
                    //               select hv.MaHV;
                    txtMaSo.Text = temp.MaHV.ToString();
                    txtHoTen.Text = temp.HoTen.ToString();
                    txtDiaChi.Text = temp.DiaChi.ToString();
                    txtEmail.Text = temp.Email.ToString();
                    txtSdt.Text = temp.Sdt.ToString();
                    txtNgaySinh.Text = temp.NgaySinh.ToString();
                    txtGioiTinh.Text = temp.GioiTinh.ToString();
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
            HocVien hv = new HocVien();
            hv = updateHS.HocViens.Where(u => u.MaHV == "HV01").Single();
            hv.MaHV = txtMaSo.Text;
            hv.DiaChi = txtDiaChi.Text;
            hv.Email = txtEmail.Text;
            hv.GioiTinh = txtGioiTinh.Text;
            hv.HoTen = txtHoTen.Text;
            hv.NgaySinh = txtNgaySinh.Text;
            hv.Sdt = txtSdt.Text;

            updateHS.SubmitChanges();
            MessageBox.Show("Thêm Thành Công!!!");
            LoadThongTin();
            MessageBox.Show(hv.HoTen);
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
