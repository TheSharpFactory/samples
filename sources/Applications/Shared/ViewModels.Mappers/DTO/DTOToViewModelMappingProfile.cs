
using AutoMapper;

using TheSharpFactory.Apps.Shared.ViewModels.Conventional;
using TheSharpFactory.Common.DTO;

namespace TheSharpFactory.Apps.Shared.ViewModels
{
    public class DTOToViewModelMappingProfile
        : Profile
    {
        public DTOToViewModelMappingProfile()
        {
            CreateMap<CustomerDTO, ICustomerViewModel>()
                .ForMember(
                    dto => dto.Id,
                    opt => opt.MapFrom(vm => vm.Id)
                )
                .ForMember(
                    dto => dto.Name,
                    opt => opt.MapFrom(vm => vm.Name)
                )
                .ForMember(
                    dto => dto.PhoneNumber,
                    opt => opt.MapFrom(vm => vm.Phone)
                );
            CreateMap<ICustomerViewModel, CustomerDTO>()
                .ForMember(
                    vm => vm.Id,
                    opt => opt.MapFrom(dto => dto.Id)
                )
                .ForMember(
                    vm => vm.Name,
                    opt => opt.MapFrom(dto => dto.Name)
                )
                .ForMember(
                    vm => vm.Phone,
                    opt => opt.MapFrom(dto => dto.PhoneNumber)
                );
        }
    }
}
