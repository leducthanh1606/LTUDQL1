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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_qlchoi_Click(object sender, EventArgs e)
        {
            CauHoi cauhoi = new CauHoi();
            cauhoi.Show();
        }

        private void btn_qldthi_Click(object sender, EventArgs e)
        {
            DeThi dethi = new DeThi();
            dethi.Show();
        }

        private void btn_qlhsinh_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh();
            hs.Show();
        }

        private void btn_qlkthi_Click(object sender, EventArgs e)
        {
            KyThi kythi = new KyThi();
            kythi.Show();
        }

        private void btn_qltthu_Click(object sender, EventArgs e)
        {
            ThiThu thithu = new ThiThu();
            thithu.Show();
        }
    }
}
