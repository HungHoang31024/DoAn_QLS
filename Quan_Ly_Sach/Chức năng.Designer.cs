namespace Quan_Ly_Sach
{
    partial class Chức_năng
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmTke = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTluong = new System.Windows.Forms.ToolStripMenuItem();
            this.stmQLNVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmQLSach = new System.Windows.Forms.ToolStripMenuItem();
            this.stmKho = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHDBS = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(214, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lí cửa hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(43, 213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(764, 363);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTke,
            this.tsmTluong,
            this.stmQLNVien,
            this.tsmQLSach,
            this.stmKho,
            this.tsmHDBS,
            this.quảnLýSáchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(860, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmTke
            // 
            this.tsmTke.Name = "tsmTke";
            this.tsmTke.Size = new System.Drawing.Size(102, 29);
            this.tsmTke.Text = "Thống kê";
            this.tsmTke.Click += new System.EventHandler(this.tsmTke_Click);
            // 
            // tsmTluong
            // 
            this.tsmTluong.Name = "tsmTluong";
            this.tsmTluong.Size = new System.Drawing.Size(113, 29);
            this.tsmTluong.Text = "Tính lương";
            this.tsmTluong.Click += new System.EventHandler(this.tsmTluong_Click);
            // 
            // stmQLNVien
            // 
            this.stmQLNVien.Name = "stmQLNVien";
            this.stmQLNVien.Size = new System.Drawing.Size(165, 29);
            this.stmQLNVien.Text = "Quản lí nhân viên";
            this.stmQLNVien.Click += new System.EventHandler(this.stmQLNVien_Click);
            // 
            // tsmQLSach
            // 
            this.tsmQLSach.Name = "tsmQLSach";
            this.tsmQLSach.Size = new System.Drawing.Size(124, 29);
            this.tsmQLSach.Text = "Quản lí sách";
            this.tsmQLSach.Click += new System.EventHandler(this.tsmQLSach_Click);
            // 
            // stmKho
            // 
            this.stmKho.Name = "stmKho";
            this.stmKho.Size = new System.Drawing.Size(119, 29);
            this.stmKho.Text = "Quản lí kho";
            this.stmKho.Click += new System.EventHandler(this.stmKho_Click);
            // 
            // tsmHDBS
            // 
            this.tsmHDBS.Name = "tsmHDBS";
            this.tsmHDBS.Size = new System.Drawing.Size(175, 29);
            this.tsmHDBS.Text = "Hóa đơn bán Sách";
            this.tsmHDBS.Click += new System.EventHandler(this.tsmHDBS_Click);
            // 
            // quảnLýSáchToolStripMenuItem
            // 
            this.quảnLýSáchToolStripMenuItem.Name = "quảnLýSáchToolStripMenuItem";
            this.quảnLýSáchToolStripMenuItem.Size = new System.Drawing.Size(134, 29);
            this.quảnLýSáchToolStripMenuItem.Text = "Quản Lý Sách";
            this.quảnLýSáchToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSáchToolStripMenuItem_Click);
            // 
            // Chức_năng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(860, 588);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Chức_năng";
            this.Text = "Chức năng";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmTke;
        private ToolStripMenuItem tsmTluong;
        private ToolStripMenuItem stmQLNVien;
        private ToolStripMenuItem tsmQLSach;
        private ToolStripMenuItem stmKho;
        private ToolStripMenuItem tsmHDBS;
        private ToolStripMenuItem quảnLýSáchToolStripMenuItem;
    }
}