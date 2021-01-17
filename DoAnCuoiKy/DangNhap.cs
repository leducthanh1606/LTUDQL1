using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DoAnCuoiKy;
using DoAnCuoiKy.Model;

namespace DoAnCuoiKy  
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void Btndangnhap_Click(object sender, EventArgs e)
        {
            var tendangnhap = txtUsername.Text;
            var matkhau = txtPassword.Text;

            using (var db = new LTUDQL1DataContext())
            {
                if (db.USERs.SingleOrDefault(u => u.f_TenDangNhap == tendangnhap && u.f_MatKhau == matkhau && u.f_IDPhanQuyen == 0)  != null)
                {
                    MessageBox.Show("LOGIN ADMIN");
                    ViewAdmin f = new ViewAdmin();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else if (db.USERs.SingleOrDefault(u => u.f_TenDangNhap == tendangnhap && u.f_MatKhau == matkhau && u.f_IDPhanQuyen == 2) != null)
                {
                    MessageBox.Show("LOGIN GIÁO VIÊN");
                    ViewGiaoVien f = new ViewGiaoVien();
                    this.Hide();
                    f.ShowDialog();
                }
                else if (db.USERs.SingleOrDefault(u => u.f_TenDangNhap == tendangnhap && u.f_MatKhau == matkhau && u.f_IDPhanQuyen == 1) != null)
                {
                    MessageBox.Show("LOGIN HỌC SINH");
<<<<<<< HEAD
                    ViewPhanHeHS f = new ViewPhanHeHS((db.USERs.SingleOrDefault(u => u.f_TenDangNhap == tendangnhap && u.f_MatKhau == matkhau && u.f_IDPhanQuyen == 1).f_MaSo).ToString());
=======
                    ViewPhanHeHS f = new ViewPhanHeHS();
>>>>>>> 039aabb594da4f7bf48bbfa2abcdd34f8ed84fcb
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }

            }


        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }
        private void dangky_Click(object sender, EventArgs e)
        {
            
            new DangKy().Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }

        }
    }
}
