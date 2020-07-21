using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json;

using StrawberryShake;
using StrawberryShake.Http;

using TheSharpFactory.Common.DTO;

namespace TheSharpFactory.SDK.Graph
{
    [GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetCustomersResultParser
        : JsonResultParserBase<IGetCustomers>
    {
        private readonly IValueSerializer _stringSerializer;

        private IReadOnlyList<ICustomerDTO> ParseGetCustomersCustomers(
            JsonElement parent,
            string field
        )
        {
            JsonElement obj = parent.GetProperty(field);

            int objLength = obj.GetArrayLength();
            var list = new ICustomerDTO[objLength];
            for (int objIndex = 0; objIndex < objLength; objIndex++)
            {
                JsonElement element = obj[objIndex];
                list[objIndex] = new CustomerDTO
                {
#if netstandard20
                    Name = DeserializeNullableString(element, "name")
#elif netstandard21 || netcoreapp31
                    Name = DeserializeNullableString(element, "name")!
#endif
                };
            }

            return list;
        }

#if netstandard20
        private string DeserializeNullableString(
            JsonElement obj,
            string fieldName
        )
        {
            if (!obj.TryGetProperty(fieldName, out JsonElement value))
            {
                return null;
            }

            if (value.ValueKind == JsonValueKind.Null)
            {
                return null;
            }

            return (string)_stringSerializer.Deserialize(value.GetString());
        }
#elif netstandard21 || netcoreapp31
#nullable enable
        private string? DeserializeNullableString(
            JsonElement obj,
            string fieldName
        )
        {
            if (!obj.TryGetProperty(fieldName, out JsonElement value))
            {
                return null;
            }

            if (value.ValueKind == JsonValueKind.Null)
            {
                return null;
            }

            return (string?)_stringSerializer.Deserialize(value.GetString())!;
        }
#endif

        protected override IGetCustomers ParserData(JsonElement data)
            => new GetCustomers
            (
                ParseGetCustomersCustomers(data, "customers")
            );

        public GetCustomersResultParser(
            IValueSerializerCollection serializerResolver
        )
        {
            if (serializerResolver is null)
            {
                throw new ArgumentNullException(nameof(serializerResolver));
            }
            _stringSerializer = serializerResolver.Get("String");
        }
    }
}
