using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp1.Models;
using BlazorApp1.Data;

namespace BlazorApp1.Controllers
{
    [Route("read-books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext; // Replace with your actual DbContext class

        public BooksController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReadBooks>>> GetBooks()
        {
            var books = await _dbContext.ReadBooks.ToListAsync();
            return Ok(books);
        }
    }
}