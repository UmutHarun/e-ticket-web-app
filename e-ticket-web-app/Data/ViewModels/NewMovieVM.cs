using e_ticket_web_app.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace e_ticket_web_app.Data.ViewModels
{
    public class NewMovieVM
    {
        [Display(Name = "Movie Name")]
        [Required(ErrorMessage = "Movie Name is required")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Display(Name = "Image Url")]
        [Required(ErrorMessage = "Image Url is required")]
        public string ImageURL { get; set; }

        [Display(Name = "Start Date")]
        [Required(ErrorMessage = "Start Date is required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [Required(ErrorMessage = "End Date is required")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Movie Category")]
        [Required(ErrorMessage = "Movie Category is required")]
        public MovieCategory MovieCategory { get; set; }

        [Display(Name = "Actors")]
        [Required(ErrorMessage = "Actor is required")]
        public List<int> ActorIds { get; set; }

        [Display(Name = "Cinema")]
        [Required(ErrorMessage = "Cinema is required")]
        public int CinemaId { get; set; }

        [Display(Name = "Producer")]
        [Required(ErrorMessage = "Producer is required")]
        public int ProducerId { get; set; }
    }
}
