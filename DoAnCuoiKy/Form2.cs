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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLamBai_Click(object sender, EventArgs e)
        {
            ViewHSThi thi = new ViewHSThi();
            thi.Show();
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            ViewHSThongTin thongtin = new ViewHSThongTin();
            thongtin.Show();
        }

        private void btnOnThi_Click(object sender, EventArgs e)
        {
            ViewHSOnThi onthi = new ViewHSOnThi();
            onthi.Show();
        }

        private void btnDongGop_Click(object sender, EventArgs e)
        {
            ViewHSDongGop donggop = new ViewHSDongGop();
            donggop.Show();
        }
    }
}
