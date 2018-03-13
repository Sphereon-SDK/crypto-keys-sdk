
# KeySignRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**digest** | **byte[]** | The digest value. This must be a hash that conforms to the algorithm choosen | 
**alg** | [**AlgEnum**](#AlgEnum) | The algorithm to use for signing the diget | 


<a name="AlgEnum"></a>
## Enum: AlgEnum
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



