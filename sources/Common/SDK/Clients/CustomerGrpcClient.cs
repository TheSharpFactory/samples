using System;
using Grpc.Core;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

using Google.Protobuf.WellKnownTypes;

using TheSharpFactory.Services.GRPC.Sales;

namespace TheSharpFactory.SDK.Clients
{
    public class CustomerGrpcClient
        : GrpcClient<SalesAggregatorService.SalesAggregatorServiceClient, Customer>
    {
        #region Common
        #region Public Members
        #region Constructors
        public CustomerGrpcClient(
            SalesAggregatorService.SalesAggregatorServiceClient client
        ) : base(client)
        {
        }
        #endregion

        #region Methods
        public override async Task<IEnumerable<Customer>> ReadList(
            CancellationToken token = default
        )
        {
            IList<Customer> list = new List<Customer>();
            using (var stream = _client.GetCustomersStream(new Empty(), cancellationToken: token))
            {
                while (await stream.ResponseStream.MoveNext(token).ConfigureAwait(false))
                {
                    list.Add(stream.ResponseStream.Current);
                }
            }
            return list;
        }
        #endregion

        #endregion
        #endregion

        #region .NET STandard 2.1 Or ASP.NET COre 3.1
#if netstandard21 || netcoreapp31
        #region Public Members
        #region Methods
        public override async IAsyncEnumerable<Customer> ReadStream(
            [EnumeratorCancellation] CancellationToken token = default
        )
        {
            using (var stream = _client.GetCustomersStream(new Empty(), cancellationToken: token))
            {
                await foreach (var c in stream.ResponseStream.ReadAllAsync(token).ConfigureAwait(false))
                {
                    yield return c;
                }
            }
        }
        #endregion
        #endregion
#endif
        #endregion
    }
}
