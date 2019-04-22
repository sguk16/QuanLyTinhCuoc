namespace QuanLyTinhCuoc.View.KhachHangView
{
    using System;
    using QuanLyTinhCuoc.BUS;
    using QuanLyTinhCuoc.View.KhachHang;
    using System.Windows.Forms;

    public partial class khachhang_Form : DevExpress.XtraEditors.XtraUserControl
    {
        KhachHangBUS KhachHang;
        public khachhang_Form()
        {
            InitializeComponent();
        }
        public void Load_KHACHHANG()
        {
            KhachHang = new KhachHangBUS();
            gcKhachHang.DataSource = KhachHang.LoadKhachHang();
        }

        private void khachhang_Form_Load(object sender, EventArgs e)
        {
            Load_KHACHHANG();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ThemKhachHang khachHang = new ThemKhachHang();
            khachHang.ShowDialog();
            Load_KHACHHANG();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string makh = gvKhachhang.GetRowCellValue(gvKhachhang.FocusedRowHandle, colMakhachhanh).ToString();
            SuaKhachHang khachHang = new SuaKhachHang(makh);
            khachHang.ShowDialog();
            Load_KHACHHANG();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            string makh = gvKhachhang.GetRowCellValue(gvKhachhang.FocusedRowHandle, colMakhachhanh).ToString();
            KhachHang.XoaKhachHang(makh);
        }
    }
}
