using System;
using System.Collections.Generic;

namespace PRL.Models;

public partial class NhaCungCap
{
    public int NhaCungCapId { get; set; }

    public string TenNhaCungCap { get; set; } = null!;

    public string? TenNguoiLienHe { get; set; }

    public string? SoDienThoai { get; set; }

    public string? DiaChi { get; set; }
}
