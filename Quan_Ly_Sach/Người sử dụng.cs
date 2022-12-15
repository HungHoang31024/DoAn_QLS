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
    public partial class Người_sử_dụng : Form
    {
        public Người_sử_dụng()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DNhap Dn = new DNhap();
            Dn.ShowDialog();
        }

        private void Người_sử_dụng_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            DNhap Dn = new DNhap();
            Dn.ShowDialog();
        }
    }
}
