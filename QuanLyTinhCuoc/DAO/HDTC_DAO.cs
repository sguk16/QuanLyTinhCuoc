namespace QuanLyTinhCuoc.DAO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using QuanLyTinhCuoc.DTO;

    public class HDTC_DAO
    {
        QLTinhCuocDT2Entities db;
        public HDTC_DAO()
        {
            db = new QLTinhCuocDT2Entities();
        }
        public List<HoaDonTinhCuoc> LoadDanhSach()
        {
            return db.HoaDonTinhCuocs.ToList();
        }
        public List<HoaDonTinhCuoc> LoadDanhSach(string idsim)
        {
            return db.HoaDonTinhCuocs.Where(hd => hd.IDSIM == idsim).ToList();
        }

        public bool CapNhatThanhToan(int mahd)
        {
            try
            {
                HoaDonTinhCuoc hd = db.HoaDonTinhCuocs.Find(mahd);
                hd.ThanhToan = true;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
            
        }
    }
}
