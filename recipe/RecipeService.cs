using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using recipe.Data;
using recipe.Models;

namespace recipe
{
    public class RecipeService
    {
        public RecipeService(RecDbContext context)
        {
            _context = context;
        }

        private RecDbContext _context { get; set; }

        //public int CreateRecipe(RecipeModel model)
        //{
        //    throw new NotImplementedException();
        //}

        public int CreateRecipe(CreateRecipeCommand cmd)
        {
            var recipe = new Recipe
            {
                Name = cmd.Name,
                IsKosher = cmd.IsKosher,
                Ingredients = cmd.Ingredients?.Select(item => new Ingredient
                {
                    Name = item.Name,
                    Quantity = item.Quantity,
                    Unit = item.Unit
                }).ToList()
            };
            _context.Add(recipe);
            _context.SaveChanges();

            return recipe.RecipeId;
        }

        public Recipe GetDetails(int zd)
        {
            Recipe model = _context.Recipes.Find(zd);
            if (model != null)
            {
                return model;
            }
            return new Recipe { Name = "Dummy" }; //In ideal world I should be returning not "Recipe" here (which is a part of the business logic) but some model entity
        }

        //this method gets things from db and I have (?) to use Linq Select to shape the amorphic DBSet output into my RecipeViewModel (which is just a meaningless obertka on top of Data.Recipe class)
        //page 359 says that I need this in order to map the output to objects different from entities in my database
        public ICollection<RecipeSummaryViewModel> GetRecipes()
        {
            return _context.Recipes.Select(i => new RecipeSummaryViewModel { Name = i.Name, TimeToCook = i.TimeToCook.ToString("HH:mm:ss"), RecipeId = i.RecipeId }).ToList();
        }
        public RecipeDetailsModel GetRecipe(int id)
        {
            return _context.Recipes
                .Where(i => i.RecipeId == id)
                .Select(i => new RecipeDetailsModel {
                    Name = i.Name,
                    TimeToCook = i.TimeToCook.ToString("HH:mm:ss"),
                    Ingredients = i.Ingredients, //I could have added a .Select(x => new IngredientViewModel here if I was paid by the number or lines of code (p. 361)
                })
                .SingleOrDefault();
        }
        public UpdateRecipeCommand UpdateRecipe(int id)
        {
            Recipe recipe = _context.Recipes.Find(id);
            UpdateRecipeCommand currentVictim = new UpdateRecipeCommand
            {
                Name = recipe.Name,
                IsKosher = recipe.IsKosher
            };
            return currentVictim;
        }

        public string UpdateRecipe(int id, UpdateRecipeCommand cmd) //page 363 - the author of this book implemented it in a cleaner way
        {
            Recipe recipe = _context.Recipes.Find(id);
            if (recipe == null)
            {
                return "No such recipe";
            }
            recipe.Name = cmd.Name;
            recipe.IsKosher = cmd.IsKosher;
            _context.SaveChanges();
            return "Recipe updated";
        }
    }
}
