using BlazorApp1.Data;
using BlazorApp1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Controllers
{
    [Route("update-book-status")]
    [ApiController]
    public class UpdateBookController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public UpdateBookController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBookStatusAsync(UpdateBookStatus book_id) // Modify parameter types as needed
        {
            var existingBook = await _dbContext.Books.FindAsync(book_id.book_id); // Find the existing book by its ID

            if (existingBook == null)
            {
                return NotFound();
            }

            // Update only the specific property you want
            existingBook.hasbeenread = book_id.hasbeenread;

            await _dbContext.SaveChangesAsync();

            return Ok("Book status updated successfully!");
        }

    }
}
