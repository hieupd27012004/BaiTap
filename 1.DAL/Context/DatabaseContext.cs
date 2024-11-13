using _1.DAL.Configurations;
using _1.DAL.Extensions;
using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<chucVu> chucVus { get; set; }
        public DbSet<hangSX> hangSXes { get; set; }
        public DbSet<hoaDon> hoaDons { get; set; }
        public DbSet<sanPhamChiTiet> sanPhamCTs { get; set; }
        public DbSet<sanPham1> sanPhams { get; set; }
        public DbSet<hoaDonChiTiet> hoaDonChiTiets { get; set; }
        public DbSet<mauSac> mauSacs { get; set; }
        public DbSet<nhanVien> nhanViens { get; set; }
        public DbSet<khachHang> khachHangs { get; set; }
        public DbSet<size> Sizes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Thực hiện các ràng buộc kết nối
            //base.OnConfiguring(optionsBuilder.
            //    ; User ID = Hieupdph40428@gmail.com; Password = 123
            if (!optionsBuilder.IsConfigured)
            {
                // Mọi người dùng Clone using the web URL để mở file nhé nếu tải xuống theo tệp zip thì phải bỏ chặn ở Windows Explorer chọn .resx rồi chuột trái ấn bỏ chặn 
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=da1000;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new chucVuConfigurations());
            modelBuilder.ApplyConfiguration(new hangSXConfigurations());
            modelBuilder.ApplyConfiguration(new hoaDonConfigurations());
            modelBuilder.ApplyConfiguration(new hoaDonChiTietConfigurations());
            modelBuilder.ApplyConfiguration(new khachHangConfigurations());
            modelBuilder.ApplyConfiguration(new mauSacConfigurations());
            modelBuilder.ApplyConfiguration(new nhanVienConfigurations());
            modelBuilder.ApplyConfiguration(new sanPhamChiTietConfigurations());
            modelBuilder.ApplyConfiguration(new sizeConfigurations());
            modelBuilder.ApplyConfiguration(new sanPhamConfigurations());
            //modelBuilder.ApplyConfiguration(new ProductInCategoryConfiguration());
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Seed(); //gọi cái này để seeding data
        }
    }
}
