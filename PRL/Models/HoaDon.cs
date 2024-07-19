using System;
using System.Collections.Generic;

namespace PRL.Models;

public partial class HoaDon
{
    public int HoaDonId { get; set; }

    public int? KhachHangId { get; set; }

    public DateTime NgayLapHoaDon { get; set; }

    public decimal TongTien { get; set; }

    public string TrangThai { get; set; } = null!;

    public int? PhuongThucThanhToanId { get; set; }

    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    public virtual KhachHang? KhachHang { get; set; }

    public virtual PhuongThucThanhToan? PhuongThucThanhToan { get; set; }
}
