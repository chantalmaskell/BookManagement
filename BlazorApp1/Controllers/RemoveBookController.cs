using BlazorApp1.Data;
using BlazorApp1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Controllers
{
    [Route("remove-book")]
    [ApiController]
    public class RemoveBookController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public RemoveBookController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpDelete]
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
    }
}