using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class KhuyenMai
{
    public int KhuyenMaiId { get; set; }

    public string TenKhuyenMai { get; set; } = null!;

    public string? MoTa { get; set; }

    public decimal GiamGia { get; set; }

    public DateTime NgayBatDau { get; set; }

    public DateTime NgayKetThuc { get; set; }
}
