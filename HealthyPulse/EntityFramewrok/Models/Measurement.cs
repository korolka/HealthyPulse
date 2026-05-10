using System;
using System.Collections.Generic;

namespace HealthyPulse.EntityFramewrok.Models;

public partial class Measurement
{
    public int Id { get; set; }

    public int PatientId { get; set; }

    public int DoctorId { get; set; }

    public int EquipmentId { get; set; }

    public int MeasurementTypeId { get; set; }

    public string MeasurementValue { get; set; } = null!;

    public virtual Doctor Doctor { get; set; } = null!;

    public virtual Equipment Equipment { get; set; } = null!;

    public virtual MeasurementType MeasurementType { get; set; } = null!;

    public virtual Patient Patient { get; set; } = null!;
}
