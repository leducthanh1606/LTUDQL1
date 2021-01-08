namespace DoAnCuoiKy
{
    partial class DeThi
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
            this.MaDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.txxMaDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaBD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaCH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.MaDT,
            this.MaDK,
            this.MaBD,
            this.MaCH});
            this.dgv_CauHoi.Location = new System.Drawing.Point(388, 12);
            this.dgv_CauHoi.Name = "dgv_CauHoi";
            this.dgv_CauHoi.ReadOnly = true;
            this.dgv_CauHoi.RowHeadersWidth = 51;
            this.dgv_CauHoi.RowTemplate.Height = 24;
            this.dgv_CauHoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CauHoi.Size = new System.Drawing.Size(747, 460);
            this.dgv_CauHoi.TabIndex = 1;
            // 
            // MaDT
            // 
            this.MaDT.HeaderText = "MaDT";
            this.MaDT.MinimumWidth = 6;
            this.MaDT.Name = "MaDT";
            this.MaDT.ReadOnly = true;
            // 
            // MaDK
            // 
            this.MaDK.HeaderText = "MaDK";
            this.MaDK.MinimumWidth = 6;
            this.MaDK.Name = "MaDK";
            this.MaDK.ReadOnly = true;
            // 
            // MaBD
            // 
            this.MaBD.HeaderText = "MaBD";
            this.MaBD.MinimumWidth = 6;
            this.MaBD.Name = "MaBD";
            this.MaBD.ReadOnly = true;
            // 
            // MaCH
            // 
            this.MaCH.HeaderText = "MaCH";
            this.MaCH.MaxInputLength = 52767;
            this.MaCH.MinimumWidth = 6;
            this.MaCH.Name = "MaCH";
            this.MaCH.ReadOnly = true;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(509, 512);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(110, 54);
            this.btn_them.TabIndex = 2;
            this.btn_them.Text = "Tạo Đề Thi";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(737, 512);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(110, 54);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xóa Đề Thi";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(976, 512);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(110, 54);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Sửa Đề Thi";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // txxMaDT
            // 
            this.txxMaDT.Location = new System.Drawing.Point(130, 71);
            this.txxMaDT.Name = "txxMaDT";
            this.txxMaDT.Size = new System.Drawing.Size(232, 22);
            this.txxMaDT.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(26, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Đề Tài";
            // 
            // txtMaDK
            // 
            this.txtMaDK.Location = new System.Drawing.Point(130, 170);
            this.txtMaDK.Name = "txtMaDK";
            this.txtMaDK.Size = new System.Drawing.Size(232, 22);
            this.txtMaDK.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(26, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã ĐK";
            // 
            // txtMaBD
            // 
            this.txtMaBD.Location = new System.Drawing.Point(130, 270);
            this.txtMaBD.Name = "txtMaBD";
            this.txtMaBD.Size = new System.Drawing.Size(232, 22);
            this.txtMaBD.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(26, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mã BD";
            // 
            // txtMaCH
            // 
            this.txtMaCH.Location = new System.Drawing.Point(130, 377);
            this.txtMaCH.Name = "txtMaCH";
            this.txtMaCH.Size = new System.Drawing.Size(232, 22);
            this.txtMaCH.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(26, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mã Câu Hỏi";
            // 
            // DeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 631);
            this.Controls.Add(this.txtMaCH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaBD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaDK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txxMaDT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv_CauHoi);
            this.Name = "DeThi";
            this.Text = "DeThi";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CauHoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_CauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCH;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.TextBox txxMaDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaBD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaCH;
        private System.Windows.Forms.Label label4;
    }
}