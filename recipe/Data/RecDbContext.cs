using Microsoft.EntityFrameworkCore;
using recipe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace recipe.Data
{
    public class RecDbContext : DbContext
    {
        public RecDbContext(DbContextOptions<RecDbContext> options) : base(options)
        {
        }

        public DbSet<Recipe> Recipes { get; set; } // I will use Recipes property to query the database. this magic line add classes that will be written into DB (afaIu).
                                                   // It is an IQueryable, so I can use Select() and Where(). EF core will convert those to SQL statements 
                                                   // when I execute them using ToList(), ToArray() or Single(). I can also use Select() to map the output to other options
    }
}
