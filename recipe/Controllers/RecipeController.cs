using Microsoft.AspNetCore.Mvc;
using recipe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace recipe.Controllers
{
    public class RecipeController : Controller
    {
        Ingredient Maslo;
        Ingredient Bulka;
        Recipe Buter;
        private Ingredient Manka;
        private Ingredient Grecka;
        private Recipe Kafka;

        public RecipeController()
        {
            Maslo = new Ingredient(1, 1, "Maslo", 23, "kg");
            Bulka = new Ingredient(2, 1, "Bulka", 123, "kusok");
            Buter = new Recipe(1, "buterbrod", new Ingredient[] { Maslo, Bulka });
            Manka = new Ingredient(3, 2, "Manka", 567, "ounce");
            Grecka = new Ingredient(4, 2, "Grecka", 12, "kusok");
            Kafka = new Recipe(2, "kasha", new Ingredient[] { Manka, Grecka });
        }

        public IActionResult Index()
        {
            ViewData["Recipes"] = new Recipe[] { Buter, Kafka };
            return View();
        }
        public IActionResult RView(int zd)
        {
            Recipe RecipeToView = zd==1?Buter: Kafka;
            ViewData["Ingredients"] = RecipeToView.Ingredients;
            return View();
        }
    }
}
