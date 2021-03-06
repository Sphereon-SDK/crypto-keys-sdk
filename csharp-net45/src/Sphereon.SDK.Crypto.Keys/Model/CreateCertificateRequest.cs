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
    /// Create certificate request
    /// </summary>
    [DataContract]
    public partial class CreateCertificateRequest :  IEquatable<CreateCertificateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCertificateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateCertificateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCertificateRequest" /> class.
        /// </summary>
        /// <param name="ApplicationMetadata">Application metadata. This is the place where you can store your own tags.</param>
        /// <param name="Name">The name for the certificate (required).</param>
        /// <param name="Attributes">The attributes.</param>
        /// <param name="Policy">The policy (required).</param>
        public CreateCertificateRequest(Dictionary<string, string> ApplicationMetadata = default(Dictionary<string, string>), string Name = default(string), Attributes Attributes = default(Attributes), CertificatePolicy Policy = default(CertificatePolicy))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for CreateCertificateRequest and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Policy" is required (not null)
            if (Policy == null)
            {
                throw new InvalidDataException("Policy is a required property for CreateCertificateRequest and cannot be null");
            }
            else
            {
                this.Policy = Policy;
            }
            this.ApplicationMetadata = ApplicationMetadata;
            this.Attributes = Attributes;
        }
        
        /// <summary>
        /// Application metadata. This is the place where you can store your own tags
        /// </summary>
        /// <value>Application metadata. This is the place where you can store your own tags</value>
        [DataMember(Name="applicationMetadata", EmitDefaultValue=false)]
        public Dictionary<string, string> ApplicationMetadata { get; set; }

        /// <summary>
        /// The name for the certificate
        /// </summary>
        /// <value>The name for the certificate</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The attributes
        /// </summary>
        /// <value>The attributes</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Attributes Attributes { get; set; }

        /// <summary>
        /// The policy
        /// </summary>
        /// <value>The policy</value>
        [DataMember(Name="policy", EmitDefaultValue=false)]
        public CertificatePolicy Policy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCertificateRequest {\n");
            sb.Append("  ApplicationMetadata: ").Append(ApplicationMetadata).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
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
            return this.Equals(obj as CreateCertificateRequest);
        }

        /// <summary>
        /// Returns true if CreateCertificateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateCertificateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCertificateRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ApplicationMetadata == other.ApplicationMetadata ||
                    this.ApplicationMetadata != null &&
                    this.ApplicationMetadata.SequenceEqual(other.ApplicationMetadata)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.Equals(other.Attributes)
                ) && 
                (
                    this.Policy == other.Policy ||
                    this.Policy != null &&
                    this.Policy.Equals(other.Policy)
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
                if (this.ApplicationMetadata != null)
                    hash = hash * 59 + this.ApplicationMetadata.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();
                if (this.Policy != null)
                    hash = hash * 59 + this.Policy.GetHashCode();
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
