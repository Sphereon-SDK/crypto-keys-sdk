# CryptoKeys.Configuration

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**azureKeyVaultSettings** | [**AzureKeyVaultSettings**](AzureKeyVaultSettings.md) |  | [optional] 
**implementationType** | **String** |  | [optional] 
**localStorageSettings** | [**LocalStorageSettings**](LocalStorageSettings.md) |  | [optional] 
**storageTypeType** | **String** |  | [optional] 
**name** | **String** | The name as it appears in the urls. Allowed values hexadecimal characters and - | 
**id** | **String** | The id of the configuration | [optional] 


<a name="ImplementationTypeEnum"></a>
## Enum: ImplementationTypeEnum


* `AZURE_KEYVAULT_MANAGED` (value: `"AZURE_KEYVAULT_MANAGED"`)

* `AZURE_KEYVAULT_DEDICATED` (value: `"AZURE_KEYVAULT_DEDICATED"`)

* `KEYSTORE_FILE` (value: `"KEYSTORE_FILE"`)




<a name="StorageTypeTypeEnum"></a>
## Enum: StorageTypeTypeEnum


* `AZURE_KEYVAULT` (value: `"AZURE_KEYVAULT"`)

* `LOCAL_STORAGE` (value: `"LOCAL_STORAGE"`)




