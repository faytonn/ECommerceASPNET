namespace ECommerceBackendASPNET.DataAccessLayer.Entities
{
    public class Header : Entity
    {
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Currency { get; set; }
        public string AboutUsText { get; set; }
        public string AboutUsDescription { get; set; }
    }
}