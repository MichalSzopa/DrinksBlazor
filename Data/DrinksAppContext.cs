using Microsoft.EntityFrameworkCore;
using DrinksWebApp.Models;

namespace DrinksWebApp.Data
{
    public class DrinksAppContext : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=databaza.db");
        }

        public DbSet<Ingredient> Ingredient { get; set; }

        public DbSet<AlcoholIngredient> AlcoholIngredient { get; set; }

        public DbSet<Drink> Drink { get; set; }

        public DbSet<AlcoholIngredientDrink> AlcoholIngredientDrink { get; set; }

        public DbSet<IngredientDrink> IngredientDrink { get; set; }

        public DbSet<Opinion> Opinion { get; set; }
    }
}
