namespace QuanLyTinhCuoc.View.HoaDonDangKy
{
    partial class ThemHoaDon
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
            this.dtpNgayDangKy = new DevExpress.XtraEditors.DateEdit();
            this.cbbIDSIM = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_chiphi = new DevExpress.XtraEditors.TextEdit();
            this.txt_mahd = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_thoatkh = new DevExpress.XtraEditors.SimpleButton();
            this.btn_themkhachhang = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayDangKy.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayDangKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbIDSIM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_chiphi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mahd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgayDangKy
            // 
            this.dtpNgayDangKy.EditValue = null;
            this.dtpNgayDangKy.Enabled = false;
            this.dtpNgayDangKy.Location = new System.Drawing.Point(221, 286);
            this.dtpNgayDangKy.Name = "dtpNgayDangKy";
            this.dtpNgayDangKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayDangKy.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayDangKy.Size = new System.Drawing.Size(216, 20);
            this.dtpNgayDangKy.TabIndex = 58;
            // 
            // cbbIDSIM
            // 
            this.cbbIDSIM.Location = new System.Drawing.Point(221, 173);
            this.cbbIDSIM.Name = "cbbIDSIM";
            this.cbbIDSIM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbIDSIM.Size = new System.Drawing.Size(216, 20);
            this.cbbIDSIM.TabIndex = 57;
            // 
            // txt_chiphi
            // 
            this.txt_chiphi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_chiphi.Enabled = false;
            this.txt_chiphi.Location = new System.Drawing.Point(221, 230);
            this.txt_chiphi.Name = "txt_chiphi";
            this.txt_chiphi.Size = new System.Drawing.Size(216, 20);
            this.txt_chiphi.TabIndex = 55;
            // 
            // txt_mahd
            // 
            this.txt_mahd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_mahd.Enabled = false;
            this.txt_mahd.Location = new System.Drawing.Point(221, 115);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.Size = new System.Drawing.Size(216, 20);
            this.txt_mahd.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(90, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 56;
            this.label6.Text = "ID SIM:";
            // 
            // btn_thoatkh
            // 
            this.btn_thoatkh.Location = new System.Drawing.Point(322, 349);
            this.btn_thoatkh.Name = "btn_thoatkh";
            this.btn_thoatkh.Size = new System.Drawing.Size(115, 32);
            this.btn_thoatkh.TabIndex = 53;
            this.btn_thoatkh.Text = "Thoát";
            this.btn_thoatkh.Click += new System.EventHandler(this.btn_thoathoadon_Click);
            // 
            // btn_themkhachhang
            // 
            this.btn_themkhachhang.Location = new System.Drawing.Point(74, 349);
            this.btn_themkhachhang.Name = "btn_themkhachhang";
            this.btn_themkhachhang.Size = new System.Drawing.Size(115, 32);
            this.btn_themkhachhang.TabIndex = 52;
            this.btn_themkhachhang.Text = "Thêm";
            this.btn_themkhachhang.Click += new System.EventHandler(this.btn_themhoadon_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(90, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Ngày đăng ký:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(90, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 50;
            this.label3.Text = "Chi phí:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(90, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Mã hóa đơn:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(175, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "THÊM HÓA ĐƠN";
            // 
            // ThemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 429);
            this.Controls.Add(this.dtpNgayDangKy);
            this.Controls.Add(this.cbbIDSIM);
            this.Controls.Add(this.txt_chiphi);
            this.Controls.Add(this.txt_mahd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_thoatkh);
            this.Controls.Add(this.btn_themkhachhang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemHoaDon";
            this.Text = "ThemHoaDon";
            this.Load += new System.EventHandler(this.ThemHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayDangKy.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayDangKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbIDSIM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_chiphi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mahd.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dtpNgayDangKy;
        private DevExpress.XtraEditors.ComboBoxEdit cbbIDSIM;
        private DevExpress.XtraEditors.TextEdit txt_chiphi;
        private DevExpress.XtraEditors.TextEdit txt_mahd;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btn_thoatkh;
        private DevExpress.XtraEditors.SimpleButton btn_themkhachhang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}