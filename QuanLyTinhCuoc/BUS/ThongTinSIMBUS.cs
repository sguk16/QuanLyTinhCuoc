namespace QuanLyTinhCuoc.BUS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using QuanLyTinhCuoc.DTO;
    using QuanLyTinhCuoc.DAO;

    public class ThongTinSIMBUS
    {
        ThongTinSIMDAO thongtinDAO = new ThongTinSIMDAO();

        public List<ThongTinSIM> LoadThongTinSim()
        {
            return thongtinDAO.LoadThongTinSim();
        }

        public bool ThemThongTinSim(ThongTinSIM thongtin)
        {
            return thongtinDAO.ThemThongTinSim(thongtin);
        }

        public bool SuaThongTinSim(ThongTinSIM thongtin)
        {
            return thongtinDAO.SuaThongTinSim(thongtin);
        }

        public bool XoaThongTinSim(ThongTinSIM thongtin)
        {
            return thongtinDAO.XoaThongTinSim(thongtin);
        }

        public string XuLyIDSIM()
        {
            string idSIM = "";
            string idGocSIM = thongtinDAO.XuLyMa();
            int chuoi2 = 0;
            chuoi2 = Convert.ToInt32((idGocSIM.Remove(0, 3)));
            if (chuoi2 + 1 < 10)
            {
                idSIM = "SIM0" + (chuoi2 + 1).ToString();
            }
            else
            {
                idSIM = "SIM" + (chuoi2 + 1).ToString();
            }

            return idSIM;
        }

        public List<String> LoadMaKH()
        {
            return thongtinDAO.LoadMaKH();
        }
        public List<ThongTinSIM> loadtheokh(string makh)
        {
            var danhsach = thongtinDAO.loadtheokh(makh);
            return danhsach.ToList();
        }
    }
}
