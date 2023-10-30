
using DevExpress.XtraBars;

namespace NGANHANG
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.barBtnTaoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRutTien = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnGuiTien = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnChuyenTien = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.rbHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbNghiepVu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbNhanVien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sslMaNV = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslHoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslNHOM = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barBtnTaoTaiKhoan
            // 
            this.barBtnTaoTaiKhoan.Caption = "Tạo Tài Khoản";
            this.barBtnTaoTaiKhoan.Enabled = false;
            this.barBtnTaoTaiKhoan.Id = 2;
            this.barBtnTaoTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnTaoTaiKhoan.ImageOptions.Image")));
            this.barBtnTaoTaiKhoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnTaoTaiKhoan.ImageOptions.LargeImage")));
            this.barBtnTaoTaiKhoan.Name = "barBtnTaoTaiKhoan";
            this.barBtnTaoTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnTaoTaiKhoan_ItemClick);
            // 
            // barBtnDangXuat
            // 
            this.barBtnDangXuat.Caption = "Đăng Xuất";
            this.barBtnDangXuat.Enabled = false;
            this.barBtnDangXuat.Id = 3;
            this.barBtnDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnDangXuat.ImageOptions.Image")));
            this.barBtnDangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnDangXuat.ImageOptions.LargeImage")));
            this.barBtnDangXuat.Name = "barBtnDangXuat";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barBtnDangNhap,
            this.barBtnTaoTaiKhoan,
            this.barBtnDangXuat,
            this.barBtnRutTien,
            this.barBtnGuiTien,
            this.barBtnChuyenTien,
            this.btnKhachHang,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ribbonControl1.MaxItemId = 14;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbHeThong,
            this.rbNghiepVu,
            this.rbNhanVien,
            this.rbBaoCao});
            this.ribbonControl1.Size = new System.Drawing.Size(884, 209);
            // 
            // barBtnDangNhap
            // 
            this.barBtnDangNhap.Caption = "Đăng Nhập";
            this.barBtnDangNhap.Id = 1;
            this.barBtnDangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnDangNhap.ImageOptions.Image")));
            this.barBtnDangNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnDangNhap.ImageOptions.LargeImage")));
            this.barBtnDangNhap.Name = "barBtnDangNhap";
            this.barBtnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDangNhap_ItemClick);
            // 
            // barBtnRutTien
            // 
            this.barBtnRutTien.Caption = "Rút tiền";
            this.barBtnRutTien.Id = 4;
            this.barBtnRutTien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnRutTien.ImageOptions.Image")));
            this.barBtnRutTien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnRutTien.ImageOptions.LargeImage")));
            this.barBtnRutTien.Name = "barBtnRutTien";
            this.barBtnRutTien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnRutTien_ItemClick);
            // 
            // barBtnGuiTien
            // 
            this.barBtnGuiTien.Caption = "Thống kê khách hàng";
            this.barBtnGuiTien.Id = 5;
            this.barBtnGuiTien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnGuiTien.ImageOptions.Image")));
            this.barBtnGuiTien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnGuiTien.ImageOptions.LargeImage")));
            this.barBtnGuiTien.Name = "barBtnGuiTien";
            // 
            // barBtnChuyenTien
            // 
            this.barBtnChuyenTien.Caption = "Chuyển tiền";
            this.barBtnChuyenTien.Id = 6;
            this.barBtnChuyenTien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnChuyenTien.ImageOptions.Image")));
            this.barBtnChuyenTien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnChuyenTien.ImageOptions.LargeImage")));
            this.barBtnChuyenTien.Name = "barBtnChuyenTien";
            this.barBtnChuyenTien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnChuyenTien_ItemClick);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Caption = "Khách hàng";
            this.btnKhachHang.Id = 9;
            this.btnKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.ImageOptions.Image")));
            this.btnKhachHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.ImageOptions.LargeImage")));
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhachHang_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Nhân Viên";
            this.barButtonItem1.Id = 10;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Sao Kê Giao dịch";
            this.barButtonItem2.Id = 11;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Thống kê khách hàng";
            this.barButtonItem3.Id = 12;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Thống kê tài khoản";
            this.barButtonItem4.Id = 13;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // rbHeThong
            // 
            this.rbHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rbHeThong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbHeThong.ImageOptions.Image")));
            this.rbHeThong.Name = "rbHeThong";
            this.rbHeThong.Text = "Hệ Thống";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnDangNhap);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnTaoTaiKhoan);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnDangXuat);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // rbNghiepVu
            // 
            this.rbNghiepVu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rbNghiepVu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbNghiepVu.ImageOptions.Image")));
            this.rbNghiepVu.Name = "rbNghiepVu";
            this.rbNghiepVu.Text = "Nghiệp Vụ";
            this.rbNghiepVu.Visible = false;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnRutTien);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnChuyenTien);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // rbNhanVien
            // 
            this.rbNhanVien.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.rbNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbNhanVien.ImageOptions.Image")));
            this.rbNhanVien.Name = "rbNhanVien";
            this.rbNhanVien.Text = "Quản Lý";
            this.rbNhanVien.Visible = false;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnKhachHang);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // rbBaoCao
            // 
            this.rbBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.rbBaoCao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbBaoCao.ImageOptions.Image")));
            this.rbBaoCao.Name = "rbBaoCao";
            this.rbBaoCao.Text = "Báo Cáo";
            this.rbBaoCao.Visible = false;
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslMaNV,
            this.sslHoTen,
            this.sslNHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 464);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sslMaNV
            // 
            this.sslMaNV.Name = "sslMaNV";
            this.sslMaNV.Size = new System.Drawing.Size(52, 20);
            this.sslMaNV.Text = "MANV";
            // 
            // sslHoTen
            // 
            this.sslHoTen.Name = "sslHoTen";
            this.sslHoTen.Size = new System.Drawing.Size(57, 20);
            this.sslHoTen.Text = "HOTEN";
            // 
            // sslNHOM
            // 
            this.sslNHOM.Name = "sslNHOM";
            this.sslNHOM.Size = new System.Drawing.Size(57, 20);
            this.sslNHOM.Text = "MHOM";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 490);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Ribbon = this.ribbonControl1;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barBtnDangNhap;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem barBtnRutTien;
        private DevExpress.XtraBars.BarButtonItem barBtnGuiTien;
        private DevExpress.XtraBars.BarButtonItem barBtnChuyenTien;
        private DevExpress.XtraBars.BarButtonItem btnKhachHang;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel sslMaNV;
        public System.Windows.Forms.ToolStripStatusLabel sslHoTen;
        public System.Windows.Forms.ToolStripStatusLabel sslNHOM;
        public DevExpress.XtraBars.BarButtonItem barBtnTaoTaiKhoan;
        public DevExpress.XtraBars.BarButtonItem barBtnDangXuat;
        private BarButtonItem barButtonItem1;
        private BarButtonItem barButtonItem2;
        private BarButtonItem barButtonItem3;
        private BarButtonItem barButtonItem4;
        public DevExpress.XtraBars.Ribbon.RibbonPage rbNghiepVu;
        public DevExpress.XtraBars.Ribbon.RibbonPage rbNhanVien;
        public DevExpress.XtraBars.Ribbon.RibbonPage rbBaoCao;
    }
}

