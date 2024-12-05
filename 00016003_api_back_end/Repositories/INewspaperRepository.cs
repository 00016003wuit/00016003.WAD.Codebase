using _00016003_api_back_end.Models;
// 00016003
namespace _00016003_api_back_end.Repositories
{
    public interface INewspaperRepository
    {
        Task<IEnumerable<Newspaper>> GetAllNewspapersAsync();
        Task<Newspaper?> GetNewspaperByIdAsync(int id);
        Task AddNewspaperAsync(Newspaper newspaper);
        Task UpdateNewspaperAsync(Newspaper newspaper);
        Task DeleteNewspaperAsync(int id);
        Task SaveAsync();
    }
}
// 00016003