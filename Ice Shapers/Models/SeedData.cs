using System;
using System.Collections.Generic;
using System.Linq;
using Ice_Shapers.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Ice_Shapers.Models
{
    public static class Seeddata
    { 

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Ice_ShapersContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Ice_ShapersContext>>()))
            {
                // Look for any movies.
                if (context.Ice.Any())
                {
                    

                context.Ice.AddRange(
                    new Ice
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M
                    },

                    new Ice
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M
                    },

                    new Ice
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M
                    },

                    new Ice
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
                return;   // DB has been seeded
            }
        }
    }
}
