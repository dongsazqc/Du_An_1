create database Du_An_Nhom4
go
use Du_An_Nhom4
go

CREATE TABLE SanPham (
    SanPhamID INT PRIMARY KEY,
    TenSanPham NVARCHAR(255) NOT NULL,
	TenThuongHieu varchar(50) not null,
    MoTa nvarchar(255),
    Gia DECIMAL(18, 2) NOT NULL,
    SoLuongTonKho INT NOT NULL,
    KichThuoc NVARCHAR(50),
    MauSac NVARCHAR(50),
	TrangThai nvarchar(30),
);

CREATE TABLE KhachHang (
    KhachHangID INT PRIMARY KEY ,
    TenKhachHang NVARCHAR(255) NOT NULL,
    Email NVARCHAR(255) NOT NULl,
    SoDienThoai NVARCHAR(50),
    DiaChi NVARCHAR(500)
);

CREATE TABLE DonHang (
    DonHangID INT PRIMARY KEY ,
    KhachHangID INT,
    NgayDatHang DATETIME NOT NULL,
    TongTien DECIMAL(18, 2) NOT NULL,
    TrangThai NVARCHAR(50) NOT NULL,
    FOREIGN KEY (KhachHangID) REFERENCES KhachHang(KhachHangID)
);

CREATE TABLE ChiTietDonHang (
    ChiTietDonHangID INT PRIMARY KEY ,
    DonHangID INT,
    SanPhamID INT,
    SoLuong INT NOT NULL,
    Gia DECIMAL(18, 2) NOT NULL,
    FOREIGN KEY (DonHangID) REFERENCES DonHang(DonHangID),
    FOREIGN KEY (SanPhamID) REFERENCES SanPham(SanPhamID)
);

CREATE TABLE NhaCungCap (
    NhaCungCapID INT PRIMARY KEY ,
    TenNhaCungCap NVARCHAR(255) NOT NULL,
    TenNguoiLienHe NVARCHAR(255),
    SoDienThoai NVARCHAR(50),
    DiaChi NVARCHAR(500)
);

CREATE TABLE KhoHang (
    KhoHangID INT PRIMARY KEY,
    SanPhamID INT,
    SoLuong INT NOT NULL,
    ViTriKho NVARCHAR(255),
    FOREIGN KEY (SanPhamID) REFERENCES SanPham(SanPhamID)
);

CREATE TABLE NguoiDung (
    NguoiDungID INT PRIMARY KEY ,
    TenDangNhap NVARCHAR(255) NOT NULL UNIQUE,
    MatKhauMaHoa NVARCHAR(255) NOT NULL,
    VaiTro NVARCHAR(50) NOT NULL
);

CREATE TABLE DanhGia (
    DanhGiaID INT PRIMARY KEY ,
    SanPhamID INT,
    KhachHangID INT,
    DanhGia INT NOT NULL CHECK (DanhGia BETWEEN 1 AND 5),
    BinhLuan NVARCHAR(MAX),
    FOREIGN KEY (SanPhamID) REFERENCES SanPham(SanPhamID),
    FOREIGN KEY (KhachHangID) REFERENCES KhachHang(KhachHangID)
);

CREATE TABLE KhuyenMai (
    KhuyenMaiID INT PRIMARY KEY IDENTITY(1,1),
    TenKhuyenMai NVARCHAR(255) NOT NULL,
    MoTa NVARCHAR(255),
    GiamGia DECIMAL(18, 2) NOT NULL,
    NgayBatDau DATETIME NOT NULL,
    NgayKetThuc DATETIME NOT NULL
);

CREATE TABLE PhuongThucThanhToan (
    PhuongThucThanhToanID INT PRIMARY KEY ,
    TenPhuongThuc NVARCHAR(255) NOT NULL,
    ChiTiet NVARCHAR(MAX)
);
CREATE TABLE HoaDon (
<<<<<<< HEAD
    HoaDonID INT PRIMARY KEY IDENTITY(1,1),
=======
    HoaDonID INT PRIMARY KEY ,
>>>>>>> 90c1821c81bd62ff2d742cf664b0bb4ae4ca1bc2
    KhachHangID INT,
    NgayLapHoaDon DATETIME NOT NULL,
    TongTien DECIMAL(18, 2) NOT NULL,
    TrangThai NVARCHAR(50) NOT NULL,
    PhuongThucThanhToanID INT,
    FOREIGN KEY (KhachHangID) REFERENCES KhachHang(KhachHangID),
    FOREIGN KEY (PhuongThucThanhToanID) REFERENCES PhuongThucThanhToan(PhuongThucThanhToanID)
);
<<<<<<< HEAD

