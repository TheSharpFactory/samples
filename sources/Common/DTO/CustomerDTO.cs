using System.ComponentModel.DataAnnotations;

using Newtonsoft.Json;

namespace TheSharpFactory.Common.DTO
{
    public partial class CustomerDTO
        : ICustomerDTO
    {
#if netstandard20
        [JsonProperty("id", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        [Required(AllowEmptyStrings = true)]
        public string Id { get; set; } = default;

        [JsonProperty("name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        [Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default;

        [JsonProperty("phone", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        [Required(AllowEmptyStrings = true)]
        public string Phone { get; set; } = default;
        
        public string ToJson()
            => JsonConvert.SerializeObject(this);
#elif netstandard21
        [JsonProperty("id", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        [Required(AllowEmptyStrings = true)]
        public string Id { get; set; } = default!;

        [JsonProperty("name", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        [Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        [JsonProperty("phone", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        [Required(AllowEmptyStrings = true)]
        public string Phone { get; set; } = default!;
#endif

        public static CustomerDTO FromJson(string data)
            => JsonConvert.DeserializeObject<CustomerDTO>(data);

    }
}
