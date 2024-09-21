using System;
using System.Collections.Generic;

namespace demothi2.Models;

public partial class Nxb
{
    public string Manxb { get; set; } = null!;

    public string? Tennxb { get; set; }

    public virtual ICollection<Sach> Saches { get; } = new List<Sach>();
}
