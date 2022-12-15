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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quan_Ly_Sach
{
    public partial class ThongKe : Form
    {
        //public ListView _listView { get; set; }  
        // public ListViewItem[] Items { get; set; }
        //public ListViewItem[] Items { get; set; }
        public ThongKe()
        {
            InitializeComponent();

        }
      

        public string manv, holot, ten, phai11, chucvu, giol, songay, tienluong;
        public string manv2, holot2, ten2, phai2, chucvu2, giol2, songay2, tienluong2;
        public string manv3, holot3, ten3, phai3, chucvu3, giol3, songay3, tienluong3;
        public string manv4, holot4, ten4, phai4, chucvu4, giol4, songay4, tienluong4;
        public string manv5, holot5, ten5, phai5, chucvu5, giol5, songay5, tienluong5;

        public string makho, tenk, diachiKH, SDTkho, Tensach, slTon, tenNhanv;
        public string makho2, tenk2, diachiKH2, SDTkho2, Tensach2, slTon2, tenNhanv2;
        public string makho3, tenk3, diachiKH3, SDTkho3, Tensach3, slTon3, tenNhanv3;
        public string makho4, tenk4, diachiKH4, SDTkho4, Tensach4, slTon4, tenNhanv4;

        private ListViewItem.ListViewSubItem listViewSubItem;

        private void sốLượngSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.grbTKSach.Enabled = true;
            this.grbTKSach.Visible = true;   

            ListViewItem item = lsvThongKSach.Items.Add(makho);            
            item.SubItems.Add(tenk);
            item.SubItems.Add(SDTkho);
            item.SubItems.Add(diachiKH);
            
            item.SubItems.Add(Tensach);
            item.SubItems.Add(slTon);
            item.SubItems.Add(tenNhanv);
            //2
            ListViewItem item2 = lsvThongKSach.Items.Add(makho2);
           
            item2.SubItems.Add(tenk2);
            item2.SubItems.Add(SDTkho2);
            item2.SubItems.Add(diachiKH2);
          
            item2.SubItems.Add(Tensach2);
            item2.SubItems.Add(slTon2);
            item2.SubItems.Add(tenNhanv2);

            //3
            ListViewItem item3 = lsvThongKSach.Items.Add(makho3);
            item3.SubItems.Add(tenk3);
            item3.SubItems.Add(SDTkho3);
            item3.SubItems.Add(diachiKH3);
          
            item3.SubItems.Add(Tensach3);
            item3.SubItems.Add(slTon3);
            item3.SubItems.Add(tenNhanv3);
        
            //4
            ListViewItem item4 = lsvThongKSach.Items.Add(makho4);
            item4.SubItems.Add(tenk4);
            item4.SubItems.Add(SDTkho4);
            item4.SubItems.Add(diachiKH4);
           
            item4.SubItems.Add(Tensach4);
            item4.SubItems.Add(slTon4);
            item4.SubItems.Add(tenNhanv4);
                       
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.grbTKSach.Enabled = false;
            this.grbTKSach.Visible = false;
            this.grbNV.Enabled = true;
            this.grbNV.Visible = true;
            /*  lsvTKnv.Items.Add(manv);
              lsvTKnv.Items.Add(holot);
              lsvTKnv.Items.Add(ten);
              lsvTKnv.Items.Add(phai);
              lsvTKnv.Items.Add(giol);
              lsvTKnv.Items.Add(songay);
              lsvTKnv.Items.Add(tienluong);*/
            ListViewItem item = lsvTKnv.Items.Add(manv);
            item.SubItems.Add(holot);
            item.SubItems.Add(ten);
            item.SubItems.Add(phai11);
            item.SubItems.Add(chucvu);
            item.SubItems.Add(giol);
            item.SubItems.Add(songay);
            item.SubItems.Add(tienluong);
            //2
            ListViewItem item2 = lsvTKnv.Items.Add(manv2);
            item2.SubItems.Add(holot2);
            item2.SubItems.Add(ten2);
            item2.SubItems.Add(phai2);
            item2.SubItems.Add(chucvu2);
            item2.SubItems.Add(giol2);
            item2.SubItems.Add(songay2);
            item2.SubItems.Add(tienluong2);
            //3
            ListViewItem item3 = lsvTKnv.Items.Add(manv3);
            item3.SubItems.Add(holot3);
            item3.SubItems.Add(ten3);
            item3.SubItems.Add(phai3);
            item3.SubItems.Add(chucvu3);
            item3.SubItems.Add(giol3);
            item3.SubItems.Add(songay3);
            item3.SubItems.Add(tienluong3);
            //4
            ListViewItem item4 = lsvTKnv.Items.Add(manv4);
            item4.SubItems.Add(holot4);
            item4.SubItems.Add(ten4);
            item4.SubItems.Add(phai4);
            item4.SubItems.Add(chucvu4);
            item4.SubItems.Add(giol4);
            item4.SubItems.Add(songay4);
            item4.SubItems.Add(tienluong4);
            //5
            ListViewItem item5 = lsvTKnv.Items.Add(manv5);
            item5.SubItems.Add(holot5);
            item5.SubItems.Add(ten5);
            item5.SubItems.Add(phai5);
            item5.SubItems.Add(chucvu5);
            item5.SubItems.Add(giol5);
            item5.SubItems.Add(songay5);
            item5.SubItems.Add(tienluong5);
        }

        private void ThongKe_Load_1(object sender, EventArgs e)
        {
            //lsvTKnv.Items.AddRange((from ListViewItem item in _listView.Items select (ListViewItem)item.Clone()).ToArray());
            //  lsvTKnv.Items. = Items[0].SubItems[0].Text;
            //tk = lblTKNV.Text.ToString(); 
           

        }
    }
}
