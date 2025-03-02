using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {

        [HttpGet]
        public ActionResult GetOrders()
        {
            var orders = new List<string> { "Order1", "Order2" };
            return Ok(orders);
        }
    }
}
