namespace DoAnCuoiKy
{
    partial class ViewCauHoi
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_CauHoi = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtND = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCaphoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaCH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.txtDAA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDAB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDAC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDAD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CauHoi)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1171, 555);
            this.splitContainer1.SplitterDistance = 768;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_CauHoi);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 555);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Câu Hỏi";
            // 
            // dgv_CauHoi
            // 
            this.dgv_CauHoi.AllowUserToAddRows = false;
            this.dgv_CauHoi.AllowUserToDeleteRows = false;
            this.dgv_CauHoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CauHoi.ColumnHeadersHeight = 29;
            this.dgv_CauHoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_CauHoi.Location = new System.Drawing.Point(3, 18);
            this.dgv_CauHoi.Name = "dgv_CauHoi";
            this.dgv_CauHoi.ReadOnly = true;
            this.dgv_CauHoi.RowHeadersWidth = 51;
            this.dgv_CauHoi.RowTemplate.Height = 24;
            this.dgv_CauHoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CauHoi.Size = new System.Drawing.Size(762, 534);
            this.dgv_CauHoi.TabIndex = 13;
            this.dgv_CauHoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CauHoi_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDAD);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtDAC);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDAB);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDAA);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDA);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtND);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMH);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtCaphoc);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMaCH);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_Sua);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 555);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết";
            // 
            // txtDA
            // 
            this.txtDA.Location = new System.Drawing.Point(141, 472);
            this.txtDA.Name = "txtDA";
            this.txtDA.Size = new System.Drawing.Size(232, 22);
            this.txtDA.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(37, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Đáp Án Đúng";
            // 
            // txtND
            // 
            this.txtND.Location = new System.Drawing.Point(141, 201);
            this.txtND.Name = "txtND";
            this.txtND.Size = new System.Drawing.Size(232, 22);
            this.txtND.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(25, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Nội dung câu hỏi";
            // 
            // txtMH
            // 
            this.txtMH.Location = new System.Drawing.Point(142, 142);
            this.txtMH.Name = "txtMH";
            this.txtMH.Size = new System.Drawing.Size(232, 22);
            this.txtMH.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(38, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Môn Học";
            // 
            // txtCaphoc
            // 
            this.txtCaphoc.Location = new System.Drawing.Point(141, 81);
            this.txtCaphoc.Name = "txtCaphoc";
            this.txtCaphoc.Size = new System.Drawing.Size(232, 22);
            this.txtCaphoc.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(40, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Cấp Học";
            // 
            // txtMaCH
            // 
            this.txtMaCH.Location = new System.Drawing.Point(142, 28);
            this.txtMaCH.Name = "txtMaCH";
            this.txtMaCH.Size = new System.Drawing.Size(232, 22);
            this.txtMaCH.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã Câu Hỏi";
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(142, 511);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(169, 32);
            this.btn_Sua.TabIndex = 24;
            this.btn_Sua.Text = "Sửa Câu Hỏi";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // txtDAA
            // 
            this.txtDAA.Location = new System.Drawing.Point(141, 266);
            this.txtDAA.Name = "txtDAA";
            this.txtDAA.Size = new System.Drawing.Size(232, 22);
            this.txtDAA.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(37, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Đáp Án A";
            // 
            // txtDAB
            // 
            this.txtDAB.Location = new System.Drawing.Point(141, 320);
            this.txtDAB.Name = "txtDAB";
            this.txtDAB.Size = new System.Drawing.Size(232, 22);
            this.txtDAB.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(37, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Đáp Án B";
            // 
            // txtDAC
            // 
            this.txtDAC.Location = new System.Drawing.Point(141, 376);
            this.txtDAC.Name = "txtDAC";
            this.txtDAC.Size = new System.Drawing.Size(232, 22);
            this.txtDAC.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(37, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "Đáp Án C";
            // 
            // txtDAD
            // 
            this.txtDAD.Location = new System.Drawing.Point(141, 425);
            this.txtDAD.Name = "txtDAD";
            this.txtDAD.Size = new System.Drawing.Size(232, 22);
            this.txtDAD.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Location = new System.Drawing.Point(37, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 41;
            this.label9.Text = "Đáp Án D";
            // 
            // CauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 555);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CauHoi";
            this.Text = "CauHoi";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CauHoi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_CauHoi;
        private System.Windows.Forms.TextBox txtDA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtND;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCaphoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaCH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.TextBox txtDAD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDAC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDAB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDAA;
        private System.Windows.Forms.Label label6;
    }
}