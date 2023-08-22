using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp1.Models;
using BlazorApp1.Data;

namespace BlazorApp1.Controllers
{
    [Route("books")] // endpoint name
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public BooksController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }



        // get a list of all the books from 'books' table
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Books>>> GetBooks()
        {
            var books = await _dbContext.Books.ToListAsync();
            return Ok(books);
        }



        // remove book by its ID
        [HttpDelete("remove-book")]
        public async Task<IActionResult> RemoveBookAsync(RemoveBook book_id) // Modify parameter types as needed
        {
            var existingBook = await _dbContext.Books.FindAsync(book_id.book_id); // Find the book by its ID

            if (existingBook == null)
            {
                return NotFound();
            }

            _dbContext.Books.Remove(existingBook); // Remove the book from the context

            await _dbContext.SaveChangesAsync();

            return Ok("Book has been removed from your list.");
        }



        // allow user to update status of book by changing the page number they are on
        [HttpPut("update-book-status")]
        public async Task<IActionResult> UpdateBookStatusAsync(UpdateBookStatus updateParams)
        {
            var existingBook = await _dbContext.Books.FindAsync(updateParams.book_id);

            if (existingBook == null)
            {
                return NotFound();
            }

            if (updateParams.hasbeenread != null)
            {
                existingBook.hasbeenread = updateParams.hasbeenread;
            }

            if (updateParams.page_number != null)
            {
                existingBook.page_number = updateParams.page_number;
            }

            await _dbContext.SaveChangesAsync();

            return Ok("Book status updated successfully!");
        }
    }
}