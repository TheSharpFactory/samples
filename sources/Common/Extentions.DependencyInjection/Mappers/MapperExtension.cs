using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using AutoMapper;

using Microsoft.Extensions.DependencyInjection;

using TheSharpFactory.Domain.Extensions;

namespace TheSharpFactory.Common.Extensions.DependencyInjection.Mappers
{
    public static class MapperExtensions
    {
        public static IServiceCollection AddMapper(
            this IServiceCollection services,
            bool dataEntityAndDomainModelMapping = true,
            bool domainModelAndDataTransferObjectMapping = false,
            params Assembly[] scannableAssemblies
        )
        {
            var defaultScannableAssemblies = new List<Assembly>();

            if (dataEntityAndDomainModelMapping)
                defaultScannableAssemblies.Add(typeof(DataEntityToDomainEntityMappingProfile).Assembly);
            if (domainModelAndDataTransferObjectMapping)
                defaultScannableAssemblies.Add(typeof(MapperExtensions).Assembly);

            if (scannableAssemblies?.Length > 0)
                defaultScannableAssemblies = defaultScannableAssemblies.Concat(scannableAssemblies).ToList();

            return services.AddAutoMapper(defaultScannableAssemblies);
        }
    }
}