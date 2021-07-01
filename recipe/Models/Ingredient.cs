namespace recipe.Models
{
    public class Ingredient
    {
        public Ingredient(int ingredientId, int recipeId, string name, decimal quantity, string unit)
        {
            IngredientId = ingredientId;
            RecipeId = recipeId;
            Name = name;
            Quantity = quantity;
            Unit = unit;
        }

        public int IngredientId { get; set; }
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; }
    }
}