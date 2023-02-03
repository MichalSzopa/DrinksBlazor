namespace DrinksWebApp.Models
{
    public class Drink
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Recipe { get; set; }

        public virtual ICollection<IngredientDrink> IngredientDrinks { get; set; }

        public virtual ICollection<AlcoholIngredientDrink> AlcoholIngredientDrinks { get; set; }

        public virtual ICollection<Opinion> Opinion { get; set; }
    }
}
