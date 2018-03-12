# CryptoKeys.CertApi

All URIs are relative to *https://gw.api.cloud.sphereon.com/crypto/keys/0.9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**createCert**](CertApi.md#createCert) | **POST** /{config}/certs/create | Create certificate
[**deleteCert**](CertApi.md#deleteCert) | **DELETE** /{config}/certs/{name} | Delete certificate
[**getCert**](CertApi.md#getCert) | **GET** /{config}/certs/{name}/{version} | Get certificate info
[**importCert**](CertApi.md#importCert) | **POST** /{config}/certs/import | Import certificate
[**listCerts**](CertApi.md#listCerts) | **GET** /{config}/certs | List certificates metadata information


<a name="createCert"></a>
# **createCert**
> CreateCertificateResponse createCert(config, certificateRequest)

Create certificate

Creates a new certificate. 

### Example
```javascript
var CryptoKeys = require('crypto_keys');
var defaultClient = CryptoKeys.ApiClient.instance;

// Configure OAuth2 access token for authorization: oauth2schema
var oauth2schema = defaultClient.authentications['oauth2schema'];
oauth2schema.accessToken = 'YOUR ACCESS TOKEN';

var apiInstance = new CryptoKeys.CertApi();

var config = "config_example"; // String | config

var certificateRequest = new CryptoKeys.CreateCertificateRequest(); // CreateCertificateRequest | The create certificate request


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.createCert(config, certificateRequest, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **config** | **String**| config | 
 **certificateRequest** | [**CreateCertificateRequest**](CreateCertificateRequest.md)| The create certificate request | 

### Return type

[**CreateCertificateResponse**](CreateCertificateResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: application/json;charset=UTF-8
 - **Accept**: application/json;charset=UTF-8

<a name="deleteCert"></a>
# **deleteCert**
> DeletedCertificateBundleResponse deleteCert(config, name)

Delete certificate

Deletes a certificate

### Example
```javascript
var CryptoKeys = require('crypto_keys');
var defaultClient = CryptoKeys.ApiClient.instance;

// Configure OAuth2 access token for authorization: oauth2schema
var oauth2schema = defaultClient.authentications['oauth2schema'];
oauth2schema.accessToken = 'YOUR ACCESS TOKEN';

var apiInstance = new CryptoKeys.CertApi();

var config = "config_example"; // String | config

var name = "name_example"; // String | name


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.deleteCert(config, name, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **config** | **String**| config | 
 **name** | **String**| name | 

### Return type

[**DeletedCertificateBundleResponse**](DeletedCertificateBundleResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

<a name="getCert"></a>
# **getCert**
> CertificateBundleResponse getCert(config, name, version)

Get certificate info

Gets information about a certificate

### Example
```javascript
var CryptoKeys = require('crypto_keys');
var defaultClient = CryptoKeys.ApiClient.instance;

// Configure OAuth2 access token for authorization: oauth2schema
var oauth2schema = defaultClient.authentications['oauth2schema'];
oauth2schema.accessToken = 'YOUR ACCESS TOKEN';

var apiInstance = new CryptoKeys.CertApi();

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
apiInstance.getCert(config, name, version, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **config** | **String**| config | 
 **name** | **String**| name | 
 **version** | **String**| version | 

### Return type

[**CertificateBundleResponse**](CertificateBundleResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

<a name="importCert"></a>
# **importCert**
> CreateCertificateResponse importCert(config, request)

Import certificate

Imports an existing valid certificate, containing a private key, into Azure Key Vault. The certificate to be imported can be in either PFX or PEM format. If the certificate is in PEM format the PEM file must contain the key as well as x509 certificates.

### Example
```javascript
var CryptoKeys = require('crypto_keys');
var defaultClient = CryptoKeys.ApiClient.instance;

// Configure OAuth2 access token for authorization: oauth2schema
var oauth2schema = defaultClient.authentications['oauth2schema'];
oauth2schema.accessToken = 'YOUR ACCESS TOKEN';

var apiInstance = new CryptoKeys.CertApi();

var config = "config_example"; // String | config

var request = new CryptoKeys.ImportCertificateRequest(); // ImportCertificateRequest | The import certificate request


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.importCert(config, request, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **config** | **String**| config | 
 **request** | [**ImportCertificateRequest**](ImportCertificateRequest.md)| The import certificate request | 

### Return type

[**CreateCertificateResponse**](CreateCertificateResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: application/json;charset=UTF-8
 - **Accept**: application/json;charset=UTF-8

<a name="listCerts"></a>
# **listCerts**
> CertificateMetadataListResponse listCerts(config)

List certificates metadata information

Gets a list of all certiciate metadata

### Example
```javascript
var CryptoKeys = require('crypto_keys');
var defaultClient = CryptoKeys.ApiClient.instance;

// Configure OAuth2 access token for authorization: oauth2schema
var oauth2schema = defaultClient.authentications['oauth2schema'];
oauth2schema.accessToken = 'YOUR ACCESS TOKEN';

var apiInstance = new CryptoKeys.CertApi();

var config = "config_example"; // String | config


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.listCerts(config, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **config** | **String**| config | 

### Return type

[**CertificateMetadataListResponse**](CertificateMetadataListResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

