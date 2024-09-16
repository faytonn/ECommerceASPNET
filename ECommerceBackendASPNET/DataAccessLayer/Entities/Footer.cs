namespace ECommerceBackendASPNET.DataAccessLayer.Entities
{
    public class Footer : Entity
    {
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Copyright { get; set; }
        public string CreatedBy { get; set; }
    }
}