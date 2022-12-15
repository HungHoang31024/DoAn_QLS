namespace Quan_Ly_Sach
{
    partial class DNhap
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
            this.lblTenTK = new System.Windows.Forms.Label();
            this.lblMKhau = new System.Windows.Forms.Label();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.txtMKhau = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblTenTK
            // 
            this.lblTenTK.AutoSize = true;
            this.lblTenTK.BackColor = System.Drawing.Color.DarkGray;
            this.lblTenTK.Location = new System.Drawing.Point(50, 129);
            this.lblTenTK.Name = "lblTenTK";
            this.lblTenTK.Size = new System.Drawing.Size(150, 27);
            this.lblTenTK.TabIndex = 0;
            this.lblTenTK.Text = "Tên tài khoản:";
            // 
            // lblMKhau
            // 
            this.lblMKhau.AutoSize = true;
            this.lblMKhau.Location = new System.Drawing.Point(50, 274);
            this.lblMKhau.Name = "lblMKhau";
            this.lblMKhau.Size = new System.Drawing.Size(110, 27);
            this.lblMKhau.TabIndex = 0;
            this.lblMKhau.Text = "Mật khẩu:";
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(202, 126);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(390, 35);
            this.txtTenTK.TabIndex = 1;
            // 
            // txtMKhau
            // 
            this.txtMKhau.Location = new System.Drawing.Point(202, 271);
            this.txtMKhau.Name = "txtMKhau";
            this.txtMKhau.Size = new System.Drawing.Size(390, 35);
            this.txtMKhau.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "Đăng nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.Location = new System.Drawing.Point(477, 339);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(115, 31);
            this.rdb1.TabIndex = 3;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "Ghi nhớ";
            this.rdb1.UseVisualStyleBackColor = true;
            // 
            // DNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(671, 516);
            this.Controls.Add(this.rdb1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMKhau);
            this.Controls.Add(this.txtTenTK);
            this.Controls.Add(this.lblMKhau);
            this.Controls.Add(this.lblTenTK);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DNhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTenTK;
        private Label lblMKhau;
        private TextBox txtTenTK;
        private TextBox txtMKhau;
        private Button button1;
        private RadioButton rdb1;
    }
}