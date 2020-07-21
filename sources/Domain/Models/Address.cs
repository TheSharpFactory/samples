namespace TheSharpFactory.Domain.Models
{
    public class Address
        : IAddress
    {
        public string ApartmentName { get; set; }
        public string ApartmentNumber { get; set; }
        public string RoadNumber { get; set; }
        public string Block { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
