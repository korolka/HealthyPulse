using HealthyPulse.Models;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace HealthyPulse.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DoctorController : Controller
    {
        /// <summary>
        /// Create new doctor
        /// </summary>
        /// <param name="doctor">Doctor entity</param>
        [HttpPost]
        public IActionResult Create([FromBody] Doctor doctor)//record
        {
            return Ok();
        }

        /// <summary>
        /// Get doctor by id
        /// </summary>
        /// <param name="id">Doctor id</param>
        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            return Ok();
        }
    }
}
