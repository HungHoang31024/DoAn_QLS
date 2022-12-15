using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quan_Ly_Sach
{
    public partial class TinhLuongcs : Form
    {

        public TinhLuongcs()
        {
            InitializeComponent();

        }
        string connectionString;
        SqlConnection conn;

        DataSet ds = new DataSet("dsQLBS");

        SqlDataAdapter danhanvien;
        SqlDataAdapter Mluong;

        public void loadData1()
        {
           /* string sQuerySach = @"select n.*, c.TenNV from Sach n, NhanVien c  where n.MaNV = c.MaNV";
            daSach = new SqlDataAdapter(sQuerySach, conn);
            daSach.Fill(ds, "tblDSSach");
            dtgQLS.DataSource = ds.Tables["tblDSSach"];*/

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=HUNG-T0352;Initial Catalog=QLBS;Integrated Security=True";

            // dữ liệu nhân viên
            string sQueryNhanVien = @"select n.*, c.TienLuong  from NhanVien n, Luong c where n.MaLuong = c.MaLuong";
            danhanvien = new SqlDataAdapter(sQueryNhanVien, conn);
            danhanvien.Fill(ds, "tblDSNhanVien");
            dtgThongTinNV.DataSource = ds.Tables["tblDSNhanVien"];
            dtgThongTinNV.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
            dtgThongTinNV.Columns["MaNV"].Width = 120;

            dtgThongTinNV.Columns["HoLot"].HeaderText = "Họ Lót";
            dtgThongTinNV.Columns["HoLot"].Width = 180;

            dtgThongTinNV.Columns["TenNV"].HeaderText = "Tên";
            dtgThongTinNV.Columns["TenNV"].Width = 100;

            dtgThongTinNV.Columns["Phai"].HeaderText = "Phái";
            dtgThongTinNV.Columns["Phai"].Width = 60;

            dtgThongTinNV.Columns["ChucVu"].HeaderText = "Chức Vụ";
            dtgThongTinNV.Columns["ChucVu"].Width = 150;

            dtgThongTinNV.Columns["ThoiGianLamViec"].HeaderText = "Thời Gian Làm VIệc";
            dtgThongTinNV.Columns["ThoiGianLamViec"].Width = 150;

            dtgThongTinNV.Columns["NgayLamVC"].HeaderText = "Số Ngày Làm";
            dtgThongTinNV.Columns["NgayLamVC"].Width = 100;

            dtgThongTinNV.Columns["MaLuong"].HeaderText = "Mã Lương";
            dtgThongTinNV.Columns["MaLuong"].Width = 100;

            dtgThongTinNV.Columns["TienLuong"].HeaderText = "Tiền Lương";
            dtgThongTinNV.Columns["TienLuong"].Width = 100;

            dtgThongTinNV.Columns["NgaySinh"].Visible = false;
            dtgThongTinNV.Columns["DiaChi"].Visible = false;
            dtgThongTinNV.Columns["SoDienThoai"].Visible = false;

            string sThemNV = @"insert into Sach values(@MaNV, @HoLot, @TenNV, @Phai, @ChucVu, @ThoiGianLamViec, @NgayLamVC, @MaLuong, @TienLuong)";
            SqlCommand cmThem = new SqlCommand(sThemNV, conn);
            cmThem.Parameters.Add("@MaNV", SqlDbType.Char, 20, "MaNV");
            cmThem.Parameters.Add("@HoLot", SqlDbType.NVarChar, 40, "HoLot");
            cmThem.Parameters.Add("@TenNV", SqlDbType.NVarChar, 50, "TenNV");
            cmThem.Parameters.Add("@Phai", SqlDbType.NVarChar, 3, "Phai");
            cmThem.Parameters.Add("@ChucVu", SqlDbType.NVarChar, 20, "ChucVu");
            cmThem.Parameters.Add("@ThoiGianLamViec", SqlDbType.NVarChar, 40, "ThoiGianLamViec");
            cmThem.Parameters.Add("@NgayLamVC", SqlDbType.Char, 20, "NgayLamVC");
            cmThem.Parameters.Add("@MaLuong", SqlDbType.Char, 5, "MaLuong");
            cmThem.Parameters.Add("@TienLuong", SqlDbType.Money, 5, "TienLuong");



            danhanvien.InsertCommand = cmThem;
        }
        public void TienLuong()
        {

            double sum1 = 0;
            double sum2 = 0;
            radbFullTime.Text = "8";
            radbPartTime.Text = "5";
            double f = double.Parse(radbFullTime.Text);
            double p = double.Parse(radbPartTime.Text);
            double n = double.Parse(txtSoNgayLmVC.Text);
            if (radbFullTime.Checked == true)
            {
                radbFullTime.Text = "8" + "h";
                radbPartTime.Text = "5" + "h";
                sum1 = (f * n) * 25000;
                txttienluong.Text = sum1.ToString();
            }
            else if (radbPartTime.Checked == true)
            {
                radbFullTime.Text = "8" + "h";
                radbPartTime.Text = "5" + "h";
                sum2 = (p * n) * 20000;
                txttienluong.Text = sum2.ToString();
            }

          
        }



        private void lsvTTNv_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* if (lsvTTNv.SelectedItems.Count > 0)
            {
                txtMaNV.Text = lsvTTNv.SelectedItems[0].SubItems[0].Text;
                txtHoLotNV.Text = lsvTTNv.SelectedItems[0].SubItems[1].Text;
                txtTenNV.Text = lsvTTNv.SelectedItems[0].SubItems[2].Text;
                txtSoNgayLmVC.Text = lsvTTNv.SelectedItems[0].SubItems[3].Text;
                txttienluong.Text = lsvTTNv.SelectedItems[0].SubItems[4].Text;
            }*/


        }


        private void TinhLuongcs_Load_1(object sender, EventArgs e)
        {
            loadData1();
          
           
        }

      

        private void label2_Click(object sender, EventArgs e)
        {

        }

      
        public void LNV()
        {
            DataGridViewRow dr = dtgThongTinNV.SelectedRows[0];

            dr.Cells["NgayLamVC"].Value = txtSoNgayLmVC.Text;
            dr.Cells["TienLuong"].Value = txttienluong.Text;
            


        }
        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
               
            if (this.txtSoNgayLmVC.Text == "")
            {
                MessageBox.Show("Hãy nhập số ngày làm việc!", "Thông Báo", MessageBoxButtons.OKCancel);
            }
            else
            {
               
                TienLuong();
                LNV();
                
              
            }
        }

        private void btnTK_Click_1(object sender, EventArgs e)
        {
          /*  ThongKe tk = new ThongKe();
            if (lsvTTNv.FullRowSelect == true)
            {
                tk.manv = lsvTTNv.SelectedItems[0].SubItems[0].Text;
                tk.holot = lsvTTNv.SelectedItems[0].SubItems[1].Text;
                tk.ten = lsvTTNv.SelectedItems[0].SubItems[2].Text;
                tk.phai11 = lsvTTNv.SelectedItems[0].SubItems[3].Text;
                tk.chucvu = lsvTTNv.SelectedItems[0].SubItems[4].Text;
                tk.giol = lsvTTNv.SelectedItems[0].SubItems[5].Text;
                tk.songay = lsvTTNv.SelectedItems[0].SubItems[6].Text;
                tk.tienluong = lsvTTNv.SelectedItems[0].SubItems[7].Text;
                //2
                tk.manv2 = lsvTTNv.SelectedItems[1].SubItems[0].Text;
                tk.holot2 = lsvTTNv.SelectedItems[1].SubItems[1].Text;
                tk.ten2 = lsvTTNv.SelectedItems[1].SubItems[2].Text;
                tk.phai2 = lsvTTNv.SelectedItems[1].SubItems[3].Text;
                tk.chucvu2 = lsvTTNv.SelectedItems[1].SubItems[4].Text;
                tk.giol2 = lsvTTNv.SelectedItems[1].SubItems[5].Text;
                tk.songay2 = lsvTTNv.SelectedItems[1].SubItems[6].Text;
                tk.tienluong2 = lsvTTNv.SelectedItems[1].SubItems[7].Text;
                //3
                tk.manv3 = lsvTTNv.SelectedItems[2].SubItems[0].Text;
                tk.holot3 = lsvTTNv.SelectedItems[2].SubItems[1].Text;
                tk.ten3 = lsvTTNv.SelectedItems[2].SubItems[2].Text;
                tk.phai3 = lsvTTNv.SelectedItems[2].SubItems[3].Text;
                tk.chucvu3 = lsvTTNv.SelectedItems[2].SubItems[4].Text;
                tk.giol3 = lsvTTNv.SelectedItems[2].SubItems[5].Text;
                tk.songay3 = lsvTTNv.SelectedItems[2].SubItems[6].Text;
                tk.tienluong3 = lsvTTNv.SelectedItems[2].SubItems[7].Text;
                //4
                tk.manv4 = lsvTTNv.SelectedItems[3].SubItems[0].Text;
                tk.holot4 = lsvTTNv.SelectedItems[3].SubItems[1].Text;
                tk.ten4 = lsvTTNv.SelectedItems[3].SubItems[2].Text;
                tk.phai4 = lsvTTNv.SelectedItems[3].SubItems[3].Text;
                tk.chucvu4 = lsvTTNv.SelectedItems[3].SubItems[4].Text;
                tk.giol4 = lsvTTNv.SelectedItems[3].SubItems[5].Text;
                tk.songay4 = lsvTTNv.SelectedItems[3].SubItems[6].Text;
                tk.tienluong4 = lsvTTNv.SelectedItems[3].SubItems[7].Text;
                //5
                tk.manv5 = lsvTTNv.SelectedItems[4].SubItems[0].Text;
                tk.holot5 = lsvTTNv.SelectedItems[4].SubItems[1].Text;
                tk.ten5 = lsvTTNv.SelectedItems[4].SubItems[2].Text;
                tk.phai5 = lsvTTNv.SelectedItems[4].SubItems[3].Text;
                tk.chucvu5 = lsvTTNv.SelectedItems[4].SubItems[4].Text;
                tk.giol5 = lsvTTNv.SelectedItems[4].SubItems[5].Text;
                tk.songay5 = lsvTTNv.SelectedItems[4].SubItems[6].Text;
                tk.tienluong5 = lsvTTNv.SelectedItems[4].SubItems[7].Text;
            }

            tk.Show();*/
        }

        private void dtgThongTinNV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dtgThongTinNV.SelectedRows[0];
            txtMaNV.Text = dr.Cells["MaNV"].Value.ToString();
            txtHoLotNV.Text = dr.Cells["HoLot"].Value.ToString();
            txtTenNV.Text = dr.Cells["TenNV"].Value.ToString();

            if (dr.Cells["Phai"].Value.ToString() == "Nam")
            {
                radbNam.Checked = true;
            }
            else
            {
                radbNu.Checked = true;
            }

            cboChucVu.Text = dr.Cells["ChucVu"].Value.ToString();

            if (dr.Cells["ThoiGianLamViec"].Value.ToString() == "Full time")
            {
                radbFullTime.Checked = true;
            }
            else
            {
                radbPartTime.Checked = true;
            }
            txtSoNgayLmVC.Text = dr.Cells["NgayLamVC"].Value.ToString();
            cboMLuong.Text = dr.Cells["MaLuong"].Value.ToString();
            txttienluong.Text = dr.Cells["TienLuong"].Value.ToString();

        }

        private void lsvTTNv_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtSoNgayLmVC_Click(object sender, EventArgs e)
        {
            this.txtSoNgayLmVC.Clear();
        }
    }
}






       
            
        

       
    

