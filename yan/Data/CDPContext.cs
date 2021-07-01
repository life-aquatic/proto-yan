using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proto.Models;
using Microsoft.EntityFrameworkCore;

namespace proto.Data
{
    public class CDPContext : DbContext
    {
        public CDPContext(DbContextOptions<CDPContext> options) : base(options)
        {
        }

        public DbSet<CDPQuant> CDPQuants { get; set; }
    }

}
