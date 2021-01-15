
namespace DoAnCuoiKy
{
    partial class ViewHSLamBai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDapAn = new System.Windows.Forms.GroupBox();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.lbCauHoi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.gbDapAn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDapAn
            // 
            this.gbDapAn.Controls.Add(this.rbB);
            this.gbDapAn.Controls.Add(this.rbA);
            this.gbDapAn.Controls.Add(this.rbC);
            this.gbDapAn.Controls.Add(this.rbD);
            this.gbDapAn.Location = new System.Drawing.Point(69, 240);
            this.gbDapAn.Name = "gbDapAn";
            this.gbDapAn.Size = new System.Drawing.Size(776, 243);
            this.gbDapAn.TabIndex = 12;
            this.gbDapAn.TabStop = false;
            this.gbDapAn.Text = "Đáp án";
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(21, 82);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(17, 16);
            this.rbB.TabIndex = 3;
            this.rbB.TabStop = true;
            this.rbB.UseVisualStyleBackColor = true;
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(21, 30);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(17, 16);
            this.rbA.TabIndex = 2;
            this.rbA.TabStop = true;
            this.rbA.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(21, 131);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(17, 16);
            this.rbC.TabIndex = 4;
            this.rbC.TabStop = true;
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Location = new System.Drawing.Point(21, 185);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(17, 16);
            this.rbD.TabIndex = 5;
            this.rbD.TabStop = true;
            this.rbD.UseVisualStyleBackColor = true;
            // 
            // lbCauHoi
            // 
            this.lbCauHoi.AutoSize = true;
            this.lbCauHoi.Location = new System.Drawing.Point(18, 12);
            this.lbCauHoi.Name = "lbCauHoi";
            this.lbCauHoi.Size = new System.Drawing.Size(0, 17);
            this.lbCauHoi.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lbCauHoi);
            this.panel1.Location = new System.Drawing.Point(69, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 177);
            this.panel1.TabIndex = 9;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(505, 489);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(214, 43);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(177, 489);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(214, 43);
            this.btnPrev.TabIndex = 10;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // ViewHSLamBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 588);
            this.Controls.Add(this.gbDapAn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Name = "ViewHSLamBai";
            this.Text = "ViewHSLamBai";
            this.gbDapAn.ResumeLayout(false);
            this.gbDapAn.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDapAn;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.Label lbCauHoi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
    }
}