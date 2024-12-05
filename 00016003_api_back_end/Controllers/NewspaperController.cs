using _00016003_api_back_end.Models;
using _00016003_api_back_end.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace _00016003_api_back_end.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewspaperController : ControllerBase
    {
        private readonly INewspaperRepository _repository;

        public NewspaperController(INewspaperRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Newspaper
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Newspaper>>> GetNewspapers()
        {
            var newspapers = await _repository.GetAllNewspapersAsync();
            return Ok(newspapers);
        }

        // POST: api/Newspaper
        [HttpPost]
        public async Task<ActionResult> CreateNewspaper(Newspaper newspaper)
        {
            await _repository.AddNewspaperAsync(newspaper);
            await _repository.SaveAsync();
            return CreatedAtAction(nameof(GetNewspapers), new { id = newspaper.Id }, newspaper);
        }

        // PUT: api/Newspaper/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateNewspaper(int id, Newspaper newspaper)
        {
            if (id != newspaper.Id)
            {
                return BadRequest();
            }

            await _repository.UpdateNewspaperAsync(newspaper);
            await _repository.SaveAsync();
            return NoContent();
        }

        // DELETE: api/Newspaper/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNewspaper(int id)
        {
            await _repository.DeleteNewspaperAsync(id);
            await _repository.SaveAsync();
            return NoContent();
        }
    }
}