=======
>>>>>>> 90c1821c81bd62ff2d742cf664b0bb4ae4ca1bc2
CREATE TABLE HoaDonChiTiet (
    HoaDonChiTietID INT PRIMARY KEY IDENTITY(1,1),
    HoaDonID INT,
    SanPhamID INT,
    MaSanPham NVARCHAR(50), -- Mã sản phẩm
    SoLuong INT NOT NULL,
    Gia DECIMAL(18, 2) NOT NULL,
    GiamGia DECIMAL(18, 2) DEFAULT 0, -- Giảm giá cho sản phẩm
    FOREIGN KEY (HoaDonID) REFERENCES HoaDon(HoaDonID),
    FOREIGN KEY (SanPhamID) REFERENCES SanPham(SanPhamID)
);

go


create proc SP_Them_SP
    @SanPhamID INT,
    @TenSanPham NVARCHAR(255),
	@TenThuongHieu varchar(50) ,
    @MoTa nvarchar(255),
    @Gia DECIMAL(18, 2),
    @SoLuongTonKho INT ,
    @KichThuoc NVARCHAR(50),
    @MauSac NVARCHAR(50),
	@TrangThai nvarchar(50)
as
Begin
     if (@SanPhamID is null)
	 begin
	 print 'ID san pham khong duoc null'
	 end

	 else if (@TenSanPham is null)
	 begin
	 print 'Ten san pham khong duoc null'
	 end

	 else if( @TenThuongHieu is null)
	 begin
	 print 'Ten thuong hieu khong duoc null'
	 end

	 else if (@Gia is null)
	 begin
	 print 'Gia khong duoc null'
	 end

	 else if(@SoLuongTonKho is null)
	 begin
	 print 'So luong khong duoc null'
	 end

	 else if( @KichThuoc is null)
	 begin
	 print 'Kich thuoc khong duoc null'
	 end

	 else if (@MauSac is null)
	 begin
	 print ' Mau sac khong duoc null'
	 end

	 else if (@TrangThai is null)
	 begin
	 print 'Trang thai khong duoc null'
	 end


     Begin try
	   insert into SanPham values(@SanPhamID,
    @TenSanPham,
	@TenThuongHieu,
    @MoTa ,
    @Gia ,
    @SoLuongTonKho  ,
    @KichThuoc ,
    @MauSac ,
	@TrangThai ) 
	print 'Thêm thành công'
	 End try
	 Begin catch
	 	 print N'Không thêm được' +error_Message();

	 End catch
End

EXEC SP_Them_SP 1, N'Quần jean', 'Nike', N'Đem lại cảm giác thoải mái nhất cho người mặc', 1000000.00, 100, N'L', N'Xanh', N'Còn Hàng'
EXEC SP_Them_SP 2, N'Quần Straight Pants', 'Nike', N'Đem lại cảm giác thoải mái nhất cho người mặc', 2000000.00, 100, N'XL', N'Đỏ', N'Còn Hàng'
EXEC SP_Them_SP 3, N'Quần Short', 'Nike', N'Đem lại cảm giác thoải mái nhất cho người mặc', 3000000.00, 120, N'XL', N'Vàng', N'Còn Hàng'

select * from SanPham



--Thủ tục thêm khách hàng
CREATE PROCEDURE SP_Them_KhachHang
    @KhachHangID INT,
    @TenKhachHang NVARCHAR(255),
    @Email NVARCHAR(255),
    @SoDienThoai NVARCHAR(50),
    @DiaChi NVARCHAR(500)
AS
BEGIN
    BEGIN TRY
        INSERT INTO KhachHang (KhachHangID, TenKhachHang, Email, SoDienThoai, DiaChi)
        VALUES (@KhachHangID, @TenKhachHang, @Email, @SoDienThoai, @DiaChi);
        PRINT N'Thêm khách hàng thành công';
    END TRY
    BEGIN CATCH
        PRINT N'Không thể thêm khách hàng: ' + ERROR_MESSAGE();
    END CATCH
END;
GO
	
EXEC SP_Them_KhachHang 45001, N'Nguyễn Văn A', 'nguyenvana@example.com', '0123456789', N'123 Nguyễn Trãi, Hà Nội';	
	

select * from KhachHang

