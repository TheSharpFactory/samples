
using AutoMapper;

using TheSharpFactory.Common.DTO;
using TheSharpFactory.Services.GRPC.Sales;

namespace TheSharpFactory.SDK
{
    public class CustomerMessageToDTOMappingProfile
        : Profile
    {
        public CustomerMessageToDTOMappingProfile()
        {
            CreateMap<Customer, CustomerDTO>()
                .ForMember(
                    dto => dto.Id,
                    opt => opt.MapFrom(message => message.Id)
                )
                .ForMember(
                    dto => dto.Name,
                    opt => opt.MapFrom(message => message.Name)
                )
                .ForMember(
                    dto => dto.Phone,
                    opt => opt.MapFrom(message => message.Phone)
                );

            CreateMap<CustomerDTO, Customer>()
                .ForMember(
                    m => m.Id,
                    opt => opt.MapFrom(message => message.Id)
                )
                .ForMember(
                    m => m.Name,
                    opt => opt.MapFrom(dto => dto.Name)
                )
                .ForMember(
                    m => m.Phone,
                    opt => opt.MapFrom(dto => dto.Phone)
                );
        }
    }
}
