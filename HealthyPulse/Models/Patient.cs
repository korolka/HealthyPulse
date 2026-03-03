using System;
using System.Collections.Generic;

namespace HealthyPulse.Models;

public partial class Patient
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public DateOnly DateOfBirth { get; set; }

    public virtual ICollection<Measurement> Measurements { get; set; } = new List<Measurement>();
}
