using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EatItContext:DbContext
    { 

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog= EatItDb; Integrated Security=true");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>()
       .HasOne(r => r.Cuisine)
       .WithMany(c => c.Recipes)
       .HasForeignKey(r => r.CuisineId)
       .IsRequired();

            modelBuilder.Entity<Recipe>()
      .HasOne(r => r.User)
      .WithMany(u => u.Recipes)
      .HasForeignKey(r => r.UserId)
      .IsRequired();

      

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Cuisine> Cuisines { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
     

    }
}
