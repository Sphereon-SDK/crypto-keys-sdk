# Sphereon.SDK.Crypto.Keys.Model.KeyBundle
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HsmType** | **string** | The HSM Type if any | 
**BackendMetadata** | **Dictionary&lt;string, string&gt;** | StorageType metadata. This is the place where additional metadata return from the backend is stored | [optional] 
**ApplicationMetadata** | **Dictionary&lt;string, string&gt;** | Application metadata. This is the place where you can store your own tags | [optional] 
**Managed** | **bool?** | True if the key is backing a certificate | [optional] 
**Kid** | **string** | Key Id | 
**Attributes** | [**Attributes**](Attributes.md) | The attributes | [optional] 
**Key** | [**JsonWebKey**](JsonWebKey.md) | The Json Web Key | 
**Url** | **string** | Key URL | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

