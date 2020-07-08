using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using RestSharp;

using TheSharpFactory.Common.DTO;

namespace TheSharpFactory.SDK.Clients
{
    public partial interface IRestClient<TDtoInterface, TDto>
        : IRestClient
        where TDtoInterface : IDto
        where TDto : class, TDtoInterface
    {
        #region Common

        string Module { get; }
        string Component { get; }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Fatch all the data</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<ICollection<TDto>> GetAsync(CancellationToken cancellationToken);
        void SetModule(string module, string component);
        #endregion

    }
}

