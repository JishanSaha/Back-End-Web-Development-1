using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace Q6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q6Controller : ControllerBase
    {
        //GET localhost:xx/api/Q6/hexagonside >>>> [S]
        [HttpGet(template: "hexagonside")]
        public double Q6(double area)
        {
            double areaInHex = Math.Sqrt(3) * 3 * area * area;
            double areaAct = areaInHex / 2;
            return areaAct;
        }
    }
}
