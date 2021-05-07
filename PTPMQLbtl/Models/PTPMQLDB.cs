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
        
        public virtual DbSet<Danhmuchang> Danhmuchangs { get; set; }
       
        public virtual DbSet<Nhomhang> Nhomhangs { get; set; }
        public virtual DbSet<Khachhang> Khachhangs { get; set; }
        public virtual DbSet<Hoadon> Hoadons { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Nhanvien>Nhanviens{ get; set; }
        public virtual DbSet<Nhacungcap> Nhacungcaps { get; set; }
        public virtual DbSet<Donhanghoa> Donhangs { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Danhmuchang>()
               .Property(e => e.Tenhang)
               .IsFixedLength();
            modelBuilder.Entity<Danhmuchang>()
               .Property(e => e.Donvitinh)
               .IsFixedLength();
           
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
            modelBuilder.Entity<Account>()
              .Property(e => e.Usename)
              .IsRequired(); 
            modelBuilder.Entity<Account>()
               .Property(e => e.Password)
               .IsRequired();
            modelBuilder.Entity<Nhanvien>()
            .Property(e => e.MaNV)
            .IsRequired();
            modelBuilder.Entity<Nhanvien>()
               .Property(e => e.TenNV)
               .IsRequired();
            modelBuilder.Entity<Nhacungcap>()
            .Property(e => e.MaNCC)
            .IsRequired();
            modelBuilder.Entity<Nhacungcap>()
          .Property(e => e.TenNCC)
          .IsRequired();
           
            modelBuilder.Entity<Nhacungcap>()
          .Property(e => e.Diachi)
          .IsRequired();
            modelBuilder.Entity<Nhacungcap>()
          .Property(e => e.Sodienthoai)
          .IsRequired();
            modelBuilder.Entity<Donhanghoa>()
           .Property(e => e.Madonhang)
           .IsRequired();
            modelBuilder.Entity<Donhanghoa>()
          .Property(e => e.Tendonhang)
          .IsRequired();

            modelBuilder.Entity<Donhanghoa>()
          .Property(e => e.Sodonhang)
          .IsRequired();
            modelBuilder.Entity<Donhanghoa>()
          .Property(e => e.Yeucau)
          .IsRequired();
        }
    }
}
