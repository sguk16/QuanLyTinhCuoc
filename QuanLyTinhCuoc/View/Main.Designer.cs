namespace QuanLyTinhCuoc
{
    partial class Main
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.tabKhachHang = new DevExpress.XtraTab.XtraTabControl();
            this.tabHDDK = new DevExpress.XtraTab.XtraTabPage();
            this.gcHddk = new DevExpress.XtraGrid.GridControl();
            this.gvHoaDon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaHDDK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDSIMHDDK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChiPhiDangKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayDangKyHDDK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabQLCT = new DevExpress.XtraTab.XtraTabPage();
            this.gcDataKhachHang = new DevExpress.XtraGrid.GridControl();
            this.gvKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgheNghiep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayDangKyKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabSIM = new DevExpress.XtraTab.XtraTabPage();
            this.gcDataTTSim = new DevExpress.XtraGrid.GridControl();
            this.gvSim = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDSIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayDangKySIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayHetHanSIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaKHSIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupKH = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btn_themkh = new DevExpress.XtraBars.BarButtonItem();
            this.btn_suakh = new DevExpress.XtraBars.BarButtonItem();
            this.btn_xoakh = new DevExpress.XtraBars.BarButtonItem();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btn_themsim = new DevExpress.XtraBars.BarButtonItem();
            this.btn_suasim = new DevExpress.XtraBars.BarButtonItem();
            this.btn_xoasim = new DevExpress.XtraBars.BarButtonItem();
            this.btn_themhddk = new DevExpress.XtraBars.BarButtonItem();
            this.btn_suahddk = new DevExpress.XtraBars.BarButtonItem();
            this.btn_xoahddk = new DevExpress.XtraBars.BarButtonItem();
            this.popupSIM = new DevExpress.XtraBars.PopupMenu(this.components);
            this.popupHDDK = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabKhachHang)).BeginInit();
            this.tabKhachHang.SuspendLayout();
            this.tabHDDK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcHddk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoaDon)).BeginInit();
            this.tabQLCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDataKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhachHang)).BeginInit();
            this.tabSIM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDataTTSim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupSIM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupHDDK)).BeginInit();
            this.SuspendLayout();
            // 
            // tabKhachHang
            // 
            this.tabKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabKhachHang.Location = new System.Drawing.Point(0, 0);
            this.tabKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.tabKhachHang.Name = "tabKhachHang";
            this.tabKhachHang.SelectedTabPage = this.tabHDDK;
            this.tabKhachHang.Size = new System.Drawing.Size(1324, 627);
            this.tabKhachHang.TabIndex = 0;
            this.tabKhachHang.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabQLCT,
            this.tabSIM,
            this.tabHDDK});
            this.tabKhachHang.Click += new System.EventHandler(this.tabKhachHang_Click);
            // 
            // tabHDDK
            // 
            this.tabHDDK.Controls.Add(this.gcHddk);
            this.tabHDDK.Margin = new System.Windows.Forms.Padding(4);
            this.tabHDDK.Name = "tabHDDK";
            this.tabHDDK.Size = new System.Drawing.Size(1314, 585);
            this.tabHDDK.Text = "Hóa Đơn Đăng Ký";
            // 
            // gcHddk
            // 
            this.gcHddk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHddk.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcHddk.Location = new System.Drawing.Point(0, 0);
            this.gcHddk.MainView = this.gvHoaDon;
            this.gcHddk.Margin = new System.Windows.Forms.Padding(4);
            this.gcHddk.Name = "gcHddk";
            this.gcHddk.Size = new System.Drawing.Size(1314, 585);
            this.gcHddk.TabIndex = 0;
            this.gcHddk.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHoaDon});
            this.gcHddk.Load += new System.EventHandler(this.gcHddk_Load);
            // 
            // gvHoaDon
            // 
            this.gvHoaDon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaHDDK,
            this.IDSIMHDDK,
            this.ChiPhiDangKy,
            this.NgayDangKyHDDK});
            this.gvHoaDon.GridControl = this.gcHddk;
            this.gvHoaDon.Name = "gvHoaDon";
            this.gvHoaDon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gcHddk_MouseUp);
            // 
            // MaHDDK
            // 
            this.MaHDDK.Caption = "Mã";
            this.MaHDDK.FieldName = "MaHDDK";
            this.MaHDDK.Name = "MaHDDK";
            this.MaHDDK.Visible = true;
            this.MaHDDK.VisibleIndex = 0;
            // 
            // IDSIMHDDK
            // 
            this.IDSIMHDDK.Caption = "ID SIM";
            this.IDSIMHDDK.FieldName = "IDSIM";
            this.IDSIMHDDK.Name = "IDSIMHDDK";
            this.IDSIMHDDK.Visible = true;
            this.IDSIMHDDK.VisibleIndex = 1;
            // 
            // ChiPhiDangKy
            // 
            this.ChiPhiDangKy.Caption = "Chi phí";
            this.ChiPhiDangKy.FieldName = "ChiPhiDangKy";
            this.ChiPhiDangKy.Name = "ChiPhiDangKy";
            this.ChiPhiDangKy.Visible = true;
            this.ChiPhiDangKy.VisibleIndex = 2;
            // 
            // NgayDangKyHDDK
            // 
            this.NgayDangKyHDDK.Caption = "Ngày đăng ký";
            this.NgayDangKyHDDK.FieldName = "NgayDangKy";
            this.NgayDangKyHDDK.Name = "NgayDangKyHDDK";
            this.NgayDangKyHDDK.Visible = true;
            this.NgayDangKyHDDK.VisibleIndex = 3;
            // 
            // tabQLCT
            // 
            this.tabQLCT.Controls.Add(this.gcDataKhachHang);
            this.tabQLCT.Margin = new System.Windows.Forms.Padding(4);
            this.tabQLCT.Name = "tabQLCT";
            this.tabQLCT.Size = new System.Drawing.Size(1314, 585);
            this.tabQLCT.Text = "Khách Hàng";
            // 
            // gcDataKhachHang
            // 
            this.gcDataKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDataKhachHang.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcDataKhachHang.Location = new System.Drawing.Point(0, 0);
            this.gcDataKhachHang.MainView = this.gvKhachHang;
            this.gcDataKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.gcDataKhachHang.Name = "gcDataKhachHang";
            this.gcDataKhachHang.Size = new System.Drawing.Size(1314, 585);
            this.gcDataKhachHang.TabIndex = 0;
            this.gcDataKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKhachHang});
            this.gcDataKhachHang.Load += new System.EventHandler(this.gcData_Load);
            // 
            // gvKhachHang
            // 
            this.gvKhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaKH,
            this.TenKH,
            this.CMND,
            this.Email,
            this.NgheNghiep,
            this.ChucVu,
            this.DiaChi,
            this.NgayDangKyKH});
            this.gvKhachHang.GridControl = this.gcDataKhachHang;
            this.gvKhachHang.Name = "gvKhachHang";
            this.gvKhachHang.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gvKhachHang_MouseUp);
            // 
            // MaKH
            // 
            this.MaKH.Caption = "Mã khách hàng";
            this.MaKH.FieldName = "MaKH";
            this.MaKH.Name = "MaKH";
            this.MaKH.Visible = true;
            this.MaKH.VisibleIndex = 0;
            // 
            // TenKH
            // 
            this.TenKH.Caption = "Họ Tên";
            this.TenKH.FieldName = "TenKH";
            this.TenKH.Name = "TenKH";
            this.TenKH.Visible = true;
            this.TenKH.VisibleIndex = 1;
            // 
            // CMND
            // 
            this.CMND.Caption = "CMND";
            this.CMND.FieldName = "CMND";
            this.CMND.Name = "CMND";
            this.CMND.Visible = true;
            this.CMND.VisibleIndex = 2;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.FieldName = "Email";
            this.Email.Name = "Email";
            this.Email.Visible = true;
            this.Email.VisibleIndex = 3;
            // 
            // NgheNghiep
            // 
            this.NgheNghiep.Caption = "Nghề Nghiệp";
            this.NgheNghiep.FieldName = "NgheNghiep";
            this.NgheNghiep.Name = "NgheNghiep";
            this.NgheNghiep.Visible = true;
            this.NgheNghiep.VisibleIndex = 4;
            // 
            // ChucVu
            // 
            this.ChucVu.Caption = "Chức vụ";
            this.ChucVu.FieldName = "ChucVu";
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.Visible = true;
            this.ChucVu.VisibleIndex = 5;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 6;
            // 
            // NgayDangKyKH
            // 
            this.NgayDangKyKH.Caption = "Ngày đăng ký";
            this.NgayDangKyKH.FieldName = "NgayDangKy";
            this.NgayDangKyKH.Name = "NgayDangKyKH";
            this.NgayDangKyKH.Visible = true;
            this.NgayDangKyKH.VisibleIndex = 7;
            // 
            // tabSIM
            // 
            this.tabSIM.Controls.Add(this.gcDataTTSim);
            this.tabSIM.Margin = new System.Windows.Forms.Padding(4);
            this.tabSIM.Name = "tabSIM";
            this.tabSIM.Size = new System.Drawing.Size(1314, 585);
            this.tabSIM.Text = "Thông Tin SIM";
            // 
            // gcDataTTSim
            // 
            this.gcDataTTSim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDataTTSim.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            gridLevelNode1.RelationName = "Level1";
            gridLevelNode2.RelationName = "Level2";
            this.gcDataTTSim.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.gcDataTTSim.Location = new System.Drawing.Point(0, 0);
            this.gcDataTTSim.MainView = this.gvSim;
            this.gcDataTTSim.Margin = new System.Windows.Forms.Padding(4);
            this.gcDataTTSim.Name = "gcDataTTSim";
            this.gcDataTTSim.Size = new System.Drawing.Size(1314, 585);
            this.gcDataTTSim.TabIndex = 0;
            this.gcDataTTSim.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSim});
            this.gcDataTTSim.Load += new System.EventHandler(this.gcDataTTSim_Load);
            // 
            // gvSim
            // 
            this.gvSim.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDSIM,
            this.SoDienThoai,
            this.NgayDangKySIM,
            this.NgayHetHanSIM,
            this.MaKHSIM});
            this.gvSim.GridControl = this.gcDataTTSim;
            this.gvSim.Name = "gvSim";
            this.gvSim.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gcDataTTSim_MouseUp);
            // 
            // IDSIM
            // 
            this.IDSIM.Caption = "ID";
            this.IDSIM.FieldName = "IDSIM";
            this.IDSIM.Name = "IDSIM";
            this.IDSIM.Visible = true;
            this.IDSIM.VisibleIndex = 0;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.Caption = "SDT";
            this.SoDienThoai.FieldName = "SoDienThoai";
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.Visible = true;
            this.SoDienThoai.VisibleIndex = 1;
            // 
            // NgayDangKySIM
            // 
            this.NgayDangKySIM.Caption = "Ngày đăng ký";
            this.NgayDangKySIM.FieldName = "NgayDangKy";
            this.NgayDangKySIM.Name = "NgayDangKySIM";
            this.NgayDangKySIM.Visible = true;
            this.NgayDangKySIM.VisibleIndex = 2;
            // 
            // NgayHetHanSIM
            // 
            this.NgayHetHanSIM.Caption = "Ngày hết hạn";
            this.NgayHetHanSIM.FieldName = "NgayHetHan";
            this.NgayHetHanSIM.Name = "NgayHetHanSIM";
            this.NgayHetHanSIM.Visible = true;
            this.NgayHetHanSIM.VisibleIndex = 3;
            // 
            // MaKHSIM
            // 
            this.MaKHSIM.Caption = "Mã khách hàng";
            this.MaKHSIM.FieldName = "MaKH";
            this.MaKHSIM.Name = "MaKHSIM";
            this.MaKHSIM.Visible = true;
            this.MaKHSIM.VisibleIndex = 4;
            // 
            // popupKH
            // 
            this.popupKH.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_themkh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_suakh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_xoakh)});
            this.popupKH.Manager = this.barManager;
            this.popupKH.Name = "popupKH";
            // 
            // btn_themkh
            // 
            this.btn_themkh.Caption = "Thêm";
            this.btn_themkh.Id = 0;
            this.btn_themkh.Name = "btn_themkh";
            this.btn_themkh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_themkh_ItemClick);
            // 
            // btn_suakh
            // 
            this.btn_suakh.Caption = "Sửa";
            this.btn_suakh.Id = 1;
            this.btn_suakh.Name = "btn_suakh";
            this.btn_suakh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_suakh_ItemClick);
            // 
            // btn_xoakh
            // 
            this.btn_xoakh.Caption = "Xóa";
            this.btn_xoakh.Id = 2;
            this.btn_xoakh.Name = "btn_xoakh";
            this.btn_xoakh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_xoakh_ItemClick);
            // 
            // barManager
            // 
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_themkh,
            this.btn_suakh,
            this.btn_xoakh,
            this.btn_themsim,
            this.btn_suasim,
            this.btn_xoasim,
            this.btn_themhddk,
            this.btn_suahddk,
            this.btn_xoahddk});
            this.barManager.MaxItemId = 9;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1324, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 627);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1324, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 627);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1324, 0);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 627);
            // 
            // btn_themsim
            // 
            this.btn_themsim.Caption = "Thêm";
            this.btn_themsim.Id = 3;
            this.btn_themsim.Name = "btn_themsim";
            this.btn_themsim.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_themsim_ItemClick);
            // 
            // btn_suasim
            // 
            this.btn_suasim.Caption = "Sửa";
            this.btn_suasim.Id = 4;
            this.btn_suasim.Name = "btn_suasim";
            this.btn_suasim.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_suasim_ItemClick);
            // 
            // btn_xoasim
            // 
            this.btn_xoasim.Caption = "Xóa";
            this.btn_xoasim.Id = 5;
            this.btn_xoasim.Name = "btn_xoasim";
            this.btn_xoasim.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_xoasim_ItemClick);
            // 
            // btn_themhddk
            // 
            this.btn_themhddk.Caption = "Thêm";
            this.btn_themhddk.Id = 6;
            this.btn_themhddk.Name = "btn_themhddk";
            this.btn_themhddk.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_themhddk_ItemClick);
            // 
            // btn_suahddk
            // 
            this.btn_suahddk.Caption = "Sửa";
            this.btn_suahddk.Id = 7;
            this.btn_suahddk.Name = "btn_suahddk";
            this.btn_suahddk.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_suahddk_ItemClick);
            // 
            // btn_xoahddk
            // 
            this.btn_xoahddk.Caption = "Xóa";
            this.btn_xoahddk.Id = 8;
            this.btn_xoahddk.Name = "btn_xoahddk";
            this.btn_xoahddk.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_xoahddk_ItemClick);
            // 
            // popupSIM
            // 
            this.popupSIM.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_themsim),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_suasim),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_xoasim)});
            this.popupSIM.Manager = this.barManager;
            this.popupSIM.Name = "popupSIM";
            // 
            // popupHDDK
            // 
            this.popupHDDK.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_themhddk),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_suahddk),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_xoahddk)});
            this.popupHDDK.Manager = this.barManager;
            this.popupHDDK.Name = "popupHDDK";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 627);
            this.Controls.Add(this.tabKhachHang);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "QUẢN LÝ TÍNH CƯỚC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tabKhachHang)).EndInit();
            this.tabKhachHang.ResumeLayout(false);
            this.tabHDDK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcHddk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoaDon)).EndInit();
            this.tabQLCT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDataKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhachHang)).EndInit();
            this.tabSIM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDataTTSim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupSIM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupHDDK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabKhachHang;
        private DevExpress.XtraTab.XtraTabPage tabQLCT;
        private DevExpress.XtraTab.XtraTabPage tabSIM;
        private DevExpress.XtraTab.XtraTabPage tabHDDK;
        private DevExpress.XtraGrid.GridControl gcDataKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKhachHang;
        private DevExpress.XtraGrid.GridControl gcHddk;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn MaHDDK;
        private DevExpress.XtraGrid.Columns.GridColumn IDSIMHDDK;
        private DevExpress.XtraGrid.Columns.GridColumn ChiPhiDangKy;
        private DevExpress.XtraGrid.Columns.GridColumn NgayDangKyHDDK;
        private DevExpress.XtraGrid.Columns.GridColumn MaKH;
        private DevExpress.XtraGrid.Columns.GridColumn TenKH;
        private DevExpress.XtraGrid.Columns.GridColumn CMND;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn NgheNghiep;
        private DevExpress.XtraGrid.Columns.GridColumn ChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn NgayDangKyKH;
        private DevExpress.XtraGrid.GridControl gcDataTTSim;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSim;
        private DevExpress.XtraGrid.Columns.GridColumn IDSIM;
        private DevExpress.XtraGrid.Columns.GridColumn SoDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn NgayDangKySIM;
        private DevExpress.XtraGrid.Columns.GridColumn NgayHetHanSIM;
        private DevExpress.XtraGrid.Columns.GridColumn MaKHSIM;
        private DevExpress.XtraBars.PopupMenu popupKH;
        private DevExpress.XtraBars.BarButtonItem btn_themkh;
        private DevExpress.XtraBars.BarButtonItem btn_suakh;
        private DevExpress.XtraBars.BarButtonItem btn_xoakh;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btn_themsim;
        private DevExpress.XtraBars.BarButtonItem btn_suasim;
        private DevExpress.XtraBars.BarButtonItem btn_xoasim;
        private DevExpress.XtraBars.BarButtonItem btn_themhddk;
        private DevExpress.XtraBars.BarButtonItem btn_suahddk;
        private DevExpress.XtraBars.BarButtonItem btn_xoahddk;
        private DevExpress.XtraBars.PopupMenu popupSIM;
        private DevExpress.XtraBars.PopupMenu popupHDDK;
    }
}

