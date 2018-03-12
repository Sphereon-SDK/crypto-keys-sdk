# Sphereon.SDK.Crypto.Keys.Model.CertificateBundle
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cer** | **byte[]** | Certificate x509 CER contents | 
**BackendMetadata** | **Dictionary&lt;string, string&gt;** | StorageType metadata. This is the place where additional metadata return from the backend is stored | [optional] 
**ApplicationMetadata** | **Dictionary&lt;string, string&gt;** | Application metadata. This is the place where you can store your own tags | [optional] 
**Kid** | **string** | Key Id | [optional] 
**Attributes** | [**Attributes**](Attributes.md) | The attributes | [optional] 
**MediaType** | **string** | Media type of the certificate | [optional] 
**Url** | **string** | Certificate URL | 
**X509Thumbprint** | **byte[]** | Certificate X509 thumbprint | [optional] 
**Cid** | **string** | Certificate Id | 
**Policy** | [**CertificatePolicy**](CertificatePolicy.md) | Certificate management policy | [optional] 
**Sid** | **string** | Secret Id | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

