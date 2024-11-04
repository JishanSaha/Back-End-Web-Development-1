using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Q3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q3Controller : ControllerBase
    {
        //GET localhost:xx/api/Q3/cube >>>> "Cube"
        [HttpGet(template:"cube/{number}")]
        public int Q3(int number)
        {
            int cubenum = number * number * number;
                return cubenum;
        }
    }
}
