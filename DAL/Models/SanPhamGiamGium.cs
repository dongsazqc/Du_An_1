using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SanPhamGiamGium
{
    public int IdsanPham { get; set; }

    public string? TenSanPham { get; set; }

    public decimal? GiaBan { get; set; }

    public decimal? PhanTramGiam { get; set; }

    public decimal? GiaGiam { get; set; }

    public DateTime NgayBatDauGiamGia { get; set; }

    public DateTime NgayKetThucGiamGia { get; set; }

    public string? MoTa { get; set; }
}
