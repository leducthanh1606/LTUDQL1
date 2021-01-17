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
    public partial class ViewPhanHeHS : Form
    {
<<<<<<< HEAD
        string mhv;
        public ViewPhanHeHS(string MaHV)
        {
            InitializeComponent();
            mhv = MaHV;
=======
        public ViewPhanHeHS()
        {
            InitializeComponent();
>>>>>>> 039aabb594da4f7bf48bbfa2abcdd34f8ed84fcb
        }

        private void btnLamBai_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            ViewHSThi thi = new ViewHSThi(mhv);
=======
            ViewHSThi thi = new ViewHSThi();
>>>>>>> 039aabb594da4f7bf48bbfa2abcdd34f8ed84fcb
            thi.Show();
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            ViewHSThongTin thongtin = new ViewHSThongTin(mhv);
=======
            ViewHSThongTin thongtin = new ViewHSThongTin();
>>>>>>> 039aabb594da4f7bf48bbfa2abcdd34f8ed84fcb
            thongtin.Show();
        }

        private void btnOnThi_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            ViewHSOnThi onthi = new ViewHSOnThi(mhv);
=======
            ViewHSOnThi onthi = new ViewHSOnThi();
>>>>>>> 039aabb594da4f7bf48bbfa2abcdd34f8ed84fcb
            onthi.Show();
        }

        private void btnDongGop_Click(object sender, EventArgs e)
        {
            ViewHSDongGop donggop = new ViewHSDongGop();
            donggop.Show();
        }
    }
}
