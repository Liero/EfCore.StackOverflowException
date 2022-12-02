using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using EfCoreApp;
#nullable disable


public class Program
{
    public static async Task Main()

    {
        var productCode = "1-XXXX";
        using (var context = new ManufactureDbContext())
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            context.ČíselníkVýrobky.Add(new ()
            {
                Kód = productCode,
                MaterialItems =
                {
                    new() {  Material = new() { KódMateriálu = "001"  } }
                }
            });
            context.SaveChanges();
        }

        using (var context = new ManufactureDbContext())
        {
            var product = await context.ČíselníkVýrobky.Include(e => e.MaterialItems).FirstAsync(p => p.Kód == productCode);
            var material = product.MaterialItems.First();
            product!.MaterialItems.Remove(material);
            foreach(var e in context.ChangeTracker.Entries())
            {
                Console.WriteLine("This is never executes");
            }
        }

    }
}

