using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp1.Models;
using BlazorApp1.Data;
using System.Reflection.Metadata.Ecma335;

namespace BlazorApp1.Controllers
{
    [Route("add-book")]
    [ApiController]

    public class AddBookController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public AddBookController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public async Task<ActionResult<Books>> PostBookAsync(Books newBook) // Books is referencing the Books model
        {
            _dbContext.Books.Add(newBook); // Books is referencing the DB in ApplicationDbContext
            await _dbContext.SaveChangesAsync();

            return Ok("Book has been added to user successfully"); // response message if book added successfully
        }
    }
}

