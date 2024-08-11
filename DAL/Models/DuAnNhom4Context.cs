using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class DuAnNhom4Context : DbContext
{
    public DuAnNhom4Context()
    {
    }

    public DuAnNhom4Context(DbContextOptions<DuAnNhom4Context> options)
        : base(options)
    {
    }

    public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }

    public virtual DbSet<DanhGium> DanhGia { get; set; }

    public virtual DbSet<DonHang> DonHangs { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }

    public virtual DbSet<HoaDonDaThanhToan> HoaDonDaThanhToans { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<KhoHang> KhoHangs { get; set; }

    public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }

    public virtual DbSet<NguoiDung> NguoiDungs { get; set; }

    public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }

    public virtual DbSet<Otptable> Otptables { get; set; }

    public virtual DbSet<PhuongThucThanhToan> PhuongThucThanhToans { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<SanPhamGiamGium> SanPhamGiamGia { get; set; }

    public virtual DbSet<SanPhamMua> SanPhamMuas { get; set; }

    public virtual DbSet<Voucher> Vouchers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
<<<<<<< HEAD
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-289J5PP0\\THUAN;Initial Catalog=Du_An_Nhom4;Integrated Security=True;Trust Server Certificate=True");
=======
        => optionsBuilder.UseSqlServer("Data Source=DUONG;Initial Catalog=Du_An_Nhom4;Integrated Security=True;Trust Server Certificate=True");
>>>>>>> 7eda9507ab6e95a34a1c1146c905750afc9a7e4b

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChiTietDonHang>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.ChiTietDonHangId).HasName("PK__ChiTietD__45B33F8326DEF041");
=======
            entity.HasKey(e => e.ChiTietDonHangId).HasName("PK__ChiTietD__45B33F83A7D016B5");
>>>>>>> 7eda9507ab6e95a34a1c1146c905750afc9a7e4b

            entity.ToTable("ChiTietDonHang");

            entity.Property(e => e.ChiTietDonHangId)
                .ValueGeneratedNever()
                .HasColumnName("ChiTietDonHangID");
            entity.Property(e => e.DonHangId).HasColumnName("DonHangID");
            entity.Property(e => e.Gia).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");

            entity.HasOne(d => d.DonHang).WithMany(p => p.ChiTietDonHangs)
                .HasForeignKey(d => d.DonHangId)
                .HasConstraintName("FK__ChiTietDo__DonHa__52593CB8");

            entity.HasOne(d => d.SanPham).WithMany(p => p.ChiTietDonHangs)
                .HasForeignKey(d => d.SanPhamId)
                .HasConstraintName("FK__ChiTietDo__SanPh__534D60F1");
        });

        modelBuilder.Entity<DanhGium>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.DanhGiaId).HasName("PK__DanhGia__52C0CA25E3BEB41E");
=======
            entity.HasKey(e => e.DanhGiaId).HasName("PK__DanhGia__52C0CA2537BCD6EE");
>>>>>>> 7eda9507ab6e95a34a1c1146c905750afc9a7e4b

            entity.Property(e => e.DanhGiaId)
                .ValueGeneratedNever()
                .HasColumnName("DanhGiaID");
            entity.Property(e => e.KhachHangId).HasColumnName("KhachHangID");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");

            entity.HasOne(d => d.KhachHang).WithMany(p => p.DanhGia)
                .HasForeignKey(d => d.KhachHangId)
<<<<<<< HEAD
                .HasConstraintName("FK__DanhGia__KhachHa__4E88ABD4");

            entity.HasOne(d => d.SanPham).WithMany(p => p.DanhGia)
                .HasForeignKey(d => d.SanPhamId)
                .HasConstraintName("FK__DanhGia__SanPham__4D94879B");
=======
                .HasConstraintName("FK__DanhGia__KhachHa__628FA481");

            entity.HasOne(d => d.SanPham).WithMany(p => p.DanhGia)
                .HasForeignKey(d => d.SanPhamId)
                .HasConstraintName("FK__DanhGia__SanPham__619B8048");
>>>>>>> 7eda9507ab6e95a34a1c1146c905750afc9a7e4b
        });

        modelBuilder.Entity<DonHang>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.DonHangId).HasName("PK__DonHang__D159F4DEF62FEF6D");
=======
            entity.HasKey(e => e.DonHangId).HasName("PK__DonHang__D159F4DEA0581537");
