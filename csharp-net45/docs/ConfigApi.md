# Sphereon.SDK.Crypto.Keys.Api.ConfigApi

All URIs are relative to *https://gw.api.cloud.sphereon.com/crypto/keys/0.9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateConfiguration**](ConfigApi.md#createconfiguration) | **POST** /manage/configs | Create a new Configuration
[**DeleteConfiguration**](ConfigApi.md#deleteconfiguration) | **DELETE** /manage/configs/{config} | Delete Configuration
[**GetConfiguration**](ConfigApi.md#getconfiguration) | **GET** /manage/configs/{config} | Get Configuration
[**UpdateConfiguration**](ConfigApi.md#updateconfiguration) | **PUT** /manage/configs/{config} | Update Configuration


<a name="createconfiguration"></a>
# **CreateConfiguration**
> ConfigurationResponse CreateConfiguration (CreateConfigurationRequest request)

Create a new Configuration

Create a new crypto key configuration

### Example
```csharp
using System;
using System.Diagnostics;
using Sphereon.SDK.Crypto.Keys.Api;
using Sphereon.SDK.Crypto.Keys.Client;
using Sphereon.SDK.Crypto.Keys.Model;

namespace Example
{
    public class CreateConfigurationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2schema
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigApi();
            var request = new CreateConfigurationRequest(); // CreateConfigurationRequest | The configuration request

            try
            {
                // Create a new Configuration
                ConfigurationResponse result = apiInstance.CreateConfiguration(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.CreateConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CreateConfigurationRequest**](CreateConfigurationRequest.md)| The configuration request | 

### Return type

[**ConfigurationResponse**](ConfigurationResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: application/json;charset=UTF-8
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteconfiguration"></a>
# **DeleteConfiguration**
> ConfigurationResponse DeleteConfiguration (string config)

Delete Configuration

Delete an existing configuration. As a protection this can only be done using the configuration Id and this not the name

### Example
```csharp
using System;
using System.Diagnostics;
using Sphereon.SDK.Crypto.Keys.Api;
using Sphereon.SDK.Crypto.Keys.Client;
using Sphereon.SDK.Crypto.Keys.Model;

namespace Example
{
    public class DeleteConfigurationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2schema
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigApi();
            var config = config_example;  // string | config id

            try
            {
                // Delete Configuration
                ConfigurationResponse result = apiInstance.DeleteConfiguration(config);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.DeleteConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **config** | **string**| config id | 

### Return type

[**ConfigurationResponse**](ConfigurationResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getconfiguration"></a>
# **GetConfiguration**
> ConfigurationResponse GetConfiguration (string config)

Get Configuration

Get existing configuration

### Example
```csharp
using System;
using System.Diagnostics;
using Sphereon.SDK.Crypto.Keys.Api;
using Sphereon.SDK.Crypto.Keys.Client;
using Sphereon.SDK.Crypto.Keys.Model;

namespace Example
{
    public class GetConfigurationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2schema
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigApi();
            var config = config_example;  // string | config name

            try
            {
                // Get Configuration
                ConfigurationResponse result = apiInstance.GetConfiguration(config);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.GetConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **config** | **string**| config name | 

### Return type

[**ConfigurationResponse**](ConfigurationResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateconfiguration"></a>
# **UpdateConfiguration**
> ConfigurationResponse UpdateConfiguration (string config, UpdateConfigurationRequest request)

Update Configuration

Update an existing configuration

### Example
```csharp
using System;
using System.Diagnostics;
using Sphereon.SDK.Crypto.Keys.Api;
using Sphereon.SDK.Crypto.Keys.Client;
using Sphereon.SDK.Crypto.Keys.Model;

namespace Example
{
    public class UpdateConfigurationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2schema
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigApi();
            var config = config_example;  // string | config
            var request = new UpdateConfigurationRequest(); // UpdateConfigurationRequest | The updated configuration request

            try
            {
                // Update Configuration
                ConfigurationResponse result = apiInstance.UpdateConfiguration(config, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.UpdateConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **config** | **string**| config | 
 **request** | [**UpdateConfigurationRequest**](UpdateConfigurationRequest.md)| The updated configuration request | 

### Return type

[**ConfigurationResponse**](ConfigurationResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: application/json;charset=UTF-8
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

