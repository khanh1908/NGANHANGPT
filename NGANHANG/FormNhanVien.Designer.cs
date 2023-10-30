
namespace NGANHANG
{
    partial class FormNhanVien
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
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label trangThaiXoaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnChuyen = new DevExpress.XtraBars.BarButtonItem();
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
            this.tableAdapterManager = new NGANHANG.DSTableAdapters.TableAdapterManager();
            this.nhanVienTableAdapter = new NGANHANG.DSTableAdapters.NhanVienTableAdapter();
            this.gD_GOIRUTTableAdapter = new NGANHANG.DSTableAdapters.GD_GOIRUTTableAdapter();
            this.gD_GOIRUTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD_CHUYENTIENTableAdapter = new NGANHANG.DSTableAdapters.GD_CHUYENTIENTableAdapter();
            this.gD_CHUYENTIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnChuyenCN = new DevExpress.XtraEditors.PanelControl();
            this.btnChuyenCN = new System.Windows.Forms.Button();
            this.cbChuyenCN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnNhap = new DevExpress.XtraEditors.PanelControl();
            this.radBtnTrangThaiXoa = new System.Windows.Forms.CheckBox();
            this.txtMaCN = new DevExpress.XtraEditors.TextEdit();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.cbxPhai = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dIACHITextEdit = new DevExpress.XtraEditors.TextEdit();
            this.txtCMND = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            mANVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            trangThaiXoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnChiNhanh)).BeginInit();
            this.pnChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_GOIRUTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_CHUYENTIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnChuyenCN)).BeginInit();
            this.pnChuyenCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnNhap)).BeginInit();
            this.pnNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPhai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIACHITextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mANVLabel.Location = new System.Drawing.Point(85, 54);
            mANVLabel.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(61, 21);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "MANV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOLabel.Location = new System.Drawing.Point(634, 56);
            hOLabel.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(39, 21);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLabel.Location = new System.Drawing.Point(1216, 56);
            tENLabel.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(47, 21);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TEN:";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cMNDLabel.Location = new System.Drawing.Point(1711, 52);
            cMNDLabel.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(62, 21);
            cMNDLabel.TabIndex = 6;
            cMNDLabel.Text = "CMND:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dIACHILabel.Location = new System.Drawing.Point(84, 130);
            dIACHILabel.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(72, 21);
            dIACHILabel.TabIndex = 8;
            dIACHILabel.Text = "DIACHI:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pHAILabel.Location = new System.Drawing.Point(1729, 122);
            pHAILabel.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(53, 21);
            pHAILabel.TabIndex = 10;
            pHAILabel.Text = "PHAI:";
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sODTLabel.Location = new System.Drawing.Point(1215, 122);
            sODTLabel.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(59, 21);
            sODTLabel.TabIndex = 12;
            sODTLabel.Text = "SODT:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mACNLabel.Location = new System.Drawing.Point(84, 190);
            mACNLabel.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(61, 21);
            mACNLabel.TabIndex = 14;
            mACNLabel.Text = "MACN:";
            // 
            // trangThaiXoaLabel
            // 
            trangThaiXoaLabel.AutoSize = true;
            trangThaiXoaLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            trangThaiXoaLabel.Location = new System.Drawing.Point(632, 190);
            trangThaiXoaLabel.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            trangThaiXoaLabel.Name = "trangThaiXoaLabel";
            trangThaiXoaLabel.Size = new System.Drawing.Size(129, 21);
            trangThaiXoaLabel.TabIndex = 16;
            trangThaiXoaLabel.Text = "Trang Thai Xoa:";
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
            this.btnReload,
            this.btnChuyen});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnChuyen)});
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
            // btnChuyen
            // 
            this.btnChuyen.Caption = "Chuyển Chi Nhánh";
            this.btnChuyen.Enabled = false;
            this.btnChuyen.Id = 9;
            this.btnChuyen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyen.ImageOptions.Image")));
            this.btnChuyen.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChuyen.ImageOptions.LargeImage")));
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnChuyen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChuyen_ItemClick);
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 749);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1924, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 698);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1924, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 698);
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
            this.pnChiNhanh.Margin = new System.Windows.Forms.Padding(94);
            this.pnChiNhanh.Name = "pnChiNhanh";
            this.pnChiNhanh.Size = new System.Drawing.Size(1924, 124);
            this.pnChiNhanh.TabIndex = 6;
            // 
            // cbxChiNhanh
            // 
            this.cbxChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChiNhanh.Enabled = false;
            this.cbxChiNhanh.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxChiNhanh.FormattingEnabled = true;
            this.cbxChiNhanh.Location = new System.Drawing.Point(734, 55);
            this.cbxChiNhanh.Margin = new System.Windows.Forms.Padding(94);
            this.cbxChiNhanh.Name = "cbxChiNhanh";
            this.cbxChiNhanh.Size = new System.Drawing.Size(823, 29);
            this.cbxChiNhanh.TabIndex = 1;
            this.cbxChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbxChiNhanh_SelectedIndexChanged);
            // 
            // lbChiNhanh
            // 
            this.lbChiNhanh.AutoSize = true;
            this.lbChiNhanh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiNhanh.Location = new System.Drawing.Point(568, 55);
            this.lbChiNhanh.Margin = new System.Windows.Forms.Padding(94, 0, 94, 0);
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
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
            // gD_GOIRUTTableAdapter
            // 
            this.gD_GOIRUTTableAdapter.ClearBeforeFill = true;
            // 
            // gD_GOIRUTBindingSource
            // 
            this.gD_GOIRUTBindingSource.DataMember = "FK_GD_GOIRUT_NhanVien";
            // 
            // gD_CHUYENTIENTableAdapter
            // 
            this.gD_CHUYENTIENTableAdapter.ClearBeforeFill = true;
            // 
            // gD_CHUYENTIENBindingSource
            // 
            this.gD_CHUYENTIENBindingSource.DataMember = "FK_GD_CHUYENTIEN_NhanVien";
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.dS;
            // 
            // nhanVienGridControl
            // 
            this.nhanVienGridControl.DataSource = this.nhanVienBindingSource;
            this.nhanVienGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.nhanVienGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(24);
            this.nhanVienGridControl.Location = new System.Drawing.Point(0, 175);
            this.nhanVienGridControl.MainView = this.gridView1;
            this.nhanVienGridControl.Margin = new System.Windows.Forms.Padding(24);
            this.nhanVienGridControl.MenuManager = this.barManager1;
            this.nhanVienGridControl.Name = "nhanVienGridControl";
            this.nhanVienGridControl.Size = new System.Drawing.Size(1924, 182);
            this.nhanVienGridControl.TabIndex = 17;
            this.nhanVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 2600;
            this.gridView1.GridControl = this.nhanVienGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // pnChuyenCN
            // 
            this.pnChuyenCN.Controls.Add(this.btnChuyenCN);
            this.pnChuyenCN.Controls.Add(this.cbChuyenCN);
            this.pnChuyenCN.Controls.Add(this.label1);
            this.pnChuyenCN.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnChuyenCN.Enabled = false;
            this.pnChuyenCN.Location = new System.Drawing.Point(0, 357);
            this.pnChuyenCN.Margin = new System.Windows.Forms.Padding(118);
            this.pnChuyenCN.Name = "pnChuyenCN";
            this.pnChuyenCN.Size = new System.Drawing.Size(1924, 130);
            this.pnChuyenCN.TabIndex = 18;
            // 
            // btnChuyenCN
            // 
            this.btnChuyenCN.BackColor = System.Drawing.Color.Blue;
            this.btnChuyenCN.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenCN.ForeColor = System.Drawing.Color.White;
            this.btnChuyenCN.Location = new System.Drawing.Point(1345, 45);
            this.btnChuyenCN.Margin = new System.Windows.Forms.Padding(19);
            this.btnChuyenCN.Name = "btnChuyenCN";
            this.btnChuyenCN.Size = new System.Drawing.Size(226, 55);
            this.btnChuyenCN.TabIndex = 2;
            this.btnChuyenCN.Text = "Chuyển";
            this.btnChuyenCN.UseVisualStyleBackColor = false;
            this.btnChuyenCN.Click += new System.EventHandler(this.btnChuyenCN_Click_1);
            // 
            // cbChuyenCN
            // 
            this.cbChuyenCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChuyenCN.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChuyenCN.FormattingEnabled = true;
            this.cbChuyenCN.Location = new System.Drawing.Point(750, 56);
            this.cbChuyenCN.Margin = new System.Windows.Forms.Padding(118);
            this.cbChuyenCN.Name = "cbChuyenCN";
            this.cbChuyenCN.Size = new System.Drawing.Size(474, 29);
            this.cbChuyenCN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(118, 0, 118, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi nhánh chuyển";
            // 
            // pnNhap
            // 
            this.pnNhap.Controls.Add(trangThaiXoaLabel);
            this.pnNhap.Controls.Add(this.radBtnTrangThaiXoa);
            this.pnNhap.Controls.Add(mACNLabel);
            this.pnNhap.Controls.Add(this.txtMaCN);
            this.pnNhap.Controls.Add(sODTLabel);
            this.pnNhap.Controls.Add(this.txtSDT);
            this.pnNhap.Controls.Add(pHAILabel);
            this.pnNhap.Controls.Add(this.cbxPhai);
            this.pnNhap.Controls.Add(dIACHILabel);
            this.pnNhap.Controls.Add(this.dIACHITextEdit);
            this.pnNhap.Controls.Add(cMNDLabel);
            this.pnNhap.Controls.Add(this.txtCMND);
            this.pnNhap.Controls.Add(tENLabel);
            this.pnNhap.Controls.Add(this.txtTen);
            this.pnNhap.Controls.Add(hOLabel);
            this.pnNhap.Controls.Add(this.txtHo);
            this.pnNhap.Controls.Add(mANVLabel);
            this.pnNhap.Controls.Add(this.txtMaNV);
            this.pnNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnNhap.Enabled = false;
            this.pnNhap.Location = new System.Drawing.Point(0, 487);
            this.pnNhap.Margin = new System.Windows.Forms.Padding(24);
            this.pnNhap.Name = "pnNhap";
            this.pnNhap.Size = new System.Drawing.Size(1924, 262);
            this.pnNhap.TabIndex = 19;
            // 
            // radBtnTrangThaiXoa
            // 
            this.radBtnTrangThaiXoa.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.nhanVienBindingSource, "TrangThaiXoa", true));
            this.radBtnTrangThaiXoa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnTrangThaiXoa.Location = new System.Drawing.Point(915, 199);
            this.radBtnTrangThaiXoa.Margin = new System.Windows.Forms.Padding(15);
            this.radBtnTrangThaiXoa.Name = "radBtnTrangThaiXoa";
            this.radBtnTrangThaiXoa.Size = new System.Drawing.Size(31, 32);
            this.radBtnTrangThaiXoa.TabIndex = 17;
            this.radBtnTrangThaiXoa.UseVisualStyleBackColor = true;
            // 
            // txtMaCN
            // 
            this.txtMaCN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "MACN", true));
            this.txtMaCN.Location = new System.Drawing.Point(245, 176);
            this.txtMaCN.Margin = new System.Windows.Forms.Padding(19);
            this.txtMaCN.MenuManager = this.barManager1;
            this.txtMaCN.Name = "txtMaCN";
            this.txtMaCN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCN.Properties.Appearance.Options.UseFont = true;
            this.txtMaCN.Properties.ReadOnly = true;
            this.txtMaCN.Size = new System.Drawing.Size(238, 28);
            this.txtMaCN.TabIndex = 15;
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "SODT", true));
            this.txtSDT.Location = new System.Drawing.Point(1345, 118);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(19);
            this.txtSDT.MenuManager = this.barManager1;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Properties.Appearance.Options.UseFont = true;
            this.txtSDT.Size = new System.Drawing.Size(282, 28);
            this.txtSDT.TabIndex = 13;
            // 
            // cbxPhai
            // 
            this.cbxPhai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "PHAI", true));
            this.cbxPhai.Location = new System.Drawing.Point(1849, 118);
            this.cbxPhai.Margin = new System.Windows.Forms.Padding(19);
            this.cbxPhai.MenuManager = this.barManager1;
            this.cbxPhai.Name = "cbxPhai";
            this.cbxPhai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPhai.Properties.Appearance.Options.UseFont = true;
            this.cbxPhai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxPhai.Properties.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.cbxPhai.Size = new System.Drawing.Size(248, 28);
            this.cbxPhai.TabIndex = 11;
            // 
            // dIACHITextEdit
            // 
            this.dIACHITextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "DIACHI", true));
            this.dIACHITextEdit.Location = new System.Drawing.Point(245, 121);
            this.dIACHITextEdit.Margin = new System.Windows.Forms.Padding(19);
            this.dIACHITextEdit.MenuManager = this.barManager1;
            this.dIACHITextEdit.Name = "dIACHITextEdit";
            this.dIACHITextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dIACHITextEdit.Properties.Appearance.Options.UseFont = true;
            this.dIACHITextEdit.Size = new System.Drawing.Size(811, 28);
            this.dIACHITextEdit.TabIndex = 9;
            // 
            // txtCMND
            // 
            this.txtCMND.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "CMND", true));
            this.txtCMND.Location = new System.Drawing.Point(1849, 44);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(24);
            this.txtCMND.MenuManager = this.barManager1;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Properties.Appearance.Options.UseFont = true;
            this.txtCMND.Size = new System.Drawing.Size(336, 28);
            this.txtCMND.TabIndex = 7;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(1346, 51);
            this.txtTen.Margin = new System.Windows.Forms.Padding(24);
            this.txtTen.MenuManager = this.barManager1;
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Size = new System.Drawing.Size(282, 28);
            this.txtTen.TabIndex = 5;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "HO", true));
            this.txtHo.Location = new System.Drawing.Point(725, 50);
            this.txtHo.Margin = new System.Windows.Forms.Padding(24);
            this.txtHo.MenuManager = this.barManager1;
            this.txtHo.Name = "txtHo";
            this.txtHo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHo.Properties.Appearance.Options.UseFont = true;
            this.txtHo.Size = new System.Drawing.Size(331, 28);
            this.txtHo.TabIndex = 3;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "MANV", true));
            this.txtMaNV.Location = new System.Drawing.Point(246, 44);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(24);
            this.txtMaNV.MenuManager = this.barManager1;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Properties.Appearance.Options.UseFont = true;
            this.txtMaNV.Properties.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(186, 28);
            this.txtMaNV.TabIndex = 1;
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 749);
            this.Controls.Add(this.pnNhap);
            this.Controls.Add(this.pnChuyenCN);
            this.Controls.Add(this.nhanVienGridControl);
            this.Controls.Add(this.pnChiNhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnChiNhanh)).EndInit();
            this.pnChiNhanh.ResumeLayout(false);
            this.pnChiNhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_GOIRUTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_CHUYENTIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnChuyenCN)).EndInit();
            this.pnChuyenCN.ResumeLayout(false);
            this.pnChuyenCN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnNhap)).EndInit();
            this.pnNhap.ResumeLayout(false);
            this.pnNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPhai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIACHITextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
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
        private DS dS;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.BarButtonItem btnChuyen;
        private System.Windows.Forms.BindingSource gD_CHUYENTIENBindingSource;
        private DSTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private DSTableAdapters.GD_GOIRUTTableAdapter gD_GOIRUTTableAdapter;
        private System.Windows.Forms.BindingSource gD_GOIRUTBindingSource;
        private DSTableAdapters.GD_CHUYENTIENTableAdapter gD_CHUYENTIENTableAdapter;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private DevExpress.XtraGrid.GridControl nhanVienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl pnChuyenCN;
        private System.Windows.Forms.ComboBox cbChuyenCN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChuyenCN;
        private DevExpress.XtraEditors.PanelControl pnNhap;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private DevExpress.XtraEditors.TextEdit txtCMND;
        private System.Windows.Forms.CheckBox radBtnTrangThaiXoa;
        private DevExpress.XtraEditors.TextEdit txtMaCN;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.ComboBoxEdit cbxPhai;
        private DevExpress.XtraEditors.TextEdit dIACHITextEdit;
    }
}