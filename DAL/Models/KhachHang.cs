using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class KhachHang
{
    public int KhachHangId { get; set; }

    public string TenKhachHang { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? SoDienThoai { get; set; }

    public string? DiaChi { get; set; }

    public bool? GioiTinh { get; set; }

    public virtual ICollection<DanhGium> DanhGia { get; set; } = new List<DanhGium>();

    public virtual ICollection<DonHang> DonHangs { get; set; } = new List<DonHang>();

    public virtual ICollection<HoaDonDaThanhToan> HoaDonDaThanhToans { get; set; } = new List<HoaDonDaThanhToan>();

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
