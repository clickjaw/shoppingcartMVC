using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShoppingCartMVC.Models;

namespace ShoppingCartMVC.Infrastructure
{
    public class DataContext : IdentityDbContext<AppUser>
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


       

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {


        }





    }
}




