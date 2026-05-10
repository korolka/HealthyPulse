namespace HealthyPulse.EntityFramewrok.Models;

public partial class Doctor
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public DateOnly DateOfBirth { get; set; }

    public DateOnly DayStartOfWork { get; set; }

    public virtual ICollection<Measurement> Measurements { get; set; } = new List<Measurement>();
}
