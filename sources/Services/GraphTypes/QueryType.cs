using System.Linq;

using AutoMapper;

using HotChocolate.Types;

using TheSharpFactory.Common.DTO;
using TheSharpFactory.Domain.Models;

namespace TheSharpFactory.Services.GraphTypes
{
    public class QueryType
        : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
            => _ = descriptor
                .Field(q => q.GetCustomers())
                .Name("getCustomers")
                .Resolver(ctx =>
                {
                    var mapper = ctx.Service<IMapper>();
                    var aggregate = ctx.Service<ISalesAggregate>();
                    aggregate.FetchAllCustomers();
                    return aggregate
                            .Customers
                            .Select(c => mapper.Map<ICustomerDTO>(c));
                });
    }
}
