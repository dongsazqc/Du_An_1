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

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<KhoHang> KhoHangs { get; set; }

    public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }

    public virtual DbSet<NguoiDung> NguoiDungs { get; set; }

    public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }

    public virtual DbSet<PhuongThucThanhToan> PhuongThucThanhToans { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<SanPhamGiamGium> SanPhamGiamGia { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DUONG;Initial Catalog=Du_An_Nhom4;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChiTietDonHang>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.ChiTietDonHangId).HasName("PK__ChiTietD__45B33F8304975F3A");
=======
            entity.HasKey(e => e.ChiTietDonHangId).HasName("PK__ChiTietD__45B33F83A17A04F6");
>>>>>>> a890bca49fd4f66c1cd817d9021778ee5ecb2ff7

            entity.ToTable("ChiTietDonHang");

            entity.Property(e => e.ChiTietDonHangId)
                .ValueGeneratedNever()
                .HasColumnName("ChiTietDonHangID");
            entity.Property(e => e.DonHangId).HasColumnName("DonHangID");
            entity.Property(e => e.Gia).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");

            entity.HasOne(d => d.DonHang).WithMany(p => p.ChiTietDonHangs)
                .HasForeignKey(d => d.DonHangId)
<<<<<<< HEAD
                .HasConstraintName("FK__ChiTietDo__DonHa__3E52440B");

            entity.HasOne(d => d.SanPham).WithMany(p => p.ChiTietDonHangs)
                .HasForeignKey(d => d.SanPhamId)
                .HasConstraintName("FK__ChiTietDo__SanPh__3F466844");
=======
                .HasConstraintName("FK__ChiTietDo__DonHa__5070F446");

            entity.HasOne(d => d.SanPham).WithMany(p => p.ChiTietDonHangs)
                .HasForeignKey(d => d.SanPhamId)
                .HasConstraintName("FK__ChiTietDo__SanPh__5165187F");
>>>>>>> a890bca49fd4f66c1cd817d9021778ee5ecb2ff7
        });

        modelBuilder.Entity<DanhGium>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.DanhGiaId).HasName("PK__DanhGia__52C0CA250431E84A");
=======
            entity.HasKey(e => e.DanhGiaId).HasName("PK__DanhGia__52C0CA25D2B27A6C");
>>>>>>> a890bca49fd4f66c1cd817d9021778ee5ecb2ff7

            entity.Property(e => e.DanhGiaId)
                .ValueGeneratedNever()
                .HasColumnName("DanhGiaID");
            entity.Property(e => e.KhachHangId).HasColumnName("KhachHangID");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");

            entity.HasOne(d => d.KhachHang).WithMany(p => p.DanhGia)
                .HasForeignKey(d => d.KhachHangId)
<<<<<<< HEAD
                .HasConstraintName("FK__DanhGia__KhachHa__4BAC3F29");

            entity.HasOne(d => d.SanPham).WithMany(p => p.DanhGia)
                .HasForeignKey(d => d.SanPhamId)
                .HasConstraintName("FK__DanhGia__SanPham__4AB81AF0");
=======
                .HasConstraintName("FK__DanhGia__KhachHa__5DCAEF64");

            entity.HasOne(d => d.SanPham).WithMany(p => p.DanhGia)
                .HasForeignKey(d => d.SanPhamId)
                .HasConstraintName("FK__DanhGia__SanPham__5CD6CB2B");
>>>>>>> a890bca49fd4f66c1cd817d9021778ee5ecb2ff7
        });

        modelBuilder.Entity<DonHang>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.DonHangId).HasName("PK__DonHang__D159F4DE91AE60E3");
=======
            entity.HasKey(e => e.DonHangId).HasName("PK__DonHang__D159F4DEF524783E");
>>>>>>> a890bca49fd4f66c1cd817d9021778ee5ecb2ff7

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
<<<<<<< HEAD
                .HasConstraintName("FK__DonHang__KhachHa__3B75D760");
