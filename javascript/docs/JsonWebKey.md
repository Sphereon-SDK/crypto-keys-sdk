# CryptoKeys.JsonWebKey

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**d** | **Blob** | RSA private exponent | [optional] 
**e** | **Blob** | RSA public exponent | [optional] 
**crv** | **String** | Elliptic curve name. see JsonWebKeyCurveName | [optional] 
**kid** | **String** | Key id | [optional] 
**k** | **Blob** | Symmetric key | [optional] 
**dp** | **Blob** | RSA Private Key Parameter | [optional] 
**dq** | **Blob** | RSA Private Key Parameter | [optional] 
**n** | **Blob** | RSA modulus | [optional] 
**p** | **Blob** | RSA secret prime | [optional] 
**kty** | **String** | Key type | [optional] 
**q** | **Blob** | RSA secret prime, with p &lt; q | [optional] 
**t** | **Blob** | HSM Token, used with Bring Your Own Key | [optional] 
**keyOps** | **[String]** | Supported operations | [optional] 
**qi** | **Blob** | RSA Private Key Parameter | [optional] 
**x** | **Blob** | X component of an EC public key | [optional] 
**y** | **Blob** | Y component of an EC public key. | [optional] 


<a name="CrvEnum"></a>
## Enum: CrvEnum


* `P_256` (value: `"P_256"`)

* `P_384` (value: `"P_384"`)

* `P_521` (value: `"P_521"`)

* `SECP256K1` (value: `"SECP256K1"`)




<a name="KtyEnum"></a>
## Enum: KtyEnum


* `EC` (value: `"EC"`)

* `RSA` (value: `"RSA"`)

* `OCT` (value: `"OCT"`)




<a name="[KeyOpsEnum]"></a>
## Enum: [KeyOpsEnum]


* `ENCRYPT` (value: `"ENCRYPT"`)

* `DECRYPT` (value: `"DECRYPT"`)

* `SIGN` (value: `"SIGN"`)

* `VERIFY` (value: `"VERIFY"`)

* `WRAP_KEY` (value: `"WRAP_KEY"`)

* `UNWRAP_KEY` (value: `"UNWRAP_KEY"`)




