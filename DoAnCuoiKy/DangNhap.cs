﻿using System;
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
                if (db.USERs.SingleOrDefault(u => u.f_TenDangNhap == tendangnhap && u.f_MatKhau == matkhau) != null)
                {
                    MessageBox.Show("LOGIN");
                    Form1 f = new Form1();
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