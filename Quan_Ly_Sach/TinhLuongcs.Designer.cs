namespace Quan_Ly_Sach
{
    partial class TinhLuongcs
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
            this.btnLuuTTNV = new System.Windows.Forms.Button();
            this.dtgThongTinNV = new System.Windows.Forms.DataGridView();
            this.grbTTnv = new System.Windows.Forms.GroupBox();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.radbNu = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.radbNam = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtHoLotNV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txttienluong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbttngaylm = new System.Windows.Forms.GroupBox();
            this.cboMLuong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radbFullTime = new System.Windows.Forms.RadioButton();
            this.radbPartTime = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.txtSoNgayLmVC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTinhLuong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgThongTinNV)).BeginInit();
            this.grbTTnv.SuspendLayout();
            this.grbttngaylm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLuuTTNV
            // 
            this.btnLuuTTNV.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLuuTTNV.Location = new System.Drawing.Point(1021, 149);
            this.btnLuuTTNV.Name = "btnLuuTTNV";
            this.btnLuuTTNV.Size = new System.Drawing.Size(152, 102);
            this.btnLuuTTNV.TabIndex = 40;
            this.btnLuuTTNV.Text = "Lưu";
            this.btnLuuTTNV.UseVisualStyleBackColor = true;
            this.btnLuuTTNV.Click += new System.EventHandler(this.btnTK_Click_1);
            // 
            // dtgThongTinNV
            // 
            this.dtgThongTinNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgThongTinNV.Location = new System.Drawing.Point(75, 330);
            this.dtgThongTinNV.Name = "dtgThongTinNV";
            this.dtgThongTinNV.RowHeadersWidth = 51;
            this.dtgThongTinNV.RowTemplate.Height = 29;
            this.dtgThongTinNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgThongTinNV.Size = new System.Drawing.Size(1134, 274);
            this.dtgThongTinNV.TabIndex = 34;
            this.dtgThongTinNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgThongTinNV_CellContentClick_1);
            // 
            // grbTTnv
            // 
            this.grbTTnv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grbTTnv.Controls.Add(this.cboChucVu);
            this.grbTTnv.Controls.Add(this.radbNu);
            this.grbTTnv.Controls.Add(this.label6);
            this.grbTTnv.Controls.Add(this.radbNam);
            this.grbTTnv.Controls.Add(this.label15);
            this.grbTTnv.Controls.Add(this.label7);
            this.grbTTnv.Controls.Add(this.txtMaNV);
            this.grbTTnv.Controls.Add(this.label8);
            this.grbTTnv.Controls.Add(this.txtTenNV);
            this.grbTTnv.Controls.Add(this.txtHoLotNV);
            this.grbTTnv.Controls.Add(this.label9);
            this.grbTTnv.Location = new System.Drawing.Point(32, 88);
            this.grbTTnv.Name = "grbTTnv";
            this.grbTTnv.Size = new System.Drawing.Size(332, 215);
            this.grbTTnv.TabIndex = 33;
            this.grbTTnv.TabStop = false;
            // 
            // cboChucVu
            // 
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Items.AddRange(new object[] {
            "Quản Lý",
            "Nhân Viên"});
            this.cboChucVu.Location = new System.Drawing.Point(106, 178);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(154, 31);
            this.cboChucVu.TabIndex = 16;
            // 
            // radbNu
            // 
            this.radbNu.AutoSize = true;
            this.radbNu.Location = new System.Drawing.Point(203, 140);
            this.radbNu.Name = "radbNu";
            this.radbNu.Size = new System.Drawing.Size(57, 27);
            this.radbNu.TabIndex = 14;
            this.radbNu.TabStop = true;
            this.radbNu.Text = "Nữ";
            this.radbNu.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Chức Vụ";
            // 
            // radbNam
            // 
            this.radbNam.AutoSize = true;
            this.radbNam.Location = new System.Drawing.Point(106, 142);
            this.radbNam.Name = "radbNam";
            this.radbNam.Size = new System.Drawing.Size(70, 27);
            this.radbNam.TabIndex = 13;
            this.radbNam.TabStop = true;
            this.radbNam.Text = "Nam";
            this.radbNam.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 142);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 23);
            this.label15.TabIndex = 3;
            this.label15.Text = "Phái:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã NV:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(106, 29);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(220, 30);
            this.txtMaNV.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tên:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(106, 104);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(220, 30);
            this.txtTenNV.TabIndex = 2;
            // 
            // txtHoLotNV
            // 
            this.txtHoLotNV.Location = new System.Drawing.Point(106, 65);
            this.txtHoLotNV.Name = "txtHoLotNV";
            this.txtHoLotNV.Size = new System.Drawing.Size(220, 30);
            this.txtHoLotNV.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Họ Lót:";
            // 
            // txttienluong
            // 
            this.txttienluong.Location = new System.Drawing.Point(738, 149);
            this.txttienluong.Name = "txttienluong";
            this.txttienluong.Size = new System.Drawing.Size(179, 30);
            this.txttienluong.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(514, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 42);
            this.label1.TabIndex = 32;
            this.label1.Text = "Thông Tin Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(738, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 36;
            this.label2.Text = "Tiền Lương:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // grbttngaylm
            // 
            this.grbttngaylm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grbttngaylm.Controls.Add(this.cboMLuong);
            this.grbttngaylm.Controls.Add(this.label5);
            this.grbttngaylm.Controls.Add(this.label4);
            this.grbttngaylm.Controls.Add(this.radbFullTime);
            this.grbttngaylm.Controls.Add(this.radbPartTime);
            this.grbttngaylm.Controls.Add(this.label17);
            this.grbttngaylm.Controls.Add(this.txtSoNgayLmVC);
            this.grbttngaylm.Controls.Add(this.label3);
            this.grbttngaylm.Location = new System.Drawing.Point(370, 88);
            this.grbttngaylm.Name = "grbttngaylm";
            this.grbttngaylm.Size = new System.Drawing.Size(332, 215);
            this.grbttngaylm.TabIndex = 37;
            this.grbttngaylm.TabStop = false;
            // 
            // cboMLuong
            // 
            this.cboMLuong.FormattingEnabled = true;
            this.cboMLuong.Location = new System.Drawing.Point(145, 34);
            this.cboMLuong.Name = "cboMLuong";
            this.cboMLuong.Size = new System.Drawing.Size(145, 31);
            this.cboMLuong.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Mã Lương:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "PartTime";
            // 
            // radbFullTime
            // 
            this.radbFullTime.AutoSize = true;
            this.radbFullTime.Location = new System.Drawing.Point(145, 85);
            this.radbFullTime.Name = "radbFullTime";
            this.radbFullTime.Size = new System.Drawing.Size(51, 27);
            this.radbFullTime.TabIndex = 13;
            this.radbFullTime.TabStop = true;
            this.radbFullTime.Text = "8h";
            this.radbFullTime.UseVisualStyleBackColor = true;
            // 
            // radbPartTime
            // 
            this.radbPartTime.AutoSize = true;
            this.radbPartTime.Location = new System.Drawing.Point(145, 124);
            this.radbPartTime.Name = "radbPartTime";
            this.radbPartTime.Size = new System.Drawing.Size(51, 27);
            this.radbPartTime.TabIndex = 12;
            this.radbPartTime.TabStop = true;
            this.radbPartTime.Text = "5h";
            this.radbPartTime.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 89);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 23);
            this.label17.TabIndex = 5;
            this.label17.Text = "FullTime";
            // 
            // txtSoNgayLmVC
            // 
            this.txtSoNgayLmVC.Location = new System.Drawing.Point(145, 170);
            this.txtSoNgayLmVC.Name = "txtSoNgayLmVC";
            this.txtSoNgayLmVC.Size = new System.Drawing.Size(145, 30);
            this.txtSoNgayLmVC.TabIndex = 10;
            this.txtSoNgayLmVC.Click += new System.EventHandler(this.txtSoNgayLmVC_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Số Ngày Làm:";
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Location = new System.Drawing.Point(738, 192);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(143, 59);
            this.btnTinhLuong.TabIndex = 35;
            this.btnTinhLuong.Text = "Tính";
            this.btnTinhLuong.UseVisualStyleBackColor = true;
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            // 
            // TinhLuongcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1261, 649);
            this.Controls.Add(this.btnLuuTTNV);
            this.Controls.Add(this.dtgThongTinNV);
            this.Controls.Add(this.grbTTnv);
            this.Controls.Add(this.txttienluong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grbttngaylm);
            this.Controls.Add(this.btnTinhLuong);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TinhLuongcs";
            this.Text = "TinhLuongcs";
            this.Load += new System.EventHandler(this.TinhLuongcs_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtgThongTinNV)).EndInit();
            this.grbTTnv.ResumeLayout(false);
            this.grbTTnv.PerformLayout();
            this.grbttngaylm.ResumeLayout(false);
            this.grbttngaylm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnLuuTTNV;
        private DataGridView dtgThongTinNV;
        private GroupBox grbTTnv;
        private RadioButton radbNu;
        private RadioButton radbNam;
        private Label label15;
        private Label label7;
        private TextBox txtMaNV;
        private Label label8;
        private TextBox txtTenNV;
        private TextBox txtHoLotNV;
        private Label label9;
        private TextBox txttienluong;
        private Label label1;
        private Label label2;
        private GroupBox grbttngaylm;
        private ComboBox cboChucVu;
        private Label label6;
        private Label label4;
        private RadioButton radbFullTime;
        private RadioButton radbPartTime;
        private Label label17;
        private TextBox txtSoNgayLmVC;
        private Label label3;
        private Button btnTinhLuong;
        private ComboBox cboMLuong;
        private Label label5;
    }
}