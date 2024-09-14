namespace ECommerceBackendASPNET.DataAccessLayer.Entities
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
