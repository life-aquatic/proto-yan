using Microsoft.AspNetCore.Mvc;
using recipe.Data;
using recipe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace recipe.Controllers
{
    public class RecipeController : Controller
    {
        
        public RecipeService _recipeService;

        public RecipeController(RecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        public IActionResult Index()
        {
            var models = _recipeService.GetRecipes();
            return View(models);
        }
        public IActionResult CreateRecipe()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateRecipe(Models.CreateRecipeCommand model)
        {
            if (ModelState.IsValid)
            {
                int resultantId = _recipeService.CreateRecipe(model);
                return RedirectToAction("RecipeDetails", new { zd = resultantId });
            }
            return View();
        }

        public IActionResult UpdateRecipe(int id)
        {
            UpdateRecipeCommand model = _recipeService.UpdateRecipe(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateRecipe(int id, Models.UpdateRecipeCommand model)
        {
            if (ModelState.IsValid)
            {
                string editingResult = _recipeService.UpdateRecipe(id, model);
                return RedirectToAction("RecipeDetails", new { zd = id }); // what the fuuuuk this "new" is here for?
            }
            return View(model);
        }

        public IActionResult RecipeDetails(int zd)
        {
            Recipe model = _recipeService.GetRecipe(zd);
            return View(model);
        }
    }
}
