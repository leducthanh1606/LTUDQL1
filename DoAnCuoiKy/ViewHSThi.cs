using DoAnCuoiKy.Model;
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
    public partial class ViewHSThi : Form
    {
        string mhv;
        public ViewHSThi(string MaHV)
        {
            mhv = MaHV;
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            LTUDQL1DataContext KyThi = new LTUDQL1DataContext();
            var mkt = KyThi.KyThis.Select(u=>u.MaHV == mhv);
            ViewHSLamBai lambai = new ViewHSLamBai(mkt.First().ToString(), mhv);
            lambai.Show();
        }

    }
}
