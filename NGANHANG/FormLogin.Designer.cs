
namespace NGANHANG
{
    partial class FormLogin
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
            this.lbChiNhanh = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cbxChiNhanh = new System.Windows.Forms.ComboBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbChiNhanh
            // 
            this.lbChiNhanh.AutoSize = true;
            this.lbChiNhanh.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lbChiNhanh.Location = new System.Drawing.Point(125, 62);
            this.lbChiNhanh.Name = "lbChiNhanh";
            this.lbChiNhanh.Size = new System.Drawing.Size(121, 29);
            this.lbChiNhanh.TabIndex = 0;
            this.lbChiNhanh.Text = "Chi Nhánh";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lbUserName.Location = new System.Drawing.Point(125, 129);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(180, 29);
            this.lbUserName.TabIndex = 2;
            this.lbUserName.Text = "Tên Đăng Nhập";
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lbMatKhau.Location = new System.Drawing.Point(125, 193);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(114, 29);
            this.lbMatKhau.TabIndex = 3;
            this.lbMatKhau.Text = "Mật Khẩu";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkGray;
            this.btnLogin.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnLogin.Location = new System.Drawing.Point(130, 284);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(211, 52);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.OrangeRed;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnThoat.Location = new System.Drawing.Point(520, 284);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(211, 52);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cbxChiNhanh
            // 
            this.cbxChiNhanh.DisplayMember = "TENCN";
            this.cbxChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChiNhanh.Font = new System.Drawing.Font("Tahoma", 14F);
            this.cbxChiNhanh.FormattingEnabled = true;
            this.cbxChiNhanh.Location = new System.Drawing.Point(407, 59);
            this.cbxChiNhanh.Name = "cbxChiNhanh";
            this.cbxChiNhanh.Size = new System.Drawing.Size(324, 36);
            this.cbxChiNhanh.TabIndex = 8;
            this.cbxChiNhanh.ValueMember = "TENSERVER";
            this.cbxChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbxChiNhanh_SelectedIndexChanged);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtTenDangNhap.Location = new System.Drawing.Point(407, 126);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(324, 36);
            this.txtTenDangNhap.TabIndex = 9;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtMatKhau.Location = new System.Drawing.Point(407, 190);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '●';
            this.txtMatKhau.Size = new System.Drawing.Size(324, 36);
            this.txtMatKhau.TabIndex = 10;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 392);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.cbxChiNhanh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.lbChiNhanh);
            this.IsMdiContainer = true;
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbChiNhanh;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cbxChiNhanh;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
    }
}