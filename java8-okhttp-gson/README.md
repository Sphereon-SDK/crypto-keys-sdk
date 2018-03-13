# crypto-keys-sdk-java8-okhttp-gson

## Requirements

Building the API client library requires [Maven](https://maven.apache.org/) to be installed.

## Installation

To install the API client library to your local Maven repository, simply execute:

```shell
mvn install
```

To deploy it to a remote Maven repository instead, configure the settings of the repository and execute:

```shell
mvn deploy
```

Refer to the [official documentation](https://maven.apache.org/plugins/maven-deploy-plugin/usage.html) for more information.

### Maven users

Add this dependency to your project's POM:

```xml
<dependency>
    <groupId>com.sphereon.sdk</groupId>
    <artifactId>crypto-keys-sdk-java8-okhttp-gson</artifactId>
    <version>0.9.0</version>
    <scope>compile</scope>
</dependency>
```

### Gradle users

Add this dependency to your project's build file:

```groovy
compile "com.sphereon.sdk:crypto-keys-sdk-java8-okhttp-gson:0.9.0"
```

### Others

At first generate the JAR by executing:

    mvn package

Then manually install the following JARs:

* target/crypto-keys-sdk-java8-okhttp-gson-0.9.0.jar
* target/lib/*.jar

## Getting Started

Please follow the [installation](#installation) instruction and execute the following Java code:

```java

import com.sphereon.sdk.crypto.keys.handler.*;
import com.sphereon.sdk.crypto.keys.handler.auth.*;
import com.sphereon.sdk.crypto.keys.model.*;
import com.sphereon.sdk.crypto.keys.api.CertApi;

import java.io.File;
import java.util.*;

public class CertApiExample {

    public static void main(String[] args) {
        ApiClient defaultClient = Configuration.getDefaultApiClient();
        
        // Configure OAuth2 access token for authorization: oauth2schema
        OAuth oauth2schema = (OAuth) defaultClient.getAuthentication("oauth2schema");
        oauth2schema.setAccessToken("YOUR ACCESS TOKEN");

        CertApi apiInstance = new CertApi();
        String config = "config_example"; // String | config
        CreateCertificateRequest certificateRequest = new CreateCertificateRequest(); // CreateCertificateRequest | The create certificate request
        try {
            CreateCertificateResponse result = apiInstance.createCert(config, certificateRequest);
            System.out.println(result);
        } catch (ApiException e) {
            System.err.println("Exception when calling CertApi#createCert");
            e.printStackTrace();
        }
    }
}

```

## Documentation for API Endpoints

All URIs are relative to *https://gw.api.cloud.sphereon.com/crypto/keys/0.9*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*CertApi* | [**createCert**](docs/CertApi.md#createCert) | **POST** /{config}/certs/create | Create certificate
*CertApi* | [**deleteCert**](docs/CertApi.md#deleteCert) | **DELETE** /{config}/certs/{name} | Delete certificate
*CertApi* | [**getCert**](docs/CertApi.md#getCert) | **GET** /{config}/certs/{name}/{version} | Get certificate info
*CertApi* | [**importCert**](docs/CertApi.md#importCert) | **POST** /{config}/certs/import | Import certificate
*CertApi* | [**listCerts**](docs/CertApi.md#listCerts) | **GET** /{config}/certs | List certificates metadata information
*ConfigApi* | [**createConfiguration**](docs/ConfigApi.md#createConfiguration) | **POST** /manage/configs | Create a new Configuration
*ConfigApi* | [**deleteConfiguration**](docs/ConfigApi.md#deleteConfiguration) | **DELETE** /manage/configs/{config} | Delete Configuration
*ConfigApi* | [**getConfiguration**](docs/ConfigApi.md#getConfiguration) | **GET** /manage/configs/{config} | Get Configuration
*ConfigApi* | [**updateConfiguration**](docs/ConfigApi.md#updateConfiguration) | **PUT** /manage/configs/{config} | Update Configuration
*ContentApi* | [**decryptUsingKey**](docs/ContentApi.md#decryptUsingKey) | **POST** /{config}/keys/{name}/{version}/decrypt | Decrypt value
*ContentApi* | [**encryptUsingKey**](docs/ContentApi.md#encryptUsingKey) | **POST** /{config}/keys/{name}/{version}/encrypt | Encrypt value
*ContentApi* | [**signUsingKey**](docs/ContentApi.md#signUsingKey) | **POST** /{config}/keys/{name}/{version}/sign | Create signature
*ContentApi* | [**verifyUsingKey**](docs/ContentApi.md#verifyUsingKey) | **POST** /{config}/keys/{name}/{version}/verify | Verify signature
*KeyApi* | [**createKey**](docs/KeyApi.md#createKey) | **POST** /{config}/keys/create | Create key
*KeyApi* | [**deleteKey**](docs/KeyApi.md#deleteKey) | **DELETE** /{config}/keys/{name} | Delete key
*KeyApi* | [**getKey**](docs/KeyApi.md#getKey) | **GET** /{config}/keys/{name}/{version} | Get key information
*KeyApi* | [**importKey**](docs/KeyApi.md#importKey) | **POST** /{config}/keys/import | Import key
*KeyApi* | [**listKeys**](docs/KeyApi.md#listKeys) | **GET** /{config}/keys | List keys metadata information


## Documentation for Models

 - [Action](docs/Action.md)
 - [Attributes](docs/Attributes.md)
 - [AzureKeyVaultSettings](docs/AzureKeyVaultSettings.md)
 - [CertificateBundle](docs/CertificateBundle.md)
 - [CertificateBundleResponse](docs/CertificateBundleResponse.md)
 - [CertificateMetadata](docs/CertificateMetadata.md)
 - [CertificateMetadataListResponse](docs/CertificateMetadataListResponse.md)
 - [CertificateParameters](docs/CertificateParameters.md)
 - [CertificatePolicy](docs/CertificatePolicy.md)
 - [ConfigurationResponse](docs/ConfigurationResponse.md)
 - [CreateCertificateRequest](docs/CreateCertificateRequest.md)
 - [CreateCertificateResponse](docs/CreateCertificateResponse.md)
 - [CreateConfigurationRequest](docs/CreateConfigurationRequest.md)
 - [CreateKeyRequest](docs/CreateKeyRequest.md)
 - [DeletedCertificateBundle](docs/DeletedCertificateBundle.md)
 - [DeletedCertificateBundleResponse](docs/DeletedCertificateBundleResponse.md)
 - [DeletedKeyBundle](docs/DeletedKeyBundle.md)
 - [DeletedKeyBundleResponse](docs/DeletedKeyBundleResponse.md)
 - [ImportCertificateRequest](docs/ImportCertificateRequest.md)
 - [ImportKeyRequest](docs/ImportKeyRequest.md)
 - [IssuerParameters](docs/IssuerParameters.md)
 - [JsonWebKey](docs/JsonWebKey.md)
 - [KeyBundle](docs/KeyBundle.md)
 - [KeyBundleResponse](docs/KeyBundleResponse.md)
 - [KeyDecryptRequest](docs/KeyDecryptRequest.md)
 - [KeyDecryptResponse](docs/KeyDecryptResponse.md)
 - [KeyEncryptRequest](docs/KeyEncryptRequest.md)
 - [KeyEncryptResponse](docs/KeyEncryptResponse.md)
 - [KeyMetadata](docs/KeyMetadata.md)
 - [KeyMetadataListResponse](docs/KeyMetadataListResponse.md)
 - [KeyProperties](docs/KeyProperties.md)
 - [KeySignRequest](docs/KeySignRequest.md)
 - [KeySignResponse](docs/KeySignResponse.md)
 - [KeyVerifyRequest](docs/KeyVerifyRequest.md)
 - [KeyVerifyResponse](docs/KeyVerifyResponse.md)
 - [LifetimeAction](docs/LifetimeAction.md)
 - [LocalStorageSettings](docs/LocalStorageSettings.md)
 - [ModelConfiguration](docs/ModelConfiguration.md)
 - [SecretProperties](docs/SecretProperties.md)
 - [SubjectAlternativeNames](docs/SubjectAlternativeNames.md)
 - [Trigger](docs/Trigger.md)
 - [UpdateConfigurationRequest](docs/UpdateConfigurationRequest.md)
 - [X509Properties](docs/X509Properties.md)


## Documentation for Authorization

Authentication schemes defined for the API:
### oauth2schema

- **Type**: OAuth
- **Flow**: application
- **Authorization URL**: 
- **Scopes**: 
  - global: accessEverything


## Recommendation

It's recommended to create an instance of `ApiClient` per thread in a multithreaded environment to avoid any potential issues.

## Author

dev@sphereon.com

