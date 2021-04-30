using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proto.Models;


namespace proto.Data
{
    public class DbInitializer
    {
        public static void Initialize(CDPContext context)
        {
            context.Database.EnsureCreated();
            context.SaveChanges();
        }
    }
}
