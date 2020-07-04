using System.CodeDom.Compiler;
using System.Collections.Generic;

using TheSharpFactory.Common.DTO;

namespace TheSharpFactory.SDK.Graph
{
    [GeneratedCode("StrawberryShake", "11.0.0")]
    public partial interface IGetCustomers
    {
        IReadOnlyList<ICustomerDTO> Customers { get; }
    }
}
