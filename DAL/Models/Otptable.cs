using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Otptable
{
    public int Otpid { get; set; }

    public string Email { get; set; } = null!;

    public string Otp { get; set; } = null!;

    public DateTime CreatedAt { get; set; }
}
