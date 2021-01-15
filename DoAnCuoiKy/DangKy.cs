using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCuoiKy.Model;

namespace DoAnCuoiKy
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            var hoten = txtHoTen.Text;
            var maso = txtMaSo.Text;
            var email = txtEmail.Text;
            var ngaysinh = datengaysinh.Text;
            var gioitinh = cbbGioiTinh.Text;
            var phone = txtPhone.Text;
            var tendangnhap = txttendangnhap.Text;
            var matkhau = txtmatkhau.Text;

            using (var db = new LTUDQL1DataContext())
            {
                if (db.USERs.SingleOrDefault(u => u.f_TenDangNhap == tendangnhap) != null)
                {
                    MessageBox.Show("Lỗi!");
                    return;
                }
                db.USERs.InsertOnSubmit(new USER
                {
                    f_HoTen = hoten,
                    f_MaSo = maso,
                    f_Email = email,
                    f_GioiTinh = gioitinh,
                    f_MatKhau = matkhau,
                    f_NgaySinh = ngaysinh,
                    f_Phone = phone,
                    f_TenDangNhap = tendangnhap
                });
                db.SubmitChanges();
                MessageBox.Show("Đăng ký thành công!");
            }

            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên!");
                txtHoTen.Focus();
            }
            else if (txtMaSo.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã số!");
                txtMaSo.Focus();
            }
            else if (cbbGioiTinh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn giới tính!");
                cbbGioiTinh.Focus();
            }
            else if (datengaysinh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn ngày sinh!");
                datengaysinh.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Email!");
                txtEmail.Focus();
            }
            else if (txtPhone.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Phone!");
                txtPhone.Focus();
            }
            else if (txttendangnhap.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!");
                txttendangnhap.Focus();
            }
            else if (txtmatkhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!");
                txtmatkhau.Focus();
            }
            else if (txtxacnhanmatkhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập xác nhận mật khẩu!");
                txtxacnhanmatkhau.Focus();
            }
            else if (txtxacnhanmatkhau.Text != txtmatkhau.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng!");
                txtxacnhanmatkhau.Focus();
                txtxacnhanmatkhau.SelectAll();
            }

        }

        private void Exit_Click(object sender, EventArgs e)
        {

            new DangNhap().ShowDialog();
            this.Hide();
        }
    }
}
