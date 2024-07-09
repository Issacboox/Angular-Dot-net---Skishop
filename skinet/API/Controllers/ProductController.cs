using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string GetProducts()
        {
            return "this will be product list";
        }

        [HttpGet("{id}")]
        public string GetProduct(int id)
        {
            return "this will be product";
        }
    }
}
