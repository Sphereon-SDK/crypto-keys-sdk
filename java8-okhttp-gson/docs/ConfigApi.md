# ConfigApi

All URIs are relative to *https://gw.api.cloud.sphereon.com/crypto/keys/0.9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**createConfiguration**](ConfigApi.md#createConfiguration) | **POST** /manage/configs | Create a new Configuration
[**deleteConfiguration**](ConfigApi.md#deleteConfiguration) | **DELETE** /manage/configs/{config} | Delete Configuration
[**getConfiguration**](ConfigApi.md#getConfiguration) | **GET** /manage/configs/{config} | Get Configuration
[**updateConfiguration**](ConfigApi.md#updateConfiguration) | **PUT** /manage/configs/{config} | Update Configuration


<a name="createConfiguration"></a>
# **createConfiguration**
> ConfigurationResponse createConfiguration(request)

Create a new Configuration

Create a new crypto key configuration

### Example
```java
// Import classes:
//import com.sphereon.sdk.crypto.keys.handler.ApiClient;
//import com.sphereon.sdk.crypto.keys.handler.ApiException;
//import com.sphereon.sdk.crypto.keys.handler.Configuration;
//import com.sphereon.sdk.crypto.keys.handler.auth.*;
//import com.sphereon.sdk.crypto.keys.api.ConfigApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: oauth2schema
OAuth oauth2schema = (OAuth) defaultClient.getAuthentication("oauth2schema");
oauth2schema.setAccessToken("YOUR ACCESS TOKEN");

ConfigApi apiInstance = new ConfigApi();
CreateConfigurationRequest request = new CreateConfigurationRequest(); // CreateConfigurationRequest | The configuration request
try {
    ConfigurationResponse result = apiInstance.createConfiguration(request);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ConfigApi#createConfiguration");
    e.printStackTrace();
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

<a name="deleteConfiguration"></a>
# **deleteConfiguration**
> ConfigurationResponse deleteConfiguration(config)

Delete Configuration

Delete an existing configuration. As a protection this can only be done using the configuration Id and this not the name

### Example
```java
// Import classes:
//import com.sphereon.sdk.crypto.keys.handler.ApiClient;
//import com.sphereon.sdk.crypto.keys.handler.ApiException;
//import com.sphereon.sdk.crypto.keys.handler.Configuration;
//import com.sphereon.sdk.crypto.keys.handler.auth.*;
//import com.sphereon.sdk.crypto.keys.api.ConfigApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: oauth2schema
OAuth oauth2schema = (OAuth) defaultClient.getAuthentication("oauth2schema");
oauth2schema.setAccessToken("YOUR ACCESS TOKEN");

ConfigApi apiInstance = new ConfigApi();
String config = "config_example"; // String | config id
try {
    ConfigurationResponse result = apiInstance.deleteConfiguration(config);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ConfigApi#deleteConfiguration");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **config** | **String**| config id |

### Return type

[**ConfigurationResponse**](ConfigurationResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

<a name="getConfiguration"></a>
# **getConfiguration**
> ConfigurationResponse getConfiguration(config)

Get Configuration

Get existing configuration

### Example
```java
// Import classes:
//import com.sphereon.sdk.crypto.keys.handler.ApiClient;
//import com.sphereon.sdk.crypto.keys.handler.ApiException;
//import com.sphereon.sdk.crypto.keys.handler.Configuration;
//import com.sphereon.sdk.crypto.keys.handler.auth.*;
//import com.sphereon.sdk.crypto.keys.api.ConfigApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: oauth2schema
OAuth oauth2schema = (OAuth) defaultClient.getAuthentication("oauth2schema");
oauth2schema.setAccessToken("YOUR ACCESS TOKEN");

ConfigApi apiInstance = new ConfigApi();
String config = "config_example"; // String | config name
try {
    ConfigurationResponse result = apiInstance.getConfiguration(config);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ConfigApi#getConfiguration");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **config** | **String**| config name |

### Return type

[**ConfigurationResponse**](ConfigurationResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

<a name="updateConfiguration"></a>
# **updateConfiguration**
> ConfigurationResponse updateConfiguration(config, request)

Update Configuration

Update an existing configuration

### Example
```java
// Import classes:
//import com.sphereon.sdk.crypto.keys.handler.ApiClient;
//import com.sphereon.sdk.crypto.keys.handler.ApiException;
//import com.sphereon.sdk.crypto.keys.handler.Configuration;
//import com.sphereon.sdk.crypto.keys.handler.auth.*;
//import com.sphereon.sdk.crypto.keys.api.ConfigApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: oauth2schema
OAuth oauth2schema = (OAuth) defaultClient.getAuthentication("oauth2schema");
oauth2schema.setAccessToken("YOUR ACCESS TOKEN");

ConfigApi apiInstance = new ConfigApi();
String config = "config_example"; // String | config
UpdateConfigurationRequest request = new UpdateConfigurationRequest(); // UpdateConfigurationRequest | The updated configuration request
try {
    ConfigurationResponse result = apiInstance.updateConfiguration(config, request);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ConfigApi#updateConfiguration");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **config** | **String**| config |
 **request** | [**UpdateConfigurationRequest**](UpdateConfigurationRequest.md)| The updated configuration request |

### Return type

[**ConfigurationResponse**](ConfigurationResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: application/json;charset=UTF-8
 - **Accept**: application/json;charset=UTF-8

