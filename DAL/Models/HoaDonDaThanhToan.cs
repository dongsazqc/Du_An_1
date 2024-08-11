using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HoaDonDaThanhToan
{
    public string HoaDonId { get; set; } = null!;

    public int? KhachHangId { get; set; }

    public decimal TongTien { get; set; }

    public string? TenKhachHang { get; set; }

    public string? Gmail { get; set; }

    public string? SoDienThoai { get; set; }

    public string? DiaChi { get; set; }

    public List<SanPhamMua> sanPhamMuas { get; set; }
    public virtual KhachHang? KhachHang { get; set; }

<<<<<<< HEAD
=======
    public virtual KhachHang? KhachHang { get; set; }

>>>>>>> 7eda9507ab6e95a34a1c1146c905750afc9a7e4b
    public virtual ICollection<SanPhamMua> SanPhamMuas { get; set; } = new List<SanPhamMua>();
}
