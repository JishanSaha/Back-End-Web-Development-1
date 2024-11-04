using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Q7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q7Controller : ControllerBase
    {
        //GET localhost:xx/api/Q7/timemachine?days={days} >>>> (formatted yyyy-MM-dd), adjusted by {days}.
        [HttpGet(template: "timemachine")]
        public string timemachine(int days)
        {
            DateTime nowTime = DateTime.Now;
            DateTime addedTime = nowTime.AddDays(days);
            return addedTime.ToString("yyyy-MM-dd");
        }
    }
}
