using e_ticket_web_app.Data.Base;
using e_ticket_web_app.Models;
using Microsoft.EntityFrameworkCore;

namespace e_ticket_web_app.Data.Services
{
    public class MovieService : EntityBaseRepository<NewMovieVM> , IMovieService
    {
        private readonly ApplicationDbContext _context;

        public MovieService(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<NewMovieVM> GetMovieByIdAsync(int id)
        {
            var movieDetails = await _context.Movies
                .Include(x => x.Cinema)
                .Include(y => y.Producer)
                .Include(z => z.Actor_Movies).ThenInclude(x => x.Actor).FirstOrDefaultAsync(x => x.Id == id);

            return movieDetails;
        }
    }
}