=======
                .HasConstraintName("FK__DonHang__KhachHa__4D94879B");
>>>>>>> a890bca49fd4f66c1cd817d9021778ee5ecb2ff7
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.HoaDonId).HasName("PK__HoaDon__6956CE69BD30F0F3");
=======
            entity.HasKey(e => e.HoaDonId).HasName("PK__HoaDon__6956CE693BE296B6");
>>>>>>> a890bca49fd4f66c1cd817d9021778ee5ecb2ff7

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
                .HasConstraintName("FK__HoaDon__KhachHan__52593CB8");

            entity.HasOne(d => d.PhuongThucThanhToan).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.PhuongThucThanhToanId)
                .HasConstraintName("FK__HoaDon__PhuongTh__534D60F1");
=======
                .HasConstraintName("FK__HoaDon__KhachHan__6477ECF3");

            entity.HasOne(d => d.PhuongThucThanhToan).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.PhuongThucThanhToanId)
                .HasConstraintName("FK__HoaDon__PhuongTh__656C112C");
>>>>>>> a890bca49fd4f66c1cd817d9021778ee5ecb2ff7
        });

        modelBuilder.Entity<HoaDonChiTiet>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.HoaDonChiTietId).HasName("PK__HoaDonCh__603A404A845EA2E2");
=======
            entity.HasKey(e => e.HoaDonChiTietId).HasName("PK__HoaDonCh__603A404AC79BA36E");
>>>>>>> a890bca49fd4f66c1cd817d9021778ee5ecb2ff7

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
                .HasConstraintName("FK__HoaDonChi__HoaDo__571DF1D5");

            entity.HasOne(d => d.SanPham).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.SanPhamId)
                .HasConstraintName("FK__HoaDonChi__SanPh__5812160E");
=======
                .HasConstraintName("FK__HoaDonChi__HoaDo__693CA210");

            entity.HasOne(d => d.SanPham).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.SanPhamId)
                .HasConstraintName("FK__HoaDonChi__SanPh__6A30C649");
>>>>>>> a890bca49fd4f66c1cd817d9021778ee5ecb2ff7
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.KhachHangId).HasName("PK__KhachHan__880F211B5403D0E3");
=======
            entity.HasKey(e => e.KhachHangId).HasName("PK__KhachHan__880F211B08C1A4F3");
>>>>>>> a890bca49fd4f66c1cd817d9021778ee5ecb2ff7

            entity.ToTable("KhachHang");

            entity.Property(e => e.KhachHangId)
                .ValueGeneratedNever()
                .HasColumnName("KhachHangID");
            entity.Property(e => e.DiaChi).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.GioiTinh).HasMaxLength(10);
            entity.Property(e => e.SoDienThoai).HasMaxLength(50);
            entity.Property(e => e.TenKhachHang).HasMaxLength(255);
        });

        modelBuilder.Entity<KhoHang>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.KhoHangId).HasName("PK__KhoHang__652256DEFEA3B154");
=======
            entity.HasKey(e => e.KhoHangId).HasName("PK__KhoHang__652256DEDDBFE655");
>>>>>>> a890bca49fd4f66c1cd817d9021778ee5ecb2ff7

            entity.ToTable("KhoHang");

            entity.Property(e => e.KhoHangId)
                .ValueGeneratedNever()
                .HasColumnName("KhoHangID");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.ViTriKho).HasMaxLength(255);

            entity.HasOne(d => d.SanPham).WithMany(p => p.KhoHangs)
                .HasForeignKey(d => d.SanPhamId)
<<<<<<< HEAD
                .HasConstraintName("FK__KhoHang__SanPham__440B1D61");
=======
                .HasConstraintName("FK__KhoHang__SanPham__5629CD9C");
>>>>>>> a890bca49fd4f66c1cd817d9021778ee5ecb2ff7
        });

        modelBuilder.Entity<KhuyenMai>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.KhuyenMaiId).HasName("PK__KhuyenMa__820D7477D584E101");
