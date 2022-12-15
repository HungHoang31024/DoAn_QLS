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
    public partial class Hóa_Đơn : Form
    {
        public Hóa_Đơn()
        {
            InitializeComponent();
        }

        String connectingString;
        SqlConnection conn;

        DataSet ds = new DataSet("dsQLHD");

        SqlDataAdapter daHD;
        private void Hóa_Đơn_Load(object sender, EventArgs e)
        {
            //loadData();
           /* this.txtTenNV.Text = tenNV;
            this.txtmasach.Text = ms;
            this.txtTS.Text = tensach;
            this.txtdonGia.Text = dongia;
            this.txtsl.Text = sol;
            this.txtMaKhach.Text = mkh;
            this.dtpNgayMua.Text = ngm;
            this.dtpGiomua.Text = giomua;
            this.txtSDT.Text = SDTkh;*/


            ListViewItem item = lsvHoaDon.Items.Add(tenNV);
            item.SubItems.Add(ms);
            item.SubItems.Add(tensach);
            item.SubItems.Add(dongia);
            item.SubItems.Add(sol);
            item.SubItems.Add(mkh);
            item.SubItems.Add(ngm);
 
            //2
            ListViewItem item1 = lsvHoaDon.Items.Add(tenNV2);
            item1.SubItems.Add(ms2);
            item1.SubItems.Add(tensach2);
            item1.SubItems.Add(dongia2);
            item1.SubItems.Add(sol2);
            item1.SubItems.Add(mkh2);
            item1.SubItems.Add(ngm2);
     
            //3
            ListViewItem item2 = lsvHoaDon.Items.Add(tenNV3);
            item2.SubItems.Add(ms3);
            item2.SubItems.Add(tensach3);
            item2.SubItems.Add(dongia3);
            item2.SubItems.Add(sol3);
            item2.SubItems.Add(mkh3);
            item2.SubItems.Add(ngm3);
          
            //4
            ListViewItem item3 = lsvHoaDon.Items.Add(tenNV4);
            item3.SubItems.Add(ms4);
            item3.SubItems.Add(tensach4);
            item3.SubItems.Add(dongia4);
            item3.SubItems.Add(sol4);
            item3.SubItems.Add(mkh4);
            item3.SubItems.Add(ngm4);
    
            //5
            ListViewItem item4 = lsvHoaDon.Items.Add(tenNV5);     
            item4.SubItems.Add(ms5);
            item4.SubItems.Add(tensach5);
            item4.SubItems.Add(dongia5);
            item4.SubItems.Add(sol5);
            item4.SubItems.Add(mkh5);
            item4.SubItems.Add(ngm5);
      
        }
        public string  tenNV, ms, tensach, dongia, sol, mkh, ngm;
        public string tenNV2, ms2, tensach2, dongia2, sol2, mkh2, ngm2;
        public string tenNV3, ms3, tensach3, dongia3, sol3, mkh3, ngm3;
        public string tenNV4, ms4, tensach4, dongia4, sol4, mkh4, ngm4;
        public string tenNV5, ms5, tensach5, dongia5, sol5, mkh5, ngm5;
        public string tenNV6, ms6, tensach6, dongia6, sol6, mkh6, ngm6;
        public string tenNV7, ms7, tensach7, dongia7, sol7, mkh7, ngm7;
        public string tenNV8, ms8, tensach8, dongia8, sol8, mkh8, ngm8;

        public void Sum()
        {
            int s, s1, s2, s3, s4, s5,s6;
            string t, t1, t2, t3, t4, t5, t6;
            t1 =lsvHoaDon.SelectedItems[0].SubItems[3].Text;
            t2 = lsvHoaDon.SelectedItems[1].SubItems[3].Text;
            t3 = lsvHoaDon.SelectedItems[2].SubItems[3].Text;
            t4 = lsvHoaDon.SelectedItems[3].SubItems[3].Text;
            t5 = lsvHoaDon.SelectedItems[4].SubItems[3].Text;
            s1 = int.Parse(t1);
            s2 = int.Parse(t2);
            s3 = int.Parse(t3);
            s4 = int.Parse(t4);
            s5 = int.Parse(t5);
            s = s1 + s2 + s3 + s4 + s5;
            t6 = Convert.ToString(s);
            this.txtTongt.Text = t6;
         
        }   
        private void btnTongTien_Click(object sender, EventArgs e)
        {
            Sum();
            
        }

       
        /* public void loadData()
         {
             SqlConnection conn = new SqlConnection();
             conn.ConnectionString = @"Data Source=HUNG-T0352;Initial Catalog=master;Integrated Security=True";
             //Dử liệu datagrid Hoa Don
             string sQueryNhanVien = @" select  MaNV, MaSach, Tensach, DonGia, SoLuong, MaKhach, TenKhach, NgayMua, GioMua, SoDienThoai from HoaDon";
             daHD = new SqlDataAdapter(sQueryNhanVien, conn);
             daHD.Fill(ds, "tblDSNV");





         }*/
    }
    }
