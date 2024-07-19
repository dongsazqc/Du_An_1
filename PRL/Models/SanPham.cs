using System;
using System.Collections.Generic;

namespace PRL.Models;

public partial class SanPham
{
    public int SanPhamId { get; set; }

    public string TenSanPham { get; set; } = null!;

    public string TenThuongHieu { get; set; } = null!;

    public string? MoTa { get; set; }

    public decimal Gia { get; set; }

    public int SoLuongTonKho { get; set; }

    public string? KichThuoc { get; set; }

    public string? MauSac { get; set; }

    public string? TrangThai { get; set; }

    public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; } = new List<ChiTietDonHang>();

    public virtual ICollection<DanhGium> DanhGia { get; set; } = new List<DanhGium>();

    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    public virtual ICollection<KhoHang> KhoHangs { get; set; } = new List<KhoHang>();
}
