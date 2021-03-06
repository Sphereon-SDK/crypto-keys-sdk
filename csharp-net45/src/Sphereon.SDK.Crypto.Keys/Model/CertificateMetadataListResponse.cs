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
    /// Certificate Metadata list response
    /// </summary>
    [DataContract]
    public partial class CertificateMetadataListResponse :  IEquatable<CertificateMetadataListResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateMetadataListResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CertificateMetadataListResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateMetadataListResponse" /> class.
        /// </summary>
        /// <param name="CertificateMetadata">The certificate metadata keyed by certificate id (required).</param>
        public CertificateMetadataListResponse(Dictionary<string, CertificateMetadata> CertificateMetadata = default(Dictionary<string, CertificateMetadata>))
        {
            // to ensure "CertificateMetadata" is required (not null)
            if (CertificateMetadata == null)
            {
                throw new InvalidDataException("CertificateMetadata is a required property for CertificateMetadataListResponse and cannot be null");
            }
            else
            {
                this.CertificateMetadata = CertificateMetadata;
            }
        }
        
        /// <summary>
        /// The certificate metadata keyed by certificate id
        /// </summary>
        /// <value>The certificate metadata keyed by certificate id</value>
        [DataMember(Name="certificateMetadata", EmitDefaultValue=false)]
        public Dictionary<string, CertificateMetadata> CertificateMetadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CertificateMetadataListResponse {\n");
            sb.Append("  CertificateMetadata: ").Append(CertificateMetadata).Append("\n");
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
            return this.Equals(obj as CertificateMetadataListResponse);
        }

        /// <summary>
        /// Returns true if CertificateMetadataListResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CertificateMetadataListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CertificateMetadataListResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CertificateMetadata == other.CertificateMetadata ||
                    this.CertificateMetadata != null &&
                    this.CertificateMetadata.SequenceEqual(other.CertificateMetadata)
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
                if (this.CertificateMetadata != null)
                    hash = hash * 59 + this.CertificateMetadata.GetHashCode();
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
