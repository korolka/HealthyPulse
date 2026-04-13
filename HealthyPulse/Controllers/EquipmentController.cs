using HealthyPulse.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthyPulse.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EquipmentController: Controller
    {
        /// <summary>
        /// Create new equipment
        /// </summary>
        /// <param name="equipment">Equipment entity</param>
        [HttpPost]
        public IActionResult Create([FromBody] Equipment equipment)
        {
            return Ok();
        }

        /// <summary>
        /// Update existing equipment
        /// </summary>
        /// <param name="id">Equipment id</param>
        [HttpPut("id")]
        public IActionResult Update(int id)
        {
            return Ok();
        }

        /// <summary>
        /// Delete equipment
        /// </summary>
        /// <param name="id">Equipment id</param>
        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
