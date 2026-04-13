namespace HealthyPulse.Models
{
    public class Doctor
    {
        /// <summary>
        /// Doctor name
        /// </summary>
        /// <example>Vlad</example>
        public string FirstName { get; set; }

        /// <summary>
        /// Doctor last name
        /// </summary>
        /// <example>Martseniuk</example>
        public string LastName { get; set; }

        /// <summary>
        /// Doctor`s date of birth
        /// </summary>
        /// <example>2001-02-17T20:45:34.910Z</example>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Doctor`s day start of work
        /// </summary>
        /// <example>2025-01-01T20:45:34.910Z</example>
        public DateTime DayStartOfWork { get; set; }
    }
}