
# CreateKeyRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**kty** | [**KtyEnum**](#KtyEnum) |  |  [optional]
**applicationMetadata** | **Map&lt;String, String&gt;** |  |  [optional]
**crv** | [**CrvEnum**](#CrvEnum) |  |  [optional]
**keyOps** | [**List&lt;KeyOpsEnum&gt;**](#List&lt;KeyOpsEnum&gt;) |  |  [optional]
**name** | **String** |  |  [optional]
**attributes** | [**Attributes**](Attributes.md) |  |  [optional]
**keySize** | **Integer** |  |  [optional]


<a name="KtyEnum"></a>
## Enum: KtyEnum
Name | Value
---- | -----
EC | &quot;EC&quot;
RSA | &quot;RSA&quot;
OCT | &quot;OCT&quot;


<a name="CrvEnum"></a>
## Enum: CrvEnum
Name | Value
---- | -----
P_256 | &quot;P_256&quot;
P_384 | &quot;P_384&quot;
P_521 | &quot;P_521&quot;
SECP256K1 | &quot;SECP256K1&quot;


<a name="List<KeyOpsEnum>"></a>
## Enum: List&lt;KeyOpsEnum&gt;
Name | Value
---- | -----
ENCRYPT | &quot;ENCRYPT&quot;
DECRYPT | &quot;DECRYPT&quot;
SIGN | &quot;SIGN&quot;
VERIFY | &quot;VERIFY&quot;
WRAP_KEY | &quot;WRAP_KEY&quot;
UNWRAP_KEY | &quot;UNWRAP_KEY&quot;



