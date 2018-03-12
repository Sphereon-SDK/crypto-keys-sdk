
# ModelConfiguration

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**azureKeyVaultSettings** | [**AzureKeyVaultSettings**](AzureKeyVaultSettings.md) |  |  [optional]
**implementationType** | [**ImplementationTypeEnum**](#ImplementationTypeEnum) |  |  [optional]
**localStorageSettings** | [**LocalStorageSettings**](LocalStorageSettings.md) |  |  [optional]
**storageTypeType** | [**StorageTypeTypeEnum**](#StorageTypeTypeEnum) |  |  [optional]
**name** | **String** | The name as it appears in the urls. Allowed values hexadecimal characters and - | 
**id** | **String** | The id of the configuration |  [optional]


<a name="ImplementationTypeEnum"></a>
## Enum: ImplementationTypeEnum
Name | Value
---- | -----
AZURE_KEYVAULT_MANAGED | &quot;AZURE_KEYVAULT_MANAGED&quot;
AZURE_KEYVAULT_DEDICATED | &quot;AZURE_KEYVAULT_DEDICATED&quot;
KEYSTORE_FILE | &quot;KEYSTORE_FILE&quot;


<a name="StorageTypeTypeEnum"></a>
## Enum: StorageTypeTypeEnum
Name | Value
---- | -----
AZURE_KEYVAULT | &quot;AZURE_KEYVAULT&quot;
LOCAL_STORAGE | &quot;LOCAL_STORAGE&quot;



