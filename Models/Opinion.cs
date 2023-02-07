using Microsoft.EntityFrameworkCore.Query;

namespace DrinksWebApp.Models
{
    public partial class Opinion
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public int Rate { get; set; }

        public int DrinkId { get; set; }

        public virtual Drink Drink { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
