using System;
using System.Collections.Generic;
using System.Text;

using AutoMapper;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using TheSharpFactory.Data.Repository.Common;
using TheSharpFactory.Data.Repository.Container;
using TheSharpFactory.Data.Repository.Container.Interfaces;
using TheSharpFactory.Domain.Models;

using CustomerEntity = TheSharpFactory.Data.Entity.WorldWideImporters.Sales.Customer;

namespace TheSharpFactory.Domain.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSharpFactoryDomain(
            this IServiceCollection services,
            Func<string> connectionStringDelegate
        )
        {
            Database.RegisterModelConnectionString(
                RepoLookup.ModelId.WorldWideImporters,
                connectionStringDelegate()
            );

            services.AddSingleton<IRepositoryContainer, RepositoryContainer>();

            services.AddSingleton<IAddress, Address>();
            services.AddSingleton<ICustomerProfile, CustomerProfile>();
            services.AddSingleton<ICustomer, Customer>();
            services.AddScoped<ISalesAggregate, SalesAggregate>();

            return services;
        }
    }
}
