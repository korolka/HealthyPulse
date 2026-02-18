namespace HealthyPulse.Models
{
    public class Patient
    {

        /// <summary>
        /// Patient name
        /// </summary>
        /// <example>Andrei</example>
        public string FirstName { get; set; }

        /// <summary>
        /// Patient last name
        /// </summary>
        /// <example>Martseniuk</example>
        public string LastName { get; set; }

        /// <summary>
        /// Patient`s date of birth
        /// </summary>
        /// <example>1984-01-10T20:45:34.910Z</example>
        public DateTime DateOfBirth { get; set; }
    }
}
