using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyTinhCuoc.BUS;
using QuanLyTinhCuoc.DTO;

namespace QuanLyTinhCuoc
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        KhachHangBUS khachhangBUS = new KhachHangBUS();
        ThongTinSIMBUS thongtinBUS = new ThongTinSIMBUS();
        HDDK_BUS hoadonBUS = new HDDK_BUS();

        public static string maSIM, maHDDK;
        public Main()
        {
            InitializeComponent();
        }


        //Load lại gridview
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoadDataKhachHang();
            LoadDataSim();
            LoadDataHDDK();
        }

        //----------------------------------------------Khách Hàng----------------------------------------------
        private void gcData_Load(object sender, EventArgs e)
        {
            LoadDataKhachHang();
        }

        private void gvKhachHang_MouseUp(object sender, MouseEventArgs e)
        {
            //click phải với các chức năng thêm xóa sửa khách hàng
            if (e.Button != MouseButtons.Right) return;
            var rowh = gvKhachHang.FocusedRowHandle;
            var focusRowView = gvKhachHang.GetFocusedRow();
            if (focusRowView == null) return;
            //Lấy row khi click
            if (rowh >= 0)
            {
                popupKH.ShowPopup(barManager, new Point(MousePosition.X, MousePosition.Y));
            }
            else
            {
                popupKH.HidePopup();
            }
        }

        private void LoadDataKhachHang()
        {
            gcDataKhachHang.DataSource = khachhangBUS.LoadKhachHang();
        }

        private void btn_refreshKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDataKhachHang();
        }

        private void btn_themkh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            View.KhachHang.ThemKhachHang form = new View.KhachHang.ThemKhachHang();
            //khi đóng form ThemKhachHang sẽ chạy method Main_FormClosing
            form.FormClosing += new FormClosingEventHandler(this.Main_FormClosing);
            form.Show();
        }

        private void btn_suakh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Truyền data vào form SuaKhachHang
            View.KhachHang.SuaKhachHang form = new View.KhachHang.SuaKhachHang("");
            form.txt_makh.Text = gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, "MaKH").ToString();
            form.txt_chucvu.Text = gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, "ChucVu").ToString();
            form.txt_cmndkh.Text = gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, "CMND").ToString();
            form.txt_diachi.Text = gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, "DiaChi").ToString();
            form.txt_email.Text = gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, "Email").ToString();
            form.txt_hotenkh.Text = gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, "TenKH").ToString();
            form.txt_nghenghiep.Text = gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, "NgheNghiep").ToString();
            form.FormClosing += new FormClosingEventHandler(this.Main_FormClosing);
            form.Show();
        }

        private void btn_xoakh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KhachHang khachhang = new KhachHang();
            //Xóa hàng click
            khachhang.MaKH = gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, "MaKH").ToString().Trim();
            if (khachhangBUS.XoaKhachHang(khachhang))
            {
                MessageBox.Show("Xóa thành công", "Thông Báo");
                LoadDataKhachHang();
                LoadDataSim();
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông Báo");
            }
        }


        //----------------------------------------------Thông Tin SIM----------------------------------------------


        private void LoadDataSim()
        {
            gcDataTTSim.DataSource = thongtinBUS.LoadThongTinSim();
        }

        private void gcDataTTSim_Load(object sender, EventArgs e)
        {
            LoadDataSim();
        }

        private void gcDataTTSim_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var rowh = gvSim.FocusedRowHandle;
            var focusRowView = gvSim.GetFocusedRow();
            if (focusRowView == null) return;
            if (rowh >= 0)
            {
                popupSIM.ShowPopup(barManager, new Point(MousePosition.X, MousePosition.Y));
            }
            else
            {
                popupSIM.HidePopup();
            }
        }

        private void btn_refreshSIM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDataSim();
        }

        private void btn_themsim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            View.ThongTinSIM.ThemSIM form = new View.ThongTinSIM.ThemSIM();
            //khi đóng form ThemSim sẽ chạy method Main_FormClosing
            form.FormClosing += new FormClosingEventHandler(this.Main_FormClosing);
            form.Show();

        }

        private void btn_suasim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            View.ThongTinSIM.SuaSIM form = new View.ThongTinSIM.SuaSIM();
            maSIM = gvSim.GetRowCellValue(gvSim.FocusedRowHandle, "IDSIM").ToString();
            if (gvSim.GetRowCellValue(gvSim.FocusedRowHandle, "MaKHSIM") == null)
            {
                form.cbbMaKH.Text = "";
            }
            else
            {
                form.cbbMaKH.Text = gvSim.GetRowCellValue(gvSim.FocusedRowHandle, "MaKHSIM").ToString();
            }
            form.txt_sdt.Text = gvSim.GetRowCellValue(gvSim.FocusedRowHandle, "SoDienThoai").ToString();
            form.dtpNgayDangKy.Text = gvSim.GetRowCellValue(gvSim.FocusedRowHandle, "NgayDangKy").ToString();
            form.dtpNgayHetHan.Text = gvSim.GetRowCellValue(gvSim.FocusedRowHandle, "NgayHetHan").ToString();
            form.FormClosing += new FormClosingEventHandler(this.Main_FormClosing);
            form.Show();
        }

        private void btn_xoasim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongTinSIM thongtin = new ThongTinSIM();
            thongtin.IDSIM = gvSim.GetRowCellValue(gvSim.FocusedRowHandle, "IDSIM").ToString().Trim();
            if (thongtinBUS.XoaThongTinSim(thongtin))
            {
                MessageBox.Show("Xóa thành công", "Thông Báo");
                LoadDataSim();
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông Báo");
            }
        }

        //----------------------------------------------Hóa Đơn Đăng Ký----------------------------------------------

        private void gcHddk_Load(object sender, EventArgs e)
        {
            LoadDataHDDK();
        }

        private void LoadDataHDDK()
        {
            gcHddk.DataSource = hoadonBUS.LoadHoaDonDangKy();
        }

        private void gcHddk_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var rowh = gvHoaDon.FocusedRowHandle;
            var focusRowView = gvHoaDon.GetFocusedRow();
            if (focusRowView == null) return;
            if (rowh >= 0)
            {
                popupHDDK.ShowPopup(barManager, new Point(MousePosition.X, MousePosition.Y));
            }
            else
            {
                popupHDDK.HidePopup();
            }
        }
        private void btn_themhddk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            View.HoaDonDangKy.ThemHoaDon form = new View.HoaDonDangKy.ThemHoaDon();
            form.FormClosing += new FormClosingEventHandler(this.Main_FormClosing);
            form.Show();
        }

        private void btn_suahddk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            View.HoaDonDangKy.SuaHoaDon form = new View.HoaDonDangKy.SuaHoaDon();
            maHDDK = gvHoaDon.GetRowCellValue(gvHoaDon.FocusedRowHandle, "MaHDDK").ToString();
            form.txt_chiphi.Text = gvHoaDon.GetRowCellValue(gvHoaDon.FocusedRowHandle, "ChiPhiDangKy").ToString().Remove(gvHoaDon.GetRowCellValue(gvHoaDon.FocusedRowHandle, "ChiPhiDangKy").ToString().Length - 4);
            form.cbbIDSIM.Text = gvHoaDon.GetRowCellValue(gvHoaDon.FocusedRowHandle, "IDSIM").ToString();
            form.dtpNgayDangKy.Text = gvHoaDon.GetRowCellValue(gvHoaDon.FocusedRowHandle, "NgayDangKy").ToString();
            form.FormClosing += new FormClosingEventHandler(this.Main_FormClosing);
            form.Show();
        }

        private void btn_refreshHDDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDataHDDK();
        }

        private void tabKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void btn_xoahddk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HoaDonDangKy hoadon = new HoaDonDangKy();
            hoadon.MaHDDK = gvHoaDon.GetRowCellValue(gvHoaDon.FocusedRowHandle, "MaHDDK").ToString().Trim();
            if (hoadonBUS.XoaHoaDonDangKy(hoadon))
            {
                MessageBox.Show("Xóa thành công", "Thông Báo");
                LoadDataHDDK();
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông Báo");
            }
        }
    }
}
