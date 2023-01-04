using Microsoft.EntityFrameworkCore;
using ShoppingCartMVC.Models;

namespace ShoppingCartMVC.Infrastructure
{
    public class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            context.Database.Migrate();

            if (!context.Products.Any())
            {
                
                Category usedgames = new Category { Name = "UsedGames", Slug = "usedgames" };
                Category newgames = new Category { Name = "NewGames", Slug = "newgames" };

                context.Products.AddRange(
                        new Product
                        {
                            Name = "Pokemon Blue",
                            Slug = "pokemon-blue",
                            Description = "The game that started it all.",
                            Price = 20M,
                            Category = usedgames,
                            Image = "pokemonblue.jpg"
                        },
                        new Product
                        {
                            Name = "Hogwarts Legacy",
                            Slug = "hogwarts-legacy",
                            Description = "Journey into Hogwarts as a student of your own making.",
                            Price = 59.99M,
                            Category = newgames,
                            Image = "hogwartslegacy.jpg"
                        }
                );

                context.SaveChanges();
            }
        }
    }
}