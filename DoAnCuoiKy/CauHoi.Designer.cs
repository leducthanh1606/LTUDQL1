namespace DoAnCuoiKy
{
    partial class CauHoi
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
            this.dgv_CauHoi = new System.Windows.Forms.DataGridView();
            this.MaCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaCH = new System.Windows.Forms.TextBox();
            this.txtCaphoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtND = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CauHoi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_CauHoi
            // 
            this.dgv_CauHoi.AllowUserToAddRows = false;
            this.dgv_CauHoi.AllowUserToDeleteRows = false;
            this.dgv_CauHoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CauHoi.ColumnHeadersHeight = 29;
            this.dgv_CauHoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCH,
            this.CapHoc,
            this.MonHoc,
            this.NoiDung,
            this.DapAn});
            this.dgv_CauHoi.Location = new System.Drawing.Point(12, 3);
            this.dgv_CauHoi.Name = "dgv_CauHoi";
            this.dgv_CauHoi.ReadOnly = true;
            this.dgv_CauHoi.RowHeadersWidth = 51;
            this.dgv_CauHoi.RowTemplate.Height = 24;
            this.dgv_CauHoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CauHoi.Size = new System.Drawing.Size(794, 540);
            this.dgv_CauHoi.TabIndex = 0;
            // 
            // MaCH
            // 
            this.MaCH.HeaderText = "MaCH";
            this.MaCH.MinimumWidth = 6;
            this.MaCH.Name = "MaCH";
            this.MaCH.ReadOnly = true;
            // 
            // CapHoc
            // 
            this.CapHoc.HeaderText = "CapHoc";
            this.CapHoc.MinimumWidth = 6;
            this.CapHoc.Name = "CapHoc";
            this.CapHoc.ReadOnly = true;
            // 
            // MonHoc
            // 
            this.MonHoc.HeaderText = "MonHoc";
            this.MonHoc.MinimumWidth = 6;
            this.MonHoc.Name = "MonHoc";
            this.MonHoc.ReadOnly = true;
            // 
            // NoiDung
            // 
            this.NoiDung.HeaderText = "NoiDung";
            this.NoiDung.MaxInputLength = 52767;
            this.NoiDung.MinimumWidth = 6;
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.ReadOnly = true;
            // 
            // DapAn
            // 
            this.DapAn.HeaderText = "DapAn";
            this.DapAn.MinimumWidth = 6;
            this.DapAn.Name = "DapAn";
            this.DapAn.ReadOnly = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(921, 511);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(169, 32);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa Câu Hỏi";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(824, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Câu Hỏi";
            // 
            // txtMaCH
            // 
            this.txtMaCH.Location = new System.Drawing.Point(928, 45);
            this.txtMaCH.Name = "txtMaCH";
            this.txtMaCH.Size = new System.Drawing.Size(232, 22);
            this.txtMaCH.TabIndex = 3;
            // 
            // txtCaphoc
            // 
            this.txtCaphoc.Location = new System.Drawing.Point(928, 99);
            this.txtCaphoc.Name = "txtCaphoc";
            this.txtCaphoc.Size = new System.Drawing.Size(232, 22);
            this.txtCaphoc.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(824, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cấp Học";
            // 
            // txtMH
            // 
            this.txtMH.Location = new System.Drawing.Point(928, 158);
            this.txtMH.Name = "txtMH";
            this.txtMH.Size = new System.Drawing.Size(232, 22);
            this.txtMH.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(824, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Môn Học";
            // 
            // txtND
            // 
            this.txtND.Location = new System.Drawing.Point(928, 224);
            this.txtND.Name = "txtND";
            this.txtND.Size = new System.Drawing.Size(232, 22);
            this.txtND.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(812, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nội dung câu hỏi";
            // 
            // txtDA
            // 
            this.txtDA.Location = new System.Drawing.Point(928, 403);
            this.txtDA.Name = "txtDA";
            this.txtDA.Size = new System.Drawing.Size(232, 22);
            this.txtDA.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(824, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Đáp Án";
            // 
            // CauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 555);
            this.Controls.Add(this.txtDA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtND);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCaphoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaCH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.dgv_CauHoi);
            this.Name = "CauHoi";
            this.Text = "CauHoi";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CauHoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_CauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapAn;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaCH;
        private System.Windows.Forms.TextBox txtCaphoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtND;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDA;
        private System.Windows.Forms.Label label5;
    }
}