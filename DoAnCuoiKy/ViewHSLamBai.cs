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
<<<<<<< HEAD
        string[] KetQua = new string[10];
        LTUDQL1DataContext LamBai = new LTUDQL1DataContext();
        List<CauHoi> ch = new List<CauHoi>();
        int stt = 0;
        string mkt;
        string mhv;
        public ViewHSLamBai(string MaKT, string MaHV)
        {
            InitializeComponent();
            DemNguoc.Start();
            mkt = MaKT;
            mhv = MaHV;
            var mdt = LamBai.KyThis.SingleOrDefault(u=> u.MaHV == mhv);
            foreach (var x in LamBai.DeThis)
            {
                if (x.MaDT.ToString().Trim() == mdt.MaDT.ToString().Trim())
                {
                    foreach (var y in LamBai.CauHois)
                    {
                        if (y.MaCH == x.MaCH)
                        {
                            ch.Add(y);
                        }
                    }
                }

            } 

            lbCauHoi.Text = ch[stt].NoiDung.ToString();
            rbA.Text = ch[stt].DapAnA.ToString();
            rbB.Text = ch[stt].DapAnB.ToString();
            rbC.Text = ch[stt].DapAnC.ToString();
            rbD.Text = ch[stt].DapAnD.ToString();
            
=======
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
>>>>>>> 039aabb594da4f7bf48bbfa2abcdd34f8ed84fcb
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
               
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
=======
            lbCauHoi.Text = "";
            if (stt >= 0)
            {
                stt++;
                lbCauHoi.Text = ch[stt].NoiDung;
                rbA.Text = ch[stt].DapAnA;
                rbB.Text = ch[stt].DapAnB;
                rbC.Text = ch[stt].DapAnC;
                rbD.Text = ch[stt].DapAnD;
>>>>>>> 039aabb594da4f7bf48bbfa2abcdd34f8ed84fcb
            }

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            
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
=======
            lbCauHoi.Text = "";
            if (stt < ch.Count())
            {
                stt--;
                lbCauHoi.Text = ch[stt].NoiDung;
                rbA.Text = ch[stt].DapAnA;
                rbB.Text = ch[stt].DapAnB;
                rbC.Text = ch[stt].DapAnC;
                rbD.Text = ch[stt].DapAnD;
>>>>>>> 039aabb594da4f7bf48bbfa2abcdd34f8ed84fcb
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            KetThucBaiThi();
        }

        private void KetThucBaiThi()
        {
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
            MessageBox.Show(diem.ToString() + "điểm.");

            LTUDQL1DataContext themKQ = new LTUDQL1DataContext();
            KetQua kt = new KetQua();
            kt.MaKT = mkt;
            kt.MaHV = mhv;
            kt.Diem = diem.ToString();

            themKQ.KetQuas.InsertOnSubmit(kt);
            themKQ.SubmitChanges();
        }

        int gio = 0;
        int phut = 60;
        int giay = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            string ThoiGian = gio.ToString() + ":" + phut.ToString() + ":" + giay.ToString();
            DongHo.Text = ThoiGian.ToString();
            if (gio > 0)
            {

                if (phut > 0)
                {
                    if (giay > 0)
                    {
                        giay--;
                    }
                    else
                    {
                        giay = 59;
                        phut--;
                    }
                }
                else
                {
                    phut = 59;
                    gio--;
                }

            }
            else
                if (gio == 0)
            {
                if (phut > 0)
                {
                    if (giay > 0)
                    {
                        giay--;
                    }
                    else
                    {
                        giay = 59;
                        phut--;
                    }
                }
                else
                {
                    giay--;
                }

            }

            if (gio == 0 && phut == 0 && giay == -1)
            {
                DemNguoc.Stop();
                KetThucBaiThi();
                MessageBox.Show("Hết giờ làm bài!!!");
                
            }
=======
>>>>>>> 039aabb594da4f7bf48bbfa2abcdd34f8ed84fcb

        }
    }
}
