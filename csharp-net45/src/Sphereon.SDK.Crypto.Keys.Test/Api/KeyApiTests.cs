/* 
 * Crypto Keys
 *
 * The Crypto Keys API allows you to import, create and work with symmetric and asymmetric keys and certificates to sign/verify digest values, encrypt/decrypt input, or hash and sign input values. The benefit is that you don't have to store secret keys in your application.  The API has an integration with Azure KeyVault, allowing you to store keys, secrets and certificates in FIPS 140-2 Level 2 validated Hardware Security Modules (HSM). The key will never leave the HSM, making it really secure, especially if you combine it with IP whitelisting      Interactive testing: A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
 *
 * OpenAPI spec version: 0.9
 * Contact: dev@sphereon.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Sphereon.SDK.Crypto.Keys.Client;
using Sphereon.SDK.Crypto.Keys.Api;
using Sphereon.SDK.Crypto.Keys.Model;

namespace Sphereon.SDK.Crypto.Keys.Test
{
    /// <summary>
    ///  Class for testing KeyApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class KeyApiTests
    {
        private KeyApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new KeyApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of KeyApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' KeyApi
            //Assert.IsInstanceOfType(typeof(KeyApi), instance, "instance is a KeyApi");
        }

        
        /// <summary>
        /// Test CreateKey
        /// </summary>
        [Test]
        public void CreateKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string config = null;
            //CreateKeyRequest request = null;
            //var response = instance.CreateKey(config, request);
            //Assert.IsInstanceOf<KeyBundle> (response, "response is KeyBundle");
        }
        
        /// <summary>
        /// Test DeleteKey
        /// </summary>
        [Test]
        public void DeleteKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string config = null;
            //string name = null;
            //var response = instance.DeleteKey(config, name);
            //Assert.IsInstanceOf<DeletedKeyBundleResponse> (response, "response is DeletedKeyBundleResponse");
        }
        
        /// <summary>
        /// Test GetKey
        /// </summary>
        [Test]
        public void GetKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string config = null;
            //string name = null;
            //string version = null;
            //var response = instance.GetKey(config, name, version);
            //Assert.IsInstanceOf<KeyBundleResponse> (response, "response is KeyBundleResponse");
        }
        
        /// <summary>
        /// Test ImportKey
        /// </summary>
        [Test]
        public void ImportKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string config = null;
            //ImportKeyRequest request = null;
            //var response = instance.ImportKey(config, request);
            //Assert.IsInstanceOf<KeyBundle> (response, "response is KeyBundle");
        }
        
        /// <summary>
        /// Test ListKeys
        /// </summary>
        [Test]
        public void ListKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string config = null;
            //var response = instance.ListKeys(config);
            //Assert.IsInstanceOf<KeyMetadataListResponse> (response, "response is KeyMetadataListResponse");
        }
        
    }

}
