﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyTinhCuoc.DTO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLTinhCuocDT2Entities : DbContext
    {
        public QLTinhCuocDT2Entities()
            : base("name=QLTinhCuocDT2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChiTietSuDung> ChiTietSuDungs { get; set; }
        public virtual DbSet<GiaCuoc> GiaCuocs { get; set; }
        public virtual DbSet<HoaDonDangKy> HoaDonDangKies { get; set; }
        public virtual DbSet<HoaDonTinhCuoc> HoaDonTinhCuocs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<ThongTinSIM> ThongTinSIMs { get; set; }
    }
}
