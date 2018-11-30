using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyTinhCuoc.BUS;

namespace QuanLyTinhCuoc.View.KhachHang
{
    public partial class ThemKhachHang : DevExpress.XtraEditors.XtraForm
    {
        KhachHangBUS khachhangBUS = new KhachHangBUS();
        public ThemKhachHang()
        {
            InitializeComponent();
        }

        private void btn_themkhachhang_Click(object sender, EventArgs e)
        {
            if (txt_chucvu.Text.Trim().Equals("") || txt_cmndkh.Text.Trim().Equals("") || txt_diachi.Text.Trim().Equals("") || txt_hotenkh.Text.Trim().Equals("") || txt_nghenghiep.Text.Trim().Equals("") || txt_email.Text.Trim().Equals(""))
            {
                MessageBox.Show("Xin hãy điền thông tin đầy đủ!", "Thông báo");
            }
            else if (txt_cmndkh.Text.Trim().Length != 9 || !int.TryParse(txt_cmndkh.Text.Trim(), out int check))
            {
                MessageBox.Show("Chứng minh nhân dân không hợp lệ!(Là số và phải đúng 9 ký tự)", "Thông báo!");
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