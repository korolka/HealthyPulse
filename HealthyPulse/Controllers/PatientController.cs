using Microsoft.AspNetCore.Mvc;

namespace HealthyPulse.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientController : Controller
    {
        [HttpPost]
        public IActionResult Create()
        {
            return Ok();
        }

        [HttpPut("id")]
        public IActionResult Update(int id)
        {
            return Ok();
        }

        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }

    }
}
