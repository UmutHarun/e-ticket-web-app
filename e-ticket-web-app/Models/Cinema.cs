using e_ticket_web_app.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace e_ticket_web_app.Models
{
    public class Cinema : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Logo Picture")]
        public string LogoUrl { get; set; }

        [Display(Name = "Cinema Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        //Relationships
        public List<NewMovieVM>? Movies { get; set; }
    }
}
