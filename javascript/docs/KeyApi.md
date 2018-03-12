# CryptoKeys.KeyApi

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
```javascript
var CryptoKeys = require('crypto_keys');
var defaultClient = CryptoKeys.ApiClient.instance;

// Configure OAuth2 access token for authorization: oauth2schema
var oauth2schema = defaultClient.authentications['oauth2schema'];
oauth2schema.accessToken = 'YOUR ACCESS TOKEN';

var apiInstance = new CryptoKeys.KeyApi();

var config = "config_example"; // String | config

var request = new CryptoKeys.CreateKeyRequest(); // CreateKeyRequest | The create key request


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.createKey(config, request, callback);
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
```javascript
var CryptoKeys = require('crypto_keys');
var defaultClient = CryptoKeys.ApiClient.instance;

// Configure OAuth2 access token for authorization: oauth2schema
var oauth2schema = defaultClient.authentications['oauth2schema'];
oauth2schema.accessToken = 'YOUR ACCESS TOKEN';

var apiInstance = new CryptoKeys.KeyApi();

var config = "config_example"; // String | config

var name = "name_example"; // String | name


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.deleteKey(config, name, callback);
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
```javascript
var CryptoKeys = require('crypto_keys');
var defaultClient = CryptoKeys.ApiClient.instance;

// Configure OAuth2 access token for authorization: oauth2schema
var oauth2schema = defaultClient.authentications['oauth2schema'];
oauth2schema.accessToken = 'YOUR ACCESS TOKEN';

var apiInstance = new CryptoKeys.KeyApi();

var config = "config_example"; // String | config

var name = "name_example"; // String | name

var version = "version_example"; // String | version


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getKey(config, name, version, callback);
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
```javascript
var CryptoKeys = require('crypto_keys');
var defaultClient = CryptoKeys.ApiClient.instance;

// Configure OAuth2 access token for authorization: oauth2schema
var oauth2schema = defaultClient.authentications['oauth2schema'];
oauth2schema.accessToken = 'YOUR ACCESS TOKEN';

var apiInstance = new CryptoKeys.KeyApi();

var config = "config_example"; // String | config

var request = new CryptoKeys.ImportKeyRequest(); // ImportKeyRequest | The import key request


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.importKey(config, request, callback);
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
```javascript
var CryptoKeys = require('crypto_keys');
var defaultClient = CryptoKeys.ApiClient.instance;

// Configure OAuth2 access token for authorization: oauth2schema
var oauth2schema = defaultClient.authentications['oauth2schema'];
oauth2schema.accessToken = 'YOUR ACCESS TOKEN';

var apiInstance = new CryptoKeys.KeyApi();

var config = "config_example"; // String | config


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.listKeys(config, callback);
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

