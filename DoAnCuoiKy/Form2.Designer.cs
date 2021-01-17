
namespace DoAnCuoiKy
{
    partial class Form2
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
            this.btnDongGop = new System.Windows.Forms.Button();
            this.btnOnThi = new System.Windows.Forms.Button();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.btnLamBai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDongGop
            // 
            this.btnDongGop.Location = new System.Drawing.Point(465, 262);
            this.btnDongGop.Name = "btnDongGop";
            this.btnDongGop.Size = new System.Drawing.Size(234, 106);
            this.btnDongGop.TabIndex = 11;
            this.btnDongGop.Text = "Đóng góp câu hỏi";
            this.btnDongGop.UseVisualStyleBackColor = true;
            this.btnDongGop.Click += new System.EventHandler(this.btnDongGop_Click);
            // 
            // btnOnThi
            // 
            this.btnOnThi.Location = new System.Drawing.Point(102, 262);
            this.btnOnThi.Name = "btnOnThi";
            this.btnOnThi.Size = new System.Drawing.Size(234, 106);
            this.btnOnThi.TabIndex = 10;
            this.btnOnThi.Text = "Ôn luyện thi thử";
            this.btnOnThi.UseVisualStyleBackColor = true;
            this.btnOnThi.Click += new System.EventHandler(this.btnOnThi_Click);
            // 
            // btnThongTin
            // 
            this.btnThongTin.Location = new System.Drawing.Point(465, 83);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(234, 106);
            this.btnThongTin.TabIndex = 9;
            this.btnThongTin.Text = "Thông tin cá nhân";
            this.btnThongTin.UseVisualStyleBackColor = true;
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // btnLamBai
            // 
            this.btnLamBai.Location = new System.Drawing.Point(102, 83);
            this.btnLamBai.Name = "btnLamBai";
            this.btnLamBai.Size = new System.Drawing.Size(234, 106);
            this.btnLamBai.TabIndex = 8;
            this.btnLamBai.Text = "Làm bài trắc nghiệm";
            this.btnLamBai.UseVisualStyleBackColor = true;
            this.btnLamBai.Click += new System.EventHandler(this.btnLamBai_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDongGop);
            this.Controls.Add(this.btnOnThi);
            this.Controls.Add(this.btnThongTin);
            this.Controls.Add(this.btnLamBai);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDongGop;
        private System.Windows.Forms.Button btnOnThi;
        private System.Windows.Forms.Button btnThongTin;
        private System.Windows.Forms.Button btnLamBai;
    }
}