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
    public partial class HDBSach : Form
    {
        public HDBSach()
        {
            InitializeComponent();
        }
        //string connectionString;
        //SqlConnection conn;

        DataSet ds = new DataSet("dsQLBS");

        SqlDataAdapter daKhachHang;
        SqlDataAdapter daSach;
        SqlDataAdapter daNhanVien;
        private void Form2_Load(object sender, EventArgs e)
        {
            loadData1();
        }
        public void loadData1()
        {
            SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = @"Data Source=MINHANH\SQLEXPRESS;Initial Catalog=QLBS;Integrated Security=True";
            conn.ConnectionString = @"Data Source=HUNG-T0352;Initial Catalog=QLBS;Integrated Security=True";
            //Dử liệu datagrid kho
            string sQuerySach = @"select s.*,k.HoTenKH, n.TenNV,n.HoLot,hd.ThanhTien from Sach s, KhachHang k, NhanVien n ,Hoadon hd where s.MaNV = n.MaNV and s.MaKH = k.MaKH and s.MaHD = hd.MaHD ";
            daSach = new SqlDataAdapter(sQuerySach, conn);
            daSach.Fill(ds, "tblDSSach");
            dgvTT6.DataSource = ds.Tables["tblDSSach"];
      

            dgvTT6.Columns["MaSach"].HeaderText = "Mã Sách";
            dgvTT6.Columns["MaSach"].Width = 100;

            dgvTT6.Columns["TenSach"].HeaderText = "Tên Sách";
            dgvTT6.Columns["TenSach"].Width = 100;

            dgvTT6.Columns["TacGia"].HeaderText = "Tác Giả";
            dgvTT6.Columns["TacGia"].Width = 100;

            dgvTT6.Columns["MaLoai"].HeaderText = "Mã loại";
            dgvTT6.Columns["MaLoai"].Width = 100;

            dgvTT6.Columns["SLTon"].HeaderText = "Số lượng tồn";
            dgvTT6.Columns["SLTon"].Width = 100;

            dgvTT6.Columns["MaKH"].HeaderText = "Mã khách hàng";
            dgvTT6.Columns["MaKH"].Width = 100;
            dgvTT6.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dgvTT6.Columns["MaNV"].Width = 100;

            dgvTT6.Columns["HoTenKH"].HeaderText = "Tên khách hàng";
            dgvTT6.Columns["HoTenKH"].Width = 100;

            dgvTT6.Columns["TenNV"].HeaderText = "Tên nhân viên";
            dgvTT6.Columns["TenNV"].Width = 100;

           

       

            string sThemS = @"insert into Sach values(@MaSach, @TenSach, @TacGia, @MaLoai, @SLTon)";
            SqlCommand cmThemKho = new SqlCommand(sThemS, conn);
            cmThemKho.Parameters.Add("@MaSach", SqlDbType.NVarChar, 15, "MaSach");
            cmThemKho.Parameters.Add("@TenSach", SqlDbType.NVarChar, 20, "TenSach");
            cmThemKho.Parameters.Add("@TacGia", SqlDbType.NVarChar, 40, "TacGia");
            cmThemKho.Parameters.Add("@MaLoai", SqlDbType.VarChar, 20, "MaLoai");
            cmThemKho.Parameters.Add("@SLTon", SqlDbType.VarChar, 20, "SLTon");
            cmThemKho.Parameters.Add("@TenNV", SqlDbType.NVarChar, 10, "TenNV");
            cmThemKho.Parameters.Add("@MaKH", SqlDbType.Char, 5, "MaKH");
            cmThemKho.Parameters.Add("@HoTenKH", SqlDbType.NVarChar, 20, "HoTenKH");
            daSach.InsertCommand = cmThemKho;


            dgvTT6.Columns["MaKHO"].Visible = false;

            dgvTT6.Columns["MaNhaSX"].Visible = false;
            dgvTT6.Columns["MaHD"].Visible = false;
            dgvTT6.Columns["HoLot"].Visible = false;
            //dgvTT6.Columns["MaNV"].Visible = false;
            //dgvTT6.Columns["MaKH"].Visible = false;
        }

        /*    private void dgvTT6_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                DataGridViewRow dr = dgvTT6.SelectedRows[0];
                txtMaNV.Text = dr.Cells["MaNV"].Value.ToString();
                txtHoLotNV.Text = dr.Cells["HoLot"].Value.ToString();
                txtTenNV.Text = dr.Cells["TenNV"].Value.ToString();
                cboPhai.SelectedValue = dr.Cells["Phai"].Value.ToString();
                cboPhai.Text = dr.Cells["Phai"].Value.ToString();
                dtpNSNV.Text = dr.Cells["NgaySinh"].Value.ToString();
                cboDCNV.SelectedValue = dr.Cells["DiaChi"].Value.ToString();
                cboDCNV.Text = dr.Cells["DiaChi"].Value.ToString();
            }
        */
        private void btnThem_Click(object sender, EventArgs e)
        {
            //Thêm 
            DataRow row = ds.Tables["tblDSSach"].NewRow();
            row["MaNV"] = txtMaNV.Text;
            row["TenNV"] = txtTenNV.Text;
            row["MaSach"] = txtMaS.Text;
            row["TenSach"] = txtTS.Text;
            row["TacGia"] = txtTG.Text;
            row["SLTon"] = txtSL.Text;
            row["MaKH"] = txtMaKH.Text;
            row["HoTenKH"] = txtTenKH.Text;
            row["MaLoai"] = txtML.Text;
            row["DonGia"] = txtDG.Text;
            //row["HoLot"] = txtHoLotNV.Text;
            row["ThanhTien"] = txtTinhTien.Text;
            ds.Tables["tblDSSach"].Rows.Add(row);
        }
        public void TinhTien()

        {
            int l = int.Parse(txtDG.Text);
            int m = int.Parse(nmSLmua.Value.ToString());
            int sum = 0;
            sum = m * l;
            this.txtTinhTien.Text = sum.ToString();


        }
       
        private void btnTinhtien_Click(object sender, EventArgs e)
        {
            TinhTien();
            SLT();
            
        }

        private void btnTinhtien_MouseClick(object sender, MouseEventArgs e)
        {
            /*Hóa_Đơn hd = new Hóa_Đơn();
            hd.dongia = this.txtTinhTien.Text;
            hd.Show();*/
        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            Hóa_Đơn HD = new Hóa_Đơn();
            HD.Show();
        }
        private void dgvTT6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgvTT6.SelectedRows[0];
            txtMaS.Text = dr.Cells["MaSach"].Value.ToString();
            txtTS.Text = dr.Cells["TenSach"].Value.ToString();
            txtTG.Text = dr.Cells["TacGia"].Value.ToString();
            txtML.Text = dr.Cells["MaLoai"].Value.ToString();
            txtDG.Text = dr.Cells["DonGia"].Value.ToString();
            txtSL.Text = dr.Cells["SLTon"].Value.ToString();
            txtMaKH.Text = dr.Cells["MaKH"].Value.ToString();
            txtMaNV.Text = dr.Cells["MaNV"].Value.ToString();
            txtTenKH.Text = dr.Cells["HoTenKH"].Value.ToString();
            txtTenNV.Text = dr.Cells["TenNV"].Value.ToString();
            txtTinhTien.Text = dr.Cells["ThanhTien"].Value.ToString();


            /* DataGridViewRow dr = dgvTT6.SelectedRows[0];
             txtMaNV.Text = dr.Cells["MaNV"].Value.ToString();
             txtTenNV.Text = dr.Cells["TenNV"].Value.ToString();
             txtMaS.Text = dr.Cells["MaSach"].Value.ToString();
             txtTS.Text = dr.Cells["TenSach"].Value.ToString();
             txtML.Text = dr.Cells["MaLoai"].Value.ToString();
             txtDG.Text = dr.Cells["DonGia"].Value.ToString();
             txtMaKH.Text = dr.Cells["MaKH"].Value.ToString();
             txtTenKH.Text = dr.Cells["HoTenKH"].Value.ToString();
             txtTG.Text = dr.Cells["TacGia"].Value.ToString();
             txtSL.Text = dr.Cells["SLTon"].Value.ToString();

             txtTinhTien.Text = dr.Cells["ThanhTien"].Value.ToString();*/
        }

        

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (dgvTT6.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgvTT6.SelectedRows[0];
                dr.Cells["MaNV"].Value = txtMaNV.Text;
                dr.Cells["TenNV"].Value = txtTenNV.Text;
                dr.Cells["MaSach"].Value = txtMaS.Text;
                dr.Cells["TenSach"].Value = txtTS.Text;
                dr.Cells["MaLoai"].Value = txtML.Text;
                dr.Cells["DonGia"].Value = txtDG.Text;
                dr.Cells["MaKH"].Value = txtMaKH.Text;
                dr.Cells["HoTenKH"].Value = txtTenKH.Text;
                dr.Cells["TacGia"].Value = txtTG.Text;
                dr.Cells["SLTon"].Value = txtSL.Text;
                //dr.Cells["HoLot"].Value = txtHoLotNV.Text;
                dr.Cells["ThanhTien"].Value = txtTinhTien.Text;

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtMaKH.ResetText();
            //this.txtHoLotNV.ResetText();
            this.txtMaNV.ResetText();
            this.txtMaS.ResetText();
            this.txtML.ResetText();
            this.txtSL.ResetText();
            this.txtTenNV.ResetText();
            this.txtTG.ResetText();
            this.txtTS.ResetText();
            this.txtDG.ResetText();
            this.txtTenKH.ResetText();
            this.txtTinhTien.ResetText();

            foreach (DataGridViewRow dr in this.dgvTT6.SelectedRows)
            {
                this.dgvTT6.Rows.RemoveAt(dr.Index);
            }
        }

        public void SLT()
        {
            int l = int.Parse(txtSL.Text);

            int m = int.Parse(nmSLmua.Value.ToString());
            int tru = 0;
            tru = l - m;
            this.txtSL.Text = tru.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

