﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp1.Models;
using BlazorApp1.Data;

namespace BlazorApp1.Controllers
{
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext; // Replace with your actual DbContext class

        public UsersController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("users")]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var users = await _dbContext.Users.ToListAsync();
            return Ok(users);
        }

        [HttpPost]
        [Route("add-user")]
        public async Task<ActionResult<User>> PostUserAsync(User newUser)
        {
            try
            {
                // Hash the password before storing it
                //string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newUser.hash_password);
                //newUser.hash_password = hashedPassword;

                _dbContext.Users.Add(newUser);
                await _dbContext.SaveChangesAsync();

                return Ok("Thanks for registering " + newUser.first_name);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while processing your request.");
            }
        }
    }
}