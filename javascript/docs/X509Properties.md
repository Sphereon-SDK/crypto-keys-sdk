# CryptoKeys.X509Properties

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**enhancedKeyUsage** | **[String]** | Enhanced key usage | [optional] 
**keyUsage** | **[String]** | List of key usages | 
**validityMonths** | **Number** | Certificate validity in months | 
**sans** | [**SubjectAlternativeNames**](SubjectAlternativeNames.md) | Subject alternative name | [optional] 
**subject** | **String** | Subject name. Should be a valid X509 Distinguished Name | 


<a name="[KeyUsageEnum]"></a>
## Enum: [KeyUsageEnum]


* `DIGITAL_SIGNATURE` (value: `"DIGITAL_SIGNATURE"`)

* `NON_REPUDIATION` (value: `"NON_REPUDIATION"`)

* `KEY_ENCIPHERMENT` (value: `"KEY_ENCIPHERMENT"`)

* `DATA_ENCIPHERMENT` (value: `"DATA_ENCIPHERMENT"`)

* `KEY_AGREEMENT` (value: `"KEY_AGREEMENT"`)

* `KEY_CERT_SIGN` (value: `"KEY_CERT_SIGN"`)

* `CRL_SIGN` (value: `"CRL_SIGN"`)

* `ENCIPHER_ONLY` (value: `"ENCIPHER_ONLY"`)

* `DECIPHER_ONLY` (value: `"DECIPHER_ONLY"`)




