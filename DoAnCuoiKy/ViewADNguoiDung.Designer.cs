namespace DoAnCuoiKy
{
    partial class ViewADNguoiDung
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_NguoiDung = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.cbbSheet = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnBrowes = new System.Windows.Forms.Button();
            this.txtfilename = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIDPhanQuyen = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtMaSo = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.fMaSoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fGioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNgaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fTenDangNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fMatKhauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIDPhanQuyenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new DoAnCuoiKy.AppData();
            this.uSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSERTableAdapter = new DoAnCuoiKy.AppDataTableAdapters.USERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NguoiDung)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.importUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(1286, 733);
            this.splitContainer1.SplitterDistance = 689;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_NguoiDung);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(689, 733);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Người Dùng";
            // 
            // dgv_NguoiDung
            // 
            this.dgv_NguoiDung.AutoGenerateColumns = false;
            this.dgv_NguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NguoiDung.ColumnHeadersHeight = 29;
            this.dgv_NguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fMaSoDataGridViewTextBoxColumn,
            this.fEmailDataGridViewTextBoxColumn,
            this.fGioiTinhDataGridViewTextBoxColumn,
            this.fNgaySinhDataGridViewTextBoxColumn,
            this.fPhoneDataGridViewTextBoxColumn,
            this.fTenDangNhapDataGridViewTextBoxColumn,
            this.fMatKhauDataGridViewTextBoxColumn,
            this.fIDPhanQuyenDataGridViewTextBoxColumn});
            this.dgv_NguoiDung.DataSource = this.uSERBindingSource;
            this.dgv_NguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_NguoiDung.Location = new System.Drawing.Point(4, 24);
            this.dgv_NguoiDung.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_NguoiDung.Name = "dgv_NguoiDung";
            this.dgv_NguoiDung.RowHeadersWidth = 51;
            this.dgv_NguoiDung.RowTemplate.Height = 24;
            this.dgv_NguoiDung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_NguoiDung.Size = new System.Drawing.Size(681, 705);
            this.dgv_NguoiDung.TabIndex = 61;
            this.dgv_NguoiDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NguoiDung_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExport);
            this.groupBox3.Controls.Add(this.btnImport);
            this.groupBox3.Controls.Add(this.cbbSheet);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btnBrowes);
            this.groupBox3.Controls.Add(this.txtfilename);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtIDPhanQuyen);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtMatKhau);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtTenDangNhap);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtPhone);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtGioiTinh);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.txtNgaySinh);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txtMaSo);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.txtHoTen);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(591, 733);
            this.groupBox3.TabIndex = 99;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin người dùng";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(419, 657);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(92, 31);
            this.btnExport.TabIndex = 99;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(312, 657);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(84, 32);
            this.btnImport.TabIndex = 98;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click_1);
            // 
            // cbbSheet
            // 
            this.cbbSheet.FormattingEnabled = true;
            this.cbbSheet.Location = new System.Drawing.Point(165, 660);
            this.cbbSheet.Name = "cbbSheet";
            this.cbbSheet.Size = new System.Drawing.Size(121, 28);
            this.cbbSheet.TabIndex = 97;
            this.cbbSheet.SelectedIndexChanged += new System.EventHandler(this.cbbSheet_SelectedIndexChanged_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.Location = new System.Drawing.Point(18, 667);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 20);
            this.label12.TabIndex = 96;
            this.label12.Text = "Sheet";
            // 
            // btnBrowes
            // 
            this.btnBrowes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnBrowes.ForeColor = System.Drawing.Color.White;
            this.btnBrowes.Location = new System.Drawing.Point(491, 620);
            this.btnBrowes.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowes.Name = "btnBrowes";
            this.btnBrowes.Size = new System.Drawing.Size(79, 27);
            this.btnBrowes.TabIndex = 95;
            this.btnBrowes.Text = "...";
            this.btnBrowes.UseVisualStyleBackColor = false;
            this.btnBrowes.Click += new System.EventHandler(this.btnBrowes_Click_1);
            // 
            // txtfilename
            // 
            this.txtfilename.Location = new System.Drawing.Point(165, 620);
            this.txtfilename.Margin = new System.Windows.Forms.Padding(4);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.ReadOnly = true;
            this.txtfilename.Size = new System.Drawing.Size(318, 27);
            this.txtfilename.TabIndex = 94;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label13.Location = new System.Drawing.Point(18, 626);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 20);
            this.label13.TabIndex = 93;
            this.label13.Text = "File Name";
            // 
            // txtIDPhanQuyen
            // 
            this.txtIDPhanQuyen.Location = new System.Drawing.Point(228, 497);
            this.txtIDPhanQuyen.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDPhanQuyen.Name = "txtIDPhanQuyen";
            this.txtIDPhanQuyen.Size = new System.Drawing.Size(318, 27);
            this.txtIDPhanQuyen.TabIndex = 92;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label14.Location = new System.Drawing.Point(85, 501);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 20);
            this.label14.TabIndex = 91;
            this.label14.Text = "Phân Quyền";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(232, 415);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(318, 27);
            this.txtMatKhau.TabIndex = 90;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label15.Location = new System.Drawing.Point(85, 421);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 20);
            this.label15.TabIndex = 89;
            this.label15.Text = "Mật Khẩu";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(232, 360);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(318, 27);
            this.txtTenDangNhap.TabIndex = 88;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label16.Location = new System.Drawing.Point(89, 364);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(138, 20);
            this.label16.TabIndex = 87;
            this.label16.Text = "Tên Đăng Nhập";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(232, 302);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(318, 27);
            this.txtPhone.TabIndex = 86;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label17.Location = new System.Drawing.Point(89, 306);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 20);
            this.label17.TabIndex = 85;
            this.label17.Text = "Phone";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(231, 186);
            this.txtGioiTinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(318, 27);
            this.txtGioiTinh.TabIndex = 84;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label18.Location = new System.Drawing.Point(88, 190);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 20);
            this.label18.TabIndex = 83;
            this.label18.Text = "Giới Tính";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(419, 544);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(151, 68);
            this.btnSua.TabIndex = 82;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(226, 544);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(151, 68);
            this.btnXoa.TabIndex = 81;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(35, 544);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(151, 68);
            this.btnThem.TabIndex = 80;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(231, 243);
            this.txtNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(318, 27);
            this.txtNgaySinh.TabIndex = 79;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label19.Location = new System.Drawing.Point(88, 247);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 20);
            this.label19.TabIndex = 78;
            this.label19.Text = "Ngày Sinh";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(231, 126);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(318, 27);
            this.txtEmail.TabIndex = 77;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label20.Location = new System.Drawing.Point(88, 130);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 20);
            this.label20.TabIndex = 76;
            this.label20.Text = "Email";
            // 
            // txtMaSo
            // 
            this.txtMaSo.Location = new System.Drawing.Point(231, 66);
            this.txtMaSo.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSo.Name = "txtMaSo";
            this.txtMaSo.ReadOnly = true;
            this.txtMaSo.Size = new System.Drawing.Size(318, 27);
            this.txtMaSo.TabIndex = 75;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label21.Location = new System.Drawing.Point(88, 69);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 20);
            this.label21.TabIndex = 74;
            this.label21.Text = "Mã Số";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(231, 17);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(318, 27);
            this.txtHoTen.TabIndex = 73;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label22.Location = new System.Drawing.Point(88, 21);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(76, 20);
            this.label22.TabIndex = 72;
            this.label22.Text = "Họ Tên ";
            // 
            // fMaSoDataGridViewTextBoxColumn
            // 
            this.fMaSoDataGridViewTextBoxColumn.DataPropertyName = "f_MaSo";
            this.fMaSoDataGridViewTextBoxColumn.HeaderText = "f_MaSo";
            this.fMaSoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fMaSoDataGridViewTextBoxColumn.Name = "fMaSoDataGridViewTextBoxColumn";
            // 
            // fEmailDataGridViewTextBoxColumn
            // 
            this.fEmailDataGridViewTextBoxColumn.DataPropertyName = "f_Email";
            this.fEmailDataGridViewTextBoxColumn.HeaderText = "f_Email";
            this.fEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fEmailDataGridViewTextBoxColumn.Name = "fEmailDataGridViewTextBoxColumn";
            // 
            // fGioiTinhDataGridViewTextBoxColumn
            // 
            this.fGioiTinhDataGridViewTextBoxColumn.DataPropertyName = "f_GioiTinh";
            this.fGioiTinhDataGridViewTextBoxColumn.HeaderText = "f_GioiTinh";
            this.fGioiTinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fGioiTinhDataGridViewTextBoxColumn.Name = "fGioiTinhDataGridViewTextBoxColumn";
            // 
            // fNgaySinhDataGridViewTextBoxColumn
            // 
            this.fNgaySinhDataGridViewTextBoxColumn.DataPropertyName = "f_NgaySinh";
            this.fNgaySinhDataGridViewTextBoxColumn.HeaderText = "f_NgaySinh";
            this.fNgaySinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fNgaySinhDataGridViewTextBoxColumn.Name = "fNgaySinhDataGridViewTextBoxColumn";
            // 
            // fPhoneDataGridViewTextBoxColumn
            // 
            this.fPhoneDataGridViewTextBoxColumn.DataPropertyName = "f_Phone";
            this.fPhoneDataGridViewTextBoxColumn.HeaderText = "f_Phone";
            this.fPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fPhoneDataGridViewTextBoxColumn.Name = "fPhoneDataGridViewTextBoxColumn";
            // 
            // fTenDangNhapDataGridViewTextBoxColumn
            // 
            this.fTenDangNhapDataGridViewTextBoxColumn.DataPropertyName = "f_TenDangNhap";
            this.fTenDangNhapDataGridViewTextBoxColumn.HeaderText = "f_TenDangNhap";
            this.fTenDangNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fTenDangNhapDataGridViewTextBoxColumn.Name = "fTenDangNhapDataGridViewTextBoxColumn";
            // 
            // fMatKhauDataGridViewTextBoxColumn
            // 
            this.fMatKhauDataGridViewTextBoxColumn.DataPropertyName = "f_MatKhau";
            this.fMatKhauDataGridViewTextBoxColumn.HeaderText = "f_MatKhau";
            this.fMatKhauDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fMatKhauDataGridViewTextBoxColumn.Name = "fMatKhauDataGridViewTextBoxColumn";
            // 
            // fIDPhanQuyenDataGridViewTextBoxColumn
            // 
            this.fIDPhanQuyenDataGridViewTextBoxColumn.DataPropertyName = "f_IDPhanQuyen";
            this.fIDPhanQuyenDataGridViewTextBoxColumn.HeaderText = "f_IDPhanQuyen";
            this.fIDPhanQuyenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fIDPhanQuyenDataGridViewTextBoxColumn.Name = "fIDPhanQuyenDataGridViewTextBoxColumn";
            // 
            // importUserBindingSource
            // 
            this.importUserBindingSource.DataSource = typeof(DoAnCuoiKy.Model.ImportUser);
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSERBindingSource
            // 
            this.uSERBindingSource.DataMember = "USER";
            this.uSERBindingSource.DataSource = this.appData;
            // 
            // uSERTableAdapter
            // 
            this.uSERTableAdapter.ClearBeforeFill = true;
            // 
            // ViewADNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 733);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewADNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KyThi";
            this.Load += new System.EventHandler(this.ViewADNguoiDung_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NguoiDung)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.importUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_NguoiDung;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.ComboBox cbbSheet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnBrowes;
        private System.Windows.Forms.TextBox txtfilename;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIDPhanQuyen;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtMaSo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridViewTextBoxColumn fHotenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fMaSoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fGioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNgaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fTenDangNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fMatKhauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIDPhanQuyenDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource importUserBindingSource;
        private AppData appData;
        private System.Windows.Forms.BindingSource uSERBindingSource;
        private AppDataTableAdapters.USERTableAdapter uSERTableAdapter;
    }
}