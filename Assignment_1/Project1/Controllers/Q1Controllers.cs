using Microsoft.AspNetCore.Mvc;

namespace Q1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q1Controller : ControllerBase
    {
        // GET localhost:xx/api/Q1/welcome >>>> "Welcome to 5125!"
        [HttpGet(template: "welcome")]
        public string welcome()
        {
            return "Welcome to 5125!";
        }
    }
}