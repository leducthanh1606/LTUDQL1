﻿using DoAnCuoiKy.Model;
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
    public partial class ViewHSDongGop : Form
    {
        public ViewHSDongGop()
        {
            InitializeComponent();
        }
        private void btnDongGop_Click(object sender, EventArgs e)
        {
            LTUDQL1DataContext DongGop = new LTUDQL1DataContext();
            //DongGopCauHoi dg = new DongGopCauHoi();

            //dg.CauHoi = txtCauHoi.Text;
            //dg.DapAnA = txtDapAnA.Text;
            //dg.DapAnB = txtDapAnB.Text;
            //dg.DapAnB = txtDapAnC.Text;
            //dg.DapAnD = txtDapAnD.Text;
            //if (rbA.Checked == true)
            //{
            //    dg.DapAnDung = "A";
            //}
            //else if (rbB.Checked == true)
            //{
            //    dg.DapAnDung = "B";
            //}
            //else if (rbC.Checked == true)
            //{
            //    dg.DapAnDung = "C";
            //}
            //else if (rbD.Checked == true)
            //{
            //    dg.DapAnDung = "D";
            //}

            //DongGop.DongGopCauHois.InsertOnSubmit(dg);
            //DongGop.SubmitChanges();
            //MessageBox.Show("Thêm Thành Công!!!");
        }

       
    }
}
