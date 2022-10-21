using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace softSys_1.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Context(serviceProvider.GetRequiredService<DbContextOptions<Context>>()))
            {
                if (context.users.Any())
                {
                    return;
                }
                List<users> user = new List<users> {
                    new users {Name= "Tyler"},
                    new users {Name= "Josh"}
                } ;
                context.AddRange(user);

                List<delivs> del = new List<delivs> {
                    new delivs {DriverName= "Jorge", address= "A Street"},
                    new delivs {DriverName= "Carter", address= "C Street"}
                };
                context.AddRange(del);

                List<Stores> store = new List<Stores> {
                    new Stores {StoreName= "Bakery", food="Bread", address= "A Street"},
                    new Stores {StoreName= "Hatchery", food="Eggs", address= "C Street"}
                };
                context.AddRange(store);
                context.SaveChanges();
            }
        }
    }
}