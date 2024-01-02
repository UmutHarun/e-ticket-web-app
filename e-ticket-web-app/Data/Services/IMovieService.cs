using e_ticket_web_app.Data.Base;
using e_ticket_web_app.Models;

namespace e_ticket_web_app.Data.Services
{
    public interface IMovieService : IEntityBaseRepository<NewMovieVM>
    {
        public Task<NewMovieVM> GetMovieByIdAsync(int id);
    }
}
