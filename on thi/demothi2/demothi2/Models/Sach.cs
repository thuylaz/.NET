using System;
using System.Collections.Generic;

namespace demothi2.Models;

public partial class Sach
{
    public string Masach { get; set; } = null!;

    public string? Tensach { get; set; }

    public string? Manxb { get; set; }

    public int? Sotrang { get; set; }

    public virtual Nxb? ManxbNavigation { get; set; }
}
