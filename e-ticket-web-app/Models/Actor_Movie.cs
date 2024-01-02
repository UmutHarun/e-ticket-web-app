using System.ComponentModel.DataAnnotations;

namespace e_ticket_web_app.Models
{
    public class Actor_Movie
    {
        public int MovieId { get; set; }

        public NewMovieVM Movie { get; set; }

        public int ActorId { get; set; }

        public Actor Actor { get; set; }
    }
}
