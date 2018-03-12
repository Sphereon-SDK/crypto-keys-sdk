
# DeletedCertificateBundle

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**backendMetadata** | **Map&lt;String, String&gt;** | StorageType metadata. This is the place where additional metadata return from the backend is stored |  [optional]
**applicationMetadata** | **Map&lt;String, String&gt;** | Application metadata. This is the place where you can store your own tags |  [optional]
**kid** | **String** | Key Id |  [optional]
**mediaType** | **String** | Media type of the certificate |  [optional]
**recoveryId** | **String** |  |  [optional]
**url** | **String** | Certificate URL | 
**sid** | **String** | Secret Id |  [optional]
**cer** | **byte[]** | Certificate x509 CER contents | 
**scheduledPurgeTime** | [**OffsetDateTime**](OffsetDateTime.md) |  |  [optional]
**attributes** | [**Attributes**](Attributes.md) | The attributes |  [optional]
**deletedTime** | [**OffsetDateTime**](OffsetDateTime.md) |  |  [optional]
**x509Thumbprint** | **byte[]** | Certificate X509 thumbprint |  [optional]
**cid** | **String** | Certificate Id | 
**policy** | [**CertificatePolicy**](CertificatePolicy.md) | Certificate management policy |  [optional]



