using recipe.Data;

namespace recipe.Models
{
    public class RecipeSummaryViewModel
    {
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public string TimeToCook { get; set; }
    }
}