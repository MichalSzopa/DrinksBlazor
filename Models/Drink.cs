namespace DrinksWebApp.Models
{
    public partial class Drink
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Recipe { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<IngredientDrink> IngredientDrinks { get; set; }

        public virtual ICollection<AlcoholIngredientDrink> AlcoholIngredientDrinks { get; set; }

        public virtual ICollection<Opinion> Opinions { get; set; }
    }
}
