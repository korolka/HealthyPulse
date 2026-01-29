using Microsoft.AspNetCore.Mvc;

namespace HealthyPulse.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DoctorController : Controller
    {
        [HttpPost]
        public IActionResult Create()//record
        {
            return Ok();
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            return Ok();
        }
    }
}
