using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Q4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q4Controller : ControllerBase
    {
        //POST : api/Q4/knockknock >>>> "Who's there?"
        [HttpPost(template:"knockknock")]
        public string knockknock()
        {
            return "Who's there?";
        }
    }
}
