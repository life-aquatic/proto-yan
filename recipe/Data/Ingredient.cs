namespace recipe.Data
{
    public class Ingredient
    {
        

        public int IngredientId { get; set; }  // This TId pattern is identified by EF Core, and it creates a primary key
        public int RecipeId { get; set; } // EF Core interprets this TId as a foreign key
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; }
    }
}