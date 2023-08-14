using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp1.Models;
using BlazorApp1.Data;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Identity;

namespace BlazorApp1.Controllers
{
    [Route("add-user")]
    [ApiController]

    public class AddUserController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public AddUserController (ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public async Task<ActionResult<AddUser>> PostUserAsync(User newUser) // 'User' is referencing the User model
        {
            // string hashedPassword = PasswordHash.HashPassword(User.hash_password);

            _dbContext.Users.Add(newUser); // 'Users' is referencing the DB in ApplicationDbContext
            await _dbContext.SaveChangesAsync();

            return Ok("User added successfully!"); // response message if user added successfully
        }
    }
}

