using HabitTracker.API.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace HabitTracker.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HabitTaskController : BaseController
    {
        public HabitTaskController()
        {
            //service injection
        }

        [HttpGet("")]
        public IActionResult GetData()
        {
            return Ok(new { message = "you have hit the endpoint" });
        }
    }
}