=======
            entity.HasKey(e => e.KhuyenMaiId).HasName("PK__KhuyenMa__820D7477ED8FD66C");
>>>>>>> a890bca49fd4f66c1cd817d9021778ee5ecb2ff7

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
            entity.HasKey(e => e.NguoiDungId).HasName("PK__NguoiDun__C4BBA4DDE6882CD0");

            entity.ToTable("NguoiDung");

            entity.HasIndex(e => e.TenDangNhap, "UQ__NguoiDun__55F68FC057514DD5").IsUnique();
=======
            entity.HasKey(e => e.NguoiDungId).HasName("PK__NguoiDun__C4BBA4DD2A4D33DD");

            entity.ToTable("NguoiDung");

            entity.HasIndex(e => e.TenDangNhap, "UQ__NguoiDun__55F68FC0F28BAB41").IsUnique();
>>>>>>> a890bca49fd4f66c1cd817d9021778ee5ecb2ff7

            entity.Property(e => e.NguoiDungId)
                .ValueGeneratedNever()
                .HasColumnName("NguoiDungID");
            entity.Property(e => e.MatKhauMaHoa).HasMaxLength(255);
            entity.Property(e => e.TenDangNhap).HasMaxLength(255);
            entity.Property(e => e.VaiTro).HasMaxLength(50);
        });

        modelBuilder.Entity<NhaCungCap>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.NhaCungCapId).HasName("PK__NhaCungC__8B891727D51BBA40");
=======
            entity.HasKey(e => e.NhaCungCapId).HasName("PK__NhaCungC__8B89172798F341D0");
>>>>>>> a890bca49fd4f66c1cd817d9021778ee5ecb2ff7

            entity.ToTable("NhaCungCap");

            entity.Property(e => e.NhaCungCapId)
                .ValueGeneratedNever()
                .HasColumnName("NhaCungCapID");
            entity.Property(e => e.DiaChi).HasMaxLength(500);
            entity.Property(e => e.SoDienThoai).HasMaxLength(50);
            entity.Property(e => e.TenNguoiLienHe).HasMaxLength(255);
            entity.Property(e => e.TenNhaCungCap).HasMaxLength(255);
        });

        modelBuilder.Entity<PhuongThucThanhToan>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.PhuongThucThanhToanId).HasName("PK__PhuongTh__333AD28DFC7FDD50");
=======
            entity.HasKey(e => e.PhuongThucThanhToanId).HasName("PK__PhuongTh__333AD28DCB2E383A");
>>>>>>> a890bca49fd4f66c1cd817d9021778ee5ecb2ff7

            entity.ToTable("PhuongThucThanhToan");

            entity.Property(e => e.PhuongThucThanhToanId)
                .ValueGeneratedNever()
                .HasColumnName("PhuongThucThanhToanID");
            entity.Property(e => e.TenPhuongThuc).HasMaxLength(255);
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.SanPhamId).HasName("PK__SanPham__05180FF4D7A4FAAA");
=======
            entity.HasKey(e => e.SanPhamId).HasName("PK__SanPham__05180FF496866F10");
>>>>>>> a890bca49fd4f66c1cd817d9021778ee5ecb2ff7

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
            entity.HasKey(e => e.MaSanPham).HasName("PK__SanPhamG__FAC7442DC6FADFBC");
=======
            entity.HasKey(e => e.MaSanPham).HasName("PK__SanPhamG__FAC7442DE3899CA4");
>>>>>>> a890bca49fd4f66c1cd817d9021778ee5ecb2ff7

            entity.Property(e => e.MaSanPham).ValueGeneratedNever();
            entity.Property(e => e.GiaBan).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.GiaGiam)
                .HasComputedColumnSql("([GiaBan]*((1)-[PhanTramGiam]/(100)))", false)
                .HasColumnType("decimal(21, 8)");
            entity.Property(e => e.MoTa).HasMaxLength(1000);
            entity.Property(e => e.PhanTramGiam).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.TenSanPham).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
