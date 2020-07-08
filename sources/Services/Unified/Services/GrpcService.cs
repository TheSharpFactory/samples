using System.Linq;
using System.Threading.Tasks;

using AutoMapper;

using Google.Protobuf.WellKnownTypes;

using Grpc.Core;

using TheSharpFactory.Domain.Models;
using TheSharpFactory.SDK.gRPC;

namespace TheSharpFactory.Services.Unified.Services
{
    public class GrpcService
        : gRPC.GrpcService.GrpcServiceBase
    {
        private readonly IMapper _mapper;
        private readonly ISalesAggregate _aggregate;

        public GrpcService(
            IMapper mapper,
            ISalesAggregate aggregate
        )
        {
            _mapper = mapper;
            _aggregate = aggregate;
        }
          
        public override async Task GetCustomersStream(
            Empty request,
            IServerStreamWriter<gRPC.CustomerMessage> responseStream,
            ServerCallContext context
        )
        {
            _aggregate.FetchAllCustomers();

            var result = _aggregate
                            .Customers
                            .Select(c => _mapper.Map<gRPC.CustomerMessage>(c))
                            .ToList();
            foreach (var message in result)
            {
                await responseStream
                        .WriteAsync(message)
                        .ConfigureAwait(false);
            }
        }
    }
}
