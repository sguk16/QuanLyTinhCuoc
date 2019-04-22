namespace QuanLyTinhCuoc.DAO
{
    using System.Collections.Generic;
    using System.Linq;
    using QuanLyTinhCuoc.DTO;
    public class KhachHangDAO
    {
        QLTinhCuocDT2Entities db;

        public KhachHangDAO()
        {
            db = new QLTinhCuocDT2Entities();
        }

        public List<KhachHang> LoadDanhSach()
        {
            var lst1 = from kh in db.KhachHangs select kh;
            return lst1.ToList();
        }

        public KhachHang TimKhachHang(string makh)
        {
            return db.KhachHangs.Find(makh);
        }

        public bool ThemKhachHang(KhachHang khachhang)
        {
            try
            {
                KhachHang kh = new KhachHang();
                kh.MaKH = khachhang.MaKH;
                kh.ChucVu = khachhang.ChucVu;
                kh.CMND = khachhang.CMND;
                kh.DiaChi = khachhang.DiaChi;
                kh.Email = khachhang.Email;
                kh.NgheNghiep = khachhang.NgheNghiep;
                kh.TenKH = khachhang.TenKH;
                kh.NgayDangKy = khachhang.NgayDangKy;
                db.KhachHangs.Add(kh);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaKhachHang(KhachHang khachhang)
        {
            try
            {
                var kh = db.KhachHangs.FirstOrDefault(k => k.MaKH == khachhang.MaKH);
                if (kh == null) return false;
                kh.ChucVu = khachhang.ChucVu;
                kh.CMND = khachhang.CMND;
                kh.DiaChi = khachhang.DiaChi;
                kh.Email = khachhang.Email;
                kh.NgheNghiep = khachhang.NgheNghiep;
                kh.TenKH = khachhang.TenKH;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaKhachHang(KhachHang khachhang)
        {
            try
            {
                var kh = db.KhachHangs.FirstOrDefault(k => k.MaKH == khachhang.MaKH);
                var ct = db.ThongTinSIMs.Where(c => c.MaKH == khachhang.MaKH);
                if (kh == null) return false;
                if (ct != null)
                {
                    foreach (var item in ct)
                    {
                        item.KhachHang = kh;
                    }
                }
                db.KhachHangs.Remove(kh);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaKhachHang(string makh)
        {
            KhachHang khachhang = TimKhachHang(makh);
            return XoaKhachHang(khachhang);
        }

        public string XuLyMa()
        {
            var lst = from kh in db.KhachHangs orderby kh.MaKH ascending select kh.MaKH;
            string makh = lst.ToList().LastOrDefault();
            if (makh.Equals("")) return "Không có mã";
            return makh;
        }
    }
}
