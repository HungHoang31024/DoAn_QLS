using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Sach
{
    public partial class DNhap : Form
    {
        public DNhap()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //quản lí
            if ((this.txtTenTK.Text == "") || (this.txtMKhau.Text == ""))
            {

                MessageBox.Show("Vui lòng nhập tên người dùng hoặc mật khẩu");
            }
            else
            {
                if ((this.txtTenTK.Text == "qlMinhAnh") && (this.txtMKhau.Text == "abc12345"))
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    this.Close();
                    Chức_năng CN = new Chức_năng();
                    CN.ShowDialog();
                }
                else if((this.txtTenTK.Text == "nvkhoa") && (this.txtMKhau.Text == "12345"))
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    this.Close();
                    Chức_năng_nhân_viên CNNV = new Chức_năng_nhân_viên();
                    CNNV.ShowDialog();
                }
                else if ((this.txtTenTK.Text == "NVQuynhCongChua") && (this.txtMKhau.Text == "9999."))
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    this.Close();
                    Chức_năng_nhân_viên CNNV = new Chức_năng_nhân_viên();
                    CNNV.ShowDialog();
                }
                else
                {
                    if (this.rdb1.Checked == true)
                    {
                        String thongbao = "\n\rBạn có ghi nhớ.";
                    }
                    MessageBox.Show("Tên và mật khẩu không đúng, hãy nhập lại", "Thông báo");
                    this.txtTenTK.Clear();
                    this.txtMKhau.Clear(); this.txtTenTK.Focus();
                }
            }
             

            this.Close();

        }
    }
}
