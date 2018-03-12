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
    ///  Class for testing DeletedCertificateBundle
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class DeletedCertificateBundleTests
    {
        // TODO uncomment below to declare an instance variable for DeletedCertificateBundle
        //private DeletedCertificateBundle instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of DeletedCertificateBundle
            //instance = new DeletedCertificateBundle();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DeletedCertificateBundle
        /// </summary>
        [Test]
        public void DeletedCertificateBundleInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" DeletedCertificateBundle
            //Assert.IsInstanceOfType<DeletedCertificateBundle> (instance, "variable 'instance' is a DeletedCertificateBundle");
        }

        /// <summary>
        /// Test the property 'BackendMetadata'
        /// </summary>
        [Test]
        public void BackendMetadataTest()
        {
            // TODO unit test for the property 'BackendMetadata'
        }
        /// <summary>
        /// Test the property 'ApplicationMetadata'
        /// </summary>
        [Test]
        public void ApplicationMetadataTest()
        {
            // TODO unit test for the property 'ApplicationMetadata'
        }
        /// <summary>
        /// Test the property 'Kid'
        /// </summary>
        [Test]
        public void KidTest()
        {
            // TODO unit test for the property 'Kid'
        }
        /// <summary>
        /// Test the property 'MediaType'
        /// </summary>
        [Test]
        public void MediaTypeTest()
        {
            // TODO unit test for the property 'MediaType'
        }
        /// <summary>
        /// Test the property 'RecoveryId'
        /// </summary>
        [Test]
        public void RecoveryIdTest()
        {
            // TODO unit test for the property 'RecoveryId'
        }
        /// <summary>
        /// Test the property 'Url'
        /// </summary>
        [Test]
        public void UrlTest()
        {
            // TODO unit test for the property 'Url'
        }
        /// <summary>
        /// Test the property 'Sid'
        /// </summary>
        [Test]
        public void SidTest()
        {
            // TODO unit test for the property 'Sid'
        }
        /// <summary>
        /// Test the property 'Cer'
        /// </summary>
        [Test]
        public void CerTest()
        {
            // TODO unit test for the property 'Cer'
        }
        /// <summary>
        /// Test the property 'ScheduledPurgeTime'
        /// </summary>
        [Test]
        public void ScheduledPurgeTimeTest()
        {
            // TODO unit test for the property 'ScheduledPurgeTime'
        }
        /// <summary>
        /// Test the property 'Attributes'
        /// </summary>
        [Test]
        public void AttributesTest()
        {
            // TODO unit test for the property 'Attributes'
        }
        /// <summary>
        /// Test the property 'DeletedTime'
        /// </summary>
        [Test]
        public void DeletedTimeTest()
        {
            // TODO unit test for the property 'DeletedTime'
        }
        /// <summary>
        /// Test the property 'X509Thumbprint'
        /// </summary>
        [Test]
        public void X509ThumbprintTest()
        {
            // TODO unit test for the property 'X509Thumbprint'
        }
        /// <summary>
        /// Test the property 'Cid'
        /// </summary>
        [Test]
        public void CidTest()
        {
            // TODO unit test for the property 'Cid'
        }
        /// <summary>
        /// Test the property 'Policy'
        /// </summary>
        [Test]
        public void PolicyTest()
        {
            // TODO unit test for the property 'Policy'
        }

    }

}
