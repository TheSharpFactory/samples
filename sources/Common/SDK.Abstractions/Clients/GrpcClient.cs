using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Grpc.Core;

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

        #region Protected Members
        #region Constructors
        protected GrpcClient(ChannelBase channel)
            : base(channel)
        {

        }
        #endregion
        #endregion

        #region Public Members
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
        public virtual IAsyncEnumerable<TMessage> ReadStream(
            CancellationToken token
        )
            => ReadList(token).GetAwaiter().GetResult().ToAsyncEnumerable();
        #endregion
#endif
        #endregion

        #region .NET Standard 2.1 Or ASP.NET Core 3.1
#if netstandard21 || netcoreapp31
        #region Public Members
        public abstract IAsyncEnumerable<TMessage> ReadStream(
            CancellationToken token
        );
        #endregion
#endif
        #endregion
    }
}
