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

    public virtual DbSet<SanPhamMua> SanPhamMuas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DUONG;Initial Catalog=Du_An_Nhom4;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChiTietDonHang>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.ChiTietDonHangId).HasName("PK__ChiTietD__45B33F83EB4B4E85");
=======
            entity.HasKey(e => e.ChiTietDonHangId).HasName("PK__ChiTietD__45B33F8393B8CFF1");
>>>>>>> 15f4cb6e96f33567415dc420506b2be08472c2f7

            entity.ToTable("ChiTietDonHang");

            entity.Property(e => e.ChiTietDonHangId)
                .ValueGeneratedNever()
                .HasColumnName("ChiTietDonHangID");
            entity.Property(e => e.DonHangId).HasColumnName("DonHangID");
            entity.Property(e => e.Gia).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");

            entity.HasOne(d => d.DonHang).WithMany(p => p.ChiTietDonHangs)
                .HasForeignKey(d => d.DonHangId)
                .HasConstraintName("FK__ChiTietDo__DonHa__5070F446");

            entity.HasOne(d => d.SanPham).WithMany(p => p.ChiTietDonHangs)
                .HasForeignKey(d => d.SanPhamId)
                .HasConstraintName("FK__ChiTietDo__SanPh__5165187F");
        });

        modelBuilder.Entity<DanhGium>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.DanhGiaId).HasName("PK__DanhGia__52C0CA252C564BD2");
=======
            entity.HasKey(e => e.DanhGiaId).HasName("PK__DanhGia__52C0CA2586A29C57");
>>>>>>> 15f4cb6e96f33567415dc420506b2be08472c2f7

            entity.Property(e => e.DanhGiaId)
                .ValueGeneratedNever()
                .HasColumnName("DanhGiaID");
            entity.Property(e => e.KhachHangId).HasColumnName("KhachHangID");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");

            entity.HasOne(d => d.KhachHang).WithMany(p => p.DanhGia)
                .HasForeignKey(d => d.KhachHangId)
                .HasConstraintName("FK__DanhGia__KhachHa__5DCAEF64");

            entity.HasOne(d => d.SanPham).WithMany(p => p.DanhGia)
                .HasForeignKey(d => d.SanPhamId)
                .HasConstraintName("FK__DanhGia__SanPham__5CD6CB2B");
        });

        modelBuilder.Entity<DonHang>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.DonHangId).HasName("PK__DonHang__D159F4DEF6B15B8A");
=======
            entity.HasKey(e => e.DonHangId).HasName("PK__DonHang__D159F4DE4D38A8E6");
>>>>>>> 15f4cb6e96f33567415dc420506b2be08472c2f7

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
                .HasConstraintName("FK__DonHang__KhachHa__4D94879B");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.HoaDonId).HasName("PK__HoaDon__6956CE692B702603");
=======
            entity.HasKey(e => e.HoaDonId).HasName("PK__HoaDon__6956CE69EB0A46A0");
>>>>>>> 15f4cb6e96f33567415dc420506b2be08472c2f7

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
            entity.Property(e => e.TenThuongHieu).HasMaxLength(255);
            entity.Property(e => e.TongTien).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TrangThai).HasMaxLength(50);

            entity.HasOne(d => d.KhachHang).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.KhachHangId)
                .HasConstraintName("FK__HoaDon__KhachHan__6477ECF3");

            entity.HasOne(d => d.PhuongThucThanhToan).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.PhuongThucThanhToanId)
                .HasConstraintName("FK__HoaDon__PhuongTh__656C112C");
        });

        modelBuilder.Entity<HoaDonChiTiet>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.HoaDonChiTietId).HasName("PK__HoaDonCh__603A404A9EA8CB60");
=======
            entity.HasKey(e => e.HoaDonChiTietId).HasName("PK__HoaDonCh__603A404ADBDC44C6");
>>>>>>> 15f4cb6e96f33567415dc420506b2be08472c2f7

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
                .HasConstraintName("FK__HoaDonChi__HoaDo__693CA210");

            entity.HasOne(d => d.SanPham).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.SanPhamId)
                .HasConstraintName("FK__HoaDonChi__SanPh__6A30C649");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.KhachHangId).HasName("PK__KhachHan__880F211BDEC8B80D");
=======
            entity.HasKey(e => e.KhachHangId).HasName("PK__KhachHan__880F211B2D425907");
