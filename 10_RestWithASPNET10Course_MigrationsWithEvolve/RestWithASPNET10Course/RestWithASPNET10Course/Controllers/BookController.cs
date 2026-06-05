using Microsoft.AspNetCore.Mvc;
using RestWithASPNET10Course.Model;
using RestWithASPNET10Course.Services;

namespace RestWithASPNET10Course.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private IBookServices _bookService;

        public BookController(IBookServices bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_bookService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var book = _bookService.FindById(id);
            if (book == null) return NotFound();
            return Ok(book);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Book book)
        {
            var createdBook = _bookService.Create(book);
            if (createdBook == null) return NotFound();
            return Ok(createdBook);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Book book)
        {
            var createdBook = _bookService.Update(book);
            if (createdBook == null) return NotFound();
            return Ok(createdBook);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _bookService.Delete(id);
            return NoContent();
        }
    }
}
