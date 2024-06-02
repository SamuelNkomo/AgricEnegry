using AuthSystem.Areas.Identity.Data;

namespace AuthSystem.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string FarmerId { get; set; }
        public ApplicationUser Farmer { get; set; }
    }
}
