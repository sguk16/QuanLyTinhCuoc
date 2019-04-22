namespace QuanLyTinhCuoc.View.ThongTinSIM
{
    using System;
    using System.Windows.Forms;
    using QuanLyTinhCuoc.BUS;

    public partial class SuaSIM : DevExpress.XtraEditors.XtraForm
    {
        ThongTinSIMBUS thongtinBUS = new ThongTinSIMBUS();

        public SuaSIM()
        {
            InitializeComponent();
        }

        private void SuaSim_Load(object sender, EventArgs e)
        {
            cbbMaKH.Properties.Items.AddRange(thongtinBUS.LoadMaKH());
            XuLyText();
        }

        private void XuLyText()
        {
            dtpNgayDangKy.Text = DateTime.Now.ToString();
            dtpNgayHetHan.Text = DateTime.Now.AddYears(+1).ToString();
        }

        private void btn_thoatsim_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_suasim_Click(object sender, EventArgs e)
        {
            if (txt_sdt.Text.Trim().Equals("") || cbbMaKH.Text.Trim().Equals(""))
            {
                MessageBox.Show("Xin hãy điền thông tin đầy đủ!", "Thông báo");
            }
            else if (txt_sdt.Text.Trim().Length != 10 || !int.TryParse(txt_sdt.Text.Trim(), out int check))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo");
            }
            else if (!cbbMaKH.Properties.Items.Contains(cbbMaKH.Text.Trim()))
            {
                MessageBox.Show("Mã Khách Hàng không đúng!", "Thông báo");
            }
            else
            {
                DTO.ThongTinSIM thongtin = new DTO.ThongTinSIM();
                thongtin.IDSIM = Main.maSIM;
                thongtin.MaKH = cbbMaKH.Text;
                thongtin.SoDienThoai = txt_sdt.Text;
                thongtin.NgayDangKy = Convert.ToDateTime(dtpNgayDangKy.Text);
                thongtin.NgayHetHan = Convert.ToDateTime(dtpNgayHetHan.Text);
                thongtin.Flag = true;
                if (thongtinBUS.SuaThongTinSim(thongtin))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!", "Thông báo");

                }
            }
        }

        private void btn_themkh_Click(object sender, EventArgs e)
        {
            KhachHang.ThemKhachHang form = new KhachHang.ThemKhachHang();
            //khi đóng form themkhachhang sẽ chạy method main_formclosing
            //form.formclosing += new formclosingeventhandler(this.main_formclosing);
            form.FormClosing += new FormClosingEventHandler(this.SuaSIM_FormClosing);
            form.Show();
        }

        private void SuaSIM_FormClosing(object sender, FormClosingEventArgs e)
        {
            cbbMaKH.Properties.Items.Clear();
            cbbMaKH.Properties.Items.AddRange(thongtinBUS.LoadMaKH());
        }
    }
}