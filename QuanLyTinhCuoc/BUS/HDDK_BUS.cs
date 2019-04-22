namespace QuanLyTinhCuoc.BUS
{
    using System;
    using System.Collections.Generic;
    using QuanLyTinhCuoc.DAO;
    using QuanLyTinhCuoc.DTO;

    public class HDDK_BUS
    {
        HDDK_DAO hoadonDAO = new HDDK_DAO();

        public List<HoaDonDangKy> LoadHoaDonDangKy()
        {
            return hoadonDAO.LoadHDDK();
        }

        public List<HoaDonDangKy> LoadHoaDonDangKy(string masim)
        {
            return hoadonDAO.LoadHDDK(masim);
        }

        public bool ThemHoaDonDangKy(HoaDonDangKy hoadon)
        {
            return hoadonDAO.ThemHoaDon(hoadon);
        }

        public bool SuaHoaDonDangKy(HoaDonDangKy hoadon)
        {
            return hoadonDAO.SuaHoaDon(hoadon);
        }

        public bool XoaHoaDonDangKy(HoaDonDangKy hoadon)
        {
            return hoadonDAO.XoaHoaDon(hoadon);
        }

        public string XuLyMa()
        {
            string MaHDDK = "";
            string maGocHD = hoadonDAO.XuLyMa();
            int chuoi2 = 0;
            chuoi2 = Convert.ToInt32((maGocHD.Remove(0, 4)));
            if (chuoi2 + 1 < 10)
            {
                MaHDDK = "HDDK0" + (chuoi2 + 1).ToString();
            }
            else
            {
                MaHDDK = "HDDK" + (chuoi2 + 1).ToString();
            }

            return MaHDDK;
        }

        public List<String> LoadIDSIM()
        {
            return hoadonDAO.LoadIDSIM();
        }
    }
}
