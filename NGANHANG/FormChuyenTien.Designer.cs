
namespace NGANHANG
{
    partial class FormChuyenTien
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label sOTKLabel;
            System.Windows.Forms.Label hOTENLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label cMNDLabel1;
            System.Windows.Forms.Label sOTKLabel1;
            System.Windows.Forms.Label hOTENLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChuyenTien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnInDanhSach = new DevExpress.XtraBars.BarButtonItem();
            this.pnChiNhanh = new DevExpress.XtraEditors.PanelControl();
            this.cbxChiNhanh = new System.Windows.Forms.ComboBox();
            this.lbChiNhanh = new System.Windows.Forms.Label();
            this.dS = new NGANHANG.DS();
            this.gD_CHUYENTIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD_CHUYENTIENTableAdapter = new NGANHANG.DSTableAdapters.GD_CHUYENTIENTableAdapter();
            this.tableAdapterManager = new NGANHANG.DSTableAdapters.TableAdapterManager();
            this.nhanVienTableAdapter = new NGANHANG.DSTableAdapters.NhanVienTableAdapter();
            this.gD_CHUYENTIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTK_CHUYEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTK_NHAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtSoTien = new DevExpress.XtraEditors.SpinEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTenNN = new DevExpress.XtraEditors.TextEdit();
            this.tKNhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxSoTKNhan = new System.Windows.Forms.ComboBox();
            this.txtCMNDNN = new DevExpress.XtraEditors.TextEdit();
            this.txtCMNDNC = new DevExpress.XtraEditors.TextEdit();
            this.tKChuyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtHoTenNC = new DevExpress.XtraEditors.TextEdit();
            this.cbxSoTKChuyen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tKChuyenTableAdapter = new NGANHANG.DSTableAdapters.TKChuyenTableAdapter();
            this.tKNhanTableAdapter = new NGANHANG.DSTableAdapters.TKNhanTableAdapter();
            sOTKLabel = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            cMNDLabel1 = new System.Windows.Forms.Label();
            sOTKLabel1 = new System.Windows.Forms.Label();
            hOTENLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnChiNhanh)).BeginInit();
            this.pnChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_CHUYENTIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_CHUYENTIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTenNN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKNhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMNDNN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMNDNC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKChuyenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTenNC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTKLabel.Location = new System.Drawing.Point(179, 87);
            sOTKLabel.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(62, 21);
            sOTKLabel.TabIndex = 2;
            sOTKLabel.Text = "SOTK:";
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOTENLabel.Location = new System.Drawing.Point(546, 97);
            hOTENLabel.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(75, 21);
            hOTENLabel.TabIndex = 4;
            hOTENLabel.Text = "HOTEN:";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cMNDLabel.Location = new System.Drawing.Point(975, 101);
            cMNDLabel.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(68, 21);
            cMNDLabel.TabIndex = 6;
            cMNDLabel.Text = "CMND:";
            cMNDLabel.Click += new System.EventHandler(this.cMNDLabel_Click);
            // 
            // cMNDLabel1
            // 
            cMNDLabel1.AutoSize = true;
            cMNDLabel1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cMNDLabel1.Location = new System.Drawing.Point(975, 215);
            cMNDLabel1.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            cMNDLabel1.Name = "cMNDLabel1";
            cMNDLabel1.Size = new System.Drawing.Size(68, 21);
            cMNDLabel1.TabIndex = 10;
            cMNDLabel1.Text = "CMND:";
            cMNDLabel1.Click += new System.EventHandler(this.cMNDLabel1_Click);
            // 
            // sOTKLabel1
            // 
            sOTKLabel1.AutoSize = true;
            sOTKLabel1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTKLabel1.Location = new System.Drawing.Point(180, 209);
            sOTKLabel1.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            sOTKLabel1.Name = "sOTKLabel1";
            sOTKLabel1.Size = new System.Drawing.Size(62, 21);
            sOTKLabel1.TabIndex = 11;
            sOTKLabel1.Text = "SOTK:";
            sOTKLabel1.Click += new System.EventHandler(this.sOTKLabel1_Click);
            // 
            // hOTENLabel1
            // 
            hOTENLabel1.AutoSize = true;
            hOTENLabel1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOTENLabel1.Location = new System.Drawing.Point(546, 211);
            hOTENLabel1.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            hOTENLabel1.Name = "hOTENLabel1";
            hOTENLabel1.Size = new System.Drawing.Size(75, 21);
            hOTENLabel1.TabIndex = 12;
            hOTENLabel1.Text = "HOTEN:";
            hOTENLabel1.Click += new System.EventHandler(this.hOTENLabel1_Click);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnHieuChinh,
            this.btnGhi,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnInDanhSach,
            this.btnThoat,
            this.btnReload});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhucHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.ActAsDropDown = true;
            this.btnThem.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.btnThem.Caption = "Thêm";
            this.btnThem.Enabled = false;
            this.btnThem.Id = 1;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Enabled = false;
            this.btnGhi.Id = 3;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Enabled = false;
            this.btnPhucHoi.Id = 5;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 7;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 8;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1924, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 776);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1924, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 725);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1924, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 725);
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu chỉnh";
            this.btnHieuChinh.Id = 2;
            this.btnHieuChinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHieuChinh.ImageOptions.Image")));
            this.btnHieuChinh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHieuChinh.ImageOptions.LargeImage")));
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 4;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnInDanhSach
            // 
            this.btnInDanhSach.Caption = "In danh sách";
            this.btnInDanhSach.Id = 6;
            this.btnInDanhSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInDanhSach.ImageOptions.Image")));
            this.btnInDanhSach.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnInDanhSach.ImageOptions.LargeImage")));
            this.btnInDanhSach.Name = "btnInDanhSach";
            this.btnInDanhSach.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // pnChiNhanh
            // 
            this.pnChiNhanh.Controls.Add(this.cbxChiNhanh);
            this.pnChiNhanh.Controls.Add(this.lbChiNhanh);
            this.pnChiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnChiNhanh.Location = new System.Drawing.Point(0, 51);
            this.pnChiNhanh.Margin = new System.Windows.Forms.Padding(60, 60, 60, 60);
            this.pnChiNhanh.Name = "pnChiNhanh";
            this.pnChiNhanh.Size = new System.Drawing.Size(1924, 93);
            this.pnChiNhanh.TabIndex = 7;
            // 
            // cbxChiNhanh
            // 
            this.cbxChiNhanh.Enabled = false;
            this.cbxChiNhanh.FormattingEnabled = true;
            this.cbxChiNhanh.Location = new System.Drawing.Point(730, 40);
            this.cbxChiNhanh.Margin = new System.Windows.Forms.Padding(60, 60, 60, 60);
            this.cbxChiNhanh.Name = "cbxChiNhanh";
            this.cbxChiNhanh.Size = new System.Drawing.Size(1029, 24);
            this.cbxChiNhanh.TabIndex = 1;
            this.cbxChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbxChiNhanh_SelectedIndexChanged);
            // 
            // lbChiNhanh
            // 
            this.lbChiNhanh.AutoSize = true;
            this.lbChiNhanh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiNhanh.Location = new System.Drawing.Point(265, 40);
            this.lbChiNhanh.Margin = new System.Windows.Forms.Padding(60, 0, 60, 0);
            this.lbChiNhanh.Name = "lbChiNhanh";
            this.lbChiNhanh.Size = new System.Drawing.Size(114, 24);
            this.lbChiNhanh.TabIndex = 0;
            this.lbChiNhanh.Text = "Chi Nhánh";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gD_CHUYENTIENBindingSource
            // 
            this.gD_CHUYENTIENBindingSource.DataMember = "GD_CHUYENTIEN";
            this.gD_CHUYENTIENBindingSource.DataSource = this.dS;
            // 
            // gD_CHUYENTIENTableAdapter
            // 
            this.gD_CHUYENTIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = this.gD_CHUYENTIENTableAdapter;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NGANHANG.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // gD_CHUYENTIENGridControl
            // 
            this.gD_CHUYENTIENGridControl.DataSource = this.gD_CHUYENTIENBindingSource;
            this.gD_CHUYENTIENGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gD_CHUYENTIENGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(19, 19, 19, 19);
            this.gD_CHUYENTIENGridControl.Location = new System.Drawing.Point(0, 144);
            this.gD_CHUYENTIENGridControl.MainView = this.gridView1;
            this.gD_CHUYENTIENGridControl.Margin = new System.Windows.Forms.Padding(19, 19, 19, 19);
            this.gD_CHUYENTIENGridControl.MenuManager = this.barManager1;
            this.gD_CHUYENTIENGridControl.Name = "gD_CHUYENTIENGridControl";
            this.gD_CHUYENTIENGridControl.Size = new System.Drawing.Size(1924, 272);
            this.gD_CHUYENTIENGridControl.TabIndex = 8;
            this.gD_CHUYENTIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGD,
            this.colMANV,
            this.colNGAYGD,
            this.colSOTIEN,
            this.colSOTK_CHUYEN,
            this.colSOTK_NHAN});
            this.gridView1.DetailHeight = 2080;
            this.gridView1.GridControl = this.gD_CHUYENTIENGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAGD
            // 
            this.colMAGD.FieldName = "MAGD";
            this.colMAGD.MinWidth = 149;
            this.colMAGD.Name = "colMAGD";
            this.colMAGD.Visible = true;
            this.colMAGD.VisibleIndex = 0;
            this.colMAGD.Width = 555;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 149;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 1;
            this.colMANV.Width = 555;
            // 
            // colNGAYGD
            // 
            this.colNGAYGD.FieldName = "NGAYGD";
            this.colNGAYGD.MinWidth = 149;
            this.colNGAYGD.Name = "colNGAYGD";
            this.colNGAYGD.Visible = true;
            this.colNGAYGD.VisibleIndex = 2;
            this.colNGAYGD.Width = 555;
            // 
            // colSOTIEN
            // 
            this.colSOTIEN.FieldName = "SOTIEN";
            this.colSOTIEN.MinWidth = 149;
            this.colSOTIEN.Name = "colSOTIEN";
            this.colSOTIEN.Visible = true;
            this.colSOTIEN.VisibleIndex = 3;
            this.colSOTIEN.Width = 555;
            // 
            // colSOTK_CHUYEN
            // 
            this.colSOTK_CHUYEN.FieldName = "SOTK_CHUYEN";
            this.colSOTK_CHUYEN.MinWidth = 149;
            this.colSOTK_CHUYEN.Name = "colSOTK_CHUYEN";
            this.colSOTK_CHUYEN.Visible = true;
            this.colSOTK_CHUYEN.VisibleIndex = 4;
            this.colSOTK_CHUYEN.Width = 555;
            // 
            // colSOTK_NHAN
            // 
            this.colSOTK_NHAN.FieldName = "SOTK_NHAN";
            this.colSOTK_NHAN.MinWidth = 149;
            this.colSOTK_NHAN.Name = "colSOTK_NHAN";
            this.colSOTK_NHAN.Visible = true;
            this.colSOTK_NHAN.VisibleIndex = 5;
            this.colSOTK_NHAN.Width = 555;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtSoTien);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.txtMaNV);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(hOTENLabel1);
            this.panelControl1.Controls.Add(this.txtHoTenNN);
            this.panelControl1.Controls.Add(sOTKLabel1);
            this.panelControl1.Controls.Add(this.cbxSoTKNhan);
            this.panelControl1.Controls.Add(cMNDLabel1);
            this.panelControl1.Controls.Add(this.txtCMNDNN);
            this.panelControl1.Controls.Add(cMNDLabel);
            this.panelControl1.Controls.Add(this.txtCMNDNC);
            this.panelControl1.Controls.Add(hOTENLabel);
            this.panelControl1.Controls.Add(this.txtHoTenNC);
            this.panelControl1.Controls.Add(sOTKLabel);
            this.panelControl1.Controls.Add(this.cbxSoTKChuyen);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Enabled = false;
            this.panelControl1.Location = new System.Drawing.Point(0, 416);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(19, 19, 19, 19);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1924, 360);
            this.panelControl1.TabIndex = 9;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // txtSoTien
            // 
            this.txtSoTien.EditValue = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtSoTien.Location = new System.Drawing.Point(550, 291);
            this.txtSoTien.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSoTien.MenuManager = this.barManager1;
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTien.Properties.Appearance.Options.UseFont = true;
            this.txtSoTien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoTien.Properties.DisplayFormat.FormatString = "{0:#,#}";
            this.txtSoTien.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSoTien.Properties.EditFormat.FormatString = "{0:#,#}";
            this.txtSoTien.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSoTien.Size = new System.Drawing.Size(149, 28);
            this.txtSoTien.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(828, 295);
            this.label4.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Mã nhân viên";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(990, 292);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(19, 19, 19, 19);
            this.txtMaNV.MenuManager = this.barManager1;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Properties.Appearance.Options.UseFont = true;
            this.txtMaNV.Properties.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(163, 28);
            this.txtMaNV.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(371, 295);
            this.label3.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Số tiền chuyển";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtHoTenNN
            // 
            this.txtHoTenNN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tKNhanBindingSource, "HOTEN", true));
            this.txtHoTenNN.Location = new System.Drawing.Point(642, 205);
            this.txtHoTenNN.Margin = new System.Windows.Forms.Padding(19, 19, 19, 19);
            this.txtHoTenNN.MenuManager = this.barManager1;
            this.txtHoTenNN.Name = "txtHoTenNN";
            this.txtHoTenNN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenNN.Properties.Appearance.Options.UseFont = true;
            this.txtHoTenNN.Properties.ReadOnly = true;
            this.txtHoTenNN.Size = new System.Drawing.Size(276, 28);
            this.txtHoTenNN.TabIndex = 13;
            // 
            // tKNhanBindingSource
            // 
            this.tKNhanBindingSource.DataMember = "TKNhan";
            this.tKNhanBindingSource.DataSource = this.dS;
            // 
            // cbxSoTKNhan
            // 
            this.cbxSoTKNhan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tKNhanBindingSource, "SOTK", true));
            this.cbxSoTKNhan.DataSource = this.tKNhanBindingSource;
            this.cbxSoTKNhan.DisplayMember = "SOTK";
            this.cbxSoTKNhan.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSoTKNhan.FormattingEnabled = true;
            this.cbxSoTKNhan.Location = new System.Drawing.Point(280, 201);
            this.cbxSoTKNhan.Margin = new System.Windows.Forms.Padding(19, 19, 19, 19);
            this.cbxSoTKNhan.Name = "cbxSoTKNhan";
            this.cbxSoTKNhan.Size = new System.Drawing.Size(225, 29);
            this.cbxSoTKNhan.TabIndex = 12;
            this.cbxSoTKNhan.ValueMember = "SOTK";
            // 
            // txtCMNDNN
            // 
            this.txtCMNDNN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tKNhanBindingSource, "CMND", true));
            this.txtCMNDNN.Location = new System.Drawing.Point(1061, 206);
            this.txtCMNDNN.Margin = new System.Windows.Forms.Padding(19, 19, 19, 19);
            this.txtCMNDNN.MenuManager = this.barManager1;
            this.txtCMNDNN.Name = "txtCMNDNN";
            this.txtCMNDNN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMNDNN.Properties.Appearance.Options.UseFont = true;
            this.txtCMNDNN.Properties.ReadOnly = true;
            this.txtCMNDNN.Size = new System.Drawing.Size(234, 28);
            this.txtCMNDNN.TabIndex = 11;
            this.txtCMNDNN.EditValueChanged += new System.EventHandler(this.txtCMNDNN_EditValueChanged);
            // 
            // txtCMNDNC
            // 
            this.txtCMNDNC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tKChuyenBindingSource, "CMND", true));
            this.txtCMNDNC.Location = new System.Drawing.Point(1061, 98);
            this.txtCMNDNC.Margin = new System.Windows.Forms.Padding(19, 19, 19, 19);
            this.txtCMNDNC.MenuManager = this.barManager1;
            this.txtCMNDNC.Name = "txtCMNDNC";
            this.txtCMNDNC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMNDNC.Properties.Appearance.Options.UseFont = true;
            this.txtCMNDNC.Properties.ReadOnly = true;
            this.txtCMNDNC.Size = new System.Drawing.Size(234, 28);
            this.txtCMNDNC.TabIndex = 7;
            this.txtCMNDNC.EditValueChanged += new System.EventHandler(this.txtCMNDNC_EditValueChanged);
            // 
            // tKChuyenBindingSource
            // 
            this.tKChuyenBindingSource.DataMember = "TKChuyen";
            this.tKChuyenBindingSource.DataSource = this.dS;
            // 
            // txtHoTenNC
            // 
            this.txtHoTenNC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tKChuyenBindingSource, "HOTEN", true));
            this.txtHoTenNC.Location = new System.Drawing.Point(642, 94);
            this.txtHoTenNC.Margin = new System.Windows.Forms.Padding(19, 19, 19, 19);
            this.txtHoTenNC.MenuManager = this.barManager1;
            this.txtHoTenNC.Name = "txtHoTenNC";
            this.txtHoTenNC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenNC.Properties.Appearance.Options.UseFont = true;
            this.txtHoTenNC.Properties.ReadOnly = true;
            this.txtHoTenNC.Size = new System.Drawing.Size(276, 28);
            this.txtHoTenNC.TabIndex = 5;
            this.txtHoTenNC.EditValueChanged += new System.EventHandler(this.txtHoTenNC_EditValueChanged);
            // 
            // cbxSoTKChuyen
            // 
            this.cbxSoTKChuyen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tKChuyenBindingSource, "SOTK", true));
            this.cbxSoTKChuyen.DataSource = this.tKChuyenBindingSource;
            this.cbxSoTKChuyen.DisplayMember = "SOTK";
            this.cbxSoTKChuyen.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSoTKChuyen.FormattingEnabled = true;
            this.cbxSoTKChuyen.Location = new System.Drawing.Point(279, 89);
            this.cbxSoTKChuyen.Margin = new System.Windows.Forms.Padding(19, 19, 19, 19);
            this.cbxSoTKChuyen.Name = "cbxSoTKChuyen";
            this.cbxSoTKChuyen.Size = new System.Drawing.Size(226, 29);
            this.cbxSoTKChuyen.TabIndex = 3;
            this.cbxSoTKChuyen.ValueMember = "SOTK";
            this.cbxSoTKChuyen.SelectedIndexChanged += new System.EventHandler(this.cbxSoTKChuyen_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thông tin tài khoản nhận";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin tài khoản chuyển";
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.dS;
            // 
            // tKChuyenTableAdapter
            // 
            this.tKChuyenTableAdapter.ClearBeforeFill = true;
            // 
            // tKNhanTableAdapter
            // 
            this.tKNhanTableAdapter.ClearBeforeFill = true;
            // 
            // FormChuyenTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 776);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gD_CHUYENTIENGridControl);
            this.Controls.Add(this.pnChiNhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormChuyenTien";
            this.Text = "FormChuyenTien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormChuyenTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnChiNhanh)).EndInit();
            this.pnChiNhanh.ResumeLayout(false);
            this.pnChiNhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_CHUYENTIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_CHUYENTIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTenNN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKNhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMNDNN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMNDNC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKChuyenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTenNC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnInDanhSach;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl pnChiNhanh;
        private System.Windows.Forms.ComboBox cbxChiNhanh;
        private System.Windows.Forms.Label lbChiNhanh;
        private System.Windows.Forms.BindingSource gD_CHUYENTIENBindingSource;
        private DS dS;
        private DSTableAdapters.GD_CHUYENTIENTableAdapter gD_CHUYENTIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gD_CHUYENTIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGD;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK_CHUYEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK_NHAN;
        private DSTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private System.Windows.Forms.BindingSource tKChuyenBindingSource;
        private DSTableAdapters.TKChuyenTableAdapter tKChuyenTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtCMNDNC;
        private DevExpress.XtraEditors.TextEdit txtHoTenNC;
        private System.Windows.Forms.ComboBox cbxSoTKChuyen;
        private System.Windows.Forms.BindingSource tKNhanBindingSource;
        private DSTableAdapters.TKNhanTableAdapter tKNhanTableAdapter;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtHoTenNN;
        private System.Windows.Forms.ComboBox cbxSoTKNhan;
        private DevExpress.XtraEditors.TextEdit txtCMNDNN;
        private DevExpress.XtraEditors.SpinEdit txtSoTien;
    }
}