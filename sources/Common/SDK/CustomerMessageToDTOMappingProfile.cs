
using AutoMapper;

using TheSharpFactory.Common.DTO;
using TheSharpFactory.SDK.gRPC;

namespace TheSharpFactory.SDK
{
    public class CustomerMessageToDTOMappingProfile
        : Profile
    {
        public CustomerMessageToDTOMappingProfile()
        {
            CreateMap<CustomerMessage, CustomerDTO>()
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

            CreateMap<CustomerDTO, CustomerMessage>()
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
