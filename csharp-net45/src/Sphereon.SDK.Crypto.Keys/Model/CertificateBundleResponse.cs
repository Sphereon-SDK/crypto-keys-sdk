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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Sphereon.SDK.Crypto.Keys.Client.SwaggerDateConverter;

namespace Sphereon.SDK.Crypto.Keys.Model
{
    /// <summary>
    /// Certificate bundle response
    /// </summary>
    [DataContract]
    public partial class CertificateBundleResponse :  IEquatable<CertificateBundleResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateBundleResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CertificateBundleResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateBundleResponse" /> class.
        /// </summary>
        /// <param name="CertificateBundle">Certificate bundle (required).</param>
        public CertificateBundleResponse(CertificateBundle CertificateBundle = default(CertificateBundle))
        {
            // to ensure "CertificateBundle" is required (not null)
            if (CertificateBundle == null)
            {
                throw new InvalidDataException("CertificateBundle is a required property for CertificateBundleResponse and cannot be null");
            }
            else
            {
                this.CertificateBundle = CertificateBundle;
            }
        }
        
        /// <summary>
        /// Certificate bundle
        /// </summary>
        /// <value>Certificate bundle</value>
        [DataMember(Name="certificateBundle", EmitDefaultValue=false)]
        public CertificateBundle CertificateBundle { get; set; }

        /// <summary>
        /// The name/id of the certificate
        /// </summary>
        /// <value>The name/id of the certificate</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// The version of the bundle
        /// </summary>
        /// <value>The version of the bundle</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CertificateBundleResponse {\n");
            sb.Append("  CertificateBundle: ").Append(CertificateBundle).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as CertificateBundleResponse);
        }

        /// <summary>
        /// Returns true if CertificateBundleResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CertificateBundleResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CertificateBundleResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CertificateBundle == other.CertificateBundle ||
                    this.CertificateBundle != null &&
                    this.CertificateBundle.Equals(other.CertificateBundle)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.CertificateBundle != null)
                    hash = hash * 59 + this.CertificateBundle.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
