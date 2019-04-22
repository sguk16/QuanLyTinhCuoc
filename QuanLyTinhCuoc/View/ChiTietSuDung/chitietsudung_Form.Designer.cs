namespace QuanLyTinhCuoc.View.ChiTietSuDung
{
    partial class chitietsudung_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_nhapfilelog = new DevExpress.XtraEditors.SimpleButton();
            this.tbxTGKT = new System.Windows.Forms.TextBox();
            this.tbxTGBD = new System.Windows.Forms.TextBox();
            this.tbxIDSIM = new System.Windows.Forms.TextBox();
            this.tbxPhiCuocGoi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxSoPhutSD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxMaCTSD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcchitietsudung = new DevExpress.XtraGrid.GridControl();
            this.gvchitietsudung = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMachitiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmasim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltgbd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltgkt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsophutsang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsophuttoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcchitietsudung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvchitietsudung)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_nhapfilelog);
            this.groupBox1.Controls.Add(this.tbxTGKT);
            this.groupBox1.Controls.Add(this.tbxTGBD);
            this.groupBox1.Controls.Add(this.tbxIDSIM);
            this.groupBox1.Controls.Add(this.tbxPhiCuocGoi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbxSoPhutSD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxMaCTSD);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(907, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // btn_nhapfilelog
            // 
            this.btn_nhapfilelog.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhapfilelog.Appearance.Options.UseFont = true;
            this.btn_nhapfilelog.Location = new System.Drawing.Point(407, 156);
            this.btn_nhapfilelog.Name = "btn_nhapfilelog";
            this.btn_nhapfilelog.Size = new System.Drawing.Size(141, 36);
            this.btn_nhapfilelog.TabIndex = 54;
            this.btn_nhapfilelog.Text = "Nhập File Log";
            this.btn_nhapfilelog.Click += new System.EventHandler(this.btn_nhapfilelog_Click);
            // 
            // tbxTGKT
            // 
            this.tbxTGKT.BackColor = System.Drawing.Color.White;
            this.tbxTGKT.Location = new System.Drawing.Point(602, 68);
            this.tbxTGKT.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTGKT.Name = "tbxTGKT";
            this.tbxTGKT.ReadOnly = true;
            this.tbxTGKT.Size = new System.Drawing.Size(213, 21);
            this.tbxTGKT.TabIndex = 31;
            // 
            // tbxTGBD
            // 
            this.tbxTGBD.BackColor = System.Drawing.Color.White;
            this.tbxTGBD.Location = new System.Drawing.Point(191, 68);
            this.tbxTGBD.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTGBD.Name = "tbxTGBD";
            this.tbxTGBD.ReadOnly = true;
            this.tbxTGBD.Size = new System.Drawing.Size(221, 21);
            this.tbxTGBD.TabIndex = 30;
            // 
            // tbxIDSIM
            // 
            this.tbxIDSIM.BackColor = System.Drawing.Color.White;
            this.tbxIDSIM.Location = new System.Drawing.Point(602, 24);
            this.tbxIDSIM.Margin = new System.Windows.Forms.Padding(4);
            this.tbxIDSIM.Name = "tbxIDSIM";
            this.tbxIDSIM.ReadOnly = true;
            this.tbxIDSIM.Size = new System.Drawing.Size(213, 21);
            this.tbxIDSIM.TabIndex = 29;
            // 
            // tbxPhiCuocGoi
            // 
            this.tbxPhiCuocGoi.BackColor = System.Drawing.Color.White;
            this.tbxPhiCuocGoi.Location = new System.Drawing.Point(602, 114);
            this.tbxPhiCuocGoi.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPhiCuocGoi.Name = "tbxPhiCuocGoi";
            this.tbxPhiCuocGoi.ReadOnly = true;
            this.tbxPhiCuocGoi.Size = new System.Drawing.Size(213, 21);
            this.tbxPhiCuocGoi.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(513, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Phí cuộc gọi";
            // 
            // tbxSoPhutSD
            // 
            this.tbxSoPhutSD.BackColor = System.Drawing.Color.White;
            this.tbxSoPhutSD.Location = new System.Drawing.Point(191, 114);
            this.tbxSoPhutSD.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSoPhutSD.Name = "tbxSoPhutSD";
            this.tbxSoPhutSD.ReadOnly = true;
            this.tbxSoPhutSD.Size = new System.Drawing.Size(221, 21);
            this.tbxSoPhutSD.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Số phút sử dụng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Thời gian kết thúc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Thời gian bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(550, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "IDSIM";
            // 
            // tbxMaCTSD
            // 
            this.tbxMaCTSD.Location = new System.Drawing.Point(191, 24);
            this.tbxMaCTSD.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMaCTSD.Name = "tbxMaCTSD";
            this.tbxMaCTSD.ReadOnly = true;
            this.tbxMaCTSD.Size = new System.Drawing.Size(221, 21);
            this.tbxMaCTSD.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã chi tiết";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gcchitietsudung);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 205);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(907, 294);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Chi tiết sử dụng";
            // 
            // gcchitietsudung
            // 
            this.gcchitietsudung.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            gridLevelNode2.RelationName = "Level2";
            this.gcchitietsudung.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.gcchitietsudung.Location = new System.Drawing.Point(2, 20);
            this.gcchitietsudung.MainView = this.gvchitietsudung;
            this.gcchitietsudung.Name = "gcchitietsudung";
            this.gcchitietsudung.Size = new System.Drawing.Size(903, 272);
            this.gcchitietsudung.TabIndex = 3;
            this.gcchitietsudung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvchitietsudung});
            // 
            // gvchitietsudung
            // 
            this.gvchitietsudung.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMachitiet,
            this.colmasim,
            this.coltgbd,
            this.coltgkt,
            this.colsophutsang,
            this.colsophuttoi});
            this.gvchitietsudung.DetailHeight = 239;
            this.gvchitietsudung.FixedLineWidth = 1;
            this.gvchitietsudung.GridControl = this.gcchitietsudung;
            this.gvchitietsudung.Name = "gvchitietsudung";
            this.gvchitietsudung.OptionsFind.AlwaysVisible = true;
            this.gvchitietsudung.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvchitietsudung_RowClick);
            // 
            // colMachitiet
            // 
            this.colMachitiet.Caption = "Mã chỉ tiết";
            this.colMachitiet.FieldName = "ID";
            this.colMachitiet.MinWidth = 13;
            this.colMachitiet.Name = "colMachitiet";
            this.colMachitiet.Visible = true;
            this.colMachitiet.VisibleIndex = 0;
            this.colMachitiet.Width = 50;
            // 
            // colmasim
            // 
            this.colmasim.Caption = "Mã SIM";
            this.colmasim.FieldName = "IDSIM";
            this.colmasim.MinWidth = 13;
            this.colmasim.Name = "colmasim";
            this.colmasim.Visible = true;
            this.colmasim.VisibleIndex = 1;
            this.colmasim.Width = 50;
            // 
            // coltgbd
            // 
            this.coltgbd.Caption = "Thời gian bắt đầu";
            this.coltgbd.FieldName = "TGBD";
            this.coltgbd.MinWidth = 13;
            this.coltgbd.Name = "coltgbd";
            this.coltgbd.Visible = true;
            this.coltgbd.VisibleIndex = 2;
            this.coltgbd.Width = 50;
            // 
            // coltgkt
            // 
            this.coltgkt.Caption = "Thời gian kết thúc";
            this.coltgkt.FieldName = "TGKT";
            this.coltgkt.MinWidth = 13;
            this.coltgkt.Name = "coltgkt";
            this.coltgkt.Visible = true;
            this.coltgkt.VisibleIndex = 3;
            this.coltgkt.Width = 50;
            // 
            // colsophutsang
            // 
            this.colsophutsang.Caption = "Số phút sáng";
            this.colsophutsang.FieldName = "SoPhutSD7h23h";
            this.colsophutsang.MinWidth = 13;
            this.colsophutsang.Name = "colsophutsang";
            this.colsophutsang.Visible = true;
            this.colsophutsang.VisibleIndex = 4;
            this.colsophutsang.Width = 50;
            // 
            // colsophuttoi
            // 
            this.colsophuttoi.Caption = "Số phút tối";
            this.colsophuttoi.FieldName = "SoPhutSD23h7h";
            this.colsophuttoi.MinWidth = 13;
            this.colsophuttoi.Name = "colsophuttoi";
            this.colsophuttoi.Visible = true;
            this.colsophuttoi.VisibleIndex = 5;
            this.colsophuttoi.Width = 50;
            // 
            // chitietsudung_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "chitietsudung_Form";
            this.Size = new System.Drawing.Size(907, 499);
            this.Load += new System.EventHandler(this.chitietsudung_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcchitietsudung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvchitietsudung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tbxTGKT;
        private System.Windows.Forms.TextBox tbxTGBD;
        private System.Windows.Forms.TextBox tbxIDSIM;
        private System.Windows.Forms.TextBox tbxPhiCuocGoi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxSoPhutSD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxMaCTSD;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_nhapfilelog;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcchitietsudung;
        private DevExpress.XtraGrid.Views.Grid.GridView gvchitietsudung;
        private DevExpress.XtraGrid.Columns.GridColumn colMachitiet;
        private DevExpress.XtraGrid.Columns.GridColumn colmasim;
        private DevExpress.XtraGrid.Columns.GridColumn coltgbd;
        private DevExpress.XtraGrid.Columns.GridColumn coltgkt;
        private DevExpress.XtraGrid.Columns.GridColumn colsophutsang;
        private DevExpress.XtraGrid.Columns.GridColumn colsophuttoi;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
