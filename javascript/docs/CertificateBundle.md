# CryptoKeys.CertificateBundle

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cer** | **Blob** | Certificate x509 CER contents | 
**backendMetadata** | **{String: String}** | StorageType metadata. This is the place where additional metadata return from the backend is stored | [optional] 
**applicationMetadata** | **{String: String}** | Application metadata. This is the place where you can store your own tags | [optional] 
**kid** | **String** | Key Id | [optional] 
**attributes** | [**Attributes**](Attributes.md) | The attributes | [optional] 
**mediaType** | **String** | Media type of the certificate | [optional] 
**url** | **String** | Certificate URL | 
**x509Thumbprint** | **Blob** | Certificate X509 thumbprint | [optional] 
**cid** | **String** | Certificate Id | 
**policy** | [**CertificatePolicy**](CertificatePolicy.md) | Certificate management policy | [optional] 
**sid** | **String** | Secret Id | [optional] 


