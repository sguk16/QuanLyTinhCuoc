namespace QuanLyTinhCuoc.BUS
{
    using System;
    using System.Collections.Generic;
    using QuanLyTinhCuoc.DAO;
    using QuanLyTinhCuoc.DTO;

    public class KhachHangBUS
    {
        KhachHangDAO khachhangDAO;
        public KhachHangBUS()
        {
            khachhangDAO = new KhachHangDAO();
        }
        public List<KhachHang> LoadKhachHang()
        {
            return khachhangDAO.LoadDanhSach();
        }
        
        public KhachHang LoadKhachHang(string makh)
        {
            return khachhangDAO.TimKhachHang(makh);
        }

        public bool ThemKhachHang(KhachHang kh)
        {
            return khachhangDAO.ThemKhachHang(kh);
        }

        public bool SuaKhachHang(KhachHang kh)
        {
            return khachhangDAO.SuaKhachHang(kh);
        }

        public bool XoaKhachHang(KhachHang khachhang)
        {
            return khachhangDAO.XoaKhachHang(khachhang);
        }

        public bool XoaKhachHang(string makh)
        {
            return khachhangDAO.XoaKhachHang(makh);
        }

        public string XuLyMa()
        {
            string maKH = "";
            string maGocKH = khachhangDAO.XuLyMa();
            int chuoi2 = 0;
            chuoi2 = Convert.ToInt32((maGocKH.Remove(0, 5)));
            if (chuoi2 + 1 < 10)
            {
                maKH = "KHACH00" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 100)
            {
                maKH = "KHACH0" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 < 1000)
            {
                maKH = "KHACH" + (chuoi2 + 1).ToString();
            }
            return maKH;
        }
    }
}
