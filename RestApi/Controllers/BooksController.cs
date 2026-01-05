using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApi.Models;

namespace RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        static private List<Book> books = new List<Book>
        {
            new Book {
                Id = 1,
                Title = "1984",
                Author = "George Orwell",
                YearPublished = "1949"
            },
            new Book {
                Id = 2,
                Title = "To Kill a Mockingbird",
                Author = "Harper Lee",
                YearPublished = "1960"
            },
            new Book {
                Id = 3,
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                YearPublished = "1925"
            },
            new Book {
                Id = 4,
                Title = "Pride and Prejudice",
                Author = "Jane Austen",
                YearPublished = "1813"
            }
        };
        [HttpGet]
        public ActionResult
    }
}
