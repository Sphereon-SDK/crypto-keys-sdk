# CryptoKeys.ImportCertificateRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**password** | **String** | If the private key has a password it needs to be supplied here | [optional] 
**applicationMetadata** | **{String: String}** | Application specific metadata | [optional] 
**certificate** | **String** | Base64 encoded representation of the certificate to import. It needs to contain the private key | 
**name** | **String** | Certificate name | 
**attributes** | [**Attributes**](Attributes.md) | Certificate attributes | [optional] 
**policy** | [**CertificatePolicy**](CertificatePolicy.md) | Certificate policy | 


