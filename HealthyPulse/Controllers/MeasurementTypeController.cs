using HealthyPulse.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthyPulse.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MeasurementTypeController : Controller
    {
        /// <summary>
        /// Create new measurementType 
        /// </summary>
        /// <param name="measurementType">MeasurementType entity</param>
        [HttpPost]
        public IActionResult Create([FromBody] MeasurementType measurementType)
        {
            return Ok();
        }

        /// <summary>
        /// Update existing measurementType 
        /// </summary>
        /// <param name="id">MeasurementType id</param>
        [HttpPut("id")]
        public IActionResult Update(int id)
        {
            return Ok();
        }

        /// <summary>
        /// Delete measurementType 
        /// </summary>
        /// <param name="id">MeasurementType id</param>
        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
