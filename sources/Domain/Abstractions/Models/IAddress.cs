namespace TheSharpFactory.Domain.Models
{
    public interface IAddress
    {
        string ApartmentName { get; set; }
        string ApartmentNumber { get; set; }
        string Block { get; set; }
        string City { get; set; }
        string Country { get; set; }
        string PostalCode { get; set; }
        string RoadNumber { get; set; }
        string State { get; set; }
    }
}