>>>>>>> 7eda9507ab6e95a34a1c1146c905750afc9a7e4b

            entity.ToTable("DonHang");

            entity.Property(e => e.DonHangId)
                .ValueGeneratedNever()
                .HasColumnName("DonHangID");
            entity.Property(e => e.GhiChu).HasMaxLength(255);
            entity.Property(e => e.KhachHangId).HasColumnName("KhachHangID");
            entity.Property(e => e.NgayDatHang).HasColumnType("datetime");
            entity.Property(e => e.TongTien).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TrangThai).HasMaxLength(50);

            entity.HasOne(d => d.KhachHang).WithMany(p => p.DonHangs)
                .HasForeignKey(d => d.KhachHangId)
                .HasConstraintName("FK__DonHang__KhachHa__4F7CD00D");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.HoaDonId).HasName("PK__HoaDon__6956CE69180C9ABD");
=======
            entity.HasKey(e => e.HoaDonId).HasName("PK__HoaDon__6956CE695A546219");
>>>>>>> 7eda9507ab6e95a34a1c1146c905750afc9a7e4b

            entity.ToTable("HoaDon");

            entity.Property(e => e.HoaDonId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HoaDonID");
            entity.Property(e => e.DiaChi).HasMaxLength(500);
            entity.Property(e => e.Gmail).HasMaxLength(255);
            entity.Property(e => e.KhachHangId).HasColumnName("KhachHangID");
            entity.Property(e => e.NgayLapHoaDon).HasColumnType("datetime");
            entity.Property(e => e.PhuongThucThanhToanId).HasColumnName("PhuongThucThanhToanID");
            entity.Property(e => e.SoDienThoai).HasMaxLength(50);
            entity.Property(e => e.TenKhachHang).HasMaxLength(255);
            entity.Property(e => e.TongTien).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TrangThai).HasMaxLength(50);

            entity.HasOne(d => d.KhachHang).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.KhachHangId)
<<<<<<< HEAD
                .HasConstraintName("FK__HoaDon__KhachHan__5535A963");
=======
                .HasConstraintName("FK__HoaDon__KhachHan__693CA210");
>>>>>>> 7eda9507ab6e95a34a1c1146c905750afc9a7e4b
        });

        modelBuilder.Entity<HoaDonChiTiet>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.HoaDonChiTietId).HasName("PK__HoaDonCh__603A404AA43CB356");
=======
            entity.HasKey(e => e.HoaDonChiTietId).HasName("PK__HoaDonCh__603A404ACABE457C");
>>>>>>> 7eda9507ab6e95a34a1c1146c905750afc9a7e4b

            entity.ToTable("HoaDonChiTiet");

            entity.Property(e => e.HoaDonChiTietId).HasColumnName("HoaDonChiTietID");
            entity.Property(e => e.Gia).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.GiamGia)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.HoaDonId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HoaDonID");
            entity.Property(e => e.MaSanPham).HasMaxLength(50);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");

            entity.HasOne(d => d.HoaDon).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.HoaDonId)
<<<<<<< HEAD
                .HasConstraintName("FK__HoaDonChi__HoaDo__59063A47");

            entity.HasOne(d => d.SanPham).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.SanPhamId)
                .HasConstraintName("FK__HoaDonChi__SanPh__59FA5E80");
=======
                .HasConstraintName("FK__HoaDonChi__HoaDo__6D0D32F4");

            entity.HasOne(d => d.SanPham).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.SanPhamId)
                .HasConstraintName("FK__HoaDonChi__SanPh__6E01572D");
>>>>>>> 7eda9507ab6e95a34a1c1146c905750afc9a7e4b
        });

        modelBuilder.Entity<HoaDonDaThanhToan>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.HoaDonId).HasName("PK__HoaDonDa__6956CE692E4BE0B8");
=======
            entity.HasKey(e => e.HoaDonId).HasName("PK__HoaDonDa__6956CE69FB2FF013");
>>>>>>> 7eda9507ab6e95a34a1c1146c905750afc9a7e4b

            entity.ToTable("HoaDonDaThanhToan");

            entity.Property(e => e.HoaDonId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HoaDonID");
            entity.Property(e => e.DiaChi).HasMaxLength(500);
            entity.Property(e => e.Gmail).HasMaxLength(255);
            entity.Property(e => e.KhachHangId).HasColumnName("KhachHangID");
            entity.Property(e => e.SoDienThoai).HasMaxLength(50);
            entity.Property(e => e.TenKhachHang).HasMaxLength(255);
            entity.Property(e => e.TongTien).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.KhachHang).WithMany(p => p.HoaDonDaThanhToans)
                .HasForeignKey(d => d.KhachHangId)
<<<<<<< HEAD
                .HasConstraintName("FK__HoaDonDaT__Khach__656C112C");
=======
                .HasConstraintName("FK__HoaDonDaT__Khach__797309D9");
>>>>>>> 7eda9507ab6e95a34a1c1146c905750afc9a7e4b
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.KhachHangId).HasName("PK__KhachHan__880F211B776377E6");
=======
            entity.HasKey(e => e.KhachHangId).HasName("PK__KhachHan__880F211B4DBACF4B");
