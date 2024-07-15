using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class KhoHang
{
    public int KhoHangId { get; set; }

    public int? SanPhamId { get; set; }

    public int SoLuong { get; set; }

    public string? ViTriKho { get; set; }

    public virtual SanPham? SanPham { get; set; }
}
