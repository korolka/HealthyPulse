using HealthyPulse.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthyPulse.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientController : Controller
    {
        /// <summary>
        /// Create new Patient 
        /// </summary>
        /// <param name="patient">Patient entity</param>
        [HttpPost]
        public IActionResult Create([FromBody] Patient patient)
        {
            return Ok();
        }

        /// <summary>
        /// Update existing Patient 
        /// </summary>
        /// <param name="id">Patient id</param>
        [HttpPut("id")]
        public IActionResult Update(int id)
        {
            return Ok();
        }

        /// <summary>
        /// Delete Patient 
        /// </summary>
        /// <param name="id">Patient id</param>
        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }

    }
}
