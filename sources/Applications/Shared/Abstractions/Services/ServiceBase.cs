using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

using AutoMapper;

using Grpc.Core;

using StrawberryShake;

using TheSharpFactory.Common.DTO;
using TheSharpFactory.SDK;
using TheSharpFactory.SDK.Clients;
using TheSharpFactory.SDK.Graph;

namespace TheSharpFactory.Apps.Shared.Services
{
    public abstract class ServiceBase<TDtoInterface, TDto, TMessage, TGrpcClient, TOperation>
        where TDtoInterface : IDto
        where TDto : class, TDtoInterface
        where TGrpcClient : ClientBase<TGrpcClient>
    {
        #region Common
        #region Protected Members
        #region Fields
        protected readonly ApiClient<TDtoInterface, TDto, TMessage, TGrpcClient, IGetCustomers> _apiClient;
        protected readonly IMapper _mapper;
        #endregion

        #region Constructors
        protected ServiceBase(
            IMapper mapper,
            ApiClient<TDtoInterface, TDto, TMessage, TGrpcClient, IGetCustomers> apiClient
        )
        {
            _mapper = mapper;
            _apiClient = apiClient;
        }
        #endregion
        #endregion
        #endregion

        #region .NET Standard 2.0
#if netstandard20
        #region Public Members
        #region Methods
        public async Task<IEnumerable<TDtoInterface>> Read(
            HttpServiceTypes serviceType = HttpServiceTypes.REST,
            CancellationToken token = default
        ) => await _apiClient
                .Read(serviceType, token: token)
                .ConfigureAwait(false);

        public abstract Task<IEnumerable<TDtoInterface>> Read(
            IOperation<TOperation> getOperation,
            HttpServiceTypes serviceType = HttpServiceTypes.REST,
            CancellationToken token = default
        );
        #endregion
        #endregion
#endif
        #endregion

        #region .NET Standard 2.1
#if netstandard21
        #region Public Members
        #region Methods
        public async IAsyncEnumerable<TDtoInterface> Read(
            HttpServiceTypes serviceType = HttpServiceTypes.REST,
            [EnumeratorCancellation] CancellationToken token = default
        )
        {
            await foreach (var c in _apiClient.Read(serviceType, token: token).ConfigureAwait(false))
                yield return c;
        }

        public abstract IAsyncEnumerable<TDtoInterface> Read(
            IOperation<TOperation>? getOperation,
            HttpServiceTypes serviceType = HttpServiceTypes.REST,
            CancellationToken token = default
        );

        public async IAsyncEnumerable<TDtoInterface> ReadStream(
            HttpServiceTypes serviceType = HttpServiceTypes.GRPC,
            [EnumeratorCancellation] CancellationToken token = default
        )
        {
            switch (serviceType)
            {
                case HttpServiceTypes.GraphQL:
                throw new Exception();

                case HttpServiceTypes.GRPC:
                IList<TDtoInterface> dtos = new List<TDtoInterface>();
                await foreach (var c in _apiClient.ReadGrpc(token).ConfigureAwait(false))
                {
                    yield return c;
                }
                break;
                default:
                throw new Exception();
            }
        }
        #endregion
        #endregion
#endif
        #endregion
    }
}
