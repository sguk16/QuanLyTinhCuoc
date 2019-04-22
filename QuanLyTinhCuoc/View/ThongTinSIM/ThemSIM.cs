namespace QuanLyTinhCuoc.View.ThongTinSIM
{
    using System;
    using System.Windows.Forms;
    using QuanLyTinhCuoc.BUS;

    public partial class ThemSIM : DevExpress.XtraEditors.XtraForm
    {
        ThongTinSIMBUS thongtinBUS = new ThongTinSIMBUS();
        DTO.KhachHang khachhang;


        public ThemSIM()
        {
            InitializeComponent();
            khachhang = new DTO.KhachHang();
        }

        private void ThemSim_Load(object sender, EventArgs e)
        {
            txt_idsim.Text = thongtinBUS.XuLyIDSIM();
            cbbMaKH.Properties.Items.AddRange(thongtinBUS.LoadMaKH());
            XuLyDate();
        }

        private void btn_thoatsim_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XuLyDate()
        {
            dtpNgayDangKy.Text = DateTime.Now.ToString();
            dtpNgayHetHan.Text = DateTime.Now.AddYears(+1).ToString();
        }

        private void btn_themsim_Click(object sender, EventArgs e)
        {
            if (txt_sdt.Text.Trim().Equals(""))
            {
                MessageBox.Show("Xin hãy điền thông tin đầy đủ!", "Thông báo");
            }
            else if (txt_sdt.Text.Trim().Length != 10 || !int.TryParse(txt_sdt.Text.Trim(), out int check))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo");
            }
            else if (!cbbMaKH.Properties.Items.Contains(cbbMaKH.Text))
            {
                MessageBox.Show("Mã Khách Hàng không đúng!", "Thông báo");
            }
            else
            {
                DTO.ThongTinSIM thongtinSIM = new DTO.ThongTinSIM();

                thongtinSIM.IDSIM = txt_idsim.Text;
                thongtinSIM.MaKH = cbbMaKH.Text;
                thongtinSIM.SoDienThoai = txt_sdt.Text;
                thongtinSIM.NgayDangKy = Convert.ToDateTime(dtpNgayDangKy.Text);
                thongtinSIM.NgayHetHan = Convert.ToDateTime(dtpNgayHetHan.Text);
                thongtinSIM.Flag = true;
                if (thongtinBUS.ThemThongTinSim(thongtinSIM))
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

        private void btn_themkh_Click(object sender, EventArgs e)
        {
            KhachHang.ThemKhachHang form = new KhachHang.ThemKhachHang();
            //khi đóng form themkhachhang sẽ chạy method main_formclosing
            //form.formclosing += new formclosingeventhandler(this.main_formclosing);
            form.FormClosing += new FormClosingEventHandler(this.ThemSim_FormClosing);
            form.Show();
        }

        private void ThemSim_FormClosing(object sender, FormClosingEventArgs e)
        {
            cbbMaKH.Properties.Items.Clear();
            cbbMaKH.Properties.Items.AddRange(thongtinBUS.LoadMaKH());
        }
    }
}