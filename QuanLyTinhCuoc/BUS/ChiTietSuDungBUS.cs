using System.Collections.Generic;
using QuanLyTinhCuoc.DAO;
using QuanLyTinhCuoc.DTO;

namespace QuanLyTinhCuoc.BUS
{
    public class ChiTietSuDungBUS
    {
        ChiTietSuDungDAO ChiTietSuDungDAO;
        public ChiTietSuDungBUS()
        {
            ChiTietSuDungDAO = new ChiTietSuDungDAO();
        }
        public List<ChiTietSuDung> LoadChiTietSuDung()
        {
            return ChiTietSuDungDAO.LoadDanhSach();
        }
        public bool Import(string[] data)
        {
            return ChiTietSuDungDAO.ImportFile(data);
        }
    }
}
