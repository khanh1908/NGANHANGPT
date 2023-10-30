
namespace NGANHANG
{
    partial class FormGuiRut
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
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label lOAIGDLabel;
            System.Windows.Forms.Label sOTIENLabel;
            System.Windows.Forms.Label sOTKLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuiRut));
            this.pnChiNhanh = new DevExpress.XtraEditors.PanelControl();
            this.cbxChiNhanh = new System.Windows.Forms.ComboBox();
            this.lbChiNhanh = new System.Windows.Forms.Label();
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
            this.dS = new NGANHANG.DS();
            this.gD_GOIRUTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD_GOIRUTTableAdapter = new NGANHANG.DSTableAdapters.GD_GOIRUTTableAdapter();
            this.tableAdapterManager = new NGANHANG.DSTableAdapters.TableAdapterManager();
            this.taiKhoanTableAdapter = new NGANHANG.DSTableAdapters.TaiKhoanTableAdapter();
            this.gD_GOIRUTGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pnlDetail = new DevExpress.XtraEditors.PanelControl();
            this.txtSoTien = new DevExpress.XtraEditors.SpinEdit();
            this.cMNDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbSoTk = new System.Windows.Forms.ComboBox();
            this.cbLoaiGD = new System.Windows.Forms.ComboBox();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            mANVLabel = new System.Windows.Forms.Label();
            lOAIGDLabel = new System.Windows.Forms.Label();
            sOTIENLabel = new System.Windows.Forms.Label();
            sOTKLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pnChiNhanh)).BeginInit();
            this.pnChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_GOIRUTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_GOIRUTGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).BeginInit();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMNDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mANVLabel.Location = new System.Drawing.Point(112, 148);
            mANVLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(61, 21);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "MANV:";
            // 
            // lOAIGDLabel
            // 
            lOAIGDLabel.AutoSize = true;
            lOAIGDLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lOAIGDLabel.Location = new System.Drawing.Point(439, 57);
            lOAIGDLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            lOAIGDLabel.Name = "lOAIGDLabel";
            lOAIGDLabel.Size = new System.Drawing.Size(76, 21);
            lOAIGDLabel.TabIndex = 7;
            lOAIGDLabel.Text = "LOAIGD:";
            // 
            // sOTIENLabel
            // 
            sOTIENLabel.AutoSize = true;
            sOTIENLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTIENLabel.Location = new System.Drawing.Point(440, 149);
            sOTIENLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            sOTIENLabel.Name = "sOTIENLabel";
            sOTIENLabel.Size = new System.Drawing.Size(74, 21);
            sOTIENLabel.TabIndex = 8;
            sOTIENLabel.Text = "SOTIEN:";
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTKLabel.Location = new System.Drawing.Point(107, 64);
            sOTKLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(57, 21);
            sOTKLabel.TabIndex = 9;
            sOTKLabel.Text = "SOTK:";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cMNDLabel.Location = new System.Drawing.Point(854, 66);
            cMNDLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(62, 21);
            cMNDLabel.TabIndex = 11;
            cMNDLabel.Text = "CMND:";
            // 
            // pnChiNhanh
            // 
            this.pnChiNhanh.Controls.Add(this.cbxChiNhanh);
            this.pnChiNhanh.Controls.Add(this.lbChiNhanh);
            this.pnChiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnChiNhanh.Location = new System.Drawing.Point(0, 51);
            this.pnChiNhanh.Margin = new System.Windows.Forms.Padding(24, 24, 24, 24);
            this.pnChiNhanh.Name = "pnChiNhanh";
            this.pnChiNhanh.Size = new System.Drawing.Size(1540, 103);
            this.pnChiNhanh.TabIndex = 5;
            // 
            // cbxChiNhanh
            // 
            this.cbxChiNhanh.FormattingEnabled = true;
            this.cbxChiNhanh.Location = new System.Drawing.Point(274, 43);
            this.cbxChiNhanh.Margin = new System.Windows.Forms.Padding(24, 24, 24, 24);
            this.cbxChiNhanh.Name = "cbxChiNhanh";
            this.cbxChiNhanh.Size = new System.Drawing.Size(740, 24);
            this.cbxChiNhanh.TabIndex = 1;
            this.cbxChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbxChiNhanh_SelectedIndexChanged);
            // 
            // lbChiNhanh
            // 
            this.lbChiNhanh.AutoSize = true;
            this.lbChiNhanh.Location = new System.Drawing.Point(155, 50);
            this.lbChiNhanh.Margin = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.lbChiNhanh.Name = "lbChiNhanh";
            this.lbChiNhanh.Size = new System.Drawing.Size(71, 17);
            this.lbChiNhanh.TabIndex = 0;
            this.lbChiNhanh.Text = "Chi Nhánh";
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
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 7;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1540, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 834);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1540, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 783);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1540, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 783);
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
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gD_GOIRUTBindingSource
            // 
            this.gD_GOIRUTBindingSource.DataMember = "GD_GOIRUT";
            this.gD_GOIRUTBindingSource.DataSource = this.dS;
            // 
            // gD_GOIRUTTableAdapter
            // 
            this.gD_GOIRUTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = this.gD_GOIRUTTableAdapter;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.taiKhoanTableAdapter;
            this.tableAdapterManager.UpdateOrder = NGANHANG.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // gD_GOIRUTGridControl
            // 
            this.gD_GOIRUTGridControl.DataSource = this.gD_GOIRUTBindingSource;
            this.gD_GOIRUTGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gD_GOIRUTGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.gD_GOIRUTGridControl.Location = new System.Drawing.Point(0, 154);
            this.gD_GOIRUTGridControl.MainView = this.gridView1;
            this.gD_GOIRUTGridControl.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.gD_GOIRUTGridControl.MenuManager = this.barManager1;
            this.gD_GOIRUTGridControl.Name = "gD_GOIRUTGridControl";
            this.gD_GOIRUTGridControl.Size = new System.Drawing.Size(1540, 338);
            this.gD_GOIRUTGridControl.TabIndex = 10;
            this.gD_GOIRUTGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 1331;
            this.gridView1.GridControl = this.gD_GOIRUTGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pnlDetail);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 492);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1540, 342);
            this.panelControl1.TabIndex = 11;
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.txtSoTien);
            this.pnlDetail.Controls.Add(cMNDLabel);
            this.pnlDetail.Controls.Add(this.cMNDTextEdit);
            this.pnlDetail.Controls.Add(sOTKLabel);
            this.pnlDetail.Controls.Add(this.cbSoTk);
            this.pnlDetail.Controls.Add(sOTIENLabel);
            this.pnlDetail.Controls.Add(lOAIGDLabel);
            this.pnlDetail.Controls.Add(this.cbLoaiGD);
            this.pnlDetail.Controls.Add(mANVLabel);
            this.pnlDetail.Controls.Add(this.txtMaNV);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetail.Enabled = false;
            this.pnlDetail.Location = new System.Drawing.Point(2, 2);
            this.pnlDetail.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(1536, 338);
            this.pnlDetail.TabIndex = 0;
            // 
            // txtSoTien
            // 
            this.txtSoTien.EditValue = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtSoTien.Location = new System.Drawing.Point(569, 141);
            this.txtSoTien.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.txtSoTien.Size = new System.Drawing.Size(219, 28);
            this.txtSoTien.TabIndex = 19;
            // 
            // cMNDTextEdit
            // 
            this.cMNDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.taiKhoanBindingSource, "CMND", true));
            this.cMNDTextEdit.Location = new System.Drawing.Point(994, 61);
            this.cMNDTextEdit.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.cMNDTextEdit.MenuManager = this.barManager1;
            this.cMNDTextEdit.Name = "cMNDTextEdit";
            this.cMNDTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cMNDTextEdit.Properties.Appearance.Options.UseFont = true;
            this.cMNDTextEdit.Size = new System.Drawing.Size(237, 28);
            this.cMNDTextEdit.TabIndex = 12;
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "TaiKhoan";
            this.taiKhoanBindingSource.DataSource = this.dS;
            // 
            // cbSoTk
            // 
            this.cbSoTk.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.taiKhoanBindingSource, "SOTK", true));
            this.cbSoTk.DataSource = this.taiKhoanBindingSource;
            this.cbSoTk.DisplayMember = "SOTK";
            this.cbSoTk.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSoTk.FormattingEnabled = true;
            this.cbSoTk.Location = new System.Drawing.Point(208, 60);
            this.cbSoTk.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.cbSoTk.Name = "cbSoTk";
            this.cbSoTk.Size = new System.Drawing.Size(203, 29);
            this.cbSoTk.TabIndex = 10;
            this.cbSoTk.ValueMember = "SOTK";
            // 
            // cbLoaiGD
            // 
            this.cbLoaiGD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gD_GOIRUTBindingSource, "LOAIGD", true));
            this.cbLoaiGD.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiGD.FormattingEnabled = true;
            this.cbLoaiGD.Items.AddRange(new object[] {
            "RT",
            "GT"});
            this.cbLoaiGD.Location = new System.Drawing.Point(569, 60);
            this.cbLoaiGD.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.cbLoaiGD.Name = "cbLoaiGD";
            this.cbLoaiGD.Size = new System.Drawing.Size(219, 29);
            this.cbLoaiGD.TabIndex = 8;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gD_GOIRUTBindingSource, "MANV", true));
            this.txtMaNV.Location = new System.Drawing.Point(208, 143);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.txtMaNV.MenuManager = this.barManager1;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Properties.Appearance.Options.UseFont = true;
            this.txtMaNV.Size = new System.Drawing.Size(203, 28);
            this.txtMaNV.TabIndex = 7;
            // 
            // FormGuiRut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 834);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gD_GOIRUTGridControl);
            this.Controls.Add(this.pnChiNhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormGuiRut";
            this.Text = "FormGuiRut";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormGuiRut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnChiNhanh)).EndInit();
            this.pnChiNhanh.ResumeLayout(false);
            this.pnChiNhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_GOIRUTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_GOIRUTGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMNDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnChiNhanh;
        private System.Windows.Forms.ComboBox cbxChiNhanh;
        private System.Windows.Forms.Label lbChiNhanh;
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
        private System.Windows.Forms.BindingSource gD_GOIRUTBindingSource;
        private DS dS;
        private DSTableAdapters.GD_GOIRUTTableAdapter gD_GOIRUTTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gD_GOIRUTGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DSTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private DevExpress.XtraEditors.PanelControl pnlDetail;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private System.Windows.Forms.ComboBox cbLoaiGD;
        private System.Windows.Forms.ComboBox cbSoTk;
        private DevExpress.XtraEditors.TextEdit cMNDTextEdit;
        private DevExpress.XtraEditors.SpinEdit txtSoTien;
    }
}