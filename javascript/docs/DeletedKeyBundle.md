# CryptoKeys.DeletedKeyBundle

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**hsmType** | **String** | The HSM Type if any | 
**scheduledPurgeTime** | **Date** |  | [optional] 
**backendMetadata** | **{String: String}** | StorageType metadata. This is the place where additional metadata return from the backend is stored | [optional] 
**applicationMetadata** | **{String: String}** | Application metadata. This is the place where you can store your own tags | [optional] 
**managed** | **Boolean** | True if the key is backing a certificate | [optional] 
**kid** | **String** | Key Id | 
**attributes** | [**Attributes**](Attributes.md) | The attributes | [optional] 
**deletedTime** | **Date** |  | [optional] 
**recoveryId** | **String** |  | [optional] 
**key** | [**JsonWebKey**](JsonWebKey.md) | The Json Web Key | 
**url** | **String** | Key URL | 


<a name="HsmTypeEnum"></a>
## Enum: HsmTypeEnum


* `NONE` (value: `"NONE"`)

* `AZURE_KEYVAULT_HSM` (value: `"AZURE_KEYVAULT_HSM"`)




