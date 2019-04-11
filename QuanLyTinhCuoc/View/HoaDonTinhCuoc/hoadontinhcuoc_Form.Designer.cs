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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gchoadontinhcuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvhoadontinhcuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gchoadontinhcuoc);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(901, 493);
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
            this.gchoadontinhcuoc.Size = new System.Drawing.Size(895, 473);
            this.gchoadontinhcuoc.TabIndex = 0;
            this.gchoadontinhcuoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvhoadontinhcuoc});
            this.gchoadontinhcuoc.Load += new System.EventHandler(this.gchoadontinhcuoc_Load);
            this.gchoadontinhcuoc.Click += new System.EventHandler(this.gchoadontinhcuoc_Click);
            // 
            // gvhoadontinhcuoc
            // 
            this.gvhoadontinhcuoc.GridControl = this.gchoadontinhcuoc;
            this.gvhoadontinhcuoc.Name = "gvhoadontinhcuoc";
            this.gvhoadontinhcuoc.OptionsFind.AlwaysVisible = true;
            this.gvhoadontinhcuoc.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvhoadontinhcuoc_CellValueChanged);
            // 
            // hoadontinhcuoc_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "hoadontinhcuoc_Form";
            this.Size = new System.Drawing.Size(907, 499);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gchoadontinhcuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvhoadontinhcuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gchoadontinhcuoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gvhoadontinhcuoc;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
