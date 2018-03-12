# KeyApi

All URIs are relative to *https://gw.api.cloud.sphereon.com/crypto/keys/0.9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**createKey**](KeyApi.md#createKey) | **POST** /{config}/keys/create | Create key
[**deleteKey**](KeyApi.md#deleteKey) | **DELETE** /{config}/keys/{name} | Delete key
[**getKey**](KeyApi.md#getKey) | **GET** /{config}/keys/{name}/{version} | Get key information
[**importKey**](KeyApi.md#importKey) | **POST** /{config}/keys/import | Import key
[**listKeys**](KeyApi.md#listKeys) | **GET** /{config}/keys | List keys metadata information


<a name="createKey"></a>
# **createKey**
> KeyBundle createKey(config, request)

Create key

Creates a new key

### Example
```java
// Import classes:
//import com.sphereon.sdk.crypto.keys.handler.ApiClient;
//import com.sphereon.sdk.crypto.keys.handler.ApiException;
//import com.sphereon.sdk.crypto.keys.handler.Configuration;
//import com.sphereon.sdk.crypto.keys.handler.auth.*;
//import com.sphereon.sdk.crypto.keys.api.KeyApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: oauth2schema
OAuth oauth2schema = (OAuth) defaultClient.getAuthentication("oauth2schema");
oauth2schema.setAccessToken("YOUR ACCESS TOKEN");

KeyApi apiInstance = new KeyApi();
String config = "config_example"; // String | config
CreateKeyRequest request = new CreateKeyRequest(); // CreateKeyRequest | The create key request
try {
    KeyBundle result = apiInstance.createKey(config, request);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling KeyApi#createKey");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **config** | **String**| config |
 **request** | [**CreateKeyRequest**](CreateKeyRequest.md)| The create key request |

### Return type

[**KeyBundle**](KeyBundle.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: application/json;charset=UTF-8
 - **Accept**: application/json;charset=UTF-8

<a name="deleteKey"></a>
# **deleteKey**
> DeletedKeyBundleResponse deleteKey(config, name)

Delete key

Deletes a key

### Example
```java
// Import classes:
//import com.sphereon.sdk.crypto.keys.handler.ApiClient;
//import com.sphereon.sdk.crypto.keys.handler.ApiException;
//import com.sphereon.sdk.crypto.keys.handler.Configuration;
//import com.sphereon.sdk.crypto.keys.handler.auth.*;
//import com.sphereon.sdk.crypto.keys.api.KeyApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: oauth2schema
OAuth oauth2schema = (OAuth) defaultClient.getAuthentication("oauth2schema");
oauth2schema.setAccessToken("YOUR ACCESS TOKEN");

KeyApi apiInstance = new KeyApi();
String config = "config_example"; // String | config
String name = "name_example"; // String | name
try {
    DeletedKeyBundleResponse result = apiInstance.deleteKey(config, name);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling KeyApi#deleteKey");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **config** | **String**| config |
 **name** | **String**| name |

### Return type

[**DeletedKeyBundleResponse**](DeletedKeyBundleResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

<a name="getKey"></a>
# **getKey**
> KeyBundleResponse getKey(config, name, version)

Get key information

Gets information about a key

### Example
```java
// Import classes:
//import com.sphereon.sdk.crypto.keys.handler.ApiClient;
//import com.sphereon.sdk.crypto.keys.handler.ApiException;
//import com.sphereon.sdk.crypto.keys.handler.Configuration;
//import com.sphereon.sdk.crypto.keys.handler.auth.*;
//import com.sphereon.sdk.crypto.keys.api.KeyApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: oauth2schema
OAuth oauth2schema = (OAuth) defaultClient.getAuthentication("oauth2schema");
oauth2schema.setAccessToken("YOUR ACCESS TOKEN");

KeyApi apiInstance = new KeyApi();
String config = "config_example"; // String | config
String name = "name_example"; // String | name
String version = "version_example"; // String | version
try {
    KeyBundleResponse result = apiInstance.getKey(config, name, version);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling KeyApi#getKey");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **config** | **String**| config |
 **name** | **String**| name |
 **version** | **String**| version |

### Return type

[**KeyBundleResponse**](KeyBundleResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

<a name="importKey"></a>
# **importKey**
> KeyBundle importKey(config, request)

Import key

Imports a new key

### Example
```java
// Import classes:
//import com.sphereon.sdk.crypto.keys.handler.ApiClient;
//import com.sphereon.sdk.crypto.keys.handler.ApiException;
//import com.sphereon.sdk.crypto.keys.handler.Configuration;
//import com.sphereon.sdk.crypto.keys.handler.auth.*;
//import com.sphereon.sdk.crypto.keys.api.KeyApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: oauth2schema
OAuth oauth2schema = (OAuth) defaultClient.getAuthentication("oauth2schema");
oauth2schema.setAccessToken("YOUR ACCESS TOKEN");

KeyApi apiInstance = new KeyApi();
String config = "config_example"; // String | config
ImportKeyRequest request = new ImportKeyRequest(); // ImportKeyRequest | The import key request
try {
    KeyBundle result = apiInstance.importKey(config, request);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling KeyApi#importKey");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **config** | **String**| config |
 **request** | [**ImportKeyRequest**](ImportKeyRequest.md)| The import key request |

### Return type

[**KeyBundle**](KeyBundle.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: application/json;charset=UTF-8
 - **Accept**: application/json;charset=UTF-8

<a name="listKeys"></a>
# **listKeys**
> KeyMetadataListResponse listKeys(config)

List keys metadata information

Gets a list of all key metadata

### Example
```java
// Import classes:
//import com.sphereon.sdk.crypto.keys.handler.ApiClient;
//import com.sphereon.sdk.crypto.keys.handler.ApiException;
//import com.sphereon.sdk.crypto.keys.handler.Configuration;
//import com.sphereon.sdk.crypto.keys.handler.auth.*;
//import com.sphereon.sdk.crypto.keys.api.KeyApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: oauth2schema
OAuth oauth2schema = (OAuth) defaultClient.getAuthentication("oauth2schema");
oauth2schema.setAccessToken("YOUR ACCESS TOKEN");

KeyApi apiInstance = new KeyApi();
String config = "config_example"; // String | config
try {
    KeyMetadataListResponse result = apiInstance.listKeys(config);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling KeyApi#listKeys");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **config** | **String**| config |

### Return type

[**KeyMetadataListResponse**](KeyMetadataListResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

