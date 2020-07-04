using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;

using Google.Protobuf.WellKnownTypes;

using Grpc.Core;

using TheSharpFactory.Domain.Models;

namespace TheSharpFactory.Services.GRPC.Sales
{
    public class SalesService
        : SalesAggregatorService.SalesAggregatorServiceBase
    {
        private readonly ISalesAggregate _sales;
        private readonly IMapper _mapper;

        public SalesService(
            ISalesAggregate sales,
            IMapper mapper
        )
        {
            _sales = sales;
            _mapper = mapper;
        }

        public override Task GetCustomersStream(
            Empty request,
            IServerStreamWriter<Customer> responseStream,
            ServerCallContext context
        )
        {
            _sales.FetchAllCustomers();

            foreach (var c in _sales.Customers)
                responseStream.WriteAsync(_mapper.Map<Customer>(c));

            return base.GetCustomersStream(request, responseStream, context);
        }
    }
}
