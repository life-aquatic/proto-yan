using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace proto.Models
{
    public class UserModel
    {
        [Required]
        [StringLength(50, ErrorMessage ="max 50")]
        [Display(Name = "User's name")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "email address")]
        public string Email { get; set; }
        [Required]
        [Phone(ErrorMessage = "make this phone number valid somehow (but I don't know the rules either)")]
        [Display(Name = "email address")]
        public string PhoneNumber { get; set; }
    }
}
