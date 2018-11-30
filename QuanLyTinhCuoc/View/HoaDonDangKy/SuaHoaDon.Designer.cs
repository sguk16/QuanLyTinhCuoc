namespace QuanLyTinhCuoc.View.HoaDonDangKy
{
    partial class SuaHoaDon
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
            this.label6 = new System.Windows.Forms.Label();
            this.btn_thoatkh = new DevExpress.XtraEditors.SimpleButton();
            this.btn_suahoadon = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayDangKy.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayDangKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbIDSIM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_chiphi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgayDangKy
            // 
            this.dtpNgayDangKy.EditValue = null;
            this.dtpNgayDangKy.Location = new System.Drawing.Point(221, 251);
            this.dtpNgayDangKy.Name = "dtpNgayDangKy";
            this.dtpNgayDangKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayDangKy.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayDangKy.Size = new System.Drawing.Size(216, 20);
            this.dtpNgayDangKy.TabIndex = 66;
            // 
            // cbbIDSIM
            // 
            this.cbbIDSIM.Location = new System.Drawing.Point(221, 138);
            this.cbbIDSIM.Name = "cbbIDSIM";
            this.cbbIDSIM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbIDSIM.Size = new System.Drawing.Size(216, 20);
            this.cbbIDSIM.TabIndex = 65;
            // 
            // txt_chiphi
            // 
            this.txt_chiphi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_chiphi.Location = new System.Drawing.Point(221, 195);
            this.txt_chiphi.Name = "txt_chiphi";
            this.txt_chiphi.Size = new System.Drawing.Size(216, 20);
            this.txt_chiphi.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(90, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 64;
            this.label6.Text = "ID SIM:";
            // 
            // btn_thoatkh
            // 
            this.btn_thoatkh.Location = new System.Drawing.Point(322, 329);
            this.btn_thoatkh.Name = "btn_thoatkh";
            this.btn_thoatkh.Size = new System.Drawing.Size(115, 32);
            this.btn_thoatkh.TabIndex = 62;
            this.btn_thoatkh.Text = "Thoát";
            this.btn_thoatkh.Click += new System.EventHandler(this.btn_thoathoadon_Click);
            // 
            // btn_suahoadon
            // 
            this.btn_suahoadon.Location = new System.Drawing.Point(74, 329);
            this.btn_suahoadon.Name = "btn_suahoadon";
            this.btn_suahoadon.Size = new System.Drawing.Size(115, 32);
            this.btn_suahoadon.TabIndex = 61;
            this.btn_suahoadon.Text = "Sửa";
            this.btn_suahoadon.Click += new System.EventHandler(this.btn_suahoadon_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(90, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 60;
            this.label5.Text = "Ngày đăng ký:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(90, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 59;
            this.label3.Text = "Chi phí:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(188, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "SỬA HÓA ĐƠN";
            // 
            // SuaHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 429);
            this.Controls.Add(this.dtpNgayDangKy);
            this.Controls.Add(this.cbbIDSIM);
            this.Controls.Add(this.txt_chiphi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_thoatkh);
            this.Controls.Add(this.btn_suahoadon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "SuaHoaDon";
            this.Text = "SuaHoaDon";
            this.Load += new System.EventHandler(this.SuaHoaDon_Load);
            this.Click += new System.EventHandler(this.SuaHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayDangKy.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayDangKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbIDSIM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_chiphi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.DateEdit dtpNgayDangKy;
        public DevExpress.XtraEditors.ComboBoxEdit cbbIDSIM;
        public DevExpress.XtraEditors.TextEdit txt_chiphi;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btn_thoatkh;
        private DevExpress.XtraEditors.SimpleButton btn_suahoadon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}