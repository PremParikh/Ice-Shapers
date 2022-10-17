using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ice_Shapers.Models;

namespace Ice_Shapers.Data
{
    public class Ice_ShapersContext : DbContext
    {
        public Ice_ShapersContext (DbContextOptions<Ice_ShapersContext> options)
            : base(options)
        {
        }

        public DbSet<Ice_Shapers.Models.Ice> Ice { get; set; }
    }
}
