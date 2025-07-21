using Microsoft.AspNetCore.Mvc;
using BookCatalogApi.Models;

namespace BookCatalogApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private static List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "1984", Author = "George Orwell", Year = 1949 },
            new Book { Id = 2, Title = "Clean Code", Author = "Robert C. Martin", Year = 2008 }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Book>> Get() => books;

        [HttpGet("{id}")]
        public ActionResult<Book> Get(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            return book is null ? NotFound() : Ok(book);
        }

        [HttpPost]
        public ActionResult<Book> Post(Book book)
        {
            book.Id = books.Max(b => b.Id) + 1;
            books.Add(book);
            return CreatedAtAction(nameof(Get), new { id = book.Id }, book);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Book updatedBook)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book is null) return NotFound();

            book.Title = updatedBook.Title;
            book.Author = updatedBook.Author;
            book.Year = updatedBook.Year;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book is null) return NotFound();

            books.Remove(book);
            return NoContent();
        }
    }
}
