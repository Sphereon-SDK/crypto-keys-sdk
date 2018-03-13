# Sphereon.SDK.Crypto.Keys.Model.KeyVerifyRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Digest** | **byte[]** | The digest value. This must be a hash that conforms to the algorithm choosen | 
**Base64Signature** | **byte[]** | The signature in base 64 form. Please note that the base 64 xor the HEX signature is mandatory. | [optional] 
**Alg** | **string** | The algorithm to use for signing the diget | 
**HexSignature** | **string** | The signature in HEX form. Please note that the base 64 xor the HEX signature is mandatory. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

