using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HoaDon
{
    public string HoaDonId { get; set; } = null!;

    public int? KhachHangId { get; set; }

    public DateTime NgayLapHoaDon { get; set; }

    public decimal TongTien { get; set; }

    public string TrangThai { get; set; } = null!;

    public int? PhuongThucThanhToanId { get; set; }

    public string? TenKhachHang { get; set; }

    public string? Gmail { get; set; }

    public string? SoDienThoai { get; set; }

    public string? DiaChi { get; set; }

    public virtual KhachHang? KhachHang { get; set; }

    public virtual ICollection<SanPhamMua> SanPhamMuas { get; set; } = new List<SanPhamMua>();
    public List<SanPhamMua> sanPhamMuas { get; set; }
}
