using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BlazorApp1.Models;
using BlazorApp1.Data;
using BCrypt;

namespace BlazorApp1.Controllers
{
    [Route("add-user")]
    [ApiController]
    public class AddUserController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public AddUserController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public async Task<ActionResult<User>> PostUserAsync(User newUser)
        {
            // Hash the password before storing it
            //string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newUser.hash_password);
            //newUser.hash_password = hashedPassword;

            _dbContext.Users.Add(newUser);
            await _dbContext.SaveChangesAsync();

            return Ok("Thanks for registering " + newUser.first_name);
        }
    }
}
