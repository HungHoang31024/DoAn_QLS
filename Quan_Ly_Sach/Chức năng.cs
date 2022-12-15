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
    public partial class Chức_năng : Form
    {
        public Chức_năng()
        {
            InitializeComponent();
        }

        private void tsmTke_Click(object sender, EventArgs e)
        {
           /* ThongKe TK = new ThongKe();
            TK.ShowDialog();*/
        }

        private void tsmTluong_Click(object sender, EventArgs e)
        {
            TinhLuongcs TL = new TinhLuongcs();
            TL.ShowDialog();
        }

        private void stmQLNVien_Click(object sender, EventArgs e)
        {
            Quản_lí_nhân_viên QLNV = new Quản_lí_nhân_viên();
            QLNV.ShowDialog();
        }

        private void tsmQLSach_Click(object sender, EventArgs e)
        {

        }

        private void stmKho_Click(object sender, EventArgs e)
        {
            Quản_lí_kho QLK = new Quản_lí_kho();
            QLK.ShowDialog();
        }

        private void tsmHDBS_Click(object sender, EventArgs e)
        {
            HDBSach HDBS = new HDBSach();
            HDBS.ShowDialog();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLSach Qlsach = new QLSach();
            Qlsach.ShowDialog();
        }
    }
}
