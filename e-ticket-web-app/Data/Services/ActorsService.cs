using e_ticket_web_app.Data.Base;
using e_ticket_web_app.Models;
using Microsoft.EntityFrameworkCore;

namespace e_ticket_web_app.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor> , IActorService
    {
        private readonly ApplicationDbContext _context;

        public ActorsService(ApplicationDbContext context) : base(context)
        {

        }
    }
}
