using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp1.Models;
using BlazorApp1.Data;

namespace BlazorApp1.Controllers
{
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public TestController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        [Route("test")]
        public async Task<ActionResult<Test>> PostTestAsync(Test newTest)
        {
            try
            {
                // Hash the password before storing it
                //string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newUser.hash_password);
                //newUser.hash_password = hashedPassword;

                _dbContext.test_table.Add(newTest);
                await _dbContext.SaveChangesAsync();

                return Ok("Thanks for that");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while processing your request.");
            }
        }
    }
}