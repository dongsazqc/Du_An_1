using System;
using System.Collections.Generic;

namespace PRL.Models;

public partial class NguoiDung
{
    public int NguoiDungId { get; set; }

    public string TenDangNhap { get; set; } = null!;

    public string MatKhauMaHoa { get; set; } = null!;

    public string VaiTro { get; set; } = null!;
}
