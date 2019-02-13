/* 
 * CyberSource Flex API
 *
 * Simple PAN tokenization service
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using cybersource-rest-client-dotnet.Client;
using cybersource-rest-client-dotnet.Model;

namespace cybersource-rest-client-dotnet.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IKeyGenerationApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Generate Key
        /// </summary>
        /// <remarks>
        /// Generate a one-time use public key and key ID to encrypt the card number in the follow-on Tokenize Card request. The key used to encrypt the card number on the cardholder’s device or browser is valid for 15 minutes and must be used to verify the signature in the response message. CyberSource recommends creating a new key for each order. Generating a key is an authenticated request initiated from your servers, prior to requesting to tokenize the card data from your customer’s device or browser.
        /// </remarks>
        /// <exception cref="cybersource-rest-client-dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generatePublicKeyRequest"> (optional)</param>
        /// <returns>FlexV1KeysPost200Response</returns>
        FlexV1KeysPost200Response GeneratePublicKey (GeneratePublicKeyRequest generatePublicKeyRequest = null);

        /// <summary>
        /// Generate Key
        /// </summary>
        /// <remarks>
        /// Generate a one-time use public key and key ID to encrypt the card number in the follow-on Tokenize Card request. The key used to encrypt the card number on the cardholder’s device or browser is valid for 15 minutes and must be used to verify the signature in the response message. CyberSource recommends creating a new key for each order. Generating a key is an authenticated request initiated from your servers, prior to requesting to tokenize the card data from your customer’s device or browser.
        /// </remarks>
        /// <exception cref="cybersource-rest-client-dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generatePublicKeyRequest"> (optional)</param>
        /// <returns>ApiResponse of FlexV1KeysPost200Response</returns>
        ApiResponse<FlexV1KeysPost200Response> GeneratePublicKeyWithHttpInfo (GeneratePublicKeyRequest generatePublicKeyRequest = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Generate Key
        /// </summary>
        /// <remarks>
        /// Generate a one-time use public key and key ID to encrypt the card number in the follow-on Tokenize Card request. The key used to encrypt the card number on the cardholder’s device or browser is valid for 15 minutes and must be used to verify the signature in the response message. CyberSource recommends creating a new key for each order. Generating a key is an authenticated request initiated from your servers, prior to requesting to tokenize the card data from your customer’s device or browser.
        /// </remarks>
        /// <exception cref="cybersource-rest-client-dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generatePublicKeyRequest"> (optional)</param>
        /// <returns>Task of FlexV1KeysPost200Response</returns>
        System.Threading.Tasks.Task<FlexV1KeysPost200Response> GeneratePublicKeyAsync (GeneratePublicKeyRequest generatePublicKeyRequest = null);

        /// <summary>
        /// Generate Key
        /// </summary>
        /// <remarks>
        /// Generate a one-time use public key and key ID to encrypt the card number in the follow-on Tokenize Card request. The key used to encrypt the card number on the cardholder’s device or browser is valid for 15 minutes and must be used to verify the signature in the response message. CyberSource recommends creating a new key for each order. Generating a key is an authenticated request initiated from your servers, prior to requesting to tokenize the card data from your customer’s device or browser.
        /// </remarks>
        /// <exception cref="cybersource-rest-client-dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generatePublicKeyRequest"> (optional)</param>
        /// <returns>Task of ApiResponse (FlexV1KeysPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlexV1KeysPost200Response>> GeneratePublicKeyAsyncWithHttpInfo (GeneratePublicKeyRequest generatePublicKeyRequest = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class KeyGenerationApi : IKeyGenerationApi
    {
        private cybersource-rest-client-dotnet.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyGenerationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public KeyGenerationApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = cybersource-rest-client-dotnet.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyGenerationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public KeyGenerationApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = cybersource-rest-client-dotnet.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public cybersource-rest-client-dotnet.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Generate Key Generate a one-time use public key and key ID to encrypt the card number in the follow-on Tokenize Card request. The key used to encrypt the card number on the cardholder’s device or browser is valid for 15 minutes and must be used to verify the signature in the response message. CyberSource recommends creating a new key for each order. Generating a key is an authenticated request initiated from your servers, prior to requesting to tokenize the card data from your customer’s device or browser.
        /// </summary>
        /// <exception cref="cybersource-rest-client-dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generatePublicKeyRequest"> (optional)</param>
        /// <returns>FlexV1KeysPost200Response</returns>
        public FlexV1KeysPost200Response GeneratePublicKey (GeneratePublicKeyRequest generatePublicKeyRequest = null)
        {
             ApiResponse<FlexV1KeysPost200Response> localVarResponse = GeneratePublicKeyWithHttpInfo(generatePublicKeyRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Generate Key Generate a one-time use public key and key ID to encrypt the card number in the follow-on Tokenize Card request. The key used to encrypt the card number on the cardholder’s device or browser is valid for 15 minutes and must be used to verify the signature in the response message. CyberSource recommends creating a new key for each order. Generating a key is an authenticated request initiated from your servers, prior to requesting to tokenize the card data from your customer’s device or browser.
        /// </summary>
        /// <exception cref="cybersource-rest-client-dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generatePublicKeyRequest"> (optional)</param>
        /// <returns>ApiResponse of FlexV1KeysPost200Response</returns>
        public ApiResponse< FlexV1KeysPost200Response > GeneratePublicKeyWithHttpInfo (GeneratePublicKeyRequest generatePublicKeyRequest = null)
        {

            var localVarPath = $"/flex/v1/keys/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (generatePublicKeyRequest != null && generatePublicKeyRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(generatePublicKeyRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = generatePublicKeyRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GeneratePublicKey", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FlexV1KeysPost200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlexV1KeysPost200Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlexV1KeysPost200Response)));
        }

        /// <summary>
        /// Generate Key Generate a one-time use public key and key ID to encrypt the card number in the follow-on Tokenize Card request. The key used to encrypt the card number on the cardholder’s device or browser is valid for 15 minutes and must be used to verify the signature in the response message. CyberSource recommends creating a new key for each order. Generating a key is an authenticated request initiated from your servers, prior to requesting to tokenize the card data from your customer’s device or browser.
        /// </summary>
        /// <exception cref="cybersource-rest-client-dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generatePublicKeyRequest"> (optional)</param>
        /// <returns>Task of FlexV1KeysPost200Response</returns>
        public async System.Threading.Tasks.Task<FlexV1KeysPost200Response> GeneratePublicKeyAsync (GeneratePublicKeyRequest generatePublicKeyRequest = null)
        {
             ApiResponse<FlexV1KeysPost200Response> localVarResponse = await GeneratePublicKeyAsyncWithHttpInfo(generatePublicKeyRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Generate Key Generate a one-time use public key and key ID to encrypt the card number in the follow-on Tokenize Card request. The key used to encrypt the card number on the cardholder’s device or browser is valid for 15 minutes and must be used to verify the signature in the response message. CyberSource recommends creating a new key for each order. Generating a key is an authenticated request initiated from your servers, prior to requesting to tokenize the card data from your customer’s device or browser.
        /// </summary>
        /// <exception cref="cybersource-rest-client-dotnet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generatePublicKeyRequest"> (optional)</param>
        /// <returns>Task of ApiResponse (FlexV1KeysPost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlexV1KeysPost200Response>> GeneratePublicKeyAsyncWithHttpInfo (GeneratePublicKeyRequest generatePublicKeyRequest = null)
        {

            var localVarPath = $"/flex/v1/keys/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (generatePublicKeyRequest != null && generatePublicKeyRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(generatePublicKeyRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = generatePublicKeyRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GeneratePublicKey", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FlexV1KeysPost200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlexV1KeysPost200Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlexV1KeysPost200Response)));
        }

    }
}
