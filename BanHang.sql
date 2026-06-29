
use QuanLyBanHangOnline

CREATE TABLE KhachHang (
    SoDienThoai VARCHAR(15) PRIMARY KEY,
    TenKhachHang VARCHAR(100),
    DiaChi TEXT
);

CREATE TABLE QuanLy (
    MaQuanLy VARCHAR(10) PRIMARY KEY,
    HoTen VARCHAR(100),
    SoDienThoai VARCHAR(15),
    Email VARCHAR(100)
);

CREATE TABLE NhanVien (
    MaNhanVien VARCHAR(10) PRIMARY KEY,
    HoTen VARCHAR(100),
    SoDienThoai VARCHAR(15),
    DiaChi TEXT
);

CREATE TABLE TaiKhoan (
    TenDangNhap VARCHAR(50) PRIMARY KEY,
    MatKhau VARCHAR(255),
    SoDienThoai VARCHAR(15),
    Email VARCHAR(100)
);

CREATE TABLE MonAn (
    MaMon VARCHAR(10) PRIMARY KEY,
    TenMon VARCHAR(100),
    GiaTien DECIMAL(10,2),
    HinhAnh VARCHAR(100)
);

CREATE TABLE DanhMuc (
    MaDanhMuc VARCHAR(10) PRIMARY KEY,
    TenDanhMuc VARCHAR(100)
);

CREATE TABLE DanhMuc_MonAn (
    MaDanhMuc VARCHAR(10),
    MaMon VARCHAR(10),
    KichThuoc VARCHAR(50),
    SoLuong INT,
    PRIMARY KEY (MaDanhMuc, MaMon),
    FOREIGN KEY (MaDanhMuc) REFERENCES DanhMuc(MaDanhMuc),
    FOREIGN KEY (MaMon) REFERENCES MonAn(MaMon)
);

CREATE TABLE NguyenLieu (
    MaNguyenLieu VARCHAR(10) PRIMARY KEY,
    TenNguyenLieu VARCHAR(100),
    DonGia DECIMAL(10,2),
    SoLuong INT,
    NhaCungCap VARCHAR(100)
);

CREATE TABLE HoaDon (
    MaHoaDon VARCHAR(10) PRIMARY KEY,
    NgayLap DATE,
    SoDienThoaiKH VARCHAR(15),
    MaNhanVien VARCHAR(10),
    FOREIGN KEY (SoDienThoaiKH) REFERENCES KhachHang(SoDienThoai),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

CREATE TABLE ChiTietHoaDon (
    MaHoaDon VARCHAR(10),
    MaMon VARCHAR(10),
    DonGia DECIMAL(10,2),
    SoLuong INT,
    ThanhTien DECIMAL(10,2),
    PRIMARY KEY (MaHoaDon, MaMon),
    FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon),
    FOREIGN KEY (MaMon) REFERENCES MonAn(MaMon)
);

CREATE TABLE PhieuNhap (
    MaPhieuNhap VARCHAR(10) PRIMARY KEY,
    NgayNhap DATE,
    NguoiGiao VARCHAR(100),
    MaNhanVienNhan VARCHAR(10),
    NhaCungCap VARCHAR(100),
    NguoiLapPhieu VARCHAR(100),
    GhiChu TEXT,
    FOREIGN KEY (MaNhanVienNhan) REFERENCES NhanVien(MaNhanVien)
);

CREATE TABLE ChiTietPhieuNhap (
    MaPhieuNhap VARCHAR(10),
    MaNguyenLieu VARCHAR(10),
    TenNguyenLieu VARCHAR(100),
    DonViTinh VARCHAR(50),
    DonGia DECIMAL(10,2),
    SoLuong INT,
    ThanhTien DECIMAL(10,2),
    PRIMARY KEY (MaPhieuNhap, MaNguyenLieu),
    FOREIGN KEY (MaPhieuNhap) REFERENCES PhieuNhap(MaPhieuNhap),
    FOREIGN KEY (MaNguyenLieu) REFERENCES NguyenLieu(MaNguyenLieu)
);

CREATE TABLE BaoCaoNgay (
    MaBaoCaoNgay VARCHAR(10) PRIMARY KEY,
    Ngay DATE,
    MaMon VARCHAR(10),
    DonViTinh VARCHAR(50),
    SoLuong INT,
    DoanhThuNgay DECIMAL(10,2),
    FOREIGN KEY (MaMon) REFERENCES MonAn(MaMon)
);

CREATE TABLE BaoCaoThang (
    MaBaoCaoThang VARCHAR(10) PRIMARY KEY,
    ThangNam DATE,
    MaMon VARCHAR(10),
    DonViTinh VARCHAR(50),
    SoLuong INT,
    DoanhThuThang DECIMAL(10,2),
    FOREIGN KEY (MaMon) REFERENCES MonAn(MaMon)
);

CREATE TABLE KiemKe (
    MaKiemKe VARCHAR(10) PRIMARY KEY,
    NgayKiemKe DATE,
    MaNguyenLieu VARCHAR(10),
    DonViTinh VARCHAR(50),
    DonGia DECIMAL(10,2),
    SoLuongTonKho INT,
    FOREIGN KEY (MaNguyenLieu) REFERENCES NguyenLieu(MaNguyenLieu)
);

