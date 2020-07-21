using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Newtonsoft.Json;

using TheSharpFactory.Common.DTO;

namespace TheSharpFactory.SDK.Clients
{
    public partial class RestClient<TDtoInterface, TDto>
        : RestSharp.RestClient, IRestClient<TDtoInterface, TDto>
        where TDtoInterface : IDto
        where TDto : class, TDtoInterface
    {
        #region Common
        #region Private Members
        #region Fields
        private readonly HttpClient _httpClient;
        private readonly Lazy<JsonSerializerSettings> _settings;
        #endregion

        #region Methods
        private JsonSerializerSettings CreateSerializerSettings()
        {
            var settings = new JsonSerializerSettings();
            UpdateJsonSerializerSettings(settings);
            return settings;
        }
        #endregion
        #endregion

        #region Protected Members
        #region Methods
        protected JsonSerializerSettings JsonSerializerSettings
            => _settings.Value;

        protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers)
        {
            if (response == null || response.Content == null)
            {
#if netstandard20
                return new ObjectResponseResult<T>(default, string.Empty);
#elif netstandard21 || netcoreapp31
                return new ObjectResponseResult<T>(default!, string.Empty);
#endif
            }

            if (ReadResponseAsString)
            {
                var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    var typedBody = JsonConvert.DeserializeObject<T>(responseText, JsonSerializerSettings);
#if netstandard20
                    return new ObjectResponseResult<T>(typedBody, responseText);
#elif netstandard21 || netcoreapp31
                    return new ObjectResponseResult<T>(typedBody!, responseText);
#endif
                }
                catch (JsonException exception)
                {
                    var message = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
                    throw new ApiException(message, (int)response.StatusCode, responseText, headers, exception);
                }
            }
            else
            {
                try
                {
                    using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                    using (var streamReader = new StreamReader(responseStream))
                    using (var jsonTextReader = new JsonTextReader(streamReader))
                    {
                        var serializer = JsonSerializer.Create(JsonSerializerSettings);
                        var typedBody = serializer.Deserialize<T>(jsonTextReader);
#if netstandard20
                        return new ObjectResponseResult<T>(typedBody, string.Empty);
#elif netstandard21 || netcoreapp31
                        return new ObjectResponseResult<T>(typedBody!, string.Empty);
#endif
                    }
                }
                catch (JsonException exception)
                {
                    var message = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
                    throw new ApiException(message, (int)response.StatusCode, string.Empty, headers, exception);
                }
            }
        }
        #endregion
        #endregion

        #region Public Members
        #region Properties
        public bool ReadResponseAsString { get; set; }
        public string Module { get; protected set; }
        public string Component { get; protected set; }
        #endregion

        #region Contructors
#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
        public RestClient(
            HttpClient httpClient
        )
            : base(httpClient.BaseAddress)
        {
            _httpClient = httpClient;
            _settings = new Lazy<JsonSerializerSettings>(CreateSerializerSettings);
        }

