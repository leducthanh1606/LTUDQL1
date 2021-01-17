using DoAnCuoiKy.Model;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Z.Dapper.Plus;

namespace DoAnCuoiKy
{
    public partial class ViewADNguoiDung : Form
    {

        public ViewADNguoiDung()
        {
            InitializeComponent();

            LoadData();

        }
        private void LoadData()
        {
            using (var db = new LTUDQL1DataContext())
            {
                dgv_NguoiDung.DataSource = db.USERs.Select(u => u);
            }
        }

        private void dgv_NguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_NguoiDung.SelectedRows.Count == 0)
            {
                return;
            }
            var dgvr = dgv_NguoiDung.SelectedRows[0];
            txtHoTen.Text = dgvr.Cells["f_HoTen"].Value as string;
            txtMaSo.Text = dgvr.Cells["f_MaSo"].Value as string;
            txtEmail.Text = dgvr.Cells["f_Email"].Value as string;
            txtGioiTinh.Text = dgvr.Cells["f_GioiTinh"].Value as string;
            txtNgaySinh.Text = dgvr.Cells["f_NgaySinh"].Value as string;
            txtPhone.Text = dgvr.Cells["f_Phone"].Value as string;
            txtTenDangNhap.Text = dgvr.Cells["f_TenDangNhap"].Value as string;
            txtMatKhau.Text = dgvr.Cells["f_MatKhau"].Value as string;
            txtIDPhanQuyen.Text = dgvr.Cells["f_IDPhanQuyen"].Value.ToString();
        }

        private void btnThem_Click(object sender, System.EventArgs e)
        {
            LTUDQL1DataContext themnd = new LTUDQL1DataContext();
            USER us = new USER();
            us.f_HoTen = txtHoTen.Text;
            us.f_MaSo = txtMaSo.Text;
            us.f_Email = txtEmail.Text;
            us.f_GioiTinh = txtGioiTinh.Text;
            us.f_NgaySinh = txtNgaySinh.Text;
            us.f_Phone = txtPhone.Text;
            us.f_TenDangNhap = txtTenDangNhap.Text;
            us.f_MatKhau = txtMatKhau.Text;
            us.f_IDPhanQuyen = int.Parse(txtIDPhanQuyen.Text.ToString());
            if (us.f_HoTen == "" && us.f_TenDangNhap == "" && us.f_MaSo == "" && us.f_Email == "" && us.f_NgaySinh == "" && us.f_MatKhau == "")
            {
                MessageBox.Show("Không được bỏ trống !!!");
                return;
            }
            else
            {
                themnd.USERs.InsertOnSubmit(us);
                themnd.SubmitChanges();
                MessageBox.Show("Tạo thành công người Dùng!!!");
                LoadData();
            }
            CleanTextBox();

        }
        private void CleanTextBox()
        {
            txtHoTen.Text = "";
            txtEmail.Text = "";
            txtMaSo.Text = "";
            txtNgaySinh.Text = "";
            txtGioiTinh.Text = "";
            txtPhone.Text = "";
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            txtIDPhanQuyen.Text = "";
        }

        private void btnSua_Click(object sender, System.EventArgs e)
        {
            LTUDQL1DataContext sua = new LTUDQL1DataContext();
            USER us = new USER();
            us = sua.USERs.Where(u => u.f_MaSo == txtMaSo.Text).Single();
            us.f_HoTen = txtHoTen.Text;
            us.f_Email = txtEmail.Text;
            us.f_GioiTinh = txtGioiTinh.Text;
            us.f_NgaySinh = txtNgaySinh.Text;
            us.f_Phone = txtPhone.Text;
            us.f_TenDangNhap = txtTenDangNhap.Text;
            us.f_MatKhau = txtMatKhau.Text;
            us.f_IDPhanQuyen =int.Parse( txtIDPhanQuyen.Text.ToString());

            sua.SubmitChanges();
            MessageBox.Show("UpDate thành công!!!");
            LoadData();
            CleanTextBox();
        }

        private void btnXoa_Click(object sender, System.EventArgs e)
        {
            LTUDQL1DataContext xoa = new LTUDQL1DataContext();
            USER us = new USER();
            us = xoa.USERs.Where(u => u.f_MaSo == txtMaSo.Text).Single();
            us.f_HoTen = txtHoTen.Text;
            us.f_Email = txtEmail.Text;
            us.f_GioiTinh = txtGioiTinh.Text;
            us.f_NgaySinh = txtNgaySinh.Text;
            us.f_Phone = txtPhone.Text;
            us.f_TenDangNhap = txtTenDangNhap.Text;
            us.f_MatKhau = txtMatKhau.Text;
            us.f_IDPhanQuyen = int.Parse(txtIDPhanQuyen.Text.ToString());

            xoa.USERs.DeleteOnSubmit(us);
            xoa.SubmitChanges();
            MessageBox.Show("Xóa thành công!!!");
            LoadData();
            CleanTextBox();
        }

        


        DataTableCollection tableCollection;

        private void cbbSheet_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cbbSheet.SelectedItem.ToString()];
            //dgv_NguoiDung.DataSource = dt;
            if (dt != null)
            {
                List<ImportUser> uSERs = new List<ImportUser>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ImportUser uSER = new ImportUser();
                    uSER.f_HoTen = dt.Rows[i]["f_HoTen"].ToString();
                    uSER.f_Email = dt.Rows[i]["f_Email"].ToString();
                    uSER.f_NgaySinh = dt.Rows[i]["f_NgaySinh"].ToString();
                    uSER.f_GioiTinh = dt.Rows[i]["f_GioiTinh"].ToString();
                    uSER.f_Phone = dt.Rows[i]["f_Phone"].ToString();
                    uSER.f_MaSo = dt.Rows[i]["f_MaSo"].ToString();
                    uSER.f_TenDangNhap = dt.Rows[i]["f_TenDangNhap"].ToString();
                    uSER.f_MatKhau = dt.Rows[i]["f_MatKhau"].ToString();
                    uSER.f_IDPhanQuyen = dt.Rows[i]["f_IDPhanQuyen"].ToString();
                    uSERs.Add(uSER);
                }
                importUserBindingSource.DataSource = uSERs;
            }
        }

        private void btnBrowes_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtfilename.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            cbbSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cbbSheet.Items.Add(table.TableName);
                        }
                    }
                }
            }
        }

        private void btnImport_Click_1(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=LTUDQL1;Integrated Security=True";
                DapperPlusManager.Entity<ImportUser>().Table("USERs");
                List<ImportUser> uSERs = importUserBindingSource.DataSource as List<ImportUser>;
                if (uSERs != null)
                {
                    using (IDbConnection db = new SqlConnection(connectionString))
                    {
                        db.BulkInsert(uSERs);
                    }
                }
                MessageBox.Show("Import Thành Công!!!");
                LoadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewADNguoiDung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.USER' table. You can move, or remove it, as needed.
            this.uSERTableAdapter.Fill(this.appData.USER);

        }
    }
}
