using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

using Grpc.Core;

namespace TheSharpFactory.SDK.Clients
{
    public abstract class GrpcClient<TClient, TMessage>
        : IGrpcClient<TClient, TMessage>
        where TClient : ClientBase<TClient>
    {
        #region Common
        #region Protected Members
        #region Fields
        protected readonly TClient _client;
        #endregion
        #endregion

        #region Public Members
        #region Constructors
        public GrpcClient(TClient client)
            => _client = client;

        #endregion

        #region Methods
        public abstract Task<IEnumerable<TMessage>> ReadList(
            CancellationToken token = default
        );
        #endregion

        #endregion

        #endregion

        #region Common
#if netstandard21 || netcoreapp31
        #region Public Members
        #region Methods
        public abstract IAsyncEnumerable<TMessage> ReadStream(CancellationToken token = default);
        #endregion
        #endregion
#endif
        #endregion
    }
}
