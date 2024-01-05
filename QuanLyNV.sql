drop database QuanLyNV

create database QuanLyNV

use QuanLyNV

CREATE TABLE NhanVien (
    MaNhanVien VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(255),
    GioiTinh NVARCHAR(10),
    SoDienThoai VARCHAR(15),
    NgayVaoLam DATETIME
);

CREATE TABLE NhanVienBanHang (
    MaNhanVien VARCHAR(10) PRIMARY KEY,
    DoanhSo FLOAT,
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

CREATE TABLE NhanVienGiaoNhan (
    MaNhanVien VARCHAR(10) PRIMARY KEY,
    PhuCapNhienLieu FLOAT,
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

INSERT INTO NhanVien (MaNhanVien, HoTen, GioiTinh, SoDienThoai, NgayVaoLam)
VALUES ('NVBH001', 'Nguyen Van A', 'Nam', '0123456789', '2023-01-15');

INSERT INTO NhanVienBanHang (MaNhanVien, DoanhSo)
VALUES ('NVBH001', 25000.0);

-- Thêm thông tin cho một nhân viên bán hàng khác
INSERT INTO NhanVien (MaNhanVien, HoTen, GioiTinh, SoDienThoai, NgayVaoLam)
VALUES ('NVBH002', 'Tran Thi B', 'Nữ', '0987654321', '2023-02-20');

INSERT INTO NhanVienBanHang (MaNhanVien, DoanhSo)
VALUES ('NVBH002', 35000.0);

-- Thêm thông tin cho nhân viên giao nhận
INSERT INTO NhanVien (MaNhanVien, HoTen, GioiTinh, SoDienThoai, NgayVaoLam)
VALUES ('NVGN001', 'Le Van C', 'Nam', '0365478912', '2023-03-10');

INSERT INTO NhanVienGiaoNhan (MaNhanVien, PhuCapNhienLieu)
VALUES ('NVGN001', 500.0);

-- Thêm thông tin cho một nhân viên giao nhận khác
INSERT INTO NhanVien (MaNhanVien, HoTen, GioiTinh, SoDienThoai, NgayVaoLam)
VALUES ('NVGN002', 'Pham Xuan D', 'Nam', '0789123456', '2023-04-05');

INSERT INTO NhanVienGiaoNhan (MaNhanVien, PhuCapNhienLieu)
VALUES ('NVGN002', 600.0);