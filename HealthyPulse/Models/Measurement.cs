namespace HealthyPulse.Models
{
    public class Measurement
    {
        /// <summary>
        /// Patiend by id
        /// </summary>
        /// <example>1</example>
        public int PatientId { get; set; }
        /// <summary>
        /// Doctor by id
        /// </summary>
        /// <example>1</example>
        public int DoctorId { get; set; }

        /// <summary>
        /// Equipment by id
        /// </summary>
        /// <example>1</example>
        public int EquipmentId { get; set; }

        /// <summary>
        /// MeasurementType by id
        /// </summary>
        /// <example>1</example>
        public int MeasurementTypeId { get; set; }

        /// <summary>
        /// Value of measurement
        /// </summary>
        /// <example>120/60</example>
        public string MeasurementValue { get; set; }
    }
}
