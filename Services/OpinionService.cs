using DrinksWebApp.Data;
using DrinksWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DrinksWebApp.Services
{
    public class OpinionService
    {
        public async Task<ICollection<Opinion>> GetByDrinkId(int drinkId)
        {
            using var context = new DrinksAppContext();
            return await context.Opinion.Where(o => o.DrinkId == drinkId).ToListAsync();
        }

        public async Task Add(Opinion opinion)
        {
            using var context = new DrinksAppContext();
            await context.AddAsync(opinion);
            await context.SaveChangesAsync();
        }
    }
}
