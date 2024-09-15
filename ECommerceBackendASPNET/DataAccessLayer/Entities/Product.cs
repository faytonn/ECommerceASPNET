namespace ECommerceBackendASPNET.DataAccessLayer.Entities
{
    public class Product : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public double OldPrice { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }


    }
}
