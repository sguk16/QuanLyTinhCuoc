namespace QuanLyTinhCuoc.View.KhachHang
{
    using System;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using QuanLyTinhCuoc.BUS;

    public partial class SuaKhachHang : DevExpress.XtraEditors.XtraForm
    {
        KhachHangBUS khachhangBUS = new KhachHangBUS();
        const string pcmnd = @"^[0-9]{9}$|^[0-9]{12}$";
        const string pemail = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$";
        public SuaKhachHang(string makh)
        {
            InitializeComponent();
            var kh = khachhangBUS.LoadKhachHang(makh);
            txt_makh.Text = makh;
            txt_hotenkh.Text = kh.TenKH;
            txt_cmndkh.Text = kh.CMND;
            txt_nghenghiep.Text = kh.NgheNghiep;
            txt_chucvu.Text = kh.ChucVu;
            txt_diachi.Text = kh.DiaChi;
            txt_email.Text = kh.Email;
        }

        private void btn_suakhachhang_Click(object sender, EventArgs e)
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
                khachhang.ChucVu = txt_chucvu.Text;
                khachhang.CMND = txt_cmndkh.Text;
                khachhang.DiaChi = txt_diachi.Text;
                khachhang.Email = txt_email.Text;
                khachhang.Flag = true;
                if (khachhangBUS.SuaKhachHang(khachhang))
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

        private void btn_thoatkh_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}