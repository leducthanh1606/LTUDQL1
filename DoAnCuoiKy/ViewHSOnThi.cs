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
    public partial class ViewHSOnThi : Form
    {
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
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ViewHSLamBaiOn lambai = new ViewHSLamBaiOn(cbDT.SelectedItem.ToString(), mhv);
            lambai.Show();
        }

      
    }
}
