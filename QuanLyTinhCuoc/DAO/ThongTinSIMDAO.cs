using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyTinhCuoc.DTO;

namespace QuanLyTinhCuoc.DAO
{
    public class ThongTinSIMDAO
    {
        QLTinhCuocDT2Entities db;
        public ThongTinSIMDAO()
        {
            db = new QLTinhCuocDT2Entities();
        }

        public List<ThongTinSIM> LoadThongTinSim()
        {
            return db.ThongTinSIMs.ToList();
        }

        public bool ThemThongTinSim(ThongTinSIM thongtin)
        {
            try
            {
                ThongTinSIM sim = new ThongTinSIM();
                sim.IDSIM = thongtin.IDSIM;
                sim.SoDienThoai = thongtin.SoDienThoai;
                sim.NgayDangKy = thongtin.NgayDangKy;
                sim.NgayHetHan = thongtin.NgayHetHan;
                sim.MaKH = thongtin.MaKH;
                db.ThongTinSIMs.Add(sim);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaThongTinSim(ThongTinSIM thongtin)
        {
            try
            {
                var sim = db.ThongTinSIMs.FirstOrDefault(s => s.IDSIM == thongtin.IDSIM);
                if (sim == null) return false;
                sim.MaKH = thongtin.MaKH;
                sim.NgayDangKy = thongtin.NgayDangKy;
                sim.NgayHetHan = thongtin.NgayHetHan;
                sim.SoDienThoai = thongtin.SoDienThoai;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaThongTinSim(ThongTinSIM thongtin)
        {
            try
            {
                var sim = db.ThongTinSIMs.FirstOrDefault(s => s.IDSIM == thongtin.IDSIM);
                var hdtc = db.HoaDonTinhCuocs.Where(tc => tc.IDSIM == thongtin.IDSIM);
                var hddk = db.HoaDonDangKies.Where(dk => dk.IDSIM == thongtin.IDSIM);
                var ctsd = db.ChiTietSuDungs.Where(ct => ct.IDSIM == thongtin.IDSIM);
                if (sim == null) return false;
                if (hdtc != null)
                {
                    db.HoaDonTinhCuocs.RemoveRange(hdtc);
                }
                if (hddk != null)
                {
                    db.HoaDonDangKies.RemoveRange(hddk);
                }
                if (ctsd != null)
                {
                    db.ChiTietSuDungs.RemoveRange(ctsd);
                }
                db.ThongTinSIMs.Remove(sim);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string XuLyMa()
        {
            var lst = from s in db.ThongTinSIMs orderby s.IDSIM ascending select s.IDSIM;
            string idsim = lst.ToList().LastOrDefault();
            if (idsim.Equals("")) return "Không có mã";
            return idsim;
        }

        public List<String> LoadMaKH()
        {
            var lst = from kh in db.KhachHangs orderby kh.MaKH ascending select kh.MaKH;
            return lst.ToList();
        }
    }
}
