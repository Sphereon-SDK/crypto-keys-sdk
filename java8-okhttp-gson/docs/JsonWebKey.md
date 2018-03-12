
# JsonWebKey

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**d** | **byte[]** | RSA private exponent |  [optional]
**e** | **byte[]** | RSA public exponent |  [optional]
**crv** | [**CrvEnum**](#CrvEnum) | Elliptic curve name. see JsonWebKeyCurveName |  [optional]
**kid** | **String** | Key id |  [optional]
**k** | **byte[]** | Symmetric key |  [optional]
**dp** | **byte[]** | RSA Private Key Parameter |  [optional]
**dq** | **byte[]** | RSA Private Key Parameter |  [optional]
**n** | **byte[]** | RSA modulus |  [optional]
**p** | **byte[]** | RSA secret prime |  [optional]
**kty** | [**KtyEnum**](#KtyEnum) | Key type |  [optional]
**q** | **byte[]** | RSA secret prime, with p &lt; q |  [optional]
**t** | **byte[]** | HSM Token, used with Bring Your Own Key |  [optional]
**keyOps** | [**List&lt;KeyOpsEnum&gt;**](#List&lt;KeyOpsEnum&gt;) | Supported operations |  [optional]
**qi** | **byte[]** | RSA Private Key Parameter |  [optional]
**x** | **byte[]** | X component of an EC public key |  [optional]
**y** | **byte[]** | Y component of an EC public key. |  [optional]


<a name="CrvEnum"></a>
## Enum: CrvEnum
Name | Value
---- | -----
P_256 | &quot;P_256&quot;
P_384 | &quot;P_384&quot;
P_521 | &quot;P_521&quot;
SECP256K1 | &quot;SECP256K1&quot;


<a name="KtyEnum"></a>
## Enum: KtyEnum
Name | Value
---- | -----
EC | &quot;EC&quot;
RSA | &quot;RSA&quot;
OCT | &quot;OCT&quot;


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



