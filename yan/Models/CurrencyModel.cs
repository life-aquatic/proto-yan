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
        [Display(Name = "Display name for currencyIn")]
        [StringLength(2, ErrorMessage = "I want it shorter")]
        public string CurrencyIn { get; set; }
        [Display(Name = "Display name for currencyOut")]
        public string CurrencyOut { get; set; }
        [Display(Name = "Display name for amount")]
        public int Amount { get; set; }

    }
}
