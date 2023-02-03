namespace DrinksWebApp.Models
{
    public class AlcoholIngredient
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal AlcoholVolume { get; set; }

        public virtual ICollection<AlcoholIngredientDrink> AlcoholIngredientDrinks { get; set; }
    }
}
