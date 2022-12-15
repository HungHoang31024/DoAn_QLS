using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Quan_Ly_Sach
{
    public partial class QLSach : Form
    {
        public QLSach()
        {
            InitializeComponent();
        }
        //string connectionString;
        //SqlConnection conn;

        DataSet ds = new DataSet("dsQLBS");

        SqlDataAdapter daSach;
        SqlDataAdapter daLoaiSach;
        SqlDataAdapter daKho;
        SqlDataAdapter daNhaSanXuat;
        SqlDataAdapter daNhanVien;
        private void QLSach_Load(object sender, EventArgs e)
        {
            loadData();
            
        }
        public void loadData()
        {
            SqlConnection conn = new SqlConnection();
        
            conn.ConnectionString = @"Data Source=HUNG-T0352;Initial Catalog=QLBS;Integrated Security=True";
            /*
            string sQueryNSX = @"select * from NhaSanXuat";
            daNhaSanXuat = new SqlDataAdapter(sQueryNSX, conn);
            daNhaSanXuat.Fill(ds, "tblNhaSanXuat");
            dtgQLS.DataSource = ds.Tables["tblNhaSanXuat"];
            txtTNSX.Text = "TenNhaSX"; 
            txtMNSX.Text = "MaNhaSX";
            
            string sQueryKHO = @"select * from KHO";
            daKho = new SqlDataAdapter(sQueryKHO, conn);
            daKho.Fill(ds, "tblKHO");
            dtgQLS.DataSource = ds.Tables["tblKHO"];
            txtTKho.Text = "TenKHO";
            txtMK.Text = "MaKHO";*/  

            // Dữ liệu datagrid Sách 
            string sQuerySach = @"select n.*, c.TenNV from Sach n, NhanVien c  where n.MaNV = c.MaNV";
            daSach = new SqlDataAdapter(sQuerySach, conn);
            daSach.Fill(ds, "tblDSSach");
            dtgQLS.DataSource = ds.Tables["tblDSSach"];
/*
            dtgQLS.Columns["MaKHO"].HeaderText = "Mã Kho";
            dtgQLS.Columns["MaKHO"].Width = 100;

            dtgQLS.Columns["TenKHO"].HeaderText = "Tên Kho";
            dtgQLS.Columns["TenKHO"].Width = 150;

            dtgQLS.Columns["DC"].HeaderText = "Địa Chỉ";
            dtgQLS.Columns["DC"].Width = 200;

            dtgQLS.Columns["SoDT"].HeaderText = "Số Điện Thoại";
            dtgQLS.Columns["SoDT"].Width = 150;

            
            dtgQLS.Columns["MaSach"].HeaderText = "Mã Sách";
            dtgQLS.Columns["MaSach"].Width = 100;

            dtgQLS.Columns["TenSach"].HeaderText = "Tên Sách";
            dtgQLS.Columns["TenSach"].Width = 150;

          
            dtgQLS.Columns["TacGia"].HeaderText = "Tác Giả";
            dtgQLS.Columns["TacGia"].Width = 150;

            dtgQLS.Columns["MaLoai"].HeaderText = "Mã Loại";
            dtgQLS.Columns["MaLoai"].Width = 110;

            dtgQLS.Columns["DonGia"].HeaderText = "Đơn Giá";
            dtgQLS.Columns["DonGia"].Width = 150;

            dtgQLS.Columns["SLTon"].HeaderText = "Số Lượng Tồn";
            dtgQLS.Columns["SLTon"].Width = 150;
/*
            dtgQLS.Columns["MaNhaSX"].HeaderText = "Mã NSX";
            dtgQLS.Columns["MaNhaSX"].Width = 100;

            dtgQLS.Columns["TenNhaSX"].HeaderText = " Tên NSX";
            dtgQLS.Columns["TenNhaSX"].Width = 100;

            dtgQLS.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
            dtgQLS.Columns["MaNV"].Width = 120;


            dtgQLS.Columns["TenNV"].HeaderText = "Tên NV";
            dtgQLS.Columns["TenNV"].Width = 100;*/

            dtgQLS.Columns["MaHD"].Visible = false;
            dtgQLS.Columns["MaKH"].Visible = false;



            string sThemS = @"insert into Sach values(@MaSach, @TenSach, @TacGia, @MaLoai, @DonGia, @SLTon, @MaNV, @TenNV)";
            SqlCommand cmThemS = new SqlCommand(sThemS, conn);
            cmThemS.Parameters.Add("@MaSach", SqlDbType.Char, 20, "MaSach");
            cmThemS.Parameters.Add("@TenSach", SqlDbType.NVarChar, 40, "TenSach");
            cmThemS.Parameters.Add("@TacGia", SqlDbType.NVarChar,50, "TacGia");
            cmThemS.Parameters.Add("@MaLoai", SqlDbType.Char, 5, "MaLoai");
            cmThemS.Parameters.Add("@DonGia", SqlDbType.Int, 10,"DonGia");
            cmThemS.Parameters.Add("@SLTon", SqlDbType.SmallInt, 5, "SLTon");
            cmThemS.Parameters.Add("@MaNV", SqlDbType.Char, 20, "MaNV");
            cmThemS.Parameters.Add("@TenNV", SqlDbType.NVarChar, 20, "TenNV");


            daSach.InsertCommand = cmThemS;


/*
            //nhà sản xuất
            string sQueryNhaSanXuat = @"select  MaNhaSX, TenNhaSX from NhaSanXuat ";
            daNhaSanXuat = new SqlDataAdapter(sQueryNhaSanXuat, conn);
            daNhaSanXuat.Fill(ds, "tblDSNhaSanXuat");
            dtgQLS.DataSource = ds.Tables["tblDSNhaSanXuat"];


            dtgQLS.Columns["TenNhaSX"].HeaderText = "Tên NSX";
            dtgQLS.Columns["TenNhaSX"].Width = 200;

      
            string sThemNSX = @"insert into Sach values(@MaNhaSX, @TenNhaSX, @DC, @SoDT)";
            SqlCommand cmThemNSX = new SqlCommand(sThemNSX, conn);
            cmThemS.Parameters.Add("@MaNhaSX", SqlDbType.NVarChar, 5, "MaNhaNSX");
            cmThemS.Parameters.Add("@TenNhaSX", SqlDbType.NVarChar, 20, "TenNhaSX");
            cmThemS.Parameters.Add("@DC", SqlDbType.NVarChar, 40, "DC");
            cmThemS.Parameters.Add("@SoDT", SqlDbType.VarChar, 20, "SoDT");
            daNhaSanXuat.InsertCommand = cmThemNSX;


            //Dữ liệu kho
            string sQueryKHO = @"select  MaKHO, TenKHO, DC, SoDT from KHO ";
            daKho = new SqlDataAdapter(sQueryKHO, conn);
            daKho.Fill(ds, "tblDSKHO");
            dtgQLS.DataSource = ds.Tables["tblDSKHO"];
          
            dgTT3.Columns["NVK"].HeaderText = "Nhân Viên Kho";
            dgTT3.Columns["NVK"].Width = 150;
            string sThemKHO = @"insert into Sach values(@MaKHo, @TenKHo, @DC, @SoDT)";
            SqlCommand cmThemKHo = new SqlCommand(sThemKHO, conn);
            cmThemS.Parameters.Add("@MaKHo", SqlDbType.NVarChar, 15, "MaKHo");
            cmThemS.Parameters.Add("@TenKho", SqlDbType.NVarChar, 20, "TenKHo");
            cmThemS.Parameters.Add("@DC", SqlDbType.NVarChar, 40, "DC");
            cmThemS.Parameters.Add("@SoDT", SqlDbType.VarChar, 20, "SoDT");
           // cmThemS.Parameters.Add("@NVK", SqlDbType.VarChar, 20, "NVK");
            daKho.InsertCommand = cmThemKHo;
*/
/*
            //Dữ liệu nhân viên
            string sQueryNhanVien = @"select  MaNV, HoLot, TenNV, Phai, NgaySinh, DiaChi from NhanVien ";
            daNhanVien = new SqlDataAdapter(sQueryNhanVien, conn);
            daNhanVien.Fill(ds, "tblDSNhanVien");
            dtgQLS.DataSource = ds.Tables["tblDSNhanVien"];
   
            dtgQLS.Columns["HoLot"].HeaderText = "Họ Lót";
            dtgQLS.Columns["HoLot"].Width = 180;

            dtgQLS.Columns["Phai"].HeaderText = "Phái";
            dtgQLS.Columns["Phai"].Width = 150;

            dtgQLS.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dtgQLS.Columns["NgaySinh"].Width = 110;

            dtgQLS.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dtgQLS.Columns["DiaChi"].Width = 180;
            string sThemNV = @"insert into Sach values(@MaNV, @HoLot, @TenNV, @Phai, @NgaySinh, @DiaChi)";
            SqlCommand cmThemNV = new SqlCommand(sThemNV, conn);
            cmThemS.Parameters.Add("@MaNV", SqlDbType.Char, 5, "MaNV");
            cmThemS.Parameters.Add("@HoLot", SqlDbType.NVarChar, 25, "HoLot");
            cmThemS.Parameters.Add("@TenNV", SqlDbType.NVarChar, 10, "TenNV");
            cmThemS.Parameters.Add("@Phai", SqlDbType.NVarChar, 3, "Phai");
            cmThemS.Parameters.Add("@NgaySinh", SqlDbType.Date, 5, "NgaySinh");
            cmThemS.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 40, "DiaCHi");
            daNhanVien.InsertCommand = cmThemNV;



*/
        }    
       
    /*    private void btnTKscah_Click(object sender, EventArgs e)
        {
            ThongKe tk = new ThongKe();
            if (lsvNhapKho.FullRowSelect == true)
            {
                tk.makho = lsvNhapKho.SelectedItems[0].SubItems[0].Text;
                tk.tenk = lsvNhapKho.SelectedItems[0].SubItems[1].Text;
                tk.SDTkho = lsvNhapKho.SelectedItems[0].SubItems[2].Text;
                tk.diachiKH = lsvNhapKho.SelectedItems[0].SubItems[3].Text;
                tk.Tensach = lsvNhapKho.SelectedItems[0].SubItems[4].Text;
                tk.slTon = lsvNhapKho.SelectedItems[0].SubItems[5].Text;
                tk.tenNhanv = lsvNhapKho.SelectedItems[0].SubItems[6].Text;

                //2
                tk.makho2 = lsvNhapKho.SelectedItems[2].SubItems[0].Text;
                tk.tenk2 = lsvNhapKho.SelectedItems[2].SubItems[1].Text;
                tk.SDTkho2 = lsvNhapKho.SelectedItems[2].SubItems[2].Text;
                tk.diachiKH2 = lsvNhapKho.SelectedItems[2].SubItems[3].Text;
                tk.Tensach2 = lsvNhapKho.SelectedItems[2].SubItems[4].Text;
                tk.slTon2 = lsvNhapKho.SelectedItems[2].SubItems[5].Text;
                tk.tenNhanv2 = lsvNhapKho.SelectedItems[2].SubItems[6].Text;

                //3
                tk.makho3 = lsvNhapKho.SelectedItems[3].SubItems[0].Text;
                tk.tenk3 = lsvNhapKho.SelectedItems[3].SubItems[1].Text;
                tk.SDTkho3 = lsvNhapKho.SelectedItems[3].SubItems[2].Text;
                tk.diachiKH3 = lsvNhapKho.SelectedItems[3].SubItems[3].Text;
                tk.Tensach3 = lsvNhapKho.SelectedItems[3].SubItems[4].Text;
                tk.slTon3 = lsvNhapKho.SelectedItems[3].SubItems[5].Text;
                tk.tenNhanv3 = lsvNhapKho.SelectedItems[3].SubItems[6].Text;

                //4
                tk.makho4 = lsvNhapKho.SelectedItems[4].SubItems[0].Text;
                tk.tenk4 = lsvNhapKho.SelectedItems[4].SubItems[1].Text;
                tk.SDTkho4 = lsvNhapKho.SelectedItems[4].SubItems[2].Text;
                tk.diachiKH4 = lsvNhapKho.SelectedItems[4].SubItems[3].Text;
                tk.Tensach4 = lsvNhapKho.SelectedItems[4].SubItems[4].Text;
                tk.slTon4 = lsvNhapKho.SelectedItems[4].SubItems[5].Text;
                tk.tenNhanv4 = lsvNhapKho.SelectedItems[4].SubItems[6].Text;
            }
            
            tk.Show();
        }
    */
        

       


      

    

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            //add();
        }

        private void dtgQLS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dtgQLS.SelectedRows[0];
          
            txtMS.Text = dr.Cells["MaSach"].Value.ToString();
            txtTS.Text = dr.Cells["TenSach"].Value.ToString();
            txtTG.Text = dr.Cells["TacGia"].Value.ToString();
            txtML.Text = dr.Cells["MaLoai"].Value.ToString();
            txtDG.Text = dr.Cells["DonGia"].Value.ToString();
            txtSL.Text = dr.Cells["SLTon"].Value.ToString();
            txtMK.Text = dr.Cells["MaKho"].Value.ToString();
            //txtTKho.Text = dr.Cells["TenKHO"].Value.ToString();
            txtMNV.Text = dr.Cells["MaNV"].Value.ToString();
            txtMNSX.Text = dr.Cells["MaNhaSX"].Value.ToString();
            txtTNV.Text = dr.Cells["TenNV"].Value.ToString();
            
           // txtTNSX.Text = dr.Cells["TenNhaSX"].Value.ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Thêm TT Sách
            DataRow row = ds.Tables["tblDSSach"].NewRow();
            row["MaSach"] = txtMS.Text;
            row["TenSach"] = txtTS.Text;
            row["TacGia"] = txtTG.Text;
            row["MaLoai"] = txtML.Text;
            row["DonGia"] = txtDG.Text;
            row["SLTon"] = txtSL.Text;
            ds.Tables["tblDSSach"].Rows.Add(row);

            //Thêm nhà sản xuất
            DataRow row1 = ds.Tables["tblDSNhaSanXuat"].NewRow();
            row1["MaNhaSX"] = txtMNSX.Text;
       
         
            ds.Tables["tblDSNhaSanXuat"].Rows.Add(row1);
            //Thêm nhà kho
            DataRow row2 = ds.Tables["tblDSKHO"].NewRow();
            row2["MaKHO"] = txtMK.Text;
            row2["TenKHO"] = txtTKho.Text;
            row2["NVK"] = txtNVkho.Text;
            ds.Tables["tblDSKHO"].Rows.Add(row2);
            //Thêm nhân viên
            DataRow row3 = ds.Tables["tblDSNhanVien"].NewRow();
            row3["MaNV"] = txtMNV.Text;

            row3["TenNV"] = txtTNV.Text;
            
            ds.Tables["tblDSNhanVien"].Rows.Add(row3);
            //row3["SoDT"] = txtSDT.Text;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
         /*   if (dtgQLS.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dtgQLS.SelectedRows[0];
                dr.Cells["MaSach"].Value = txtMS.Text;
                dr.Cells["TenSach"].Value = txtTS.Text;
                dr.Cells["TacGia"].Value = txtTG.Text;
                dr.Cells["MaLoai"].Value = txtML.Text;
                ds.Tables["tblDSSach"].Rows.Add(dr);
                dr.Cells["DonGia"].Value = txtDG.Text;
                dr.Cells["SLTon"].Value = txtSL.Text;
            }
            else if (dgTT2.SelectedRows.Count > 0)
            {
                DataGridViewRow dr1 = dgTT2.SelectedRows[0];
                dr1.Cells["MaNhaSX"].Value = txtMNSX.Text;
                dr1.Cells["TenNhaSX"].Value = txtTNSX.Text;
         
                ds.Tables["tblDSNhaSanXuat"].Rows.Add(dr1);
            }
            else if (dgTT3.SelectedRows.Count > 0)
            {
                DataGridViewRow dr2 = dgTT3.SelectedRows[0];
                dr2.Cells["MaKHO"].Value = txtMK.Text;
                dr2.Cells["TenKHO"].Value = txtTKho.Text;
                dr2.Cells["DC"].Value = cboDCKho.SelectedValue;
                dr2.Cells["DC"].Value = cboDCKho.Text;
                dr2.Cells["SoDT"].Value = txtSDTKho.Text;
                ds.Tables["tblDSKHO"].Rows.Add(dr2);
            }
            else if (dgTT4.SelectedRows.Count > 0)
            {
                DataGridViewRow dr3 = dgTT4.SelectedRows[0];
                dr3.Cells["MaNV"].Value = txtMNV.Text;

                dr3.Cells["TenNV"].Value = txtTNV.Text;
         
                ds.Tables["tblDSNhanVien"].Rows.Add(dr3);
                //dr3.Cells["SoDT"].Value = txtSDTKho.Text;
            }*/
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtMS.ResetText();
            this.txtMNV.ResetText();
            this.txtMNSX.ResetText();
            this.txtMK.ResetText();
            this.txtML.ResetText();
  
            this.txtDG.ResetText();
      
            this.txtSL.ResetText();
            this.txtTG.ResetText();
            this.txtTKho.ResetText();
      
            this.txtTNV.ResetText();
            this.txtTS.ResetText();
         
            foreach (DataGridViewRow dr in this.dtgQLS.SelectedRows)
            {
                this.dtgQLS.Rows.RemoveAt(dr.Index);
            }
           
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "tblDSNhanVien"].EndCurrentEdit();
            this.BindingContext[ds, "tblDSKHO"].EndCurrentEdit();
            this.BindingContext[ds, "tblDSNhaSanXuat"].EndCurrentEdit();
            this.BindingContext[ds, "tblDSSach"].EndCurrentEdit();
            if (ds.HasChanges() == true)
            {
                if (MessageBox.Show("Bạn có thực sự muốn lưu các thay đổi trên bảng dữ liệu Danh sách nhân viên ?", "Xác nhận thay đổi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        daNhanVien.Update(ds.Tables["tblDSNhanVien"]);
                        daKho.Update(ds.Tables["tblDSKHO"]);
                        daNhaSanXuat.Update(ds.Tables["tblDSNhaSanXuat"]);
                        daSach.Update(ds.Tables["tblDSSach"]);
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

        private void txtMS_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}