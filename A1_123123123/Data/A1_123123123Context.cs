using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using A1_123123123.Models;

namespace A1_123123123.Models
{
    public class A1_123123123Context : DbContext
    {
        public A1_123123123Context (DbContextOptions<A1_123123123Context> options)
            : base(options)
        {
        }

        public DbSet<A1_123123123.Models.Animal> Animal { get; set; }

        public DbSet<A1_123123123.Models.PetFood> PetFood { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PetFood>().HasData(new PetFood() { AnimalId = 2, Id = 2, Name = "Cheapfood", Brand = "PetSmart", Description = "The cheapest of cheap", NutritionalInfo = "ha!", Price = 12.99m, Weight = 20 },
                new PetFood() { AnimalId = 1, Id = 3, Name = "Cheapfood", Brand = "PetSmart", Description = "The cheapest of cheap", NutritionalInfo = "ha!", Price = 12.99m, Weight = 20 } );

            modelBuilder.Entity<Animal>().HasData(new Animal() { Description = "Moos a lot", Id = 3, Name = "Cow" },
                new Animal() { Id = 4, Name = "Donkey", Description = "Waffles" });
        }
    }
}
