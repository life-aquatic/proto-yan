using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace recipe.Models
{
    public class ModifyRecipeBase
    {
        [Display(Name = "How is this aswsome dish called")]
        public string Name { get; set; }
        [Display(Name = "Is it kosher")]
        public bool IsKosher { get; set; }
    }
}
