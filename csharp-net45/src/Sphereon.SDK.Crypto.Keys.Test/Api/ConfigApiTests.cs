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
    ///  Class for testing ConfigApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ConfigApiTests
    {
        private ConfigApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ConfigApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ConfigApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ConfigApi
            //Assert.IsInstanceOfType(typeof(ConfigApi), instance, "instance is a ConfigApi");
        }

        
        /// <summary>
        /// Test CreateConfiguration
        /// </summary>
        [Test]
        public void CreateConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateConfigurationRequest request = null;
            //var response = instance.CreateConfiguration(request);
            //Assert.IsInstanceOf<ConfigurationResponse> (response, "response is ConfigurationResponse");
        }
        
        /// <summary>
        /// Test DeleteConfiguration
        /// </summary>
        [Test]
        public void DeleteConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string config = null;
            //var response = instance.DeleteConfiguration(config);
            //Assert.IsInstanceOf<ConfigurationResponse> (response, "response is ConfigurationResponse");
        }
        
        /// <summary>
        /// Test GetConfiguration
        /// </summary>
        [Test]
        public void GetConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string config = null;
            //var response = instance.GetConfiguration(config);
            //Assert.IsInstanceOf<ConfigurationResponse> (response, "response is ConfigurationResponse");
        }
        
        /// <summary>
        /// Test UpdateConfiguration
        /// </summary>
        [Test]
        public void UpdateConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string config = null;
            //UpdateConfigurationRequest request = null;
            //var response = instance.UpdateConfiguration(config, request);
            //Assert.IsInstanceOf<ConfigurationResponse> (response, "response is ConfigurationResponse");
        }
        
    }

}
