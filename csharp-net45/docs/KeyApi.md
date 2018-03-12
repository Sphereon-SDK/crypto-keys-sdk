# Sphereon.SDK.Crypto.Keys.Api.KeyApi

All URIs are relative to *https://gw.api.cloud.sphereon.com/crypto/keys/0.9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateKey**](KeyApi.md#createkey) | **POST** /{config}/keys/create | Create key
[**DeleteKey**](KeyApi.md#deletekey) | **DELETE** /{config}/keys/{name} | Delete key
[**GetKey**](KeyApi.md#getkey) | **GET** /{config}/keys/{name}/{version} | Get key information
[**ImportKey**](KeyApi.md#importkey) | **POST** /{config}/keys/import | Import key
[**ListKeys**](KeyApi.md#listkeys) | **GET** /{config}/keys | List keys metadata information


<a name="createkey"></a>
# **CreateKey**
> KeyBundle CreateKey (string config, CreateKeyRequest request)

Create key

Creates a new key

### Example
```csharp
using System;
using System.Diagnostics;
using Sphereon.SDK.Crypto.Keys.Api;
using Sphereon.SDK.Crypto.Keys.Client;
using Sphereon.SDK.Crypto.Keys.Model;

namespace Example
{
    public class CreateKeyExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2schema
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KeyApi();
            var config = config_example;  // string | config
            var request = new CreateKeyRequest(); // CreateKeyRequest | The create key request

            try
            {
                // Create key
                KeyBundle result = apiInstance.CreateKey(config, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeyApi.CreateKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **config** | **string**| config | 
 **request** | [**CreateKeyRequest**](CreateKeyRequest.md)| The create key request | 

### Return type

[**KeyBundle**](KeyBundle.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: application/json;charset=UTF-8
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletekey"></a>
# **DeleteKey**
> DeletedKeyBundleResponse DeleteKey (string config, string name)

Delete key

Deletes a key

### Example
```csharp
using System;
using System.Diagnostics;
using Sphereon.SDK.Crypto.Keys.Api;
using Sphereon.SDK.Crypto.Keys.Client;
using Sphereon.SDK.Crypto.Keys.Model;

namespace Example
{
    public class DeleteKeyExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2schema
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KeyApi();
            var config = config_example;  // string | config
            var name = name_example;  // string | name

            try
            {
                // Delete key
                DeletedKeyBundleResponse result = apiInstance.DeleteKey(config, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeyApi.DeleteKey: " + e.Message );
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

### Return type

[**DeletedKeyBundleResponse**](DeletedKeyBundleResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getkey"></a>
# **GetKey**
> KeyBundleResponse GetKey (string config, string name, string version)

Get key information

Gets information about a key

### Example
```csharp
using System;
using System.Diagnostics;
using Sphereon.SDK.Crypto.Keys.Api;
using Sphereon.SDK.Crypto.Keys.Client;
using Sphereon.SDK.Crypto.Keys.Model;

namespace Example
{
    public class GetKeyExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2schema
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KeyApi();
            var config = config_example;  // string | config
            var name = name_example;  // string | name
            var version = version_example;  // string | version

            try
            {
                // Get key information
                KeyBundleResponse result = apiInstance.GetKey(config, name, version);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeyApi.GetKey: " + e.Message );
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

### Return type

[**KeyBundleResponse**](KeyBundleResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importkey"></a>
# **ImportKey**
> KeyBundle ImportKey (string config, ImportKeyRequest request)

Import key

Imports a new key

### Example
```csharp
using System;
using System.Diagnostics;
using Sphereon.SDK.Crypto.Keys.Api;
using Sphereon.SDK.Crypto.Keys.Client;
using Sphereon.SDK.Crypto.Keys.Model;

namespace Example
{
    public class ImportKeyExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2schema
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KeyApi();
            var config = config_example;  // string | config
            var request = new ImportKeyRequest(); // ImportKeyRequest | The import key request

            try
            {
                // Import key
                KeyBundle result = apiInstance.ImportKey(config, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeyApi.ImportKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **config** | **string**| config | 
 **request** | [**ImportKeyRequest**](ImportKeyRequest.md)| The import key request | 

### Return type

[**KeyBundle**](KeyBundle.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: application/json;charset=UTF-8
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listkeys"></a>
# **ListKeys**
> KeyMetadataListResponse ListKeys (string config)

List keys metadata information

Gets a list of all key metadata

### Example
```csharp
using System;
using System.Diagnostics;
using Sphereon.SDK.Crypto.Keys.Api;
using Sphereon.SDK.Crypto.Keys.Client;
using Sphereon.SDK.Crypto.Keys.Model;

namespace Example
{
    public class ListKeysExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2schema
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new KeyApi();
            var config = config_example;  // string | config

            try
            {
                // List keys metadata information
                KeyMetadataListResponse result = apiInstance.ListKeys(config);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeyApi.ListKeys: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **config** | **string**| config | 

### Return type

[**KeyMetadataListResponse**](KeyMetadataListResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

