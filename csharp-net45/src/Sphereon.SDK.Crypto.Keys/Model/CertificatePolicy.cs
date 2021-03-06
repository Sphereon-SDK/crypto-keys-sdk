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
    /// The certificate policy
    /// </summary>
    [DataContract]
    public partial class CertificatePolicy :  IEquatable<CertificatePolicy>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CertificatePolicy" /> class.
        /// </summary>
        /// <param name="LifetimeActions">LifetimeActions.</param>
        /// <param name="KeyProperties">KeyProperties.</param>
        /// <param name="X509Properties">X509Properties.</param>
        /// <param name="Attributes">Attributes.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Issuer">Issuer.</param>
        /// <param name="SecretProperties">SecretProperties.</param>
        public CertificatePolicy(List<LifetimeAction> LifetimeActions = default(List<LifetimeAction>), KeyProperties KeyProperties = default(KeyProperties), X509Properties X509Properties = default(X509Properties), Attributes Attributes = default(Attributes), string Id = default(string), IssuerParameters Issuer = default(IssuerParameters), SecretProperties SecretProperties = default(SecretProperties))
        {
            this.LifetimeActions = LifetimeActions;
            this.KeyProperties = KeyProperties;
            this.X509Properties = X509Properties;
            this.Attributes = Attributes;
            this.Id = Id;
            this.Issuer = Issuer;
            this.SecretProperties = SecretProperties;
        }
        
        /// <summary>
        /// Gets or Sets LifetimeActions
        /// </summary>
        [DataMember(Name="lifetimeActions", EmitDefaultValue=false)]
        public List<LifetimeAction> LifetimeActions { get; set; }

        /// <summary>
        /// Gets or Sets KeyProperties
        /// </summary>
        [DataMember(Name="keyProperties", EmitDefaultValue=false)]
        public KeyProperties KeyProperties { get; set; }

        /// <summary>
        /// Gets or Sets X509Properties
        /// </summary>
        [DataMember(Name="x509Properties", EmitDefaultValue=false)]
        public X509Properties X509Properties { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Attributes Attributes { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Issuer
        /// </summary>
        [DataMember(Name="issuer", EmitDefaultValue=false)]
        public IssuerParameters Issuer { get; set; }

        /// <summary>
        /// Gets or Sets SecretProperties
        /// </summary>
        [DataMember(Name="secretProperties", EmitDefaultValue=false)]
        public SecretProperties SecretProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CertificatePolicy {\n");
            sb.Append("  LifetimeActions: ").Append(LifetimeActions).Append("\n");
            sb.Append("  KeyProperties: ").Append(KeyProperties).Append("\n");
            sb.Append("  X509Properties: ").Append(X509Properties).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  SecretProperties: ").Append(SecretProperties).Append("\n");
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
            return this.Equals(obj as CertificatePolicy);
        }

        /// <summary>
        /// Returns true if CertificatePolicy instances are equal
        /// </summary>
        /// <param name="other">Instance of CertificatePolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CertificatePolicy other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LifetimeActions == other.LifetimeActions ||
                    this.LifetimeActions != null &&
                    this.LifetimeActions.SequenceEqual(other.LifetimeActions)
                ) && 
                (
                    this.KeyProperties == other.KeyProperties ||
                    this.KeyProperties != null &&
                    this.KeyProperties.Equals(other.KeyProperties)
                ) && 
                (
                    this.X509Properties == other.X509Properties ||
                    this.X509Properties != null &&
                    this.X509Properties.Equals(other.X509Properties)
                ) && 
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.Equals(other.Attributes)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Issuer == other.Issuer ||
                    this.Issuer != null &&
                    this.Issuer.Equals(other.Issuer)
                ) && 
                (
                    this.SecretProperties == other.SecretProperties ||
                    this.SecretProperties != null &&
                    this.SecretProperties.Equals(other.SecretProperties)
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
                if (this.LifetimeActions != null)
                    hash = hash * 59 + this.LifetimeActions.GetHashCode();
                if (this.KeyProperties != null)
                    hash = hash * 59 + this.KeyProperties.GetHashCode();
                if (this.X509Properties != null)
                    hash = hash * 59 + this.X509Properties.GetHashCode();
                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Issuer != null)
                    hash = hash * 59 + this.Issuer.GetHashCode();
                if (this.SecretProperties != null)
                    hash = hash * 59 + this.SecretProperties.GetHashCode();
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
