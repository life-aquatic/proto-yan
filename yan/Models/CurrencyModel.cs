using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace proto.Models
{
    public class CurrencyModel
    {
        [Required]
        [Display(Name = "Your name")]
        [StringLength(10)]
        public string CurrencyIn { get; set; }
        public string CurrencyOut { get; set; }
        public int Amount { get; set; }

    }
}
