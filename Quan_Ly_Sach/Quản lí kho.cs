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
    public partial class Quản_lí_kho : Form
    {
        public Quản_lí_kho()
        {
            InitializeComponent();
        }

        //String connectingString;
        //SqlConnection conn;

        DataSet ds = new DataSet("dsQLBS");

        SqlDataAdapter daKho;
        SqlDataAdapter daSach;
        private void Quản_lí_kho_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=HUNG-T0352;Initial Catalog=QLBS;Integrated Security=True";

            //Dử liệu datagrid kho
            string sQueryKho = @" select  MaKHO, TenKHO, DC, SoDT from KHO";
            daKho = new SqlDataAdapter(sQueryKho, conn);
            daKho.Fill(ds, "tblDSKHO");
            dtgvQLK.DataSource = ds.Tables["tblDSKHO"];
            dtgvQLK.Columns["MaKho"].HeaderText = "Mã Kho";
            dtgvQLK.Columns["MaKho"].Width = 100;

            dtgvQLK.Columns["TenKho"].HeaderText = "Tên Kho";
            dtgvQLK.Columns["TenKho"].Width = 100;

            dtgvQLK.Columns["DC"].HeaderText = "Địa chỉ";
            dtgvQLK.Columns["DC"].Width = 100;

            dtgvQLK.Columns["SoDT"].HeaderText = "Sồ Điện thoại";
            dtgvQLK.Columns["SoDT"].Width = 100;

            string sThemKho = @"insert into Sach values(@MaKho, @TenKho, @DiaChi, @SoDienThoai)";
            SqlCommand cmThemKho = new SqlCommand(sThemKho, conn);
            cmThemKho.Parameters.Add("@MaKho", SqlDbType.NVarChar, 15, "MaKho");
            cmThemKho.Parameters.Add("@TenKho", SqlDbType.NVarChar, 20, "TenKho");
            cmThemKho.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 40, "DiaChi");
            cmThemKho.Parameters.Add("@SoDienThoai", SqlDbType.VarChar, 20, "SoDienThoai");
            daKho.InsertCommand = cmThemKho;

            //Dử liệu datagrid Sach
            string sQuerySach = @"select  MaSach, TenSach, TacGia, MaLoai, DonGia, SLTon from Sach ";
            daSach = new SqlDataAdapter(sQuerySach, conn);
            daSach.Fill(ds, "tblDSSach");
            dtgvS.DataSource = ds.Tables["tblDSSach"];
            dtgvS.Columns["MaSach"].HeaderText = "Mã Sách";
            dtgvS.Columns["MaSach"].Width = 100;

            dtgvS.Columns["TenSach"].HeaderText = "Tên Sách";
            dtgvS.Columns["MaSach"].Width = 150;

            dtgvS.Columns["TenSach"].HeaderText = "Tên Sách";
            dtgvS.Columns["MaSach"].Width = 150;

            dtgvS.Columns["TacGia"].HeaderText = "Tác Giả";
            dtgvS.Columns["TacGia"].Width = 150;

            dtgvS.Columns["MaLoai"].HeaderText = "Mã Loại";
            dtgvS.Columns["MaLoai"].Width = 110;

            dtgvS.Columns["DonGia"].HeaderText = "Đơn Giá";
            dtgvS.Columns["DonGia"].Width = 150;

            dtgvS.Columns["SLTon"].HeaderText = "Số Lượng Tồn";
            dtgvS.Columns["SLTon"].Width = 150;

        }

        private void dtgvQLK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dtgvQLK.SelectedRows[0];
            txtMK.Text = dr.Cells["MaKHO"].Value.ToString();
            txtTK.Text = dr.Cells["TenKHO"].Value.ToString();
            cmbNVK.SelectedValue = dr.Cells["DC"].Value.ToString();
            cmbDCK.Text = dr.Cells["DC"].Value.ToString();
            txtSDT.Text = dr.Cells["SoDT"].Value.ToString();
        }

        private void dtgvS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dtgvS.SelectedRows[0];
            txtMS.Text = dr.Cells["MaSach"].Value.ToString();
            txtTS.Text = dr.Cells["TenSach"].Value.ToString();
            txtTG.Text = dr.Cells["TacGia"].Value.ToString();
            txtML.Text = dr.Cells["MaLoai"].Value.ToString();
            txtDG.Text = dr.Cells["DonGia"].Value.ToString();
            txtSL.Text = dr.Cells["SLTon"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Thêm kho
            DataRow row = ds.Tables["tblDSKhO"].NewRow();
            row["MaKhO"] = txtMK.Text;
            row["TenKhO"] = txtTK.Text;
            row["DiaChi"] = cmbDCK.SelectedValue;
            row["DiaChi"] = cmbDCK.Text;
            row["SoDienThoai"] = txtSDT.Text;
            ds.Tables["tblDSKho"].Rows.Add(row);
            //Thêm Sách
            DataRow row1 = ds.Tables["tblDSSach"].NewRow();
            row1["MaSach"] = txtMS.Text;
            row1["TenSach"] = txtTS.Text;
            row1["TacGia"] = txtTG.Text;
            row1["MaLoai"] = txtML.Text;
            row1["DonGia"] = txtDG.Text;
            row1["SLTon"] = txtSL.Text;
            ds.Tables["tblDSSach"].Rows.Add(row1);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtMK.ResetText();
            this.txtTK.ResetText();
            this.cmbDCK.ResetText();
            this.txtSDT.ResetText();
            this.txtMS.ResetText();
            this.txtTS.ResetText();
            this.txtML.ResetText();
            this.txtTG.ResetText();
            this.txtDG.ResetText();
            this.txtSL.ResetText();
            
            foreach (DataGridViewRow dr in this.dtgvS.SelectedRows)
            {
                this.dtgvS.Rows.RemoveAt(dr.Index);
            }
            foreach (DataGridViewRow dr in this.dtgvQLK.SelectedRows)
            {
                this.dtgvQLK.Rows.RemoveAt(dr.Index);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (dtgvQLK.SelectedRows.Count > 0)
            {
                DataGridViewRow dr2 = dtgvQLK.SelectedRows[0];
                dr2.Cells["MaKho"].Value = txtMK.Text;
                dr2.Cells["TenKho"].Value = txtTK.Text;
                dr2.Cells["DiaChi"].Value = cmbDCK.SelectedValue;
                dr2.Cells["DiaChi"].Value = cmbDCK.Text;
                dr2.Cells["SoDienThoai"].Value = txtSDT.Text;
                ds.Tables["tblDSKhO"].Rows.Add(dr2);
            }
            else if (dtgvS.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dtgvS.SelectedRows[0];
                dr.Cells["MaSach"].Value = txtMS.Text;
                dr.Cells["TenSach"].Value = txtTS.Text;
                dr.Cells["TacGia"].Value = txtTG.Text;
                dr.Cells["MaLoai"].Value = txtML.Text;
                ds.Tables["tblDSSach"].Rows.Add(dr);
                dr.Cells["DonGia"].Value = txtDG.Text;
                dr.Cells["SLTon"].Value = txtSL.Text;


            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "tblDSKhO"].EndCurrentEdit();
            this.BindingContext[ds, "tblDSSach"].EndCurrentEdit();
            if (ds.HasChanges() == true)
            {
                if (MessageBox.Show("Bạn có thực sự muốn lưu các thay đổi trên bảng dữ liệu Danh sách nhân viên ?", "Xác nhận thay đổi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        daKho.Update(ds.Tables["tblDSKHO"]);
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMK_MouseClick(object sender, MouseEventArgs e)
        { 
           this.dtgvQLK.Visible = true;
            this.dtgvQLK.Enabled = true;
        }

        private void txtMS_MouseClick(object sender, MouseEventArgs e)
        {
            this.dtgvS.Visible = true;
            this.dtgvS.Enabled = true;
        }
    }
 }
