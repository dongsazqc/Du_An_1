using System;
using System.Collections.Generic;

namespace PRL.Models;

public partial class Voucher
{
    public int MaVoucher { get; set; }

    public string TenVoucher { get; set; } = null!;

    public string TenThuongHieu { get; set; } = null!;

    public decimal PhanTramGiam { get; set; }

    public decimal GiaTri { get; set; }

    public DateOnly NgayBatDau { get; set; }

    public DateOnly NgayKetThuc { get; set; }

    public string? DieuKienSuDung { get; set; }
}
