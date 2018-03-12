# CertApi

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
```java
// Import classes:
//import com.sphereon.sdk.crypto.keys.handler.ApiClient;
//import com.sphereon.sdk.crypto.keys.handler.ApiException;
//import com.sphereon.sdk.crypto.keys.handler.Configuration;
//import com.sphereon.sdk.crypto.keys.handler.auth.*;
//import com.sphereon.sdk.crypto.keys.api.CertApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: oauth2schema
OAuth oauth2schema = (OAuth) defaultClient.getAuthentication("oauth2schema");
oauth2schema.setAccessToken("YOUR ACCESS TOKEN");

CertApi apiInstance = new CertApi();
String config = "config_example"; // String | config
CreateCertificateRequest certificateRequest = new CreateCertificateRequest(); // CreateCertificateRequest | The create certificate request
try {
    CreateCertificateResponse result = apiInstance.createCert(config, certificateRequest);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CertApi#createCert");
    e.printStackTrace();
}
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
```java
// Import classes:
//import com.sphereon.sdk.crypto.keys.handler.ApiClient;
//import com.sphereon.sdk.crypto.keys.handler.ApiException;
//import com.sphereon.sdk.crypto.keys.handler.Configuration;
//import com.sphereon.sdk.crypto.keys.handler.auth.*;
//import com.sphereon.sdk.crypto.keys.api.CertApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: oauth2schema
OAuth oauth2schema = (OAuth) defaultClient.getAuthentication("oauth2schema");
oauth2schema.setAccessToken("YOUR ACCESS TOKEN");

CertApi apiInstance = new CertApi();
String config = "config_example"; // String | config
String name = "name_example"; // String | name
try {
    DeletedCertificateBundleResponse result = apiInstance.deleteCert(config, name);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CertApi#deleteCert");
    e.printStackTrace();
}
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
```java
// Import classes:
//import com.sphereon.sdk.crypto.keys.handler.ApiClient;
//import com.sphereon.sdk.crypto.keys.handler.ApiException;
//import com.sphereon.sdk.crypto.keys.handler.Configuration;
//import com.sphereon.sdk.crypto.keys.handler.auth.*;
//import com.sphereon.sdk.crypto.keys.api.CertApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: oauth2schema
OAuth oauth2schema = (OAuth) defaultClient.getAuthentication("oauth2schema");
oauth2schema.setAccessToken("YOUR ACCESS TOKEN");

CertApi apiInstance = new CertApi();
String config = "config_example"; // String | config
String name = "name_example"; // String | name
String version = "version_example"; // String | version
try {
    CertificateBundleResponse result = apiInstance.getCert(config, name, version);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CertApi#getCert");
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
```java
// Import classes:
//import com.sphereon.sdk.crypto.keys.handler.ApiClient;
//import com.sphereon.sdk.crypto.keys.handler.ApiException;
//import com.sphereon.sdk.crypto.keys.handler.Configuration;
//import com.sphereon.sdk.crypto.keys.handler.auth.*;
//import com.sphereon.sdk.crypto.keys.api.CertApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: oauth2schema
OAuth oauth2schema = (OAuth) defaultClient.getAuthentication("oauth2schema");
oauth2schema.setAccessToken("YOUR ACCESS TOKEN");

CertApi apiInstance = new CertApi();
String config = "config_example"; // String | config
ImportCertificateRequest request = new ImportCertificateRequest(); // ImportCertificateRequest | The import certificate request
try {
    CreateCertificateResponse result = apiInstance.importCert(config, request);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CertApi#importCert");
    e.printStackTrace();
}
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
```java
// Import classes:
//import com.sphereon.sdk.crypto.keys.handler.ApiClient;
//import com.sphereon.sdk.crypto.keys.handler.ApiException;
//import com.sphereon.sdk.crypto.keys.handler.Configuration;
//import com.sphereon.sdk.crypto.keys.handler.auth.*;
//import com.sphereon.sdk.crypto.keys.api.CertApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: oauth2schema
OAuth oauth2schema = (OAuth) defaultClient.getAuthentication("oauth2schema");
oauth2schema.setAccessToken("YOUR ACCESS TOKEN");

CertApi apiInstance = new CertApi();
String config = "config_example"; // String | config
try {
    CertificateMetadataListResponse result = apiInstance.listCerts(config);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CertApi#listCerts");
    e.printStackTrace();
}
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

