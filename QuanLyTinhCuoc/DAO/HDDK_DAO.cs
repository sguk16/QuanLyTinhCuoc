namespace QuanLyTinhCuoc.DAO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using QuanLyTinhCuoc.DTO;

    public class HDDK_DAO
    {
        QLTinhCuocDT2Entities db;

        public HDDK_DAO()
        {
            db = new QLTinhCuocDT2Entities();
        }

        public List<HoaDonDangKy> LoadHDDK()
        {
            return db.HoaDonDangKies.ToList();
        }

        public List<HoaDonDangKy> LoadHDDK(string masim)
        {
            return db.HoaDonDangKies.Where(hd => hd.IDSIM == masim).ToList();
        }

        public bool ThemHoaDon(HoaDonDangKy hoadon)
        {
            try
            {
                HoaDonDangKy hd = new HoaDonDangKy();
                ThongTinSIM sim = db.ThongTinSIMs.Find(hoadon.IDSIM);
                hd.MaHDDK = hoadon.MaHDDK;
                hd.IDSIM = hoadon.IDSIM;
                hd.NgayDangKy = hoadon.NgayDangKy;
                hd.ChiPhiDangKy = hoadon.ChiPhiDangKy;
                sim.Flag = true;
                db.HoaDonDangKies.Add(hd);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaHoaDon(HoaDonDangKy hoadon)
        {
            try
            {
                var hd = db.HoaDonDangKies.FirstOrDefault(h => h.MaHDDK == hoadon.MaHDDK);
                if (hd == null) return false;
                hd.IDSIM = hoadon.IDSIM;
                hd.NgayDangKy = hoadon.NgayDangKy;
                hd.ChiPhiDangKy = hoadon.ChiPhiDangKy;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaHoaDon(HoaDonDangKy hoadon)
        {
            try
            {
                var hd = db.HoaDonDangKies.FirstOrDefault(h => h.MaHDDK == hoadon.MaHDDK);
                if (hd == null) return false;
                db.HoaDonDangKies.Remove(hd);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<String> LoadIDSIM()
        {
            var lst = from sim in db.ThongTinSIMs orderby sim.IDSIM ascending select sim.IDSIM;
            return lst.ToList();
        }

        public string XuLyMa()
        {
            var lst = from hd in db.HoaDonDangKies orderby hd.MaHDDK ascending select hd.MaHDDK;
            string madh = lst.ToList().LastOrDefault();
            if (madh.Equals("")) return "Không có mã";
            return madh;
        }
    }
}
