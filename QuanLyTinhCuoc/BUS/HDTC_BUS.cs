namespace QuanLyTinhCuoc.BUS
{
    using System.Collections.Generic;
    using QuanLyTinhCuoc.DAO;
    using QuanLyTinhCuoc.DTO;

    public class HDTC_BUS
    {
        HDTC_DAO hdtcDAO;
        public HDTC_BUS()
        {
            hdtcDAO = new HDTC_DAO();
        }

        public List<HoaDonTinhCuoc> LoadHDTC()
        {
            return hdtcDAO.LoadDanhSach();
        }

        public List<HoaDonTinhCuoc> LoadHDTC(string idsim)
        {
            return hdtcDAO.LoadDanhSach(idsim);
        }

        public bool ThanhToan(int mahdtc)
        {
            return hdtcDAO.CapNhatThanhToan(mahdtc);
        }
    }
}
