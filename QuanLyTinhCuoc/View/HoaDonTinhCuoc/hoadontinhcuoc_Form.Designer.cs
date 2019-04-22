namespace QuanLyTinhCuoc.View.HoaDonTinhCuoc
{
    partial class hoadontinhcuoc_Form
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gchoadontinhcuoc = new DevExpress.XtraGrid.GridControl();
            this.gvhoadontinhcuoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaHDTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDSIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTuNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDenNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhiHangThang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gcSIM = new DevExpress.XtraGrid.GridControl();
            this.gvSIM = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn31 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_phihangthang = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_idhd = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_denngay = new DevExpress.XtraEditors.TextEdit();
            this.txt_tungay = new DevExpress.XtraEditors.TextEdit();
            this.txt_ngayxuat = new DevExpress.XtraEditors.TextEdit();
            this.ce_trangthai = new DevExpress.XtraEditors.CheckEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reset = new DevExpress.XtraEditors.SimpleButton();
            this.txt_tongtien = new DevExpress.XtraEditors.TextEdit();
            this.txt_idsim = new DevExpress.XtraEditors.TextEdit();
            this.btn_luu = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gchoadontinhcuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvhoadontinhcuoc)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSIM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSIM)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_phihangthang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_idhd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_denngay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tungay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ngayxuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_trangthai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tongtien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_idsim.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gchoadontinhcuoc);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(398, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 499);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn";
            // 
            // gchoadontinhcuoc
            // 
            this.gchoadontinhcuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gchoadontinhcuoc.Location = new System.Drawing.Point(3, 17);
            this.gchoadontinhcuoc.MainView = this.gvhoadontinhcuoc;
            this.gchoadontinhcuoc.Name = "gchoadontinhcuoc";
            this.gchoadontinhcuoc.Size = new System.Drawing.Size(503, 479);
            this.gchoadontinhcuoc.TabIndex = 0;
            this.gchoadontinhcuoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvhoadontinhcuoc});
            this.gchoadontinhcuoc.Load += new System.EventHandler(this.gchoadontinhcuoc_Load);
            // 
            // gvhoadontinhcuoc
            // 
            this.gvhoadontinhcuoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaHDTC,
            this.colIDSIM,
            this.colTuNgay,
            this.colDenNgay,
            this.colPhiHangThang,
            this.colTongTien,
            this.colNgayXuat,
            this.colThanhToan});
            this.gvhoadontinhcuoc.GridControl = this.gchoadontinhcuoc;
            this.gvhoadontinhcuoc.Name = "gvhoadontinhcuoc";
            this.gvhoadontinhcuoc.OptionsFind.AlwaysVisible = true;
            this.gvhoadontinhcuoc.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvhoadontinhcuoc_RowClick);
            // 
            // colMaHDTC
            // 
            this.colMaHDTC.Caption = "Mã HDTC";
            this.colMaHDTC.FieldName = "MaHDTC";
            this.colMaHDTC.Name = "colMaHDTC";
            this.colMaHDTC.Visible = true;
            this.colMaHDTC.VisibleIndex = 0;
            // 
            // colIDSIM
            // 
            this.colIDSIM.Caption = "Mã SIM";
            this.colIDSIM.FieldName = "IDSIM";
            this.colIDSIM.Name = "colIDSIM";
            this.colIDSIM.Visible = true;
            this.colIDSIM.VisibleIndex = 1;
            // 
            // colTuNgay
            // 
            this.colTuNgay.Caption = "Từ ngày";
            this.colTuNgay.FieldName = "TuNgay";
            this.colTuNgay.Name = "colTuNgay";
            this.colTuNgay.Visible = true;
            this.colTuNgay.VisibleIndex = 2;
            // 
            // colDenNgay
            // 
            this.colDenNgay.Caption = "Đến ngày";
            this.colDenNgay.FieldName = "DenNgay";
            this.colDenNgay.Name = "colDenNgay";
            this.colDenNgay.Visible = true;
            this.colDenNgay.VisibleIndex = 3;
            // 
            // colPhiHangThang
            // 
            this.colPhiHangThang.Caption = "Phí hàng tháng";
            this.colPhiHangThang.FieldName = "PhiHangThang";
            this.colPhiHangThang.Name = "colPhiHangThang";
            this.colPhiHangThang.Visible = true;
            this.colPhiHangThang.VisibleIndex = 4;
            // 
            // colTongTien
            // 
            this.colTongTien.Caption = "Tổng tiền";
            this.colTongTien.FieldName = "TongTien";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.Visible = true;
            this.colTongTien.VisibleIndex = 5;
            // 
            // colNgayXuat
            // 
            this.colNgayXuat.Caption = "Ngày xuất";
            this.colNgayXuat.FieldName = "NgayXuat";
            this.colNgayXuat.Name = "colNgayXuat";
            this.colNgayXuat.Visible = true;
            this.colNgayXuat.VisibleIndex = 6;
            // 
            // colThanhToan
            // 
            this.colThanhToan.Caption = "Thanh toán";
            this.colThanhToan.FieldName = "ThanhToan";
            this.colThanhToan.Name = "colThanhToan";
            this.colThanhToan.Visible = true;
            this.colThanhToan.VisibleIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gcSIM);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 225);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin SIM";
            // 
            // gcSIM
            // 
            this.gcSIM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSIM.Location = new System.Drawing.Point(3, 17);
            this.gcSIM.MainView = this.gvSIM;
            this.gcSIM.Name = "gcSIM";
            this.gcSIM.Size = new System.Drawing.Size(392, 205);
            this.gcSIM.TabIndex = 4;
            this.gcSIM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSIM});
            // 
            // gvSIM
            // 
            this.gvSIM.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn31});
            this.gvSIM.DetailHeight = 239;
            this.gvSIM.FixedLineWidth = 1;
            this.gvSIM.GridControl = this.gcSIM;
            this.gvSIM.Name = "gvSIM";
            this.gvSIM.OptionsFind.AlwaysVisible = true;
            this.gvSIM.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvSIM_RowClick);
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Mã SIM";
            this.gridColumn9.FieldName = "IDSIM";
            this.gridColumn9.MinWidth = 13;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 0;
            this.gridColumn9.Width = 50;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Số điện thoại";
            this.gridColumn10.FieldName = "SoDienThoai";
            this.gridColumn10.MinWidth = 13;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 1;
            this.gridColumn10.Width = 50;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Ngày đăng ký";
            this.gridColumn11.FieldName = "NgayDangKy";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 2;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Ngày hết hạn";
            this.gridColumn12.FieldName = "NgayHetHan";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 3;
            // 
            // gridColumn31
            // 
            this.gridColumn31.Caption = "Tình trạng";
            this.gridColumn31.FieldName = "Flag";
            this.gridColumn31.Name = "gridColumn31";
            this.gridColumn31.Visible = true;
            this.gridColumn31.VisibleIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 499);
            this.panel1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_phihangthang);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txt_idhd);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_denngay);
            this.groupBox3.Controls.Add(this.txt_tungay);
            this.groupBox3.Controls.Add(this.txt_ngayxuat);
            this.groupBox3.Controls.Add(this.ce_trangthai);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btn_reset);
            this.groupBox3.Controls.Add(this.txt_tongtien);
            this.groupBox3.Controls.Add(this.txt_idsim);
            this.groupBox3.Controls.Add(this.btn_luu);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(398, 274);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin";
            // 
            // txt_phihangthang
            // 
            this.txt_phihangthang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_phihangthang.Enabled = false;
            this.txt_phihangthang.Location = new System.Drawing.Point(132, 66);
            this.txt_phihangthang.Name = "txt_phihangthang";
            this.txt_phihangthang.Size = new System.Drawing.Size(216, 20);
            this.txt_phihangthang.TabIndex = 76;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(25, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 75;
            this.label9.Text = "Phí hàng tháng:";
            // 
            // txt_idhd
            // 
            this.txt_idhd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_idhd.Enabled = false;
            this.txt_idhd.Location = new System.Drawing.Point(132, 14);
            this.txt_idhd.Name = "txt_idhd";
            this.txt_idhd.Size = new System.Drawing.Size(216, 20);
            this.txt_idhd.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(25, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 73;
            this.label8.Text = "Mã HD:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(230, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 16);
            this.label6.TabIndex = 72;
            this.label6.Text = "đến";
            // 
            // txt_denngay
            // 
            this.txt_denngay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_denngay.Enabled = false;
            this.txt_denngay.Location = new System.Drawing.Point(266, 124);
            this.txt_denngay.Name = "txt_denngay";
            this.txt_denngay.Size = new System.Drawing.Size(80, 20);
            this.txt_denngay.TabIndex = 71;
            // 
            // txt_tungay
            // 
            this.txt_tungay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_tungay.Enabled = false;
            this.txt_tungay.Location = new System.Drawing.Point(130, 124);
            this.txt_tungay.Name = "txt_tungay";
            this.txt_tungay.Size = new System.Drawing.Size(85, 20);
            this.txt_tungay.TabIndex = 70;
            // 
            // txt_ngayxuat
            // 
            this.txt_ngayxuat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ngayxuat.Enabled = false;
            this.txt_ngayxuat.Location = new System.Drawing.Point(132, 156);
            this.txt_ngayxuat.Name = "txt_ngayxuat";
            this.txt_ngayxuat.Size = new System.Drawing.Size(216, 20);
            this.txt_ngayxuat.TabIndex = 69;
            // 
            // ce_trangthai
            // 
            this.ce_trangthai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ce_trangthai.Location = new System.Drawing.Point(130, 190);
            this.ce_trangthai.Name = "ce_trangthai";
            this.ce_trangthai.Properties.Caption = "Đã thanh toán";
            this.ce_trangthai.Size = new System.Drawing.Size(93, 19);
            this.ce_trangthai.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(24, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Tình trạng:";
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_reset.Location = new System.Drawing.Point(286, 216);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(115, 32);
            this.btn_reset.TabIndex = 65;
            this.btn_reset.Text = "Reset";
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_tongtien.Enabled = false;
            this.txt_tongtien.Location = new System.Drawing.Point(130, 92);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(216, 20);
            this.txt_tongtien.TabIndex = 59;
            // 
            // txt_idsim
            // 
            this.txt_idsim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_idsim.Enabled = false;
            this.txt_idsim.Location = new System.Drawing.Point(132, 40);
            this.txt_idsim.Name = "txt_idsim";
            this.txt_idsim.Size = new System.Drawing.Size(216, 20);
            this.txt_idsim.TabIndex = 58;
            // 
            // btn_luu
            // 
            this.btn_luu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_luu.Location = new System.Drawing.Point(144, 215);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(115, 32);
            this.btn_luu.TabIndex = 56;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_themthongtinsim_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(24, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(24, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 54;
            this.label4.Text = "Ngày xuất:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(24, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "Phí thu từ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(25, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Tổng tiền:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(24, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "ID Sim:";
            // 
            // hoadontinhcuoc_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "hoadontinhcuoc_Form";
            this.Size = new System.Drawing.Size(907, 499);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gchoadontinhcuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvhoadontinhcuoc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSIM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSIM)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_phihangthang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_idhd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_denngay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tungay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ngayxuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_trangthai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tongtien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_idsim.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gchoadontinhcuoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gvhoadontinhcuoc;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHDTC;
        private DevExpress.XtraGrid.Columns.GridColumn colIDSIM;
        private DevExpress.XtraGrid.Columns.GridColumn colTuNgay;
        private DevExpress.XtraGrid.Columns.GridColumn colDenNgay;
        private DevExpress.XtraGrid.Columns.GridColumn colPhiHangThang;
        private DevExpress.XtraGrid.Columns.GridColumn colTongTien;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayXuat;
        private DevExpress.XtraGrid.Columns.GridColumn colThanhToan;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gcSIM;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSIM;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn31;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.CheckEdit ce_trangthai;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_reset;
        private DevExpress.XtraEditors.TextEdit txt_idsim;
        private DevExpress.XtraEditors.SimpleButton btn_luu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txt_ngayxuat;
        private DevExpress.XtraEditors.TextEdit txt_tongtien;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txt_denngay;
        private DevExpress.XtraEditors.TextEdit txt_tungay;
        private DevExpress.XtraEditors.TextEdit txt_phihangthang;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit txt_idhd;
        private System.Windows.Forms.Label label8;
    }
}
