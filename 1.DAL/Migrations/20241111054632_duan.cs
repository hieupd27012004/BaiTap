using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.DAL.Migrations
{
    public partial class duan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "chucVu",
                columns: table => new
                {
                    IDChucVu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenCV = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chucVu", x => x.IDChucVu);
                });

            migrationBuilder.CreateTable(
                name: "hangSX",
                columns: table => new
                {
                    IDHangSX = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenHangSX = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hangSX", x => x.IDHangSX);
                });

            migrationBuilder.CreateTable(
                name: "khachHang",
                columns: table => new
                {
                    SDT_KH = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenKH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    diaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trangThai = table.Column<bool>(type: "bit", nullable: false),
                    diem = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khachHang", x => x.SDT_KH);
                });

            migrationBuilder.CreateTable(
                name: "mauSac",
                columns: table => new
                {
                    IDMauSac = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenMau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mauSac", x => x.IDMauSac);
                });

            migrationBuilder.CreateTable(
                name: "sanPham",
                columns: table => new
                {
                    IDsanPham = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenLoaiHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPham", x => x.IDsanPham);
                });

            migrationBuilder.CreateTable(
                name: "size",
                columns: table => new
                {
                    IDSize = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiZe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_size", x => x.IDSize);
                });

            migrationBuilder.CreateTable(
                name: "nhanVien",
                columns: table => new
                {
                    IDNhanVien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDChucVu = table.Column<int>(type: "int", nullable: false),
                    TenNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    diaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tinhTrang = table.Column<bool>(type: "bit", nullable: false),
                    matKhau = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhanVien", x => x.IDNhanVien);
                    table.ForeignKey(
                        name: "FK_nhanVien_chucVu_IDChucVu",
                        column: x => x.IDChucVu,
                        principalTable: "chucVu",
                        principalColumn: "IDChucVu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sanPhamChiTiet",
                columns: table => new
                {
                    IDSanPhamChiTiet = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDMauSac = table.Column<int>(type: "int", nullable: false),
                    IDSize = table.Column<int>(type: "int", nullable: false),
                    IDHangSX = table.Column<int>(type: "int", nullable: false),
                    IDsanPham = table.Column<int>(type: "int", nullable: false),
                    TenSP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    maSP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gianhap = table.Column<float>(type: "real", nullable: false),
                    Giaban = table.Column<float>(type: "real", nullable: false),
                    Soluong = table.Column<int>(type: "int", nullable: false),
                    Trangthai = table.Column<bool>(type: "bit", nullable: false),
                    linkAnh = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPhamChiTiet", x => x.IDSanPhamChiTiet);
                    table.ForeignKey(
                        name: "FK_sanPhamChiTiet_hangSX_IDHangSX",
                        column: x => x.IDHangSX,
                        principalTable: "hangSX",
                        principalColumn: "IDHangSX",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPhamChiTiet_mauSac_IDMauSac",
                        column: x => x.IDMauSac,
                        principalTable: "mauSac",
                        principalColumn: "IDMauSac",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPhamChiTiet_sanPham_IDsanPham",
                        column: x => x.IDsanPham,
                        principalTable: "sanPham",
                        principalColumn: "IDsanPham",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPhamChiTiet_size_IDSize",
                        column: x => x.IDSize,
                        principalTable: "size",
                        principalColumn: "IDSize",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDon",
                columns: table => new
                {
                    IDHoaDon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDNhanVien = table.Column<int>(type: "int", nullable: false),
                    SDT_KH = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    tongTien = table.Column<float>(type: "real", nullable: false),
                    ngayBan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ghiChu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDon", x => x.IDHoaDon);
                    table.ForeignKey(
                        name: "FK_hoaDon_khachHang_SDT_KH",
                        column: x => x.SDT_KH,
                        principalTable: "khachHang",
                        principalColumn: "SDT_KH");
                    table.ForeignKey(
                        name: "FK_hoaDon_nhanVien_IDNhanVien",
                        column: x => x.IDNhanVien,
                        principalTable: "nhanVien",
                        principalColumn: "IDNhanVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDonChiTiet",
                columns: table => new
                {
                    IDHoaDon = table.Column<int>(type: "int", nullable: false),
                    IDSanPham = table.Column<int>(type: "int", nullable: false),
                    Soluong = table.Column<int>(type: "int", nullable: false),
                    donGia = table.Column<float>(type: "real", nullable: false),
                    Trangthai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDonChiTiet", x => new { x.IDHoaDon, x.IDSanPham });
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiet_hoaDon_IDHoaDon",
                        column: x => x.IDHoaDon,
                        principalTable: "hoaDon",
                        principalColumn: "IDHoaDon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiet_sanPhamChiTiet_IDSanPham",
                        column: x => x.IDSanPham,
                        principalTable: "sanPhamChiTiet",
                        principalColumn: "IDSanPhamChiTiet",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "chucVu",
                columns: new[] { "IDChucVu", "tenCV" },
                values: new object[,]
                {
                    { 1, "Quản lý" },
                    { 2, "Nhân viên" }
                });

            migrationBuilder.InsertData(
                table: "hangSX",
                columns: new[] { "IDHangSX", "tenHangSX", "trangThai" },
                values: new object[,]
                {
                    { 1, "Nike", true },
                    { 2, "Adidas", true },
                    { 3, "Puma", true }
                });

            migrationBuilder.InsertData(
                table: "khachHang",
                columns: new[] { "SDT_KH", "TenKH", "diaChi", "diem", "gioiTinh", "trangThai" },
                values: new object[,]
                {
                    { "0123456567", "Nguyễn Văn B", "Hải Phòng", 10000, false, true },
                    { "0123456678", "Nguyễn Văn C", "Lạng Sơn", 10000, true, true },
                    { "0123456789", "Nguyễn Văn A", "Hà Nội", 10000, true, true }
                });

            migrationBuilder.InsertData(
                table: "mauSac",
                columns: new[] { "IDMauSac", "tenMau", "trangThai" },
                values: new object[,]
                {
                    { 1, "Đen", true },
                    { 2, "Trắng", true },
                    { 3, "Đỏ", true }
                });

            migrationBuilder.InsertData(
                table: "sanPham",
                columns: new[] { "IDsanPham", "tenLoaiHang", "trangThai" },
                values: new object[,]
                {
                    { 1, "Sneaker", true },
                    { 2, "Giày thể thao", true },
                    { 3, "Giày boot", true },
                    { 4, "Giày da", true }
                });

            migrationBuilder.InsertData(
                table: "size",
                columns: new[] { "IDSize", "SiZe", "trangThai" },
                values: new object[,]
                {
                    { 1, "36", true },
                    { 2, "37", true },
                    { 3, "38", true },
                    { 4, "39", true },
                    { 5, "40", true }
                });

            migrationBuilder.InsertData(
                table: "nhanVien",
                columns: new[] { "IDNhanVien", "IDChucVu", "SDT", "TenNV", "diaChi", "email", "matKhau", "tinhTrang" },
                values: new object[,]
                {
                    { 1, 1, "0976819974", "Phạm Đức Hiếu", "Quảng Ninh", "Hieupdph40428@gmail.com", "123", true },
                    { 2, 2, "0379702144", "Nguyễn Văn B", "Hà Nội", "aaa@gmail.com", "123", true }
                });

            migrationBuilder.InsertData(
                table: "sanPhamChiTiet",
                columns: new[] { "IDSanPhamChiTiet", "Giaban", "Gianhap", "IDHangSX", "IDMauSac", "IDSize", "IDsanPham", "Soluong", "TenSP", "Trangthai", "linkAnh", "maSP" },
                values: new object[,]
                {
                    { 1, 2000f, 1500f, 1, 1, 1, 1, 500, "Nike Air Max", true, "", "GIAY01" },
                    { 2, 2100f, 1600f, 2, 2, 2, 2, 300, "Adidas Ultraboost", true, "", "GIAY02" },
                    { 3, 1800f, 1400f, 3, 3, 3, 1, 400, "Puma Suede", true, "", "GIAY03" },
                    { 4, 2300f, 1800f, 1, 1, 4, 3, 200, "Giày boot da", true, "", "GIAY04" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_hoaDon_IDNhanVien",
                table: "hoaDon",
                column: "IDNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDon_SDT_KH",
                table: "hoaDon",
                column: "SDT_KH");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonChiTiet_IDSanPham",
                table: "hoaDonChiTiet",
                column: "IDSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_nhanVien_IDChucVu",
                table: "nhanVien",
                column: "IDChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhamChiTiet_IDHangSX",
                table: "sanPhamChiTiet",
                column: "IDHangSX");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhamChiTiet_IDMauSac",
                table: "sanPhamChiTiet",
                column: "IDMauSac");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhamChiTiet_IDsanPham",
                table: "sanPhamChiTiet",
                column: "IDsanPham");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhamChiTiet_IDSize",
                table: "sanPhamChiTiet",
                column: "IDSize");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "hoaDon");

            migrationBuilder.DropTable(
                name: "sanPhamChiTiet");

            migrationBuilder.DropTable(
                name: "khachHang");

            migrationBuilder.DropTable(
                name: "nhanVien");

            migrationBuilder.DropTable(
                name: "hangSX");

            migrationBuilder.DropTable(
                name: "mauSac");

            migrationBuilder.DropTable(
                name: "sanPham");

            migrationBuilder.DropTable(
                name: "size");

            migrationBuilder.DropTable(
                name: "chucVu");
        }
    }
}
