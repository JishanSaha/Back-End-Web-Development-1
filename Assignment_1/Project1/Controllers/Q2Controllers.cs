using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Q2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q2Controller : ControllerBase
    {
        // GET localhost:xx/api/Q2/greeting??name=Gary >>>> "Hi Gary!"
        // GET localhost:xx/api/Q2/greetingname=Ren%C3%A9e >>>> "Hi Renée!"
        [HttpGet(template: "greeting")]
        public string Q2(string name)
        {
            return $"Hi {name}!";
        }
    }
}
        // GET localhost:xx/api/Q2/greeting?name= >>>> "Hi Renee!"
       /* [HttpGet(template:"greetingname2")]
        public string greetingname2()
        {
            return "Hi Renee!";
        }
    }
}
       */