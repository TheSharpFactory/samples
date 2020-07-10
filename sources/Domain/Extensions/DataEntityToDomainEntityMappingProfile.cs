using AutoMapper;

using TheSharpFactory.Domain.Models;

using CustomerEntity = TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer;

namespace TheSharpFactory.Domain.Extensions
{
    public class DataEntityToDomainEntityMappingProfile
        : Profile
    {
        public DataEntityToDomainEntityMappingProfile()
        {
            CreateMap<CustomerEntity, Customer>()
                .ForMember(
                    c => c.Id,
                    opt => opt.MapFrom(
                            entity => entity.CustomerID
                        )
                )
                .ForMember(
                    c => c.Name,
                    opt => opt.MapFrom(
                            entity => entity.CustomerName
                        )
                );

            CreateMap<Customer, CustomerEntity>()
                .ForMember(
                    entity => entity.CustomerID,
                    opt => opt.MapFrom(
                            c => c.Id
                        )
                )
                .ForMember(
                    entity => entity.CustomerName,
                    opt => opt.MapFrom(
                            c => c.Name
                        )
                );
        }
    }
}