>>>>>>> 7eda9507ab6e95a34a1c1146c905750afc9a7e4b

            entity.ToTable("KhachHang");

            entity.Property(e => e.KhachHangId).HasColumnName("KhachHangID");
<<<<<<< HEAD
            entity.Property(e => e.CapDoThanhVien).HasMaxLength(20);
=======
            entity.Property(e => e.CapDoThanhVien)
                .HasMaxLength(20)
                .HasDefaultValue("Ðô`ng");
>>>>>>> 7eda9507ab6e95a34a1c1146c905750afc9a7e4b
            entity.Property(e => e.DiaChi).HasMaxLength(500);
            entity.Property(e => e.DiemTichLuy).HasDefaultValue(0);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.SoDienThoai).HasMaxLength(50);
            entity.Property(e => e.TenKhachHang).HasMaxLength(255);
        });

        modelBuilder.Entity<KhoHang>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.KhoHangId).HasName("PK__KhoHang__652256DE0B9EA38C");
=======
            entity.HasKey(e => e.KhoHangId).HasName("PK__KhoHang__652256DE33E51575");
>>>>>>> 7eda9507ab6e95a34a1c1146c905750afc9a7e4b

            entity.ToTable("KhoHang");

            entity.Property(e => e.KhoHangId)
                .ValueGeneratedNever()
                .HasColumnName("KhoHangID");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.ViTriKho).HasMaxLength(255);

            entity.HasOne(d => d.SanPham).WithMany(p => p.KhoHangs)
                .HasForeignKey(d => d.SanPhamId)
                .HasConstraintName("FK__KhoHang__SanPham__5812160E");
        });

        modelBuilder.Entity<KhuyenMai>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.KhuyenMaiId).HasName("PK__KhuyenMa__820D747796A3CF28");
=======
            entity.HasKey(e => e.KhuyenMaiId).HasName("PK__KhuyenMa__820D7477E8D8F797");
>>>>>>> 7eda9507ab6e95a34a1c1146c905750afc9a7e4b

            entity.ToTable("KhuyenMai");

            entity.Property(e => e.KhuyenMaiId).HasColumnName("KhuyenMaiID");
            entity.Property(e => e.GiamGia).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MoTa).HasMaxLength(255);
            entity.Property(e => e.NgayBatDau).HasColumnType("datetime");
            entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");
            entity.Property(e => e.TenKhuyenMai).HasMaxLength(255);
        });

        modelBuilder.Entity<NguoiDung>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.NguoiDungId).HasName("PK__NguoiDun__C4BBA4DDD6DF7A0A");

            entity.ToTable("NguoiDung");

            entity.HasIndex(e => e.TenDangNhap, "UQ__NguoiDun__55F68FC0CFDAE21B").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__NguoiDun__A9D105341E799E18").IsUnique();
=======
            entity.HasKey(e => e.NguoiDungId).HasName("PK__NguoiDun__C4BBA4DD5931EF97");

            entity.ToTable("NguoiDung");

            entity.HasIndex(e => e.TenDangNhap, "UQ__NguoiDun__55F68FC0954F340B").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__NguoiDun__A9D105344DDA5DBF").IsUnique();
>>>>>>> 7eda9507ab6e95a34a1c1146c905750afc9a7e4b

            entity.Property(e => e.NguoiDungId).HasColumnName("NguoiDungID");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.MatKhauMaHoa).HasMaxLength(255);
            entity.Property(e => e.TenDangNhap).HasMaxLength(50);
        });

        modelBuilder.Entity<NhaCungCap>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.NhaCungCapId).HasName("PK__NhaCungC__8B8917276118754C");
=======
            entity.HasKey(e => e.NhaCungCapId).HasName("PK__NhaCungC__8B8917277EC98929");
>>>>>>> 7eda9507ab6e95a34a1c1146c905750afc9a7e4b

            entity.ToTable("NhaCungCap");

            entity.Property(e => e.NhaCungCapId)
                .ValueGeneratedNever()
                .HasColumnName("NhaCungCapID");
            entity.Property(e => e.DiaChi).HasMaxLength(500);
            entity.Property(e => e.SoDienThoai).HasMaxLength(50);
            entity.Property(e => e.TenNguoiLienHe).HasMaxLength(255);
            entity.Property(e => e.TenNhaCungCap).HasMaxLength(255);
        });

        modelBuilder.Entity<Otptable>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.Otpid).HasName("PK__OTPTable__5C2EC56231C4C927");
=======
            entity.HasKey(e => e.Otpid).HasName("PK__OTPTable__5C2EC56237097EB1");
