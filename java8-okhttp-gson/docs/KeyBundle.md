
# KeyBundle

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**hsmType** | [**HsmTypeEnum**](#HsmTypeEnum) | The HSM Type if any | 
**backendMetadata** | **Map&lt;String, String&gt;** | StorageType metadata. This is the place where additional metadata return from the backend is stored |  [optional]
**applicationMetadata** | **Map&lt;String, String&gt;** | Application metadata. This is the place where you can store your own tags |  [optional]
**managed** | **Boolean** | True if the key is backing a certificate |  [optional]
**kid** | **String** | Key Id | 
**attributes** | [**Attributes**](Attributes.md) | The attributes |  [optional]
**key** | [**JsonWebKey**](JsonWebKey.md) | The Json Web Key | 
**url** | **String** | Key URL | 


<a name="HsmTypeEnum"></a>
## Enum: HsmTypeEnum
Name | Value
---- | -----
NONE | &quot;NONE&quot;
AZURE_KEYVAULT_HSM | &quot;AZURE_KEYVAULT_HSM&quot;



