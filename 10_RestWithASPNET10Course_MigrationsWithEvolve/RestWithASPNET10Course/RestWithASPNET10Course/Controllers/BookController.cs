using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNET10Course.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(book);
        }
    }
}
