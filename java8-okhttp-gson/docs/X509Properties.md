
# X509Properties

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**enhancedKeyUsage** | **List&lt;String&gt;** | Enhanced key usage |  [optional]
**keyUsage** | [**List&lt;KeyUsageEnum&gt;**](#List&lt;KeyUsageEnum&gt;) | List of key usages | 
**validityMonths** | **Integer** | Certificate validity in months | 
**sans** | [**SubjectAlternativeNames**](SubjectAlternativeNames.md) | Subject alternative name |  [optional]
**subject** | **String** | Subject name. Should be a valid X509 Distinguished Name | 


<a name="List<KeyUsageEnum>"></a>
## Enum: List&lt;KeyUsageEnum&gt;
Name | Value
---- | -----
DIGITAL_SIGNATURE | &quot;DIGITAL_SIGNATURE&quot;
NON_REPUDIATION | &quot;NON_REPUDIATION&quot;
KEY_ENCIPHERMENT | &quot;KEY_ENCIPHERMENT&quot;
DATA_ENCIPHERMENT | &quot;DATA_ENCIPHERMENT&quot;
KEY_AGREEMENT | &quot;KEY_AGREEMENT&quot;
KEY_CERT_SIGN | &quot;KEY_CERT_SIGN&quot;
CRL_SIGN | &quot;CRL_SIGN&quot;
ENCIPHER_ONLY | &quot;ENCIPHER_ONLY&quot;
DECIPHER_ONLY | &quot;DECIPHER_ONLY&quot;



