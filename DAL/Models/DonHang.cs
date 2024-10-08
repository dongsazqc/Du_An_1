﻿using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class DonHang
{
    public int DonHangId { get; set; }

    public int? KhachHangId { get; set; }

    public DateTime NgayDatHang { get; set; }

    public decimal TongTien { get; set; }

    public string TrangThai { get; set; } = null!;

    public string? GhiChu { get; set; }

    public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; } = new List<ChiTietDonHang>();

    public virtual KhachHang? KhachHang { get; set; }
}
