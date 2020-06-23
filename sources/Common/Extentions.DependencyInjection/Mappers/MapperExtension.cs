using System.Reflection;

using AutoMapper;

using Microsoft.Extensions.DependencyInjection;

using TheSharpFactory.Common.DTO;
using TheSharpFactory.Data.Entity.WorldWideImporters.Sales;

namespace TheSharpFactory.Common.Extensions.DependencyInjection.Mappers
{
    public static class MapperExtensions
    {
        private static readonly Assembly[] ScannableAssemblies =
            new Assembly[]
            {
                typeof(Customer).Assembly,
                typeof(CustomerDTO).Assembly
            };
        public static IServiceCollection AddMapper(this IServiceCollection services)
            => services.AddAutoMapper(ScannableAssemblies);
    }
}