using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Q8Controller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q8Controller : ControllerBase
    {
        [HttpPost(template: "squashfellows")]
        public string squashfellows([FromForm] int small, [FromForm] int large)
        {
            double price1 = small * 25.50;
            double price2 = large * 40.50;
            double totalPrice = price1 + price2;
            double tax = Math.Round(totalPrice * 0.13, 2);
            double total = totalPrice + tax;

            var culture = new CultureInfo("en-CA");

            string strvalue1 = price1.ToString("C2", culture);
            string strvalue2 = price2.ToString("C2", culture);
            string strtotalprice = totalPrice.ToString("C2", culture);
            string strtax = tax.ToString("C2", culture);
            string strtotal = total.ToString("C2", culture);
            return $"{small} Small @ 25.50 = {strvalue1}; {large} Large @ 40.50 = {strvalue2}; Subtotal = {strtotalprice}; Tax = {strtax} HST; Total = {strtotal}";
        }

    }
}