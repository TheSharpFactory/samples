﻿//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.6.2.0 (NJsonSchema v10.1.23.0 (Newtonsoft.Json v12.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

namespace TheSharpFactory.SDK
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    [GeneratedCode("NSwag", "13.6.2.0 (NJsonSchema v10.1.23.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class ApiException
        : Exception
    {
        public int StatusCode { get; private set; }

        public IReadOnlyDictionary<string, IEnumerable<string>> Headers { get; private set; }
#if netstandard20
        public string Response { get; private set; }
        public ApiException(
            string message,
            int statusCode,
            string response,
            IReadOnlyDictionary<string, IEnumerable<string>> headers,
            Exception innerException
        )
            : base(message + "\n\nStatus: " + statusCode + "\nResponse: \n" + ((response == null) ? "(null)" : response.Substring(0, response.Length >= 512 ? 512 : response.Length)), innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }
#elif netstandard21 || netcoreapp31
#nullable enable
        public string? Response { get; private set; }

        public ApiException(
            string message,
            int statusCode,

            string? response,
            IReadOnlyDictionary<string, IEnumerable<string>> headers,
            Exception? innerException
        )
            : base(message + "\n\nStatus: " + statusCode + "\nResponse: \n" + ((response == null) ? "(null)" : response.Substring(0, response.Length >= 512 ? 512 : response.Length)), innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }
#endif

        public override string ToString()
            => $"HTTP Response: \n\n{Response}\n\n{base.ToString()}";
    }

    [GeneratedCode("NSwag", "13.6.2.0 (NJsonSchema v10.1.23.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class ApiException<TResult>
        : ApiException
    {
        public TResult Result { get; private set; }
#if netstandard20
        public ApiException(
            string message,
            int statusCode,
            string response,
            IReadOnlyDictionary<string, IEnumerable<string>> headers,
            TResult result,
            System.Exception innerException
        )
            : base(message, statusCode, response, headers, innerException)
            => Result = result;
#elif netstandard21 || netcoreapp31
#nullable enable
        public ApiException(
            string message,
            int statusCode,
            string? response,
            IReadOnlyDictionary<string, IEnumerable<string>> headers,
            TResult result,
            Exception? innerException
        )
                    : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
#endif
    }

}