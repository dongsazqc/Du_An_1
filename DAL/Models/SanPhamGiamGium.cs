using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SanPhamGiamGium
{
    public int MaSanPham { get; set; }

    public string TenSanPham { get; set; }

    public decimal GiaBan { get; set; }

    public decimal PhanTramGiam { get; set; }

    public decimal GiaGiam { get; set; }

    public DateOnly NgayBatDauGiamGia { get; set; }

    public DateOnly NgayKetThucGiamGia { get; set; }

    public string MoTa { get; set; }
}
