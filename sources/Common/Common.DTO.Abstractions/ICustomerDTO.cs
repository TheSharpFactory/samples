using Newtonsoft.Json;

namespace TheSharpFactory.Common.DTO
{

    public interface ICustomerDTO
        : IDto
    {
        string Id { get; set; }
        string Name { get; set; }
        string Phone { get; set; }

#if netstandard20
        string ToJson();
#elif netstandard21 || netcoreapp31
        public string ToJson()
            => JsonConvert.SerializeObject(this);
#endif        
    }
}