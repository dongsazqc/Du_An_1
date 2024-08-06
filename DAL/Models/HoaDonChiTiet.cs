using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HoaDonChiTiet
{
    public int HoaDonChiTietId { get; set; }

    public string? HoaDonId { get; set; }
    public string TenSanPham {  get; set; }
    public string TenThuongHieu { get; set; }
    public int? SanPhamId { get; set; }

    public string? MaSanPham { get; set; }

    public int SoLuong { get; set; }

    public decimal Gia { get; set; }

    public decimal? GiamGia { get; set; }
    public decimal TongGia { get; set; }

    public virtual HoaDon? HoaDon { get; set; }

    public virtual SanPham? SanPham { get; set; }
}
