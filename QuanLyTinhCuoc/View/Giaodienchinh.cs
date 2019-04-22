using DevExpress.XtraBars;
using QuanLyTinhCuoc.View.ChiTietSuDung;
using QuanLyTinhCuoc.View.HoaDonDangKy;
using QuanLyTinhCuoc.View.KhachHangView;
using QuanLyTinhCuoc.View.ThongTinSIM;
using QuanLyTinhCuoc.View.HoaDonTinhCuoc;

namespace QuanLyTinhCuoc.View
{
    public partial class Giaodienchinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Giaodienchinh()
        {
            InitializeComponent();
            barButtonItem1.PerformClick();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            khachhang_Form form = new khachhang_Form();
            form.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Controls.Add(form);
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            hoadondangky_Form form = new hoadondangky_Form();
            form.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Controls.Add(form);
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            thongtinsim_Form form = new thongtinsim_Form();
            form.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Controls.Add(form);
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            chitietsudung_Form form = new chitietsudung_Form();
            form.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Controls.Add(form);
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            hoadontinhcuoc_Form form = new hoadontinhcuoc_Form();
            form.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Controls.Add(form);
        }
    }
}