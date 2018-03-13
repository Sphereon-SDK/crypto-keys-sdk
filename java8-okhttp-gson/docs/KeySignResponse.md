
# KeySignResponse

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**kid** | **String** | The Key Id | 
**base64Signature** | **byte[]** | The signature of the sign request in base 64 form | 
**algorithm** | [**AlgorithmEnum**](#AlgorithmEnum) | The signature algorithm used in the request | 
**hexSignature** | **String** | The signature of the sign request in hex form | 


<a name="AlgorithmEnum"></a>
## Enum: AlgorithmEnum
Name | Value
---- | -----
PS256 | &quot;PS256&quot;
PS384 | &quot;PS384&quot;
PS512 | &quot;PS512&quot;
RS256 | &quot;RS256&quot;
RS384 | &quot;RS384&quot;
RS512 | &quot;RS512&quot;
RSNULL | &quot;RSNULL&quot;
ES256 | &quot;ES256&quot;
ES384 | &quot;ES384&quot;
ES512 | &quot;ES512&quot;
ECDSA256 | &quot;ECDSA256&quot;



