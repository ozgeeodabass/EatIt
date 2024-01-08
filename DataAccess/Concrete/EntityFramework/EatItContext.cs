using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EatItContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog= EatItDb; Integrated Security=true");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
       .HasOne(e => e.OperationClaim)
       .WithMany(e => e.Users)
       .HasForeignKey(e => e.UserId)
       .IsRequired();

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Cuisine> Cuisines { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }


    }
}
