using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

using StrawberryShake;

namespace TheSharpFactory.SDK.Graph
{
    [GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetCustomersOperation
        : IOperation<IGetCustomers>
    {
        public string Name
            => "GetCustomers";

        public IDocument Document
            => Query.Default;

        public OperationKind Kind
            => OperationKind.Query;

        public Type ResultType
            => typeof(IGetCustomers);

        public IReadOnlyList<VariableValue> GetVariableValues()
            => Array.Empty<VariableValue>();
    }
}
