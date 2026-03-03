using System;
using System.Collections.Generic;

namespace HealthyPulse.Models;

public partial class MeasurementType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Unit { get; set; } = null!;

    public virtual ICollection<Equipment> Equipment { get; set; } = new List<Equipment>();

    public virtual ICollection<Measurement> Measurements { get; set; } = new List<Measurement>();
}
