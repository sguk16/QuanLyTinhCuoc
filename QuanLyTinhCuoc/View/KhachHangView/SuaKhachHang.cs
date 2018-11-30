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
    public partial class SuaKhachHang : DevExpress.XtraEditors.XtraForm
    {
        KhachHangBUS khachhangBUS = new KhachHangBUS();

        public SuaKhachHang()
        {
            InitializeComponent();
        }

        private void btn_suakhachhang_Click(object sender, EventArgs e)
        {
            if (txt_chucvu.Text.Trim().Equals("") || txt_cmndkh.Text.Trim().Equals("") || txt_diachi.Text.Trim().Equals("") || txt_hotenkh.Text.Trim().Equals("") || txt_nghenghiep.Text.Trim().Equals("") || txt_email.Text.Trim().Equals(""))
            {
                MessageBox.Show("Xin hãy điền thông tin đầy đủ!", "Thông báo");
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