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
            
        }

        public IActionResult Index()
        {
           
            return View();
        }
        public IActionResult RView(int zd)
        {
            
            return View();
        }
    }
}
