using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class NguoiDung
{
    public int NguoiDungId { get; set; }

    public string TenDangNhap { get; set; } = null!;

    public string MatKhauMaHoa { get; set; } = null!;

    public string Email { get; set; } = null!;
}
