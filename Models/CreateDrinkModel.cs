namespace DrinksWebApp.Models
{
    public class CreateDrinkModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Recipe { get; set; }

        public List<int> Ingredients { get; set; }

        public List<int> AlcoholIngredients { get; set; }

    }
}
