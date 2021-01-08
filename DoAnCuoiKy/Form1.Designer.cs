namespace DoAnCuoiKy
{
    partial class Form1
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
            this.btn_qlchoi = new System.Windows.Forms.Button();
            this.btn_qldthi = new System.Windows.Forms.Button();
            this.btn_qlhsinh = new System.Windows.Forms.Button();
            this.btn_qlkthi = new System.Windows.Forms.Button();
            this.btn_qltthu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_qlchoi
            // 
            this.btn_qlchoi.Location = new System.Drawing.Point(78, 77);
            this.btn_qlchoi.Name = "btn_qlchoi";
            this.btn_qlchoi.Size = new System.Drawing.Size(215, 94);
            this.btn_qlchoi.TabIndex = 0;
            this.btn_qlchoi.Text = "Quản Lý Câu Hỏi";
            this.btn_qlchoi.UseVisualStyleBackColor = true;
            this.btn_qlchoi.Click += new System.EventHandler(this.btn_qlchoi_Click);
            // 
            // btn_qldthi
            // 
            this.btn_qldthi.Location = new System.Drawing.Point(78, 339);
            this.btn_qldthi.Name = "btn_qldthi";
            this.btn_qldthi.Size = new System.Drawing.Size(215, 94);
            this.btn_qldthi.TabIndex = 1;
            this.btn_qldthi.Text = "Quản Lý Đề Thi";
            this.btn_qldthi.UseVisualStyleBackColor = true;
            this.btn_qldthi.Click += new System.EventHandler(this.btn_qldthi_Click);
            // 
            // btn_qlhsinh
            // 
            this.btn_qlhsinh.Location = new System.Drawing.Point(383, 210);
            this.btn_qlhsinh.Name = "btn_qlhsinh";
            this.btn_qlhsinh.Size = new System.Drawing.Size(215, 94);
            this.btn_qlhsinh.TabIndex = 2;
            this.btn_qlhsinh.Text = "Quản Lý Học Sinh";
            this.btn_qlhsinh.UseVisualStyleBackColor = true;
            this.btn_qlhsinh.Click += new System.EventHandler(this.btn_qlhsinh_Click);
            // 
            // btn_qlkthi
            // 
            this.btn_qlkthi.Location = new System.Drawing.Point(674, 77);
            this.btn_qlkthi.Name = "btn_qlkthi";
            this.btn_qlkthi.Size = new System.Drawing.Size(215, 94);
            this.btn_qlkthi.TabIndex = 3;
            this.btn_qlkthi.Text = "Quản Lý Kỳ Thi";
            this.btn_qlkthi.UseVisualStyleBackColor = true;
            this.btn_qlkthi.Click += new System.EventHandler(this.btn_qlkthi_Click);
            // 
            // btn_qltthu
            // 
            this.btn_qltthu.Location = new System.Drawing.Point(674, 339);
            this.btn_qltthu.Name = "btn_qltthu";
            this.btn_qltthu.Size = new System.Drawing.Size(215, 94);
            this.btn_qltthu.TabIndex = 4;
            this.btn_qltthu.Text = "Quản Lý Kỳ Thi Thử, Ôn Tập";
            this.btn_qltthu.UseVisualStyleBackColor = true;
            this.btn_qltthu.Click += new System.EventHandler(this.btn_qltthu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 514);
            this.Controls.Add(this.btn_qltthu);
            this.Controls.Add(this.btn_qlkthi);
            this.Controls.Add(this.btn_qlhsinh);
            this.Controls.Add(this.btn_qldthi);
            this.Controls.Add(this.btn_qlchoi);
            this.Name = "Form1";
            this.Text = "Phân Hệ Giáo Viên";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_qlchoi;
        private System.Windows.Forms.Button btn_qldthi;
        private System.Windows.Forms.Button btn_qlhsinh;
        private System.Windows.Forms.Button btn_qlkthi;
        private System.Windows.Forms.Button btn_qltthu;
    }
}

