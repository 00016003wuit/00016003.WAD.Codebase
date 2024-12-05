using _00016003_api_back_end.Data;
using _00016003_api_back_end.Models;
using Microsoft.EntityFrameworkCore;

namespace _00016003_api_back_end.Repositories
{
    public class NewspaperRepository : INewspaperRepository
    {
        private readonly ApplicationDbContext _context;

        public NewspaperRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Newspaper>> GetAllNewspapersAsync()
        {
            return await _context.Newspapers.ToListAsync();
        }

        public async Task<Newspaper?> GetNewspaperByIdAsync(int id)
        {
            return await _context.Newspapers.FindAsync(id);
        }

        public async Task AddNewspaperAsync(Newspaper newspaper)
        {
            await _context.Newspapers.AddAsync(newspaper);
        }

        public async Task UpdateNewspaperAsync(Newspaper newspaper)
        {
            _context.Newspapers.Update(newspaper);
        }

        public async Task DeleteNewspaperAsync(int id)
        {
            var newspaper = await _context.Newspapers.FindAsync(id);
            if (newspaper != null)
            {
                _context.Newspapers.Remove(newspaper);
            }
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
