# Sphereon.SDK.Crypto.Keys.Api.ContentApi

All URIs are relative to *https://gw.api.cloud.sphereon.com/crypto/keys/0.9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DecryptUsingKey**](ContentApi.md#decryptusingkey) | **POST** /{config}/keys/{name}/{version}/decrypt | Decrypt value
[**EncryptUsingKey**](ContentApi.md#encryptusingkey) | **POST** /{config}/keys/{name}/{version}/encrypt | Encrypt value
[**SignUsingKey**](ContentApi.md#signusingkey) | **POST** /{config}/keys/{name}/{version}/sign | Create signature
[**VerifyUsingKey**](ContentApi.md#verifyusingkey) | **POST** /{config}/keys/{name}/{version}/verify | Verify signature


<a name="decryptusingkey"></a>
# **DecryptUsingKey**
> KeyDecryptResponse DecryptUsingKey (string config, string name, string version, KeyDecryptRequest request)

Decrypt value

Decrypts a well-formed block of ciphertext using the target encryption key and specified algorithm. This operation is the reverse of the encrypt operation. This operation applies to asymmetric and symmetric keys since it uses the private portion of the key.

### Example
```csharp
using System;
using System.Diagnostics;
using Sphereon.SDK.Crypto.Keys.Api;
using Sphereon.SDK.Crypto.Keys.Client;
using Sphereon.SDK.Crypto.Keys.Model;

namespace Example
{
    public class DecryptUsingKeyExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2schema
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentApi();
            var config = config_example;  // string | config
            var name = name_example;  // string | name
            var version = version_example;  // string | version
            var request = new KeyDecryptRequest(); // KeyDecryptRequest | The decrypt request

            try
            {
                // Decrypt value
                KeyDecryptResponse result = apiInstance.DecryptUsingKey(config, name, version, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentApi.DecryptUsingKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **config** | **string**| config | 
 **name** | **string**| name | 
 **version** | **string**| version | 
 **request** | [**KeyDecryptRequest**](KeyDecryptRequest.md)| The decrypt request | 

### Return type

[**KeyDecryptResponse**](KeyDecryptResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: application/json;charset=UTF-8
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="encryptusingkey"></a>
# **EncryptUsingKey**
> KeyEncryptResponse EncryptUsingKey (string config, string name, string version, KeyEncryptRequest request)

Encrypt value

Encrypts a sequence of bytes using an encryption key. This operation is only strictly necessary for symmetric keys since encryption with an asymmetric key can be performed using the public portion of the key. This operation is supported for asymmetric keys as a convenience for callers that have a key-reference but do not have access to the public key material.

### Example
```csharp
using System;
using System.Diagnostics;
using Sphereon.SDK.Crypto.Keys.Api;
using Sphereon.SDK.Crypto.Keys.Client;
using Sphereon.SDK.Crypto.Keys.Model;

namespace Example
{
    public class EncryptUsingKeyExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2schema
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentApi();
            var config = config_example;  // string | config
            var name = name_example;  // string | name
            var version = version_example;  // string | version
            var request = new KeyEncryptRequest(); // KeyEncryptRequest | The encrypt request

            try
            {
                // Encrypt value
                KeyEncryptResponse result = apiInstance.EncryptUsingKey(config, name, version, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentApi.EncryptUsingKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **config** | **string**| config | 
 **name** | **string**| name | 
 **version** | **string**| version | 
 **request** | [**KeyEncryptRequest**](KeyEncryptRequest.md)| The encrypt request | 

### Return type

[**KeyEncryptResponse**](KeyEncryptResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: application/json;charset=UTF-8
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signusingkey"></a>
# **SignUsingKey**
> KeySignResponse SignUsingKey (string config, string name, string version, KeySignRequest request)

Create signature

Creates a signature from a digest using a key. This operation is applicable to asymmetric and symmetric keys, since this operation uses the private portion of the key. Please note that the input needs to be a hash using a hash algorithm that fits the JsonWebKeySignatureAlgorithm, meaning SHA-256, SHA-384 or SHA-512

### Example
```csharp
using System;
using System.Diagnostics;
using Sphereon.SDK.Crypto.Keys.Api;
using Sphereon.SDK.Crypto.Keys.Client;
using Sphereon.SDK.Crypto.Keys.Model;

namespace Example
{
    public class SignUsingKeyExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2schema
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentApi();
            var config = config_example;  // string | config
            var name = name_example;  // string | name
            var version = version_example;  // string | version
            var request = new KeySignRequest(); // KeySignRequest | The sign request

            try
            {
                // Create signature
                KeySignResponse result = apiInstance.SignUsingKey(config, name, version, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentApi.SignUsingKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **config** | **string**| config | 
 **name** | **string**| name | 
 **version** | **string**| version | 
 **request** | [**KeySignRequest**](KeySignRequest.md)| The sign request | 

### Return type

[**KeySignResponse**](KeySignResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: application/json;charset=UTF-8
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="verifyusingkey"></a>
# **VerifyUsingKey**
> KeyVerifyResponse VerifyUsingKey (string config, string name, string version, KeyVerifyRequest request)

Verify signature

Verifies a signature using a key. This operation is applicable to assymetric and symmetric keys. It is not strictly necessary for asymmetric keys, since signature verification can be performed using the public portion of the key but this operation is supported as a convenience for callers that only have a key-reference and not the public portion of the key.

### Example
```csharp
using System;
using System.Diagnostics;
using Sphereon.SDK.Crypto.Keys.Api;
using Sphereon.SDK.Crypto.Keys.Client;
using Sphereon.SDK.Crypto.Keys.Model;

namespace Example
{
    public class VerifyUsingKeyExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2schema
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContentApi();
            var config = config_example;  // string | config
            var name = name_example;  // string | name
            var version = version_example;  // string | version
            var request = new KeyVerifyRequest(); // KeyVerifyRequest | The verify request

            try
            {
                // Verify signature
                KeyVerifyResponse result = apiInstance.VerifyUsingKey(config, name, version, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContentApi.VerifyUsingKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **config** | **string**| config | 
 **name** | **string**| name | 
 **version** | **string**| version | 
 **request** | [**KeyVerifyRequest**](KeyVerifyRequest.md)| The verify request | 

### Return type

[**KeyVerifyResponse**](KeyVerifyResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: application/json;charset=UTF-8
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

