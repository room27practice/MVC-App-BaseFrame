namespace Infrastructure.Models
{
    public class Category : BaseEntity<int>
    {
        public Category()
        {

        }
        public string Color { get; set; }

    }
}