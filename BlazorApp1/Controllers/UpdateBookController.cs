using BlazorApp1.Data;
using BlazorApp1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

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