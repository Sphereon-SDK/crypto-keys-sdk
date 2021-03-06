/* 
 * Crypto Keys
 *
 * The Crypto Keys API allows you to import, create and work with symmetric and asymmetric keys and certificates to sign/verify digest values, encrypt/decrypt input, or hash and sign input values. The benefit is that you don't have to store secret keys in your application.  The API has an integration with Azure KeyVault, allowing you to store keys, secrets and certificates in FIPS 140-2 Level 2 validated Hardware Security Modules (HSM). The key will never leave the HSM, making it really secure, especially if you combine it with IP whitelisting      Interactive testing: A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
 *
 * OpenAPI spec version: 0.9
 * Contact: dev@sphereon.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Sphereon.SDK.Crypto.Keys.Api;
using Sphereon.SDK.Crypto.Keys.Model;
using Sphereon.SDK.Crypto.Keys.Client;
using System.Reflection;

namespace Sphereon.SDK.Crypto.Keys.Test
{
    /// <summary>
    ///  Class for testing IssuerParameters
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class IssuerParametersTests
    {
        // TODO uncomment below to declare an instance variable for IssuerParameters
        //private IssuerParameters instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of IssuerParameters
            //instance = new IssuerParameters();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of IssuerParameters
        /// </summary>
        [Test]
        public void IssuerParametersInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" IssuerParameters
            //Assert.IsInstanceOfType<IssuerParameters> (instance, "variable 'instance' is a IssuerParameters");
        }

        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Cty'
        /// </summary>
        [Test]
        public void CtyTest()
        {
            // TODO unit test for the property 'Cty'
        }

    }

}
