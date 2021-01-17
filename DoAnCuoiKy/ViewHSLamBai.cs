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
    public partial class ViewHSLamBai : Form
    {
        LTUDQL1DataContext LamBai = new LTUDQL1DataContext();
        List<CauHoi> ch = new List<CauHoi>();
        int stt = 0;
        public ViewHSLamBai()
        {
            //ch.Add((from kt in LamBai.KyThis
            //         join dt in LamBai.DeThis on kt.MaDT equals dt.MaDT
            //         join choi in LamBai.CauHois on dt.MaCH equals choi.MaCH
            //         select new { choi }).Single());

            InitializeComponent();

            //CauHoi a = new CauHoi();
            //IQueryable < CauHoi > b = (from kt in LamBai.KyThis
            //    join dt in LamBai.DeThis on kt.MaDT equals dt.MaDT
            //    join choi in LamBai.CauHois on dt.MaDT equals choi.MaCH
            //    select new CauHoi { CapHoc = choi.CapHoc, MonHoc = choi.MonHoc, MaCH = choi.MaCH, NoiDung = choi.NoiDung, DapAnA = choi.DapAnA, DapAnB = choi.DapAnB, DapAnC = choi.DapAnC, DapAnD = choi.DapAnD, DapAnDung = choi.DapAnDung });

            //ch.Add(b.Single());
            ch.Add(LamBai.CauHois.Where(u => u.MaCH == "CH01").Single());
            ch.Add(LamBai.CauHois.Where(u => u.MaCH == "CH04").Single());
            ch.Add(LamBai.CauHois.Where(u => u.MaCH == "CH05").Single());

            lbCauHoi.Text = ch[stt].NoiDung.ToString();
            rbA.Text = ch[stt].DapAnA;
            rbB.Text = ch[stt].DapAnB;
            rbC.Text = ch[stt].DapAnC;
            rbD.Text = ch[stt].DapAnD;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            lbCauHoi.Text = "";
            if (stt >= 0)
            {
                stt++;
                lbCauHoi.Text = ch[stt].NoiDung;
                rbA.Text = ch[stt].DapAnA;
                rbB.Text = ch[stt].DapAnB;
                rbC.Text = ch[stt].DapAnC;
                rbD.Text = ch[stt].DapAnD;
            }

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            lbCauHoi.Text = "";
            if (stt < ch.Count())
            {
                stt--;
                lbCauHoi.Text = ch[stt].NoiDung;
                rbA.Text = ch[stt].DapAnA;
                rbB.Text = ch[stt].DapAnB;
                rbC.Text = ch[stt].DapAnC;
                rbD.Text = ch[stt].DapAnD;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {

        }
    }
}
