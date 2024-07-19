using System;
using System.Collections.Generic;

namespace PRL.Models;

public partial class DonHang
{
    public int DonHangId { get; set; }

    public int? KhachHangId { get; set; }

    public DateTime NgayDatHang { get; set; }

    public decimal TongTien { get; set; }

    public string TrangThai { get; set; } = null!;

    public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; } = new List<ChiTietDonHang>();

    public virtual KhachHang? KhachHang { get; set; }
}
