using BlazorApp1.Models;
using BlazorApp1.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Services
{
    public class BooksService
    {
        private readonly ApplicationDbContext _dbContext;

        public BooksService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Books>> GetBooksAsync()
        {
            return await _dbContext.Books.ToListAsync();
        }
    }
}