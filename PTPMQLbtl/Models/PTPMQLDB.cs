using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PTPMQLbtl.Models
{
    public partial class PTPMQLDB : DbContext
    {
        public PTPMQLDB()
            : base("name=PTPMQLDB")
        {
        }

      
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Chitietdonhang> Chitietdonhangs { get; set; }
        public virtual DbSet<Danhmuchang> Danhmuchangs { get; set; }
        public virtual DbSet<Donhang> Donhangs { get; set; }
        public virtual DbSet<Nhomhang> Nhomhangs { get; set; }
        public virtual DbSet<Khachhang> Khachhangs { get; set; }
        public virtual DbSet<Hoadon> Hoadons { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chitietdonhang>()
                  .Property(e => e.Dongia)
              .IsRequired();
            modelBuilder.Entity<Chitietdonhang>()
               .Property(e => e.Machitietdonhang)
               .IsFixedLength();
            modelBuilder.Entity<Chitietdonhang>()
            .Property(e => e.Madonhang)
            .IsFixedLength();
            modelBuilder.Entity<Chitietdonhang>()
               .Property(e => e.Mathang)
               .IsFixedLength();
            modelBuilder.Entity<Chitietdonhang>()
                  .Property(e => e.Dongia)
                .IsRequired();
            modelBuilder.Entity<Danhmuchang>()
               .Property(e => e.Tenhang)
               .IsFixedLength();
            modelBuilder.Entity<Danhmuchang>()
               .Property(e => e.Donvitinh)
               .IsFixedLength();
            modelBuilder.Entity<Donhang>()
               .Property(e => e.Ngaydathang)
               .IsRequired();
            modelBuilder.Entity<Donhang>()
               .Property(e => e.Madonhang)
               .IsRequired();
            modelBuilder.Entity<Khachhang>()
             .Property(e => e.Makhachhang)
             .IsRequired();
            modelBuilder.Entity<Khachhang>()
          .Property(e => e.Hodem)
          .IsRequired();
            modelBuilder.Entity<Khachhang>()
          .Property(e => e.Ten)
          .IsRequired();
            modelBuilder.Entity<Khachhang>()
          .Property(e => e.Diachi)
          .IsRequired();
            modelBuilder.Entity<Khachhang>()
          .Property(e => e.Sodienthoai)
          .IsRequired();
            modelBuilder.Entity<Nhomhang>()
          .Property(e => e.Manhomhang)
          .IsRequired();
            modelBuilder.Entity<Nhomhang>()
          .Property(e => e.Tennhomhang)
          .IsRequired();
            modelBuilder.Entity<Nhomhang>()
          .Property(e => e.Mota)
          .IsRequired();
            modelBuilder.Entity<Hoadon>()
         .Property(e => e.Sohoadon)
         .IsRequired();
            modelBuilder.Entity<Hoadon>()
         .Property(e => e.Ngayban)
         .IsRequired();
        }
    }
}
