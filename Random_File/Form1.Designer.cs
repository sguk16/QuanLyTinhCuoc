namespace Random_File
{
    partial class Form1
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.gvfilelog = new System.Windows.Forms.DataGridView();
            this.idsim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgbd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgkt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btntaodulieu = new DevExpress.XtraEditors.SimpleButton();
            this.btnxuatfile = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaxrows = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvfilelog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxrows.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Firebrick;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(11, 10);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(319, 36);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "TRÌNH TẠO FILE LOG";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1025, 80);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1025, 80);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.labelControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1007, 40);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 40);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1007, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // gvfilelog
            // 
            this.gvfilelog.AllowUserToAddRows = false;
            this.gvfilelog.AllowUserToDeleteRows = false;
            this.gvfilelog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvfilelog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsim,
            this.tgbd,
            this.tgkt});
            this.gvfilelog.Location = new System.Drawing.Point(34, 158);
            this.gvfilelog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvfilelog.Name = "gvfilelog";
            this.gvfilelog.ReadOnly = true;
            this.gvfilelog.RowTemplate.Height = 28;
            this.gvfilelog.Size = new System.Drawing.Size(962, 350);
            this.gvfilelog.TabIndex = 2;
            // 
            // idsim
            // 
            this.idsim.HeaderText = "IDSIM";
            this.idsim.Name = "idsim";
            this.idsim.ReadOnly = true;
            this.idsim.Width = 150;
            // 
            // tgbd
            // 
            this.tgbd.HeaderText = "Thời gian bắt đầu";
            this.tgbd.MinimumWidth = 100;
            this.tgbd.Name = "tgbd";
            this.tgbd.ReadOnly = true;
            this.tgbd.Width = 260;
            // 
            // tgkt
            // 
            this.tgkt.HeaderText = "Thời gian kết thúc";
            this.tgkt.MinimumWidth = 100;
            this.tgkt.Name = "tgkt";
            this.tgkt.ReadOnly = true;
            this.tgkt.Width = 260;
            // 
            // btntaodulieu
            // 
            this.btntaodulieu.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntaodulieu.Appearance.Options.UseFont = true;
            this.btntaodulieu.Location = new System.Drawing.Point(550, 95);
            this.btntaodulieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntaodulieu.Name = "btntaodulieu";
            this.btntaodulieu.Size = new System.Drawing.Size(158, 30);
            this.btntaodulieu.TabIndex = 5;
            this.btntaodulieu.Text = "Tạo dữ liệu";
            this.btntaodulieu.Click += new System.EventHandler(this.btntaodulieu_Click);
            // 
            // btnxuatfile
            // 
            this.btnxuatfile.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxuatfile.Appearance.Options.UseFont = true;
            this.btnxuatfile.Location = new System.Drawing.Point(794, 95);
            this.btnxuatfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxuatfile.Name = "btnxuatfile";
            this.btnxuatfile.Size = new System.Drawing.Size(191, 30);
            this.btnxuatfile.TabIndex = 6;
            this.btnxuatfile.Text = "Xuất file log";
            this.btnxuatfile.Click += new System.EventHandler(this.btnxuatfile_Click);
            // 
            // txtMaxrows
            // 
            this.txtMaxrows.Location = new System.Drawing.Point(122, 92);
            this.txtMaxrows.Name = "txtMaxrows";
            this.txtMaxrows.Size = new System.Drawing.Size(125, 22);
            this.txtMaxrows.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(34, 95);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 17);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Số lượng log:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 517);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtMaxrows);
            this.Controls.Add(this.btnxuatfile);
            this.Controls.Add(this.btntaodulieu);
            this.Controls.Add(this.gvfilelog);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvfilelog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxrows.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.DataGridView gvfilelog;
        private DevExpress.XtraEditors.SimpleButton btntaodulieu;
        private DevExpress.XtraEditors.SimpleButton btnxuatfile;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsim;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgbd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgkt;
        private DevExpress.XtraEditors.TextEdit txtMaxrows;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}

