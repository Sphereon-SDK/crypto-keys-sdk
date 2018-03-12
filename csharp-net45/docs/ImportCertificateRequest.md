# Sphereon.SDK.Crypto.Keys.Model.ImportCertificateRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Password** | **string** | If the private key has a password it needs to be supplied here | [optional] 
**ApplicationMetadata** | **Dictionary&lt;string, string&gt;** | Application specific metadata | [optional] 
**Certificate** | **string** | Base64 encoded representation of the certificate to import. It needs to contain the private key | 
**Name** | **string** | Certificate name | 
**Attributes** | [**Attributes**](Attributes.md) | Certificate attributes | [optional] 
**Policy** | [**CertificatePolicy**](CertificatePolicy.md) | Certificate policy | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

