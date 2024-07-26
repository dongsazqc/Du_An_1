-- Tạo database và sử dụng database
CREATE DATABASE Du_An_Nhom4
GO
USE Du_An_Nhom4
GO

-- Tạo bảng SanPham
CREATE TABLE SanPham (
    SanPhamID INT PRIMARY KEY,
    TenSanPham NVARCHAR(255) NOT NULL,
    TenThuongHieu VARCHAR(50) NOT NULL,
    MoTa NVARCHAR(255),
    Gia DECIMAL(18, 2) NOT NULL,
    SoLuongTonKho INT NOT NULL,
    KichThuoc NVARCHAR(50),
    MauSac NVARCHAR(50),
    TrangThai NVARCHAR(30)
);
GO

-- Tạo bảng KhachHang
CREATE TABLE KhachHang (
    KhachHangID INT PRIMARY KEY,
    TenKhachHang NVARCHAR(255) NOT NULL,
    Email NVARCHAR(255) NOT NULL,
    SoDienThoai NVARCHAR(50),
    DiaChi NVARCHAR(500)
);
GO

-- Tạo bảng DonHang
CREATE TABLE DonHang (
    DonHangID INT PRIMARY KEY,
    KhachHangID INT,
    NgayDatHang DATETIME NOT NULL,
    TongTien DECIMAL(18, 2) NOT NULL,
    TrangThai NVARCHAR(50) NOT NULL,
    FOREIGN KEY (KhachHangID) REFERENCES KhachHang(KhachHangID)
);
GO

-- Tạo bảng ChiTietDonHang
CREATE TABLE ChiTietDonHang (
    ChiTietDonHangID INT PRIMARY KEY,
    DonHangID INT,
    SanPhamID INT,
    SoLuong INT NOT NULL,
    Gia DECIMAL(18, 2) NOT NULL,
    FOREIGN KEY (DonHangID) REFERENCES DonHang(DonHangID),
    FOREIGN KEY (SanPhamID) REFERENCES SanPham(SanPhamID)
);
GO

-- Tạo bảng NhaCungCap
CREATE TABLE NhaCungCap (
    NhaCungCapID INT PRIMARY KEY,
    TenNhaCungCap NVARCHAR(255) NOT NULL,
    TenNguoiLienHe NVARCHAR(255),
    SoDienThoai NVARCHAR(50),
    DiaChi NVARCHAR(500)
);
GO

-- Tạo bảng KhoHang
CREATE TABLE KhoHang (
    KhoHangID INT PRIMARY KEY,
    SanPhamID INT,
    SoLuong INT NOT NULL,
    ViTriKho NVARCHAR(255),
    FOREIGN KEY (SanPhamID) REFERENCES SanPham(SanPhamID)
);
GO

-- Tạo bảng NguoiDung
CREATE TABLE NguoiDung (
    NguoiDungID INT PRIMARY KEY,
    TenDangNhap NVARCHAR(255) NOT NULL UNIQUE,
    MatKhauMaHoa NVARCHAR(255) NOT NULL,
    VaiTro NVARCHAR(50) NOT NULL
);
GO

-- Tạo bảng DanhGia
CREATE TABLE DanhGia (
    DanhGiaID INT PRIMARY KEY,
    SanPhamID INT,
    KhachHangID INT,
    DanhGia INT NOT NULL CHECK (DanhGia BETWEEN 1 AND 5),
    BinhLuan NVARCHAR(MAX),
    FOREIGN KEY (SanPhamID) REFERENCES SanPham(SanPhamID),
    FOREIGN KEY (KhachHangID) REFERENCES KhachHang(KhachHangID)
);
GO

-- Tạo bảng KhuyenMai
CREATE TABLE KhuyenMai (
    KhuyenMaiID INT PRIMARY KEY IDENTITY(1,1),
    TenKhuyenMai NVARCHAR(255) NOT NULL,
    MoTa NVARCHAR(255),
    GiamGia DECIMAL(18, 2) NOT NULL,
    NgayBatDau DATETIME NOT NULL,
    NgayKetThuc DATETIME NOT NULL
);
GO

