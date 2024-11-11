using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<chucVu>().HasData(
                new chucVu() { IDChucVu = 1, tenCV = "Quản lý" },
                new chucVu() { IDChucVu = 2, tenCV = "Nhân viên" }
            );

            modelBuilder.Entity<hangSX>().HasData(
                new hangSX() { IDHangSX = 1, tenHangSX = "Nike", trangThai = true },
                new hangSX() { IDHangSX = 2, tenHangSX = "Adidas", trangThai = true },
                new hangSX() { IDHangSX = 3, tenHangSX = "Puma", trangThai = true }
            );

            modelBuilder.Entity<khachHang>().HasData(
                new khachHang() { SDT_KH = "0123456789", TenKH = "Nguyễn Văn A", gioiTinh = true, diaChi = "Hà Nội", trangThai = true, diem = 10000 },
                new khachHang() { SDT_KH = "0123456567", TenKH = "Nguyễn Văn B", gioiTinh = false, diaChi = "Hải Phòng", trangThai = true, diem = 10000 },
                new khachHang() { SDT_KH = "0123456678", TenKH = "Nguyễn Văn C", gioiTinh = true, diaChi = "Lạng Sơn", trangThai = true, diem = 10000 }
            );

            modelBuilder.Entity<mauSac>().HasData(
                new mauSac() { IDMauSac = 1, tenMau = "Đen", trangThai = true },
                new mauSac() { IDMauSac = 2, tenMau = "Trắng", trangThai = true },
                new mauSac() { IDMauSac = 3, tenMau = "Đỏ", trangThai = true }
            );

            modelBuilder.Entity<size>().HasData(
                new size() { IDSize = 1, SiZe = "36", trangThai = true },
                new size() { IDSize = 2, SiZe = "37", trangThai = true },
                new size() { IDSize = 3, SiZe = "38", trangThai = true },
                new size() { IDSize = 4, SiZe = "39", trangThai = true },
                new size() { IDSize = 5, SiZe = "40", trangThai = true }
            );

            modelBuilder.Entity<sanPham1>().HasData(
                new sanPham1() { IDsanPham = 1, tenLoaiHang = "Sneaker", trangThai = true },
                new sanPham1() { IDsanPham = 2, tenLoaiHang = "Giày thể thao", trangThai = true },
                new sanPham1() { IDsanPham = 3, tenLoaiHang = "Giày boot", trangThai = true },
                new sanPham1() { IDsanPham = 4, tenLoaiHang = "Giày da", trangThai = true }
            );

            modelBuilder.Entity<nhanVien>().HasData(
                new nhanVien() { IDNhanVien = 1, TenNV = "Phạm Đức Hiếu", IDChucVu = 1, diaChi = "Quảng Ninh", SDT = "0976819974", email = "Hieupdph40428@gmail.com", tinhTrang = true, matKhau = "123" },
                new nhanVien() { IDNhanVien = 2, TenNV = "Nguyễn Văn B", IDChucVu = 2, diaChi = "Hà Nội", SDT = "0379702144", email = "aaa@gmail.com", tinhTrang = true, matKhau = "123" }
            );

            modelBuilder.Entity<sanPhamChiTiet>().HasData(
                new sanPhamChiTiet() { IDSanPhamChiTiet = 1, maSP = "GIAY01", TenSP = "Nike Air Max", Gianhap = 1500, Giaban = 2000, Soluong = 500, Trangthai = true, IDHangSX = 1, IDSize = 1, IDMauSac = 1, IDsanPham = 1, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 2, maSP = "GIAY02", TenSP = "Adidas Ultraboost", Gianhap = 1600, Giaban = 2100, Soluong = 300, Trangthai = true, IDHangSX = 2, IDSize = 2, IDMauSac = 2, IDsanPham = 2, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 3, maSP = "GIAY03", TenSP = "Puma Suede", Gianhap = 1400, Giaban = 1800, Soluong = 400, Trangthai = true, IDHangSX = 3, IDSize = 3, IDMauSac = 3, IDsanPham = 1, linkAnh = "" },
                new sanPhamChiTiet() { IDSanPhamChiTiet = 4, maSP = "GIAY04", TenSP = "Giày boot da", Gianhap = 1800, Giaban = 2300, Soluong = 200, Trangthai = true, IDHangSX = 1, IDSize = 4, IDMauSac = 1, IDsanPham = 3, linkAnh = "" }
            );
        }
    }
}