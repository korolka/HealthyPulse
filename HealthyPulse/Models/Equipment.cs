namespace HealthyPulse.Models
{
    public class Equipment
    {
        /// <summary>
        /// Equipment model name
        /// </summary>
        /// <example>Tonometer SilverCloud MB23 Electronic arm with LCD Screen and Voice Alert</example>
        public string ModelName { get; set; }

        /// <summary>
        /// Measurement id (1 - blood pressure, 2 - heart rate, 3 - blood sugar)
        /// </summary>
        /// <example>1</example>
        public int MeasurementType { get; set; }
    }
}
