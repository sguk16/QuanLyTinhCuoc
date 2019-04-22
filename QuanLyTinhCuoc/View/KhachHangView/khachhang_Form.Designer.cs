namespace QuanLyTinhCuoc.View.KhachHangView
{
    partial class khachhang_Form
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gcKhachHang = new DevExpress.XtraGrid.GridControl();
            this.gvKhachhang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMakhachhanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNghenghiep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChucvu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiachi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhachhang)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.simpleButton2);
            this.groupBox2.Controls.Add(this.simpleButton1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(907, 63);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hoạt động";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(139, 20);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 24);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Sửa";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(28, 21);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 24);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Thêm";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gcKhachHang
            // 
            this.gcKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            gridLevelNode2.RelationName = "Level2";
            this.gcKhachHang.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.gcKhachHang.Location = new System.Drawing.Point(3, 17);
            this.gcKhachHang.MainView = this.gvKhachhang;
            this.gcKhachHang.Name = "gcKhachHang";
            this.gcKhachHang.Size = new System.Drawing.Size(901, 416);
            this.gcKhachHang.TabIndex = 0;
            this.gcKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKhachhang});
            // 
            // gvKhachhang
            // 
            this.gvKhachhang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMakhachhanh,
            this.colten,
            this.colCMND,
            this.colNghenghiep,
            this.colChucvu,
            this.colDiachi,
            this.colEmail});
            this.gvKhachhang.DetailHeight = 239;
            this.gvKhachhang.FixedLineWidth = 1;
            this.gvKhachhang.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gvKhachhang.GridControl = this.gcKhachHang;
            this.gvKhachhang.Name = "gvKhachhang";
            this.gvKhachhang.OptionsFind.AlwaysVisible = true;
            // 
            // colMakhachhanh
            // 
            this.colMakhachhanh.Caption = "Mã Khách hàng";
            this.colMakhachhanh.FieldName = "MaKH";
            this.colMakhachhanh.MinWidth = 13;
            this.colMakhachhanh.Name = "colMakhachhanh";
            this.colMakhachhanh.Visible = true;
            this.colMakhachhanh.VisibleIndex = 0;
            this.colMakhachhanh.Width = 50;
            // 
            // colten
            // 
            this.colten.Caption = "Tên khách hàng";
            this.colten.FieldName = "TenKH";
            this.colten.MinWidth = 13;
            this.colten.Name = "colten";
            this.colten.Visible = true;
            this.colten.VisibleIndex = 1;
            this.colten.Width = 50;
            // 
            // colCMND
            // 
            this.colCMND.Caption = "CMND";
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 13;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 2;
            this.colCMND.Width = 50;
            // 
            // colNghenghiep
            // 
            this.colNghenghiep.Caption = "Nghề Nghiệp";
            this.colNghenghiep.FieldName = "NgheNghiep";
            this.colNghenghiep.MinWidth = 13;
            this.colNghenghiep.Name = "colNghenghiep";
            this.colNghenghiep.Visible = true;
            this.colNghenghiep.VisibleIndex = 3;
            this.colNghenghiep.Width = 50;
            // 
            // colChucvu
            // 
            this.colChucvu.Caption = "Chức vụ";
            this.colChucvu.FieldName = "ChucVu";
            this.colChucvu.MinWidth = 13;
            this.colChucvu.Name = "colChucvu";
            this.colChucvu.Visible = true;
            this.colChucvu.VisibleIndex = 4;
            this.colChucvu.Width = 50;
            // 
            // colDiachi
            // 
            this.colDiachi.Caption = "Địa chỉ";
            this.colDiachi.FieldName = "DiaChi";
            this.colDiachi.MinWidth = 13;
            this.colDiachi.Name = "colDiachi";
            this.colDiachi.Visible = true;
            this.colDiachi.VisibleIndex = 5;
            this.colDiachi.Width = 50;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.MinWidth = 13;
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 6;
            this.colEmail.Width = 50;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gcKhachHang);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(907, 436);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách khách hàng";
            // 
            // khachhang_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "khachhang_Form";
            this.Size = new System.Drawing.Size(907, 499);
            this.Load += new System.EventHandler(this.khachhang_Form_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhachhang)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gcKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKhachhang;
        private DevExpress.XtraGrid.Columns.GridColumn colMakhachhanh;
        private DevExpress.XtraGrid.Columns.GridColumn colten;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colNghenghiep;
        private DevExpress.XtraGrid.Columns.GridColumn colChucvu;
        private DevExpress.XtraGrid.Columns.GridColumn colDiachi;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}
