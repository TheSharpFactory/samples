
using AutoMapper;

using TheSharpFactory.Domain.Models;

namespace TheSharpFactory.Common.DTO
{
    public class DTOToDomainModelMappingProfile
        : Profile
    {
        public DTOToDomainModelMappingProfile()
        {
            CreateMap<CustomerDTO, Customer>()
                .ForMember(
                    model => model.Id,
                    opt => opt.MapFrom(dto => dto.Id)
                )
                .ForMember(
                    model=>model.Name,
                    opt=>opt.MapFrom(dto=>dto.Name)
                )
                .ForMember(
                    model=>model.PhoneNumber,
                    opt=>opt.MapFrom(dto=>dto.Phone)
                )
                ;
            CreateMap<Customer, CustomerDTO>()
                .ForMember(
                    dto => dto.Id,
                    opt => opt.MapFrom(model => model.Id)
                )
                .ForMember(
                    dto => dto.Name,
                    opt => opt.MapFrom(model => model.Name)
                )
                .ForMember(
                    dto => dto.Phone,
                    opt => opt.MapFrom(model => model.PhoneNumber)
                )
                ;
        }
    }
}
