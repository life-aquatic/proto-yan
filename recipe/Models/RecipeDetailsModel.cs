using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using recipe.Data;

namespace recipe.Models
{
    public class RecipeDetailsModel : Recipe
    {
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public string TimeToCook { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
