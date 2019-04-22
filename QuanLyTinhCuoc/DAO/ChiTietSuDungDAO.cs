namespace QuanLyTinhCuoc.DAO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using QuanLyTinhCuoc.DTO;

    public class ChiTietSuDungDAO
    {
        QLTinhCuocDT2Entities db;
        public ChiTietSuDungDAO()
        {
            db = new QLTinhCuocDT2Entities();
        }
        public List<ChiTietSuDung> LoadDanhSach()
        {
            var lst1 = from kh in db.ChiTietSuDungs select kh;
            return lst1.ToList();
        }
        public bool ImportFile(string[] data)
        {
            try
            {
                foreach (string line in data)
                {
                    int id = db.ChiTietSuDungs.Max(item => item.ID);
                    decimal sophutSD7h23h = 0;
                    decimal sophutSD23h7h = 0;
                    string[] split = line.Split('\t');
                    DateTime dateBD = DateTime.ParseExact(split[1], "yyyy-MM-dd HH:mm:ss",
                            System.Globalization.CultureInfo.InvariantCulture);
                    DateTime dateKT = DateTime.ParseExact(split[2], "yyyy-MM-dd HH:mm:ss",
                            System.Globalization.CultureInfo.InvariantCulture);
                    DateTime tmp23 = dateBD.Date.AddHours(23);
                    DateTime tmp7 = dateBD.Date.AddHours(7);
                    if ((dateBD.Hour < 23 && dateBD.Hour >=7) && (dateKT.Hour >= 23 || dateKT.Hour < 7))
                    {
                        sophutSD23h7h = Math.Round((decimal)(dateKT - tmp23).TotalMinutes);
                        sophutSD7h23h = Math.Round((decimal)(tmp23 - dateBD).TotalMinutes);
                    }
                    else
                        if(dateBD.Hour < 7 && (dateKT.Hour >= 7 && dateKT.Hour < 23))
                        {
                            sophutSD7h23h = Math.Round((decimal)(dateKT - tmp7).TotalMinutes);
                            sophutSD23h7h = Math.Round((decimal)(tmp7 - dateBD).TotalMinutes);
                        }
                        else
                            if( dateBD.Hour >= 7 && dateKT.Hour<23 )
                                sophutSD7h23h = Math.Round((decimal)(dateKT - dateBD).TotalMinutes);
                            else
                                sophutSD23h7h = Math.Round((decimal)(dateKT - dateBD).TotalMinutes);
                    /*TimeSpan time = dateKT - dateBD;
                    decimal phut = Math.Round((decimal)time.TotalMinutes);
                    
                    if (7 < dateKT.Hour && dateKT.Hour < 24)
                    {
                        sophutSD7h23h = phut;
                    }
                    else
                    {
                        sophutSD23h7h = phut;
                    }*/
                    db.ChiTietSuDungs.Add(new ChiTietSuDung() { ID = id + 1, IDSIM = split[0], TGBD = dateBD, TGKT = dateKT, SoPhutSD7h23h = sophutSD7h23h, SoPhutSD23h7h = sophutSD23h7h });
                    db.SaveChanges();
                }
                TinhHoaDonTinhCuoc();
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
        public void TinhHoaDonTinhCuoc()
        {
            var result = db.ChiTietSuDungs
                .GroupBy(x => new { x.IDSIM, x.TGBD.Value.Month })
                .Select(g => new
                {
                    sim = g.Key.IDSIM,
                    thang = g.Key.Month,
                    sophutsang = g.Sum(x => x.SoPhutSD7h23h),
                    sophuttoi = g.Sum(x => x.SoPhutSD23h7h),
                }).ToList();
            foreach (var item in result)
            {
                int ma = db.HoaDonTinhCuocs.Max(i => i.MaHDTC);//db.HoaDonTinhCuocs.Max(i => i.MaHDTC);
                Console.WriteLine(ma);
                int id = ma + 1;
                DateTime ngaytu = new DateTime(DateTime.Now.Year, item.thang, 1);
                ngaytu = ngaytu.AddDays((-ngaytu.Day) + 1);
                string tungay_tam = String.Format("{0:yyyy-MM-dd}", ngaytu);
                DateTime tungay = DateTime.ParseExact(tungay_tam, "yyyy-MM-dd",
                        System.Globalization.CultureInfo.InvariantCulture);

                DateTime ngayden = new DateTime(DateTime.Now.Year, item.thang, 1);
                ngayden = ngayden.AddMonths(1);
                ngayden = ngayden.AddDays(-(ngayden.Day));
                string denngay_tam = String.Format("{0:yyyy-MM-dd}", ngayden);
                DateTime denngay = DateTime.ParseExact(denngay_tam, "yyyy-MM-dd",
                        System.Globalization.CultureInfo.InvariantCulture);

                decimal? tongtien = 50000 + 200 * item.sophutsang + 150 * item.sophuttoi;
                db.HoaDonTinhCuocs.Add(new HoaDonTinhCuoc() { MaHDTC = id, IDSIM = item.sim.ToString(), TuNgay = tungay, DenNgay = denngay, PhiHangThang = 50000, TongTien = tongtien, NgayXuat = DateTime.Now, ThanhToan = false, Flag = false });
                db.SaveChanges();
            }
        }
    }
}
