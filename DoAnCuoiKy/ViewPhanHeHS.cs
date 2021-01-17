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
        string mhv;
        public ViewPhanHeHS(string MaHV)
        {
            InitializeComponent();
            mhv = MaHV;
        }

        private void btnLamBai_Click(object sender, EventArgs e)
        {
            ViewHSThi thi = new ViewHSThi(mhv);
            thi.Show();
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            ViewHSThongTin thongtin = new ViewHSThongTin(mhv);
            thongtin.Show();
        }

        private void btnOnThi_Click(object sender, EventArgs e)
        {
            ViewHSOnThi onthi = new ViewHSOnThi(mhv);
            onthi.Show();
        }

        private void btnDongGop_Click(object sender, EventArgs e)
        {
            ViewHSDongGop donggop = new ViewHSDongGop();
            donggop.Show();
        }
    }
}
