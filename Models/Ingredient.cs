namespace DrinksWebApp.Models
{
    public class Ingredient
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<IngredientDrink> IngredientDrinks { get; set; }
    }
}
