namespace QuanLyTinhCuoc.View.HoaDonDangKy
{
    using System;
    using System.Windows.Forms;
    using QuanLyTinhCuoc.BUS;

    public partial class SuaHoaDon : DevExpress.XtraEditors.XtraForm
    {
        HDDK_BUS hoadonBUS = new HDDK_BUS();

        public SuaHoaDon()
        {
            InitializeComponent();
        }

        private void btn_suahoadon_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_chiphi.Text.Trim(), out int check))
            {
                MessageBox.Show("Số tiền không hợp lệ!", "Thông báo");
            }
            if (cbbIDSIM.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng chọn mã sim", "Thông báo");
            }
            else if (cbbIDSIM.Properties.Items.Contains(cbbIDSIM.Text))
            {
                MessageBox.Show("Mã SIM không đúng!", "Thông báo");
            }
            else
            {
                DTO.HoaDonDangKy hoadon = new DTO.HoaDonDangKy();
                hoadon.MaHDDK = Main.maHDDK;
                hoadon.IDSIM = cbbIDSIM.Text;
                hoadon.ChiPhiDangKy = Convert.ToDecimal(txt_chiphi.Text);
                hoadon.NgayDangKy = Convert.ToDateTime(dtpNgayDangKy.Text);
                hoadon.Flag = true;
                if (hoadonBUS.SuaHoaDonDangKy(hoadon))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!" + Main.maSIM + 0, "Thông báo");

                }
            }
        }

        private void btn_thoathoadon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SuaHoaDon_Load(object sender, EventArgs e)
        {
            cbbIDSIM.Properties.Items.AddRange(hoadonBUS.LoadIDSIM());
        }
    }
}