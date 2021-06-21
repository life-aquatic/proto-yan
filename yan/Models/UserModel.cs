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
        [StringLength(50, ErrorMessage ="max 5")]
        [Display(Name = "User's name")]
        public string Name { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "emeil no good")]
        [Display(Name = "email address")]
        public string Email { get; set; }
        [Required]
        [Phone]
        [Display(Name = "phone")]
        public string PhoneNumber { get; set; }
    }
}
