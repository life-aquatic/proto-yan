using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace recipe.Data
{
    public class Cook
    {
        public Guid CookId { get; set; } // This TId pattern is identified by EF Core, and it creates a primary key
        public string Name { get; set; }
        public string Specialization { get; set; }
    }
}
