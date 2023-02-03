using DrinksWebApp.Data;
using DrinksWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DrinksWebApp.Services
{
    public class DrinkService
    {

        public DrinkService()
        {
        }

        public async Task<Drink[]> GetListAsync()
        {
            using var context = new DrinksAppContext();
            return await context.Drink.ToArrayAsync();
        }

        public async Task<Drink> GetDetails(int id)
        {
            using var context = new DrinksAppContext();
            return await context.Drink
            .Include(d => d.IngredientDrinks)
                .ThenInclude(d => d.Ingredient)
            .Include(d => d.AlcoholIngredientDrinks)
                .ThenInclude(d => d.AlcoholIngredient)
            .Where(d => d.Id == id)
            .FirstOrDefaultAsync();
        }

        public async Task Add(Drink model, int[] ingredients, int[] alcoholIngredients)
        {
            using var context = new DrinksAppContext();
            await context.Drink.AddAsync(model);
            await context.SaveChangesAsync();
            // var drink = context.Drink.LastOrDefaultAsync(x => x.Id);

            var ingredientDrinks = new List<IngredientDrink>();
            foreach(var ingredient in ingredients)
            {
                ingredientDrinks.Add(new IngredientDrink()
                {
                    DrinkId = model.Id,
                    IngredientId = ingredient,
                    Quantity = "0",
                });
            }

            var alcoholIngredientDrinks = new List<AlcoholIngredientDrink>();
            foreach (var alcoholIngredient in alcoholIngredients)
            {
                alcoholIngredientDrinks.Add(new AlcoholIngredientDrink()
                {
                    DrinkId = model.Id,
                    AlcoholIngredientId = alcoholIngredient,
                });
            }

            await context.IngredientDrink.AddRangeAsync(ingredientDrinks);
            await context.AlcoholIngredientDrink.AddRangeAsync(alcoholIngredientDrinks);
            await context.SaveChangesAsync();
        }
    }
}
