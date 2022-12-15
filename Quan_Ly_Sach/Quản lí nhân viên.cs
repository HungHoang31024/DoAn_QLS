using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Sach
{
    public partial class Quản_lí_nhân_viên : Form
    {
        public Quản_lí_nhân_viên()
        {
            InitializeComponent();
        }
        //String connectingString;
        //SqlConnection conn;

        DataSet ds = new DataSet("dsQLBS");

        SqlDataAdapter daNhanVien;
        private void Quản_lí_nhân_viên_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=HUNG-T0352;Initial Catalog=master;Integrated Security=True";


            //Dử liệu datagrid Nhan Vien
            string sQueryNhanVien = @" select  MaNV, HoLot, TenNV, Phai, NgaySinh, DiaChi, SoDienThoai, ChucVu, ThoiGianLamViec from NhanVien";
            daNhanVien = new SqlDataAdapter(sQueryNhanVien, conn);
            daNhanVien.Fill(ds, "tblNhanVien");
            dtgvQLNV.DataSource = ds.Tables["tblNhanVien"];
            dtgvQLNV.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dtgvQLNV.Columns["MaNV"].Width = 100;

            dtgvQLNV.Columns["HoLot"].HeaderText = "Họ lót";
            dtgvQLNV.Columns["HoLot"].Width = 100;

            dtgvQLNV.Columns["TenNV"].HeaderText = "Tên nhân viên";
            dtgvQLNV.Columns["TenNV"].Width = 100;

            dtgvQLNV.Columns["Phai"].HeaderText = "Phái";
            dtgvQLNV.Columns["Phai"].Width = 100;

            dtgvQLNV.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dtgvQLNV.Columns["NgaySinh"].Width = 100;

            dtgvQLNV.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dtgvQLNV.Columns["DiaChi"].Width = 100;

            dtgvQLNV.Columns["SoDienThoai"].HeaderText = "Số điên thoại";
            dtgvQLNV.Columns["SoDienThoai"].Width = 100;

            dtgvQLNV.Columns["ChucVu"].HeaderText = "Chức vụ";
            dtgvQLNV.Columns["ChucVu"].Width = 100;

            dtgvQLNV.Columns["ThoiGianLamViec"].HeaderText = "Thời gian làm việc";
            dtgvQLNV.Columns["ThoiGianLamViec"].Width = 100;

            string sThemNV = @"insert into Sach values(@MaNV, @HoLot, @TenNV, @Phai, @NgaySinh, @DiaChi, @SoDienThoai, @ChucVu, @ThoiGianLamViec)";
            SqlCommand cmThemNV = new SqlCommand(sThemNV, conn);
            cmThemNV.Parameters.Add("@MaNV", SqlDbType.Char, 5, "MaNV");
            cmThemNV.Parameters.Add("@HoLot", SqlDbType.NVarChar, 25, "HoLot");
            cmThemNV.Parameters.Add("@TenNV", SqlDbType.NVarChar, 10, "TenNV");
            cmThemNV.Parameters.Add("@Phai", SqlDbType.NVarChar, 3, "Phai");
            cmThemNV.Parameters.Add("@NgaySinh", SqlDbType.Date, 5, "NgaySinh");
            cmThemNV.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 40, "DiaChi");
            cmThemNV.Parameters.Add("@ChucVu", SqlDbType.NVarChar, 15, "ChucVu");
            cmThemNV.Parameters.Add("@ThoiGianLamViec", SqlDbType.NVarChar, 15, "ThoiGianLamViec");

            daNhanVien.InsertCommand = cmThemNV;
        }

        private void dtgvQLNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dtgvQLNV.SelectedRows[0];
            txtMNV.Text = dr.Cells["MaNV"].Value.ToString();
            txtHolot.Text = dr.Cells["HoLot"].Value.ToString();
            txttenNV.Text = dr.Cells["TenNV"].Value.ToString();
            cmbPhai.SelectedValue = dr.Cells["Phai"].Value.ToString();
            cmbPhai.Text = dr.Cells["Phai"].Value.ToString();
            dtpNS.Text = dr.Cells["NgaySinh"].Value.ToString();
            cmbDC.SelectedValue = dr.Cells["DiaChi"].Value.ToString();
            cmbDC.Text = dr.Cells["DiaChi"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Thêm nhân viên
            DataRow row = ds.Tables["tblDSNhanVien"].NewRow();
            row["MaNV"] = txtMNV.Text;
            row["HoLot"] = txtHolot.Text;
            row["TenNV"] = txttenNV.Text;
            row["Phai"] = cmbPhai.SelectedValue;
            row["Phai"] = cmbPhai.Text;
            row["NgaySinh"] = dtpNS.Text;
            row["DiaChi"] = cmbDC.SelectedValue;
            row["SoDienThoai"] = txtSDT.Text;
            row["ChucVu"] = cmbCV.SelectedValue;
            row["ChucVu"] = cmbCV.Text;
            row["ThoiGianlamViec"] =cmbTGLV.SelectedValue;
            row["ThoiGianLamViec"] = cmbTGLV.Text;

            ds.Tables["tblDSNhanVien"].Rows.Add(row);
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtMNV.ResetText();
            this.txtHolot.ResetText();
            this.txttenNV.ResetText();
            this.txtSDT.ResetText();
            this.cmbPhai.ResetText();
            this.cmbDC.ResetText();
            this.dtpNS.ResetText();
            this.cmbCV.ResetText();
            this.cmbTGLV.ResetText();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr= dtgvQLNV.SelectedRows[0];
            dr.Cells["MaNV"].Value = txtMNV.Text;
            dr.Cells["HoLot"].Value = txtHolot.Text;
            dr.Cells["TenNV"].Value = txttenNV.Text;
            dr.Cells["Phai"].Value = cmbPhai.SelectedValue;
            dr.Cells["Phai"].Value = cmbPhai.Text;
            dr.Cells["NgaySinh"].Value = dtpNS.Text;
            dr.Cells["SoDienThoai"].Value = txtSDT.Text;
            dr.Cells["DiaChi"].Value = cmbDC.SelectedValue;
            dr.Cells["DiaChi"].Value = cmbDC.Text;
            dr.Cells["ChucVu"].Value = cmbCV.SelectedValue;
            dr.Cells["ChucVu"].Value = cmbCV.Text;
            dr.Cells["ThoiGianLamViec"].Value = cmbTGLV.SelectedValue;
            dr.Cells["ThoiGianLamViec"].Value = cmbTGLV.Text;

            ds.Tables["tblDSNhanVien"].Rows.Add(dr);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "tblDSNhanVien"].EndCurrentEdit();
            if (ds.HasChanges() == true)
            {
                if (MessageBox.Show("Bạn có thực sự muốn lưu các thay đổi trên bảng dữ liệu Danh sách nhân viên ?", "Xác nhận thay đổi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        daNhanVien.Update(ds.Tables["tblDSNV"]);
                
                        MessageBox.Show("Đã cập nhật");
                    }
                    catch (Exception x) { MessageBox.Show(x.Message); }
                }
            }
            else
            {
                MessageBox.Show("Cơ sở dữ liệu chưa có sự thay đổi.", "Thông báo người dùng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            loadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMNV_MouseClick(object sender, MouseEventArgs e)
        {
            this.dtgvQLNV.Visible = true;
            this.dtgvQLNV.Enabled = true;
        }
    }
 }
