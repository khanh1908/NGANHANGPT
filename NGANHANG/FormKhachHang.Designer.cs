
namespace NGANHANG
{
    partial class FormKhachHang
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
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label nGAYCAPLabel;
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label pHAILabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhachHang));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnInDanhSach = new DevExpress.XtraBars.BarButtonItem();
            this.pnChiNhanh = new DevExpress.XtraEditors.PanelControl();
            this.cbxChiNhanh = new System.Windows.Forms.ComboBox();
            this.lbChiNhanh = new System.Windows.Forms.Label();
            this.dS = new NGANHANG.DS();
            this.bdsKhachHang = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangTableAdapter = new NGANHANG.DSTableAdapters.KhachHangTableAdapter();
            this.tableAdapterManager = new NGANHANG.DSTableAdapters.TableAdapterManager();
            this.taiKhoanTableAdapter = new NGANHANG.DSTableAdapters.TaiKhoanTableAdapter();
            this.khachHangGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnDetail = new DevExpress.XtraEditors.PanelControl();
            this.pHAIComboBox = new System.Windows.Forms.ComboBox();
            this.txtMaCN = new DevExpress.XtraEditors.TextEdit();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.dateNgCap = new DevExpress.XtraEditors.DateEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.txtCMND = new DevExpress.XtraEditors.TextEdit();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gcTaiKhoan = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripThem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripGhi = new System.Windows.Forms.ToolStripMenuItem();
            cMNDLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            nGAYCAPLabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            pHAILabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnChiNhanh)).BeginInit();
            this.pnChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnDetail)).BeginInit();
            this.pnDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgCap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(113, 40);
            cMNDLabel.Margin = new System.Windows.Forms.Padding(24, 0, 24, 0);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(51, 17);
            cMNDLabel.TabIndex = 0;
            cMNDLabel.Text = "CMND:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(459, 43);
            hOLabel.Margin = new System.Windows.Forms.Padding(24, 0, 24, 0);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(32, 17);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(753, 46);
            tENLabel.Margin = new System.Windows.Forms.Padding(24, 0, 24, 0);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(38, 17);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TEN:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(113, 101);
            dIACHILabel.Margin = new System.Windows.Forms.Padding(24, 0, 24, 0);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(57, 17);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "DIACHI:";
            // 
            // nGAYCAPLabel
            // 
            nGAYCAPLabel.AutoSize = true;
            nGAYCAPLabel.Location = new System.Drawing.Point(458, 162);
            nGAYCAPLabel.Margin = new System.Windows.Forms.Padding(24, 0, 24, 0);
            nGAYCAPLabel.Name = "nGAYCAPLabel";
            nGAYCAPLabel.Size = new System.Drawing.Size(72, 17);
            nGAYCAPLabel.TabIndex = 10;
            nGAYCAPLabel.Text = "NGAYCAP:";
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Location = new System.Drawing.Point(113, 159);
            sODTLabel.Margin = new System.Windows.Forms.Padding(24, 0, 24, 0);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(49, 17);
            sODTLabel.TabIndex = 12;
            sODTLabel.Text = "SODT:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(1514, 642);
            mACNLabel.Margin = new System.Windows.Forms.Padding(24, 0, 24, 0);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(49, 17);
            mACNLabel.TabIndex = 14;
            mACNLabel.Text = "MACN:";
            // 
            // pHAILabel1
            // 
            pHAILabel1.AutoSize = true;
            pHAILabel1.Location = new System.Drawing.Point(747, 103);
            pHAILabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            pHAILabel1.Name = "pHAILabel1";
            pHAILabel1.Size = new System.Drawing.Size(42, 17);
            pHAILabel1.TabIndex = 16;
            pHAILabel1.Text = "PHAI:";
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHieuChinh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
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
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu chỉnh";
            this.btnHieuChinh.Enabled = false;
            this.btnHieuChinh.Id = 2;
            this.btnHieuChinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHieuChinh.ImageOptions.Image")));
            this.btnHieuChinh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHieuChinh.ImageOptions.LargeImage")));
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnHieuChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHieuChinh_ItemClick);
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
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Enabled = false;
            this.btnXoa.Id = 4;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 745);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1924, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 694);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1924, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 694);
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
            this.pnChiNhanh.Margin = new System.Windows.Forms.Padding(24);
            this.pnChiNhanh.Name = "pnChiNhanh";
            this.pnChiNhanh.Size = new System.Drawing.Size(1924, 114);
            this.pnChiNhanh.TabIndex = 4;
            // 
            // cbxChiNhanh
            // 
            this.cbxChiNhanh.FormattingEnabled = true;
            this.cbxChiNhanh.Location = new System.Drawing.Point(482, 52);
            this.cbxChiNhanh.Margin = new System.Windows.Forms.Padding(24);
            this.cbxChiNhanh.Name = "cbxChiNhanh";
            this.cbxChiNhanh.Size = new System.Drawing.Size(584, 24);
            this.cbxChiNhanh.TabIndex = 1;
            this.cbxChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbxChiNhanh_SelectedIndexChanged_1);
            // 
            // lbChiNhanh
            // 
            this.lbChiNhanh.AutoSize = true;
            this.lbChiNhanh.Location = new System.Drawing.Point(360, 56);
            this.lbChiNhanh.Margin = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.lbChiNhanh.Name = "lbChiNhanh";
            this.lbChiNhanh.Size = new System.Drawing.Size(71, 17);
            this.lbChiNhanh.TabIndex = 0;
            this.lbChiNhanh.Text = "Chi Nhánh";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsKhachHang
            // 
            this.bdsKhachHang.DataMember = "KhachHang";
            this.bdsKhachHang.DataSource = this.dS;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = this.khachHangTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.taiKhoanTableAdapter;
            this.tableAdapterManager.UpdateOrder = NGANHANG.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // khachHangGridControl
            // 
            this.khachHangGridControl.DataSource = this.bdsKhachHang;
            this.khachHangGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.khachHangGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(24);
            this.khachHangGridControl.Location = new System.Drawing.Point(0, 165);
            this.khachHangGridControl.MainView = this.gridView1;
            this.khachHangGridControl.Margin = new System.Windows.Forms.Padding(24);
            this.khachHangGridControl.MenuManager = this.barManager1;
            this.khachHangGridControl.Name = "khachHangGridControl";
            this.khachHangGridControl.Size = new System.Drawing.Size(1924, 265);
            this.khachHangGridControl.TabIndex = 6;
            this.khachHangGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCMND,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colPHAI,
            this.colNGAYCAP,
            this.colSODT,
            this.colMACN});
            this.gridView1.GridControl = this.khachHangGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 25;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 0;
            this.colCMND.Width = 94;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 94;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 94;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 94;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 25;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            this.colPHAI.Width = 94;
            // 
            // colNGAYCAP
            // 
            this.colNGAYCAP.FieldName = "NGAYCAP";
            this.colNGAYCAP.MinWidth = 25;
            this.colNGAYCAP.Name = "colNGAYCAP";
            this.colNGAYCAP.Visible = true;
            this.colNGAYCAP.VisibleIndex = 5;
            this.colNGAYCAP.Width = 94;
            // 
            // colSODT
            // 
            this.colSODT.FieldName = "SODT";
            this.colSODT.MinWidth = 25;
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 6;
            this.colSODT.Width = 94;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 25;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 7;
            this.colMACN.Width = 94;
            // 
            // pnDetail
            // 
            this.pnDetail.Controls.Add(pHAILabel1);
            this.pnDetail.Controls.Add(this.pHAIComboBox);
            this.pnDetail.Controls.Add(mACNLabel);
            this.pnDetail.Controls.Add(this.txtMaCN);
            this.pnDetail.Controls.Add(sODTLabel);
            this.pnDetail.Controls.Add(this.txtSDT);
            this.pnDetail.Controls.Add(nGAYCAPLabel);
            this.pnDetail.Controls.Add(this.dateNgCap);
            this.pnDetail.Controls.Add(dIACHILabel);
            this.pnDetail.Controls.Add(this.txtDiaChi);
            this.pnDetail.Controls.Add(tENLabel);
            this.pnDetail.Controls.Add(this.txtTen);
            this.pnDetail.Controls.Add(hOLabel);
            this.pnDetail.Controls.Add(this.txtHo);
            this.pnDetail.Controls.Add(cMNDLabel);
            this.pnDetail.Controls.Add(this.txtCMND);
            this.pnDetail.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnDetail.Enabled = false;
            this.pnDetail.Location = new System.Drawing.Point(0, 430);
            this.pnDetail.Margin = new System.Windows.Forms.Padding(24);
            this.pnDetail.Name = "pnDetail";
            this.pnDetail.Size = new System.Drawing.Size(1126, 315);
            this.pnDetail.TabIndex = 7;
            // 
            // pHAIComboBox
            // 
            this.pHAIComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKhachHang, "PHAI", true));
            this.pHAIComboBox.FormattingEnabled = true;
            this.pHAIComboBox.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.pHAIComboBox.Location = new System.Drawing.Point(839, 98);
            this.pHAIComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.pHAIComboBox.Name = "pHAIComboBox";
            this.pHAIComboBox.Size = new System.Drawing.Size(189, 24);
            this.pHAIComboBox.TabIndex = 17;
            // 
            // txtMaCN
            // 
            this.txtMaCN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhachHang, "MACN", true));
            this.txtMaCN.Location = new System.Drawing.Point(1681, 638);
            this.txtMaCN.Margin = new System.Windows.Forms.Padding(24);
            this.txtMaCN.MenuManager = this.barManager1;
            this.txtMaCN.Name = "txtMaCN";
            this.txtMaCN.Size = new System.Drawing.Size(375, 22);
            this.txtMaCN.TabIndex = 15;
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhachHang, "SODT", true));
            this.txtSDT.Location = new System.Drawing.Point(218, 156);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(24);
            this.txtSDT.MenuManager = this.barManager1;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(198, 22);
            this.txtSDT.TabIndex = 13;
            // 
            // dateNgCap
            // 
            this.dateNgCap.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhachHang, "NGAYCAP", true));
            this.dateNgCap.EditValue = null;
            this.dateNgCap.Location = new System.Drawing.Point(646, 156);
            this.dateNgCap.Margin = new System.Windows.Forms.Padding(24);
            this.dateNgCap.MenuManager = this.barManager1;
            this.dateNgCap.Name = "dateNgCap";
            this.dateNgCap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgCap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgCap.Size = new System.Drawing.Size(319, 22);
            this.dateNgCap.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhachHang, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(218, 97);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(24);
            this.txtDiaChi.MenuManager = this.barManager1;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(488, 22);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhachHang, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(840, 39);
            this.txtTen.Margin = new System.Windows.Forms.Padding(24);
            this.txtTen.MenuManager = this.barManager1;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(189, 22);
            this.txtTen.TabIndex = 5;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhachHang, "HO", true));
            this.txtHo.Location = new System.Drawing.Point(527, 39);
            this.txtHo.Margin = new System.Windows.Forms.Padding(24);
            this.txtHo.MenuManager = this.barManager1;
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(179, 22);
            this.txtHo.TabIndex = 3;
            // 
            // txtCMND
            // 
            this.txtCMND.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhachHang, "CMND", true));
            this.txtCMND.Location = new System.Drawing.Point(218, 35);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(24);
            this.txtCMND.MenuManager = this.barManager1;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(198, 22);
            this.txtCMND.TabIndex = 1;
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "FK_TaiKhoan_KhachHang";
            this.taiKhoanBindingSource.DataSource = this.bdsKhachHang;
            // 
            // gcTaiKhoan
            // 
            this.gcTaiKhoan.DataSource = this.taiKhoanBindingSource;
            this.gcTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTaiKhoan.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(24);
            this.gcTaiKhoan.Enabled = false;
            this.gcTaiKhoan.Location = new System.Drawing.Point(1126, 430);
            this.gcTaiKhoan.MainView = this.gridView2;
            this.gcTaiKhoan.Margin = new System.Windows.Forms.Padding(24);
            this.gcTaiKhoan.MenuManager = this.barManager1;
            this.gcTaiKhoan.Name = "gcTaiKhoan";
            this.gcTaiKhoan.Size = new System.Drawing.Size(798, 315);
            this.gcTaiKhoan.TabIndex = 11;
            this.gcTaiKhoan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colCMND1,
            this.colSODU,
            this.colMACN1,
            this.colNGAYMOTK});
            this.gridView2.DetailHeight = 437;
            this.gridView2.GridControl = this.gcTaiKhoan;
            this.gridView2.Name = "gridView2";
            // 
            // colSOTK
            // 
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.MinWidth = 25;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 0;
            this.colSOTK.Width = 94;
            // 
            // colCMND1
            // 
            this.colCMND1.FieldName = "CMND";
            this.colCMND1.MinWidth = 25;
            this.colCMND1.Name = "colCMND1";
            this.colCMND1.Visible = true;
            this.colCMND1.VisibleIndex = 1;
            this.colCMND1.Width = 94;
            // 
            // colSODU
            // 
            this.colSODU.FieldName = "SODU";
            this.colSODU.MinWidth = 25;
            this.colSODU.Name = "colSODU";
            this.colSODU.Visible = true;
            this.colSODU.VisibleIndex = 2;
            this.colSODU.Width = 94;
            // 
            // colMACN1
            // 
            this.colMACN1.FieldName = "MACN";
            this.colMACN1.MinWidth = 25;
            this.colMACN1.Name = "colMACN1";
            this.colMACN1.Visible = true;
            this.colMACN1.VisibleIndex = 3;
            this.colMACN1.Width = 94;
            // 
            // colNGAYMOTK
            // 
            this.colNGAYMOTK.FieldName = "NGAYMOTK";
            this.colNGAYMOTK.MinWidth = 25;
            this.colNGAYMOTK.Name = "colNGAYMOTK";
            this.colNGAYMOTK.Visible = true;
            this.colNGAYMOTK.VisibleIndex = 4;
            this.colNGAYMOTK.Width = 94;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripThem,
            this.toolStripXoa,
            this.toolStripGhi});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 76);
            // 
            // toolStripThem
            // 
            this.toolStripThem.Name = "toolStripThem";
            this.toolStripThem.Size = new System.Drawing.Size(115, 24);
            this.toolStripThem.Text = "Thêm";
            this.toolStripThem.Click += new System.EventHandler(this.toolStripThem_Click);
            // 
            // toolStripXoa
            // 
            this.toolStripXoa.Name = "toolStripXoa";
            this.toolStripXoa.Size = new System.Drawing.Size(115, 24);
            this.toolStripXoa.Text = "Xóa";
            // 
            // toolStripGhi
            // 
            this.toolStripGhi.Name = "toolStripGhi";
            this.toolStripGhi.Size = new System.Drawing.Size(115, 24);
            this.toolStripGhi.Text = "Ghi";
            this.toolStripGhi.Click += new System.EventHandler(this.toolStripGhi_Click);
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 745);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.gcTaiKhoan);
            this.Controls.Add(this.pnDetail);
            this.Controls.Add(this.khachHangGridControl);
            this.Controls.Add(this.pnChiNhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormKhachHang";
            this.Text = "FormKhachHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnChiNhanh)).EndInit();
            this.pnChiNhanh.ResumeLayout(false);
            this.pnChiNhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnDetail)).EndInit();
            this.pnDetail.ResumeLayout(false);
            this.pnDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgCap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnInDanhSach;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.BindingSource bdsKhachHang;
        private DS dS;
        private DevExpress.XtraEditors.PanelControl pnChiNhanh;
        private System.Windows.Forms.ComboBox cbxChiNhanh;
        private System.Windows.Forms.Label lbChiNhanh;
        private DSTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl khachHangGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl pnDetail;
        private DevExpress.XtraEditors.TextEdit txtMaCN;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.DateEdit dateNgCap;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraEditors.TextEdit txtCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYCAP;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DSTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraGrid.GridControl gcTaiKhoan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND1;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN1;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMOTK;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripThem;
        private System.Windows.Forms.ToolStripMenuItem toolStripXoa;
        private System.Windows.Forms.ToolStripMenuItem toolStripGhi;
        private System.Windows.Forms.ComboBox pHAIComboBox;
    }
}