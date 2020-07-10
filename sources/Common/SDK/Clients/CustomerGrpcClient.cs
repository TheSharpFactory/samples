using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

using Google.Protobuf.WellKnownTypes;

using Grpc.Core;

using TheSharpFactory.SDK.gRPC;

namespace TheSharpFactory.SDK.Clients
{
    public class CustomerGrpcClient
        : GrpcClient<CustomerMessage>
    {
        #region Common
        #region Public Members
        #region Constructors
        public CustomerGrpcClient(
            ChannelBase channel
        ) : base(channel)
        {
        }
        #endregion

        #region Methods
        public override async Task<IEnumerable<CustomerMessage>> ReadList(
            CancellationToken token = default
        )
        {
            IList<CustomerMessage> list = new List<CustomerMessage>();
            using (var stream = GetCustomersStream(new Empty(), cancellationToken: token))
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
        public override async IAsyncEnumerable<CustomerMessage> ReadStream(
            [EnumeratorCancellation] CancellationToken token = default
        )
        {
            using (var stream = GetCustomersStream(new Empty(), cancellationToken: token))
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
