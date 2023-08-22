using BlazorApp1.Models;
using BlazorApp1.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Services
{
    public class FriendsService
    {
        private readonly ApplicationDbContext _dbContext;

        public FriendsService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _dbContext.Users.ToListAsync(); // at some point change this to get data from a Friends table instead. Users is just placeholder for now
        }
    }
}