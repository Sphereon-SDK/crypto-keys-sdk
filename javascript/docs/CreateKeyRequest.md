# CryptoKeys.CreateKeyRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**kty** | **String** |  | [optional] 
**applicationMetadata** | **{String: String}** |  | [optional] 
**crv** | **String** |  | [optional] 
**keyOps** | **[String]** |  | [optional] 
**name** | **String** |  | [optional] 
**attributes** | [**Attributes**](Attributes.md) |  | [optional] 
**keySize** | **Number** |  | [optional] 


<a name="KtyEnum"></a>
## Enum: KtyEnum


* `EC` (value: `"EC"`)

* `RSA` (value: `"RSA"`)

* `OCT` (value: `"OCT"`)




<a name="CrvEnum"></a>
## Enum: CrvEnum


* `P_256` (value: `"P_256"`)

* `P_384` (value: `"P_384"`)

* `P_521` (value: `"P_521"`)

* `SECP256K1` (value: `"SECP256K1"`)




<a name="[KeyOpsEnum]"></a>
## Enum: [KeyOpsEnum]


* `ENCRYPT` (value: `"ENCRYPT"`)

* `DECRYPT` (value: `"DECRYPT"`)

* `SIGN` (value: `"SIGN"`)

* `VERIFY` (value: `"VERIFY"`)

* `WRAP_KEY` (value: `"WRAP_KEY"`)

* `UNWRAP_KEY` (value: `"UNWRAP_KEY"`)




