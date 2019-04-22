namespace QuanLyTinhCuoc.View.HoaDonDangKy
{
    using System;
    using System.Windows.Forms;
    using QuanLyTinhCuoc.BUS;

    public partial class ThemHoaDon : DevExpress.XtraEditors.XtraForm
    {
        HDDK_BUS hoadonBUS = new HDDK_BUS();

        public ThemHoaDon()
        {
            InitializeComponent();
        }

        private void ThemHoaDon_Load(object sender, EventArgs e)
        {
            XuLyView();
        }

        private void XuLyView()
        {
            txt_mahd.Text = hoadonBUS.XuLyMa();
            txt_chiphi.Text = "50000";
            cbbIDSIM.Properties.Items.AddRange(hoadonBUS.LoadIDSIM());
            dtpNgayDangKy.Text = DateTime.Now.ToString();
        }

        private void btn_themhoadon_Click(object sender, EventArgs e)
        {
            if (cbbIDSIM.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng chọn mã SIM", "Thông báo");
            }
            else if (!cbbIDSIM.Properties.Items.Contains(cbbIDSIM.Text))
            {
                MessageBox.Show("Mã SIM không đúng!", "Thông báo");
            }
            else
            {
                DTO.HoaDonDangKy hoadon = new DTO.HoaDonDangKy();
                hoadon.MaHDDK = txt_mahd.Text;
                hoadon.ChiPhiDangKy = Convert.ToDecimal(txt_chiphi.Text);
                hoadon.IDSIM = cbbIDSIM.Text;
                hoadon.NgayDangKy = Convert.ToDateTime(dtpNgayDangKy.Text);
                hoadon.Flag = true;
                if (hoadonBUS.ThemHoaDonDangKy(hoadon))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Thông báo");
                }
            }
        }

        private void btn_thoathoadon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}