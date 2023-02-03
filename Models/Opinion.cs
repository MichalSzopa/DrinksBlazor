namespace DrinksWebApp.Models
{
    public class Opinion
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public int Rate { get; set; }

        public virtual Drink Drink { get; set; }
    }
}
