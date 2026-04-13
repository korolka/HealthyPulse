using HealthyPulse.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

namespace HealthyPulse.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MeasurementController : Controller
    {
        /// <summary>
        /// Create new measurement 
        /// </summary>
        /// <param name="measurement">Measurement entity</param>
        [HttpPost]
        public IActionResult Create([FromBody] Measurement measurement)
        {
            return Ok();
        }

        /// <summary>
        /// Update existing measurement 
        /// </summary>
        /// <param name="id">Measurement id</param>
        [HttpPut("id")]
        public IActionResult Update(int id)
        {
            return Ok();
        }

        /// <summary>
        /// Delete measurement 
        /// </summary>
        /// <param name="id">Measurement id</param>
        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
