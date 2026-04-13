using System;
using System.Collections.Generic;

namespace HealthyPulse.EntityFramewrok.Models;

public partial class Equipment
{
    public int Id { get; set; }

    public string ModelName { get; set; } = null!;

    public int MeasurementType { get; set; }

    public virtual MeasurementType MeasurementTypeNavigation { get; set; } = null!;

    public virtual ICollection<Measurement> Measurements { get; set; } = new List<Measurement>();
}
