using e_ticket_web_app.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace e_ticket_web_app.Models
{
    public class Actor : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is Required")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Name is Required")]
        [StringLength(50,MinimumLength = 3,ErrorMessage = "Full Name must be between 3 and 50 chars")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is Required")]
        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie>? Actor_Movies { get; set; }
    }
}
