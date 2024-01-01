using e_ticket_web_app.Data.Base;
using e_ticket_web_app.Models;

namespace e_ticket_web_app.Data.Services
{
    public class CinemaService : EntityBaseRepository<Cinema> , ICinemaService
    {
        private readonly ApplicationDbContext _context;

        public CinemaService(ApplicationDbContext context) : base(context)
        {

        }
    }
}
