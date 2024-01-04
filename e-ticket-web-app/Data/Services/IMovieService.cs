using e_ticket_web_app.Data.Base;
using e_ticket_web_app.Data.ViewModels;
using e_ticket_web_app.Models;

namespace e_ticket_web_app.Data.Services
{
    public interface IMovieService : IEntityBaseRepository<Movie>
    {
        public Task<Movie> GetMovieByIdAsync(int id);

        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();

        Task AddNewMovie(NewMovieVM newMovie);

        Task UpdateMovie(NewMovieVM movie);
    }
}
