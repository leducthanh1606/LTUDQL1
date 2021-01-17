<<<<<<< HEAD
﻿using DoAnCuoiKy.Model;
using System;
=======
﻿using System;
>>>>>>> 039aabb594da4f7bf48bbfa2abcdd34f8ed84fcb
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
    public partial class ViewHSOnThi : Form
    {
<<<<<<< HEAD
        string mhv;
        public ViewHSOnThi(string MaHV)
        {
            InitializeComponent();
            mhv = MaHV;
            
            LTUDQL1DataContext ChonDT = new LTUDQL1DataContext();
            DeThi dt = new DeThi();


            List<string> mdthi = new List<string>();
            foreach(var i in ChonDT.DeThis)
            {
                mdthi.Add(i.MaDT);
            }
            IEnumerable<string> temp = mdthi.Distinct();
            List<string> md = new List<string>();
            foreach (var i in temp)
            {
                md.Add(i.Trim());
            }    

            cbDT.DataSource = md;
=======
        public ViewHSOnThi()
        {
            InitializeComponent();
>>>>>>> 039aabb594da4f7bf48bbfa2abcdd34f8ed84fcb
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            ViewHSLamBaiOn lambai = new ViewHSLamBaiOn(cbDT.SelectedItem.ToString(), mhv);
=======
            ViewHSLamBai lambai = new ViewHSLamBai();
>>>>>>> 039aabb594da4f7bf48bbfa2abcdd34f8ed84fcb
            lambai.Show();
        }

      
    }
}
