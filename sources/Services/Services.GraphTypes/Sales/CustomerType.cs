using System;
using System.Collections.Generic;
using System.Text;

using HotChocolate.Types;

using TheSharpFactory.Common.DTO;

namespace TheSharpFactory.Services.GraphTypes.Sales
{
	public class CustomerType
        : ObjectType<ICustomerDTO>
	{
        protected override void Configure(IObjectTypeDescriptor<ICustomerDTO> descriptor)
        {
            descriptor.Name("Customer");
            descriptor
                .Field(dto => dto.Id)
                .Name("id")
                .Type<NonNullType<StringType>>();
            descriptor
                .Field(dto => dto.Name)
                .Name("name")
                .Type<NonNullType<StringType>>();
            descriptor
                .Field(dto => dto.Phone)
                .Name("phone")
                .Type<StringType>();
        }
    }
}
