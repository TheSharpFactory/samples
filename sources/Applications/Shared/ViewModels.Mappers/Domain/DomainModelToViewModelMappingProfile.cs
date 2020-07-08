
using AutoMapper;

using TheSharpFactory.Apps.Shared.ViewModels.Conventional;
using TheSharpFactory.Domain.Models;

namespace TheSharpFactory.Apps.Shared.ViewModels
{
    public class DomainModelToViewModelMappingProfile
        : Profile
    {
        public DomainModelToViewModelMappingProfile()
        {
            CreateMap<ICustomer, ICustomerViewModel>()
                .ForMember(
                    c => c.Id,
                    opt => opt.MapFrom(vm => vm.Id)
                )
                .ForMember(
                    c => c.Name,
                    opt => opt.MapFrom(vm => vm.Name)
                )
                .ForMember(
                    c => c.PhoneNumber,
                    opt => opt.MapFrom(vm => vm.PhoneNumber)
                );
            CreateMap<ICustomerViewModel, ICustomer>()
                .ForMember(
                    vm => vm.Id,
                    opt => opt.MapFrom(c => c.Id)
                )
                .ForMember(
                    vm => vm.Name,
                    opt => opt.MapFrom(c => c.Name)
                )
                .ForMember(
                    vm => vm.PhoneNumber,
                    opt => opt.MapFrom(c => c.PhoneNumber)
                );
        }
    }
}
