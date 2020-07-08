using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using Google.Protobuf.WellKnownTypes;

using Grpc.Core;
using Grpc.Core.Utils;

using TheSharpFactory.SDK.gRPC;

namespace TheSharpFactory.SDK.Clients
{
    public abstract class GrpcClient<TMessage>
        : GrpcService.GrpcServiceClient, IGrpcClient<TMessage>
        where TMessage : class
    {
        #region Common
        #region Protected Members
        #region Fields
        #endregion
        #endregion

        #region Public Members
        #region Constructors
        public GrpcClient(ChannelBase channel)
            : base(channel)
        {

        }

        #endregion

        #region Methods
        public abstract Task<IEnumerable<TMessage>> ReadList(
            CancellationToken token = default
        );
        #endregion

        #endregion

        #endregion

        #region .NET Standard 2.0
#if netstandard20
        #region Public Members
        #region Methods
        public async Task<IEnumerable<CustomerMessage>> ReadStream(
            CancellationToken token
        )
            => await base.GetCustomersStream(
                new Empty(),
                cancellationToken: token
            )
            .ResponseStream
            .ToListAsync()
            .ConfigureAwait(false);
        #endregion
        #endregion
#endif
        #endregion

        #region .NET Standard 2.1 Or ASP.NET Core 3.1
#if netstandard21 || netcoreapp31
        #region Public Members
        #region Methods
        public abstract IAsyncEnumerable<TMessage> ReadStream(
            CancellationToken token
        );
        #endregion
        #endregion
#endif
        #endregion

    }
}
