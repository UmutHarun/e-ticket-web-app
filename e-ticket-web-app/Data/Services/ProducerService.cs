using e_ticket_web_app.Data.Base;
using e_ticket_web_app.Models;

namespace e_ticket_web_app.Data.Services
{
    public class ProducerService : EntityBaseRepository<Producer> , IProducerService
    {
        private readonly ApplicationDbContext _context;

        public ProducerService(ApplicationDbContext context) : base(context)
        {

        }
    }
}
