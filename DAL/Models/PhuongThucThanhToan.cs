using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class PhuongThucThanhToan
{
    public int PhuongThucThanhToanId { get; set; }

    public string TenPhuongThuc { get; set; } = null!;

    public string? ChiTiet { get; set; }
}