>>>>>>> 7eda9507ab6e95a34a1c1146c905750afc9a7e4b

            entity.ToTable("OTPTable");

            entity.Property(e => e.Otpid).HasColumnName("OTPID");
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Otp)
                .HasMaxLength(6)
                .HasColumnName("OTP");
        });

        modelBuilder.Entity<PhuongThucThanhToan>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.PhuongThucThanhToanId).HasName("PK__PhuongTh__333AD28D21C55562");
=======
            entity.HasKey(e => e.PhuongThucThanhToanId).HasName("PK__PhuongTh__333AD28D9383A373");
>>>>>>> 7eda9507ab6e95a34a1c1146c905750afc9a7e4b

            entity.ToTable("PhuongThucThanhToan");

            entity.Property(e => e.PhuongThucThanhToanId)
                .ValueGeneratedNever()
                .HasColumnName("PhuongThucThanhToanID");
            entity.Property(e => e.TenPhuongThuc).HasMaxLength(255);
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.SanPhamId).HasName("PK__SanPham__05180FF4D5BC50D3");
=======
            entity.HasKey(e => e.SanPhamId).HasName("PK__SanPham__05180FF4F0254306");
>>>>>>> 7eda9507ab6e95a34a1c1146c905750afc9a7e4b

            entity.ToTable("SanPham");

            entity.Property(e => e.SanPhamId)
                .ValueGeneratedNever()
                .HasColumnName("SanPhamID");
            entity.Property(e => e.Gia).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.KichThuoc).HasMaxLength(50);
            entity.Property(e => e.MauSac).HasMaxLength(50);
            entity.Property(e => e.MoTa).HasMaxLength(255);
            entity.Property(e => e.TenSanPham).HasMaxLength(255);
            entity.Property(e => e.TenThuongHieu)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TrangThai).HasMaxLength(30);
        });

        modelBuilder.Entity<SanPhamGiamGium>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.MaSanPham).HasName("PK__SanPhamG__FAC7442D1DFDC9C3");
=======
            entity.HasKey(e => e.MaSanPham).HasName("PK__SanPhamG__FAC7442DEE285C46");
>>>>>>> 7eda9507ab6e95a34a1c1146c905750afc9a7e4b

            entity.Property(e => e.MaSanPham).ValueGeneratedNever();
            entity.Property(e => e.GiaBan).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.GiaGiam)
                .HasComputedColumnSql("([GiaBan]*((1)-[PhanTramGiam]/(100)))", false)
                .HasColumnType("decimal(21, 8)");
            entity.Property(e => e.MoTa).HasMaxLength(1000);
            entity.Property(e => e.PhanTramGiam).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.TenSanPham).HasMaxLength(255);
        });

        modelBuilder.Entity<SanPhamMua>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.SanPhamMuaId).HasName("PK__SanPhamM__AB1887E03B9CA32C");
=======
            entity.HasKey(e => e.SanPhamMuaId).HasName("PK__SanPhamM__AB1887E044EDE5B6");
>>>>>>> 7eda9507ab6e95a34a1c1146c905750afc9a7e4b

            entity.ToTable("SanPhamMua");

            entity.Property(e => e.Gia).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.HoaDonId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HoaDonID");
            entity.Property(e => e.TenSanPham).HasMaxLength(255);
            entity.Property(e => e.TenThuongHieu).HasMaxLength(255);
            entity.Property(e => e.TongGia).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.HoaDon).WithMany(p => p.SanPhamMuas)
                .HasForeignKey(d => d.HoaDonId)
<<<<<<< HEAD
                .HasConstraintName("FK__SanPhamMu__HoaDo__628FA481");
=======
                .HasConstraintName("FK__SanPhamMu__HoaDo__76969D2E");
>>>>>>> 7eda9507ab6e95a34a1c1146c905750afc9a7e4b

            entity.HasOne(d => d.HoaDonNavigation).WithMany(p => p.SanPhamMuas)
                .HasForeignKey(d => d.HoaDonId)
                .HasConstraintName("FK_SanPhamMua_HoaDonDaThanhToan");
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.MaVoucher).HasName("PK__Voucher__0AAC5B11B208410D");
=======
            entity.HasKey(e => e.MaVoucher).HasName("PK__Voucher__0AAC5B1125028091");
>>>>>>> 7eda9507ab6e95a34a1c1146c905750afc9a7e4b

            entity.ToTable("Voucher");

            entity.Property(e => e.MaVoucher).ValueGeneratedNever();
            entity.Property(e => e.DieuKienSuDung).HasColumnType("text");
            entity.Property(e => e.GiaTri).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PhanTramGiam).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.TenThuongHieu)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TenVoucher)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
