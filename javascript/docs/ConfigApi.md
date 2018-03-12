# CryptoKeys.ConfigApi

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
```javascript
var CryptoKeys = require('crypto_keys');
var defaultClient = CryptoKeys.ApiClient.instance;

// Configure OAuth2 access token for authorization: oauth2schema
var oauth2schema = defaultClient.authentications['oauth2schema'];
oauth2schema.accessToken = 'YOUR ACCESS TOKEN';

var apiInstance = new CryptoKeys.ConfigApi();

var request = new CryptoKeys.CreateConfigurationRequest(); // CreateConfigurationRequest | The configuration request


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.createConfiguration(request, callback);
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
```javascript
var CryptoKeys = require('crypto_keys');
var defaultClient = CryptoKeys.ApiClient.instance;

// Configure OAuth2 access token for authorization: oauth2schema
var oauth2schema = defaultClient.authentications['oauth2schema'];
oauth2schema.accessToken = 'YOUR ACCESS TOKEN';

var apiInstance = new CryptoKeys.ConfigApi();

var config = "config_example"; // String | config id


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.deleteConfiguration(config, callback);
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
```javascript
var CryptoKeys = require('crypto_keys');
var defaultClient = CryptoKeys.ApiClient.instance;

// Configure OAuth2 access token for authorization: oauth2schema
var oauth2schema = defaultClient.authentications['oauth2schema'];
oauth2schema.accessToken = 'YOUR ACCESS TOKEN';

var apiInstance = new CryptoKeys.ConfigApi();

var config = "config_example"; // String | config name


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getConfiguration(config, callback);
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
```javascript
var CryptoKeys = require('crypto_keys');
var defaultClient = CryptoKeys.ApiClient.instance;

// Configure OAuth2 access token for authorization: oauth2schema
var oauth2schema = defaultClient.authentications['oauth2schema'];
oauth2schema.accessToken = 'YOUR ACCESS TOKEN';

var apiInstance = new CryptoKeys.ConfigApi();

var config = "config_example"; // String | config

var request = new CryptoKeys.UpdateConfigurationRequest(); // UpdateConfigurationRequest | The updated configuration request


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.updateConfiguration(config, request, callback);
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

