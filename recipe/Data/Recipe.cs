﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace recipe.Data
{
    public class Recipe
    {
       
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public DateTime TimeToCook { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
        public bool IsKosher { get; set; }


    }
}
