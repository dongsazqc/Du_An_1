using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class DanhGium
{
    public int DanhGiaId { get; set; }

    public int? SanPhamId { get; set; }

    public int? KhachHangId { get; set; }

    public int DanhGia { get; set; }

    public string? BinhLuan { get; set; }

    public virtual KhachHang? KhachHang { get; set; }

    public virtual SanPham? SanPham { get; set; }
}
