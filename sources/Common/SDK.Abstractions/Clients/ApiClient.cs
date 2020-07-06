using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

using AutoMapper;

using Grpc.Core;

using StrawberryShake;

using TheSharpFactory.Common.DTO;

namespace TheSharpFactory.SDK.Clients
{
    public abstract class ApiClient<TDtoInterface, TDto, TMessage, TGrpcClient, TOperation>
        where TDtoInterface : IDto
        where TDto : class, TDtoInterface
        where TMessage : class
        where TGrpcClient : GrpcClient<TMessage>, IGrpcClient<TMessage>
    {
        #region Common
        #region Protected Members
        #region Fields
        protected readonly IMapper _mapper;
        protected readonly IRestClient<TDtoInterface, TDto> _restClient;
        protected readonly IGraphQLClient _graphClient;
        protected readonly TGrpcClient _grpcClient;
        #endregion

        #region Constructors
        protected ApiClient(
            IMapper mapper,
            IRestClient<TDtoInterface, TDto> restClient,
            IGraphQLClient graphClient,
            TGrpcClient grpcClient,
            string module,
            string component
        )
        {
            _mapper = mapper;
            _restClient = restClient;
            _restClient.SetModule(module, component);
            _graphClient = graphClient;
            _grpcClient = grpcClient;
        }
        #endregion

        #region Methods

        protected async Task<ICollection<TDtoInterface>> ReadRest(
            CancellationToken token = default
        )
            => await _restClient.GetAsync(token)
                    .ConfigureAwait(false);
        #endregion

        #endregion

        #region Public Members
        #region Methods
        #endregion
        #endregion
        #endregion

        #region .NET Standard 2.0
#if netstandard20
        #region Public Members
        #region Methods
        public async Task<IEnumerable<TDtoInterface>> Read(
            HttpServiceTypes apiType,
            CancellationToken token = default
        )
        {
            switch (apiType)
            {
                case HttpServiceTypes.GraphQL:
                return await ReadGraph(null, token).ConfigureAwait(false);
                case HttpServiceTypes.GRPC:
                return await ReadGrpc(token).ConfigureAwait(false);
                default:
                return await ReadRest(token)
                            .ConfigureAwait(false);

            }
        }
        public async Task<IEnumerable<TDtoInterface>> Read(
            HttpServiceTypes apiType,
            IOperation<TOperation> operation = null,
            CancellationToken token = default
        )
        {
            switch (apiType)
            {
                case HttpServiceTypes.GraphQL:
                return await ReadGraph(operation, token).ConfigureAwait(false);
                case HttpServiceTypes.GRPC:
                return await ReadGrpc(token).ConfigureAwait(false);
                default:
                return await ReadRest(token)
                            .ConfigureAwait(false);
            }
        }
        public abstract Task<IEnumerable<TDtoInterface>> ReadGraph(
            IOperation<TOperation> operation = null,
            CancellationToken token = default
        );
        public abstract Task<IEnumerable<TDtoInterface>> ReadGrpc(
            CancellationToken token = default
        );
        #endregion
        #endregion
#endif
        #endregion

        #region .NET Standard 2.1 Or ASP.NET Core 3.1
#if netstandard21 || netcoreapp31
        #region Private Members
        #region Methods

        #endregion
        #endregion
        #region Public Members
        #region Methods        
        public async IAsyncEnumerable<TDtoInterface> Read(
            HttpServiceTypes apiType,
            IOperation<TOperation>? operation = null,
            [EnumeratorCancellation] CancellationToken token = default
        )
        {
            switch (apiType)
            {
                case HttpServiceTypes.GraphQL:
                if (operation is null)
                {
                    await foreach (var c in ReadGraph(null, token).ConfigureAwait(false))
                        yield return c;
                }
                await foreach (var c in ReadGraph(operation!, token).ConfigureAwait(false))
                    yield return c;
                break;
                case HttpServiceTypes.GRPC:
                await foreach (var c in ReadGrpc(token).ConfigureAwait(false))
                    yield return c;
                break;
                default:
                var data = await ReadRest(token)
                            .ConfigureAwait(false);
                foreach (var c in data)
                    yield return c;
                break;

            }
        }
        public abstract IAsyncEnumerable<TDtoInterface> ReadGraph(
            IOperation<TOperation>? operation = null,
            CancellationToken token = default
        );
        public abstract IAsyncEnumerable<TDtoInterface> ReadGrpc(
            CancellationToken token = default
        );
        #endregion
        #endregion
#endif
        #endregion
    }
}
