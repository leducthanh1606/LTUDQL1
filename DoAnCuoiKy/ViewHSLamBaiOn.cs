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
    public partial class ViewHSLamBaiOn : Form
    {
        string[] KetQua = new string[10];
        string[] DapAn = new string[10];
        LTUDQL1DataContext LamBai = new LTUDQL1DataContext();
        List<CauHoi> ch = new List<CauHoi>();
        int stt = 0;
        string mdt;
        string mhv;
        public ViewHSLamBaiOn(string MaDT, string MaHV)
        {
            InitializeComponent();
            mdt = MaDT;
            mhv = MaHV;
            int temp = 0;
            foreach (var x in LamBai.DeThis)
            {
                if (x.MaDT.ToString().Trim() == mdt)
                {
                    foreach (var y in LamBai.CauHois)
                    {
                        if (y.MaCH == x.MaCH)
                        {
                            ch.Add(y);
                            DapAn[temp] = y.DapAnDung.ToString();
                            temp++;
                        }
                    }
                }

            }

            lbCauHoi.Text = ch[stt].NoiDung.ToString();
            rbA.Text = ch[stt].DapAnA.ToString();
            rbB.Text = ch[stt].DapAnB.ToString();
            rbC.Text = ch[stt].DapAnC.ToString();
            rbD.Text = ch[stt].DapAnD.ToString();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            lbDapAn.Text = "";
            if (rbA.Checked == true)
            {
                KetQua[stt] = "A";
            }
            else if (rbB.Checked == true)
            {
                KetQua[stt] = "B";
            }
            else if (rbC.Checked == true)
            {
                KetQua[stt] = "C";
            }
            else if (rbD.Checked == true)
            {
                KetQua[stt] = "D";
            }
            if (stt < KetQua.Count() - 1 && KetQua[stt + 1] != null)
            {
                if (KetQua[stt + 1] == "A")
                {
                    rbA.Checked = true;
                }
                else if (KetQua[stt + 1] == "B")
                {
                    rbB.Checked = true;
                }
                else if (KetQua[stt + 1] == "C")
                {
                    rbC.Checked = true;
                }
                else if (KetQua[stt + 1] == "D")
                {
                    rbD.Checked = true;
                }
            }
            if (stt < KetQua.Count() - 1 && KetQua[stt + 1] == null)
            {
                rbA.Checked = false;
                rbB.Checked = false;
                rbC.Checked = false;
                rbD.Checked = false;
            }
            if (stt >= 0 && stt < ch.Count() - 1)
            {
                lbCauHoi.Text = "";
                stt++;
                lbCauHoi.Text = ch[stt].NoiDung.ToString();
                rbA.Text = ch[stt].DapAnA.ToString();
                rbB.Text = ch[stt].DapAnB.ToString();
                rbC.Text = ch[stt].DapAnC.ToString();
                rbD.Text = ch[stt].DapAnD.ToString();
            }

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            lbDapAn.Text = "";
            if (rbA.Checked == true)
            {
                KetQua[stt] = "A";
            }
            else if (rbB.Checked == true)
            {
                KetQua[stt] = "B";
            }
            else if (rbC.Checked == true)
            {
                KetQua[stt] = "C";
            }
            else if (rbD.Checked == true)
            {
                KetQua[stt] = "D";
            }
            if (stt > 0 && KetQua[stt - 1] != null)
            {
                if (KetQua[stt - 1] == "A")
                {
                    rbA.Checked = true;
                }
                else if (KetQua[stt - 1] == "B")
                {
                    rbB.Checked = true;
                }
                else if (KetQua[stt - 1] == "C")
                {
                    rbC.Checked = true;
                }
                else if (KetQua[stt - 1] == "D")
                {
                    rbD.Checked = true;
                }
            }
            if (stt > 0 && KetQua[stt - 1] == null)
            {
                rbA.Checked = false;
                rbB.Checked = false;
                rbC.Checked = false;
                rbD.Checked = false;
            }

            if (stt < ch.Count() && stt > 0)
            {
                lbCauHoi.Text = "";
                stt--;
                lbCauHoi.Text = ch[stt].NoiDung.ToString();
                rbA.Text = ch[stt].DapAnA.ToString();
                rbB.Text = ch[stt].DapAnB.ToString();
                rbC.Text = ch[stt].DapAnC.ToString();
                rbD.Text = ch[stt].DapAnD.ToString();
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            lbDapAn.Text = "";
            if (rbA.Checked == true)
            {
                KetQua[stt] = "A";
            }
            else if (rbB.Checked == true)
            {
                KetQua[stt] = "B";
            }
            else if (rbC.Checked == true)
            {
                KetQua[stt] = "C";
            }
            else if (rbD.Checked == true)
            {
                KetQua[stt] = "D";
            }
            int diem = 0;
            for (int i = 0; i < ch.Count(); i++)
            {
                if (ch[i].DapAnDung.ToString().Trim() == KetQua[i])
                {
                    diem++;
                }
            }
            MessageBox.Show(diem.ToString() + "câu đúng.");
        }

        private void btnDapAn_Click(object sender, EventArgs e)
        {
            lbDapAn.Text = DapAn[stt];
        }
    }
}
