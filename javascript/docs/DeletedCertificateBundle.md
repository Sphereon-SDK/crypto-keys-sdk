# CryptoKeys.DeletedCertificateBundle

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**backendMetadata** | **{String: String}** | StorageType metadata. This is the place where additional metadata return from the backend is stored | [optional] 
**applicationMetadata** | **{String: String}** | Application metadata. This is the place where you can store your own tags | [optional] 
**kid** | **String** | Key Id | [optional] 
**mediaType** | **String** | Media type of the certificate | [optional] 
**recoveryId** | **String** |  | [optional] 
**url** | **String** | Certificate URL | 
**sid** | **String** | Secret Id | [optional] 
**cer** | **Blob** | Certificate x509 CER contents | 
**scheduledPurgeTime** | **Date** |  | [optional] 
**attributes** | [**Attributes**](Attributes.md) | The attributes | [optional] 
**deletedTime** | **Date** |  | [optional] 
**x509Thumbprint** | **Blob** | Certificate X509 thumbprint | [optional] 
**cid** | **String** | Certificate Id | 
**policy** | [**CertificatePolicy**](CertificatePolicy.md) | Certificate management policy | [optional] 


