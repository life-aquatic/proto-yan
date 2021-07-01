using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace recipe.Models
{
    public class Recipe
    {
        public Recipe(int recipeId, string name, ICollection<Ingredient> ingredients)
        {
            RecipeId = recipeId;
            Name = name;
            Ingredients = ingredients;
        }

        public int RecipeId { get; set; }
        public string Name { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }


    }
}
