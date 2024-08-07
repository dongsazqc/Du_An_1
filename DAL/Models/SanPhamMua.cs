using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SanPhamMua
{
    public int SanPhamMuaId { get; set; }

    public string TenSanPham { get; set; } = null!;

    public string TenThuongHieu { get; set; } = null!;

    public int SoLuong { get; set; }

    public decimal Gia { get; set; }

    public decimal? TongGia { get; set; }

    public string? HoaDonId { get; set; }

    public virtual HoaDon? HoaDon { get; set; }
}