#pragma warning restore CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
        #endregion

        #region Methods

        public void SetModule(
            string module,
            string component
        )
        {
            if (string.IsNullOrEmpty(module))
                throw new ArgumentNullException(nameof(module));
            if (string.IsNullOrEmpty(component))
                throw new ArgumentException(nameof(component));
            Module = module;
            Component = component;
        }

        /// <summary>Fatch all the customers</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ICollection<TDtoInterface>> GetAsync()
            => GetAsync(CancellationToken.None);


        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Fatch all the customers</summary>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>        
        public async Task<ICollection<TDtoInterface>> GetAsync(
            CancellationToken cancellationToken
        )
        {
            var urlBuilder_ = new StringBuilder();
            urlBuilder_ = urlBuilder_
                            .Append(Module)
                            .Append('/')
                            .Append(Component);

            var client_ = _httpClient;

            using (var request_ = new HttpRequestMessage())
            {
                request_.Method = new HttpMethod("GET");
                request_.Headers.Accept.Add(
                    MediaTypeWithQualityHeaderValue.Parse("text/json")
                );

                PrepareRequest(client_, request_, urlBuilder_);
                var url_ = urlBuilder_.ToString();

                request_.RequestUri = new Uri(
                    url_,
                    UriKind.RelativeOrAbsolute
                );
                PrepareRequest(client_, request_, url_);

                var response_ = await client_.SendAsync(
                    request_,
                    HttpCompletionOption.ResponseHeadersRead,
                    cancellationToken
                ).ConfigureAwait(false);
                try
                {
                    var headers_ = response_
                                    .Headers
                                    .ToDictionary(
                                        h_ => h_.Key,
                                        h_ => h_.Value
                                    );
                    if (response_.Content?.Headers != null)
                    {
                        foreach (var item_ in response_.Content.Headers)
                            headers_[item_.Key] = item_.Value;
                    }

                    ProcessResponse(client_, response_);

                    var status_ = ((int)response_.StatusCode).ToString();
                    if (status_ == "200")
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<ICollection<TDto>>(response_, headers_)
                                                .ConfigureAwait(false);
                        return objectResponse_
                                    .Object
                                    .Cast<TDtoInterface>()
                                    .ToList();
                    }
                    else
                    if (status_ != "200" && status_ != "204")
                    {
                        var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                        throw new ApiException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", (int)response_.StatusCode, responseData_, headers_, null);
                    }
#if netstandard20
                    return default;
#elif netstandard21 || netcoreapp31
#nullable enable
                    return default!;
#endif
                }
                finally
                {
                    response_?.Dispose();
                }
            }
        }
        #endregion

        #endregion

        #region .NET Standard 2.0
#if netstandard20
        #region Private Members
        #region Methods
        private string ConvertToString(object value, CultureInfo cultureInfo)
        {
            if (value is Enum)
            {
                var name = Enum.GetName(value.GetType(), value);
                if (name != null)
                {
                    var field = value
                                    .GetType()
                                    .GetTypeInfo()
                                    .GetDeclaredField(name);
                    return field?.GetCustomAttribute(typeof(EnumMemberAttribute)) is EnumMemberAttribute attribute
                         ? attribute.Value ?? name
                         : Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
                }
            }
            else if (value is bool)
            {
                return Convert.ToString(value, cultureInfo)?.ToLowerInvariant();
            }
            else if (value is byte[] b)
            {
                return Convert.ToBase64String(b);
            }
            else if (value?.GetType().IsArray == true)
            {
                var array = ((Array)value).OfType<object>();
                return string.Join(
                    ",",
                    array.Select(o => ConvertToString(o, cultureInfo))
                );
            }

            return Convert.ToString(value, cultureInfo);
        }
        #endregion
        #endregion
#endif
        #endregion
        #region .NET Standard 2.1 Or ASP.NET Core 3.1
#if netstandard21 || netcoreapp31
        #region Private Members
        #region Methods
        private string? ConvertToString(object? value, CultureInfo cultureInfo)
        {
            if (value is Enum)
            {
                var name = Enum.GetName(value.GetType(), value);
                if (name != null)
                {
                    var field = value
                                    .GetType()
                                    .GetTypeInfo()
                                    .GetDeclaredField(name);
                    return field?.GetCustomAttribute(typeof(EnumMemberAttribute)) is EnumMemberAttribute attribute
                          ? attribute.Value ?? name
                          : Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
                }
            }
            else if (value is bool)
            {
                return Convert.ToString(value, cultureInfo)?.ToLowerInvariant();
            }
            else if (value is byte[] b)
            {
                return Convert.ToBase64String(b);
            }
            else if (value?.GetType().IsArray == true)
            {
                var array = ((Array)value).OfType<object>();
                return string.Join(
                    ",",
                    array.Select(o => ConvertToString(o, cultureInfo))
                );
            }

            return Convert.ToString(value, cultureInfo);
        }
        #endregion
        #endregion
#endif
        #endregion
        #endregion

        partial void UpdateJsonSerializerSettings(JsonSerializerSettings settings);
        partial void PrepareRequest(HttpClient client, HttpRequestMessage request, string url);
        partial void PrepareRequest(HttpClient client, HttpRequestMessage request, StringBuilder urlBuilder);
        partial void ProcessResponse(HttpClient client, HttpResponseMessage response);
    }
}