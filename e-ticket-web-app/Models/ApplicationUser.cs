using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace e_ticket_web_app.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
    }
}
