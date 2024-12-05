using _00016003_api_back_end.Data;
using _00016003_api_back_end.Models;
using Microsoft.EntityFrameworkCore;

namespace _00016003_api_back_end.Repositories
{
    public class NewspaperRepository : INewspaperRepository
    {
        // 00016003
        private readonly ApplicationDbContext _context;

        public NewspaperRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Newspaper>> GetAllNewspapersAsync()
        {
            return await _context.Newspapers.ToListAsync();
        }
        // 00016003
        public async Task<Newspaper?> GetNewspaperByIdAsync(int id)
        {
            return await _context.Newspapers.FindAsync(id);
        }
        // 00016003
        public async Task AddNewspaperAsync(Newspaper newspaper)
        {
            await _context.Newspapers.AddAsync(newspaper);
        }// 00016003

        public async Task UpdateNewspaperAsync(Newspaper newspaper)
        {
            _context.Newspapers.Update(newspaper);
        }
        // 00016003
        public async Task DeleteNewspaperAsync(int id)
        {
            var newspaper = await _context.Newspapers.FindAsync(id);
            if (newspaper != null)
            {
                _context.Newspapers.Remove(newspaper);
            }
        }
        // 00016003
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
// 00016003