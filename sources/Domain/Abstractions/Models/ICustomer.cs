namespace TheSharpFactory.Domain.Models
{
    public interface ICustomer
    {
        int Id { get; set; }
        string Name { get; set; }
        string PhoneNumber { get; set; }
        ICustomerProfile Profile { get; set; }
    }
}