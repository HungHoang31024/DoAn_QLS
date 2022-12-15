namespace Quan_Ly_Sach
{
    partial class Chức_năng_nhân_viên
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblGT = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmQLSach = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmQLKho = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDBHang = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(16, 251);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(666, 295);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblGT
            // 
            this.lblGT.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGT.ForeColor = System.Drawing.Color.Blue;
            this.lblGT.Location = new System.Drawing.Point(34, 118);
            this.lblGT.Name = "lblGT";
            this.lblGT.Size = new System.Drawing.Size(608, 72);
            this.lblGT.TabIndex = 1;
            this.lblGT.Text = "Chào mừng bạn đến với cửa hàng";
            this.lblGT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmQLSach,
            this.tsmQLKho,
            this.tsmDBHang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(712, 35);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmQLSach
            // 
            this.tsmQLSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsmQLSach.Name = "tsmQLSach";
            this.tsmQLSach.Size = new System.Drawing.Size(147, 31);
            this.tsmQLSach.Text = "Quản lí sách";
            this.tsmQLSach.Click += new System.EventHandler(this.tsmQLSach_Click);
            // 
            // tsmQLKho
            // 
            this.tsmQLKho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsmQLKho.Name = "tsmQLKho";
            this.tsmQLKho.Size = new System.Drawing.Size(140, 31);
            this.tsmQLKho.Text = "Quản lí kho";
            this.tsmQLKho.Click += new System.EventHandler(this.tsmQLKho_Click);
            // 
            // tsmDBHang
            // 
            this.tsmDBHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsmDBHang.Name = "tsmDBHang";
            this.tsmDBHang.Size = new System.Drawing.Size(163, 31);
            this.tsmDBHang.Text = "Đơn bán hàng";
            this.tsmDBHang.Click += new System.EventHandler(this.tsmDBHang_Click);
            // 
            // Chức_năng_nhân_viên
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(712, 584);
            this.Controls.Add(this.lblGT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Chức_năng_nhân_viên";
            this.Text = "Chức_năng_nhân_viên";
            this.Load += new System.EventHandler(this.Chức_năng_nhân_viên_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblGT;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmQLSach;
        private ToolStripMenuItem tsmQLKho;
        private ToolStripMenuItem tsmDBHang;
    }
}