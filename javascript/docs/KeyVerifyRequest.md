# CryptoKeys.KeyVerifyRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**digest** | **Blob** | The digest value. This must be a hash that conforms to the algorithm choosen | 
**base64Signature** | **Blob** | The signature in base 64 form. Please note that the base 64 xor the HEX signature is mandatory. | [optional] 
**alg** | **String** | The algorithm to use for signing the diget | 
**hexSignature** | **String** | The signature in HEX form. Please note that the base 64 xor the HEX signature is mandatory. | [optional] 


<a name="AlgEnum"></a>
## Enum: AlgEnum


* `PS256` (value: `"PS256"`)

* `PS384` (value: `"PS384"`)

* `PS512` (value: `"PS512"`)

* `RS256` (value: `"RS256"`)

* `RS384` (value: `"RS384"`)

* `RS512` (value: `"RS512"`)

* `RSNULL` (value: `"RSNULL"`)

* `ES256` (value: `"ES256"`)

* `ES384` (value: `"ES384"`)

* `ES512` (value: `"ES512"`)

* `ECDSA256` (value: `"ECDSA256"`)