>>>>>>> 15f4cb6e96f33567415dc420506b2be08472c2f7

            entity.ToTable("KhachHang");

            entity.Property(e => e.KhachHangId)
                .ValueGeneratedNever()
                .HasColumnName("KhachHangID");
            entity.Property(e => e.DiaChi).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.SoDienThoai).HasMaxLength(50);
            entity.Property(e => e.TenKhachHang).HasMaxLength(255);
        });

        modelBuilder.Entity<KhoHang>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.KhoHangId).HasName("PK__KhoHang__652256DE19B54E4B");
=======
            entity.HasKey(e => e.KhoHangId).HasName("PK__KhoHang__652256DE586C814B");
>>>>>>> 15f4cb6e96f33567415dc420506b2be08472c2f7

            entity.ToTable("KhoHang");

            entity.Property(e => e.KhoHangId)
                .ValueGeneratedNever()
                .HasColumnName("KhoHangID");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.ViTriKho).HasMaxLength(255);

            entity.HasOne(d => d.SanPham).WithMany(p => p.KhoHangs)
                .HasForeignKey(d => d.SanPhamId)
                .HasConstraintName("FK__KhoHang__SanPham__5629CD9C");
        });

        modelBuilder.Entity<KhuyenMai>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.KhuyenMaiId).HasName("PK__KhuyenMa__820D747798CF537A");
=======
            entity.HasKey(e => e.KhuyenMaiId).HasName("PK__KhuyenMa__820D74777B686D31");
>>>>>>> 15f4cb6e96f33567415dc420506b2be08472c2f7

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
            entity.HasKey(e => e.NguoiDungId).HasName("PK__NguoiDun__C4BBA4DDDADC1DFA");

            entity.ToTable("NguoiDung");

            entity.HasIndex(e => e.TenDangNhap, "UQ__NguoiDun__55F68FC0B2A88EBC").IsUnique();
=======
            entity.HasKey(e => e.NguoiDungId).HasName("PK__NguoiDun__C4BBA4DD7B155F64");

            entity.ToTable("NguoiDung");

            entity.HasIndex(e => e.TenDangNhap, "UQ__NguoiDun__55F68FC04AB4DB6F").IsUnique();
>>>>>>> 15f4cb6e96f33567415dc420506b2be08472c2f7

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
            entity.HasKey(e => e.NhaCungCapId).HasName("PK__NhaCungC__8B891727C5C1EDCE");
=======
            entity.HasKey(e => e.NhaCungCapId).HasName("PK__NhaCungC__8B891727F919C346");
>>>>>>> 15f4cb6e96f33567415dc420506b2be08472c2f7

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
            entity.HasKey(e => e.PhuongThucThanhToanId).HasName("PK__PhuongTh__333AD28D8CDCE20B");
=======
            entity.HasKey(e => e.PhuongThucThanhToanId).HasName("PK__PhuongTh__333AD28D30398CFF");
>>>>>>> 15f4cb6e96f33567415dc420506b2be08472c2f7

            entity.ToTable("PhuongThucThanhToan");

            entity.Property(e => e.PhuongThucThanhToanId)
                .ValueGeneratedNever()
                .HasColumnName("PhuongThucThanhToanID");
            entity.Property(e => e.TenPhuongThuc).HasMaxLength(255);
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.SanPhamId).HasName("PK__SanPham__05180FF46C9456B7");
=======
            entity.HasKey(e => e.SanPhamId).HasName("PK__SanPham__05180FF4A5E657A7");
>>>>>>> 15f4cb6e96f33567415dc420506b2be08472c2f7

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
            entity.HasKey(e => e.MaSanPham).HasName("PK__SanPhamG__FAC7442D55E6E2EF");
=======
            entity.HasKey(e => e.MaSanPham).HasName("PK__SanPhamG__FAC7442D4DA6867B");
>>>>>>> 15f4cb6e96f33567415dc420506b2be08472c2f7

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
            entity.HasKey(e => e.SanPhamMuaId).HasName("PK__SanPhamM__AB1887C0A8B5BA49");

            entity.ToTable("SanPhamMua");

            entity.Property(e => e.SanPhamMuaId).HasColumnName("SanPhamMuaID");
            entity.Property(e => e.Gia).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TenSanPham).HasMaxLength(255);
            entity.Property(e => e.TenThuongHieu)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TongGia).HasColumnType("decimal(18, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
