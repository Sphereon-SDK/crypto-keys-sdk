# Sphereon.SDK.Crypto.Keys.Api.CertApi

All URIs are relative to *https://gw.api.cloud.sphereon.com/crypto/keys/0.9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCert**](CertApi.md#createcert) | **POST** /{config}/certs/create | Create certificate
[**DeleteCert**](CertApi.md#deletecert) | **DELETE** /{config}/certs/{name} | Delete certificate
[**GetCert**](CertApi.md#getcert) | **GET** /{config}/certs/{name}/{version} | Get certificate info
[**ImportCert**](CertApi.md#importcert) | **POST** /{config}/certs/import | Import certificate
[**ListCerts**](CertApi.md#listcerts) | **GET** /{config}/certs | List certificates metadata information


<a name="createcert"></a>
# **CreateCert**
> CreateCertificateResponse CreateCert (string config, CreateCertificateRequest certificateRequest)

Create certificate

Creates a new certificate. 

### Example
```csharp
using System;
using System.Diagnostics;
using Sphereon.SDK.Crypto.Keys.Api;
using Sphereon.SDK.Crypto.Keys.Client;
using Sphereon.SDK.Crypto.Keys.Model;

namespace Example
{
    public class CreateCertExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2schema
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CertApi();
            var config = config_example;  // string | config
            var certificateRequest = new CreateCertificateRequest(); // CreateCertificateRequest | The create certificate request

            try
            {
                // Create certificate
                CreateCertificateResponse result = apiInstance.CreateCert(config, certificateRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CertApi.CreateCert: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **config** | **string**| config | 
 **certificateRequest** | [**CreateCertificateRequest**](CreateCertificateRequest.md)| The create certificate request | 

### Return type

[**CreateCertificateResponse**](CreateCertificateResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: application/json;charset=UTF-8
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecert"></a>
# **DeleteCert**
> DeletedCertificateBundleResponse DeleteCert (string config, string name)

Delete certificate

Deletes a certificate

### Example
```csharp
using System;
using System.Diagnostics;
using Sphereon.SDK.Crypto.Keys.Api;
using Sphereon.SDK.Crypto.Keys.Client;
using Sphereon.SDK.Crypto.Keys.Model;

namespace Example
{
    public class DeleteCertExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2schema
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CertApi();
            var config = config_example;  // string | config
            var name = name_example;  // string | name

            try
            {
                // Delete certificate
                DeletedCertificateBundleResponse result = apiInstance.DeleteCert(config, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CertApi.DeleteCert: " + e.Message );
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

[**DeletedCertificateBundleResponse**](DeletedCertificateBundleResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcert"></a>
# **GetCert**
> CertificateBundleResponse GetCert (string config, string name, string version)

Get certificate info

Gets information about a certificate

### Example
```csharp
using System;
using System.Diagnostics;
using Sphereon.SDK.Crypto.Keys.Api;
using Sphereon.SDK.Crypto.Keys.Client;
using Sphereon.SDK.Crypto.Keys.Model;

namespace Example
{
    public class GetCertExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2schema
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CertApi();
            var config = config_example;  // string | config
            var name = name_example;  // string | name
            var version = version_example;  // string | version

            try
            {
                // Get certificate info
                CertificateBundleResponse result = apiInstance.GetCert(config, name, version);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CertApi.GetCert: " + e.Message );
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

[**CertificateBundleResponse**](CertificateBundleResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importcert"></a>
# **ImportCert**
> CreateCertificateResponse ImportCert (string config, ImportCertificateRequest request)

Import certificate

Imports an existing valid certificate, containing a private key, into Azure Key Vault. The certificate to be imported can be in either PFX or PEM format. If the certificate is in PEM format the PEM file must contain the key as well as x509 certificates.

### Example
```csharp
using System;
using System.Diagnostics;
using Sphereon.SDK.Crypto.Keys.Api;
using Sphereon.SDK.Crypto.Keys.Client;
using Sphereon.SDK.Crypto.Keys.Model;

namespace Example
{
    public class ImportCertExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2schema
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CertApi();
            var config = config_example;  // string | config
            var request = new ImportCertificateRequest(); // ImportCertificateRequest | The import certificate request

            try
            {
                // Import certificate
                CreateCertificateResponse result = apiInstance.ImportCert(config, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CertApi.ImportCert: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **config** | **string**| config | 
 **request** | [**ImportCertificateRequest**](ImportCertificateRequest.md)| The import certificate request | 

### Return type

[**CreateCertificateResponse**](CreateCertificateResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: application/json;charset=UTF-8
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcerts"></a>
# **ListCerts**
> CertificateMetadataListResponse ListCerts (string config)

List certificates metadata information

Gets a list of all certiciate metadata

### Example
```csharp
using System;
using System.Diagnostics;
using Sphereon.SDK.Crypto.Keys.Api;
using Sphereon.SDK.Crypto.Keys.Client;
using Sphereon.SDK.Crypto.Keys.Model;

namespace Example
{
    public class ListCertsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2schema
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CertApi();
            var config = config_example;  // string | config

            try
            {
                // List certificates metadata information
                CertificateMetadataListResponse result = apiInstance.ListCerts(config);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CertApi.ListCerts: " + e.Message );
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

[**CertificateMetadataListResponse**](CertificateMetadataListResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

