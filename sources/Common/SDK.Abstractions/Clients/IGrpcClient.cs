
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TheSharpFactory.SDK.Clients
{
    public interface IGrpcClient<TMessage>
        where TMessage : class
    {
        Task<IEnumerable<TMessage>> ReadList(CancellationToken token = default);
        IAsyncEnumerable<TMessage> ReadStream(CancellationToken token = default);
    }
}
