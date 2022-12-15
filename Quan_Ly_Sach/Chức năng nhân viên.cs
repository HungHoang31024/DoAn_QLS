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
    public partial class Chức_năng_nhân_viên : Form
    {
        public Chức_năng_nhân_viên()
        {
            InitializeComponent();
        }

        private void Chức_năng_nhân_viên_Load(object sender, EventArgs e)
        {

        }

        private void tsmQLSach_Click(object sender, EventArgs e)
        {

        }

        private void tsmQLKho_Click(object sender, EventArgs e)
        {
            Quản_lí_kho QLK = new Quản_lí_kho();
            QLK.ShowDialog();
        }

        private void tsmDBHang_Click(object sender, EventArgs e)
        {
            HDBSach HDBS = new HDBSach();
            HDBS.ShowDialog();
        }
    }
}
