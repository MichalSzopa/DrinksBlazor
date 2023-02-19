using static DrinksWebApp.Shared.Enums;

namespace DrinksWebApp.Models
{
    public partial class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public UserType Type { get; set; }

        public virtual ICollection<Opinion> Opinions { get; set; }

        public virtual ICollection<Drink> Drinks { get; set; }
    }
}