-- Tạo bảng PhuongThucThanhToan
CREATE TABLE PhuongThucThanhToan (
    PhuongThucThanhToanID INT PRIMARY KEY,
    TenPhuongThuc NVARCHAR(255) NOT NULL,
    ChiTiet NVARCHAR(MAX)
);
GO

-- Tạo bảng HoaDon với HoaDonID kiểu VARCHAR
CREATE TABLE HoaDon (
    HoaDonID VARCHAR(50) PRIMARY KEY,
    KhachHangID INT,
    NgayLapHoaDon DATETIME NOT NULL,
    TongTien DECIMAL(18, 2) NOT NULL,
    TrangThai NVARCHAR(50) NOT NULL,
    PhuongThucThanhToanID INT,
    FOREIGN KEY (KhachHangID) REFERENCES KhachHang(KhachHangID),
    FOREIGN KEY (PhuongThucThanhToanID) REFERENCES PhuongThucThanhToan(PhuongThucThanhToanID)
);
go
-- Thêm các cột TenKhachHang, Gmail, SoDienThoai và DiaChi vào bảng HoaDon
ALTER TABLE HoaDon
ADD 
    TenKhachHang NVARCHAR(255),
    Gmail NVARCHAR(255),
    SoDienThoai NVARCHAR(50),
    DiaChi NVARCHAR(500);
GO



-- Tạo bảng HoaDonChiTiet với HoaDonID kiểu VARCHAR
CREATE TABLE HoaDonChiTiet (
    HoaDonChiTietID INT PRIMARY KEY IDENTITY(1,1),
    HoaDonID VARCHAR(50),
    SanPhamID INT,
    MaSanPham NVARCHAR(50),
    SoLuong INT NOT NULL,
    Gia DECIMAL(18, 2) NOT NULL,
    GiamGia DECIMAL(18, 2) DEFAULT 0,
    FOREIGN KEY (HoaDonID) REFERENCES HoaDon(HoaDonID),
    FOREIGN KEY (SanPhamID) REFERENCES SanPham(SanPhamID)
);
GO

-- Thêm cột NgaySanXuat vào bảng SanPham
ALTER TABLE SanPham
ADD NgaySanXuat DATE;
GO

-- Thêm cột GioiTinh vào bảng KhachHang
ALTER TABLE KhachHang
ADD GioiTinh NVARCHAR(10);
GO

-- Thêm cột GhiChu vào bảng DonHang
ALTER TABLE DonHang
ADD GhiChu NVARCHAR(255);
GO

-- Thủ tục thêm sản phẩm
CREATE PROC SP_Them_SP
    @SanPhamID INT,
    @TenSanPham NVARCHAR(255),
    @TenThuongHieu VARCHAR(50),
    @MoTa NVARCHAR(255),
    @Gia DECIMAL(18, 2),
    @SoLuongTonKho INT,
    @KichThuoc NVARCHAR(50),
    @MauSac NVARCHAR(50),
    @TrangThai NVARCHAR(50)
AS
BEGIN
    IF (@SanPhamID IS NULL)
    BEGIN
        PRINT 'ID sản phẩm không được null'
    END
    ELSE IF (@TenSanPham IS NULL)
    BEGIN
        PRINT 'Tên sản phẩm không được null'
    END
    ELSE IF (@TenThuongHieu IS NULL)
    BEGIN
        PRINT 'Tên thương hiệu không được null'
    END
    ELSE IF (@Gia IS NULL)
    BEGIN
        PRINT 'Giá không được null'
    END
    ELSE IF (@SoLuongTonKho IS NULL)
    BEGIN
        PRINT 'Số lượng không được null'
    END
    ELSE IF (@KichThuoc IS NULL)
    BEGIN
        PRINT 'Kích thước không được null'
    END
    ELSE IF (@MauSac IS NULL)
    BEGIN
        PRINT 'Màu sắc không được null'
    END
    ELSE IF (@TrangThai IS NULL)
    BEGIN
        PRINT 'Trạng thái không được null'
    END
    BEGIN TRY
        INSERT INTO SanPham VALUES(
            @SanPhamID,
            @TenSanPham,
            @TenThuongHieu,
            @MoTa,
            @Gia,
            @SoLuongTonKho,
            @KichThuoc,
            @M
