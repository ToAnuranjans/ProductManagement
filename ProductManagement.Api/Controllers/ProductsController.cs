using Microsoft.AspNetCore.Mvc;

namespace ProductManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Products : ControllerBase
    {
        public Products()
        {
        }

        [HttpGet]
        public string Get() => "Hello World";
    }
}
