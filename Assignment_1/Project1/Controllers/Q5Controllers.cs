using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Q5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q5Controller : ControllerBase
    {
        //POST localhost:xx/api/Q5/secret >>>> "Shh.. the secret is number"
        [HttpPost(template: "secret")]
        public string Q5([FromBody] int integer)
        {

            return $"Shh.. the secret is {integer}";
        }
    }
}
