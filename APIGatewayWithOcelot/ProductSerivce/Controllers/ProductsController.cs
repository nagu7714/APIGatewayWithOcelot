using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductSerivce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetProducts()
        {
            var orders = new List<string> { "Product1", "Product2" };
            return Ok(orders);
        }
    }
}
