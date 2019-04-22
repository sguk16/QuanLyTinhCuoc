namespace QuanLyTinhCuoc.View.KhachHang
{
    using System;
    using System.Windows.Forms;
    using QuanLyTinhCuoc.BUS;
    using System.Text.RegularExpressions;

    public partial class ThemKhachHang : DevExpress.XtraEditors.XtraForm
    {
        KhachHangBUS khachhangBUS = new KhachHangBUS();
        const string pcmnd = @"^[0-9]{9}$|^[0-9]{12}$";
        const string pemail = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$";
        public ThemKhachHang()
        {
            InitializeComponent();
        }

        private void btn_themkhachhang_Click(object sender, EventArgs e)
        {
            Regex cmnd = new Regex(pcmnd, RegexOptions.IgnoreCase);
            Regex email = new Regex(pemail, RegexOptions.IgnoreCase);
            if (txt_chucvu.Text.Trim().Equals("") || txt_cmndkh.Text.Trim().Equals("") || txt_diachi.Text.Trim().Equals("") || txt_hotenkh.Text.Trim().Equals("") || txt_nghenghiep.Text.Trim().Equals("") || txt_email.Text.Trim().Equals(""))
            {
                MessageBox.Show("Xin hãy điền thông tin đầy đủ!", "Thông báo");
            }
            else if (!cmnd.Match(txt_cmndkh.Text).Success)
            {
                MessageBox.Show("Chứng minh nhân dân không hợp lệ!(Là số và phải đúng 9 hoặc 12 ký tự)", "Thông báo!");
            }
            else if (!email.Match(txt_email.Text).Success)
            {
                MessageBox.Show("Email không hợp lệ!\nEmail phải có dạng: examble@examble.com");
            }
            else
            {
                DTO.KhachHang khachhang = new DTO.KhachHang();
                khachhang.MaKH = txt_makh.Text;
                khachhang.TenKH = txt_hotenkh.Text;
                khachhang.NgheNghiep = txt_nghenghiep.Text;
                khachhang.Email = txt_email.Text;
                khachhang.ChucVu = txt_chucvu.Text;
                khachhang.CMND = txt_cmndkh.Text;
                khachhang.DiaChi = txt_diachi.Text;
                khachhang.NgayDangKy = Convert.ToDateTime(date_ngaydangkykh.Text);
                khachhang.Flag = true;
                if (khachhangBUS.ThemKhachHang(khachhang))
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

        private void btn_thoatkh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemKhachHang_Load(object sender, EventArgs e)
        {
            txt_makh.Text = khachhangBUS.XuLyMa();
            date_ngaydangkykh.Text = DateTime.Now.ToString();
        }
    }
}