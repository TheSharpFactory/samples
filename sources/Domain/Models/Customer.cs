namespace TheSharpFactory.Domain.Models
{
    public class Customer
        : ICustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public ICustomerProfile Profile { get; set; }
    }
}
