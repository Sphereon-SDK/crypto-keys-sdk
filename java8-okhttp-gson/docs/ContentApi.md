# ContentApi

All URIs are relative to *https://gw.api.cloud.sphereon.com/crypto/keys/0.9*

Method | HTTP request | Description
------------- | ------------- | -------------
[**decryptUsingKey**](ContentApi.md#decryptUsingKey) | **POST** /{config}/keys/{name}/{version}/decrypt | Decrypt value
[**encryptUsingKey**](ContentApi.md#encryptUsingKey) | **POST** /{config}/keys/{name}/{version}/encrypt | Encrypt value
[**signUsingKey**](ContentApi.md#signUsingKey) | **POST** /{config}/keys/{name}/{version}/sign | Create signature
[**verifyUsingKey**](ContentApi.md#verifyUsingKey) | **POST** /{config}/keys/{name}/{version}/verify | Verify signature


<a name="decryptUsingKey"></a>
# **decryptUsingKey**
> KeyDecryptResponse decryptUsingKey(config, name, version, request)

Decrypt value

Decrypts a well-formed block of ciphertext using the target encryption key and specified algorithm. This operation is the reverse of the encrypt operation. This operation applies to asymmetric and symmetric keys since it uses the private portion of the key.

### Example
```java
// Import classes:
//import com.sphereon.sdk.crypto.keys.handler.ApiClient;
//import com.sphereon.sdk.crypto.keys.handler.ApiException;
//import com.sphereon.sdk.crypto.keys.handler.Configuration;
//import com.sphereon.sdk.crypto.keys.handler.auth.*;
//import com.sphereon.sdk.crypto.keys.api.ContentApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: oauth2schema
OAuth oauth2schema = (OAuth) defaultClient.getAuthentication("oauth2schema");
oauth2schema.setAccessToken("YOUR ACCESS TOKEN");

ContentApi apiInstance = new ContentApi();
String config = "config_example"; // String | config
String name = "name_example"; // String | name
String version = "version_example"; // String | version
KeyDecryptRequest request = new KeyDecryptRequest(); // KeyDecryptRequest | The decrypt request
try {
    KeyDecryptResponse result = apiInstance.decryptUsingKey(config, name, version, request);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ContentApi#decryptUsingKey");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **config** | **String**| config |
 **name** | **String**| name |
 **version** | **String**| version |
 **request** | [**KeyDecryptRequest**](KeyDecryptRequest.md)| The decrypt request |

### Return type

[**KeyDecryptResponse**](KeyDecryptResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: application/json;charset=UTF-8
 - **Accept**: application/json;charset=UTF-8

<a name="encryptUsingKey"></a>
# **encryptUsingKey**
> KeyEncryptResponse encryptUsingKey(config, name, version, request)

Encrypt value

Encrypts a sequence of bytes using an encryption key. This operation is only strictly necessary for symmetric keys since encryption with an asymmetric key can be performed using the public portion of the key. This operation is supported for asymmetric keys as a convenience for callers that have a key-reference but do not have access to the public key material.

### Example
```java
// Import classes:
//import com.sphereon.sdk.crypto.keys.handler.ApiClient;
//import com.sphereon.sdk.crypto.keys.handler.ApiException;
//import com.sphereon.sdk.crypto.keys.handler.Configuration;
//import com.sphereon.sdk.crypto.keys.handler.auth.*;
//import com.sphereon.sdk.crypto.keys.api.ContentApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: oauth2schema
OAuth oauth2schema = (OAuth) defaultClient.getAuthentication("oauth2schema");
oauth2schema.setAccessToken("YOUR ACCESS TOKEN");

ContentApi apiInstance = new ContentApi();
String config = "config_example"; // String | config
String name = "name_example"; // String | name
String version = "version_example"; // String | version
KeyEncryptRequest request = new KeyEncryptRequest(); // KeyEncryptRequest | The encrypt request
try {
    KeyEncryptResponse result = apiInstance.encryptUsingKey(config, name, version, request);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ContentApi#encryptUsingKey");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **config** | **String**| config |
 **name** | **String**| name |
 **version** | **String**| version |
 **request** | [**KeyEncryptRequest**](KeyEncryptRequest.md)| The encrypt request |

### Return type

[**KeyEncryptResponse**](KeyEncryptResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: application/json;charset=UTF-8
 - **Accept**: application/json;charset=UTF-8

<a name="signUsingKey"></a>
# **signUsingKey**
> KeySignResponse signUsingKey(config, name, version, request)

Create signature

Creates a signature from a digest using a key. This operation is applicable to asymmetric and symmetric keys, since this operation uses the private portion of the key. Please note that the input needs to be a hash using a hash algorithm that fits the JsonWebKeySignatureAlgorithm, meaning SHA-256, SHA-384 or SHA-512

### Example
```java
// Import classes:
//import com.sphereon.sdk.crypto.keys.handler.ApiClient;
//import com.sphereon.sdk.crypto.keys.handler.ApiException;
//import com.sphereon.sdk.crypto.keys.handler.Configuration;
//import com.sphereon.sdk.crypto.keys.handler.auth.*;
//import com.sphereon.sdk.crypto.keys.api.ContentApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: oauth2schema
OAuth oauth2schema = (OAuth) defaultClient.getAuthentication("oauth2schema");
oauth2schema.setAccessToken("YOUR ACCESS TOKEN");

ContentApi apiInstance = new ContentApi();
String config = "config_example"; // String | config
String name = "name_example"; // String | name
String version = "version_example"; // String | version
KeySignRequest request = new KeySignRequest(); // KeySignRequest | The sign request
try {
    KeySignResponse result = apiInstance.signUsingKey(config, name, version, request);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ContentApi#signUsingKey");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **config** | **String**| config |
 **name** | **String**| name |
 **version** | **String**| version |
 **request** | [**KeySignRequest**](KeySignRequest.md)| The sign request |

### Return type

[**KeySignResponse**](KeySignResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: application/json;charset=UTF-8
 - **Accept**: application/json;charset=UTF-8

<a name="verifyUsingKey"></a>
# **verifyUsingKey**
> KeyVerifyResponse verifyUsingKey(config, name, version, request)

Verify signature

Verifies a signature using a key. This operation is applicable to assymetric and symmetric keys. It is not strictly necessary for asymmetric keys, since signature verification can be performed using the public portion of the key but this operation is supported as a convenience for callers that only have a key-reference and not the public portion of the key.

### Example
```java
// Import classes:
//import com.sphereon.sdk.crypto.keys.handler.ApiClient;
//import com.sphereon.sdk.crypto.keys.handler.ApiException;
//import com.sphereon.sdk.crypto.keys.handler.Configuration;
//import com.sphereon.sdk.crypto.keys.handler.auth.*;
//import com.sphereon.sdk.crypto.keys.api.ContentApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: oauth2schema
OAuth oauth2schema = (OAuth) defaultClient.getAuthentication("oauth2schema");
oauth2schema.setAccessToken("YOUR ACCESS TOKEN");

ContentApi apiInstance = new ContentApi();
String config = "config_example"; // String | config
String name = "name_example"; // String | name
String version = "version_example"; // String | version
KeyVerifyRequest request = new KeyVerifyRequest(); // KeyVerifyRequest | The verify request
try {
    KeyVerifyResponse result = apiInstance.verifyUsingKey(config, name, version, request);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ContentApi#verifyUsingKey");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **config** | **String**| config |
 **name** | **String**| name |
 **version** | **String**| version |
 **request** | [**KeyVerifyRequest**](KeyVerifyRequest.md)| The verify request |

### Return type

[**KeyVerifyResponse**](KeyVerifyResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: application/json;charset=UTF-8
 - **Accept**: application/json;charset=UTF-8

