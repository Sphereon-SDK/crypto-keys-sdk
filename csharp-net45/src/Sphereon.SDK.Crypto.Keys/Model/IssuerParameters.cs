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
    /// Issuer params of the X509 component of a certificate
    /// </summary>
    [DataContract]
    public partial class IssuerParameters :  IEquatable<IssuerParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuerParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IssuerParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IssuerParameters" /> class.
        /// </summary>
        /// <param name="Name">Name of the referenced issuer object or reserved names; for example, &#39;Self&#39; or &#39;Unknown&#39;. (required).</param>
        /// <param name="Cty">Type of certificate (required).</param>
        public IssuerParameters(string Name = default(string), string Cty = default(string))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for IssuerParameters and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Cty" is required (not null)
            if (Cty == null)
            {
                throw new InvalidDataException("Cty is a required property for IssuerParameters and cannot be null");
            }
            else
            {
                this.Cty = Cty;
            }
        }
        
        /// <summary>
        /// Name of the referenced issuer object or reserved names; for example, &#39;Self&#39; or &#39;Unknown&#39;.
        /// </summary>
        /// <value>Name of the referenced issuer object or reserved names; for example, &#39;Self&#39; or &#39;Unknown&#39;.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Type of certificate
        /// </summary>
        /// <value>Type of certificate</value>
        [DataMember(Name="cty", EmitDefaultValue=false)]
        public string Cty { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssuerParameters {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Cty: ").Append(Cty).Append("\n");
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
            return this.Equals(obj as IssuerParameters);
        }

        /// <summary>
        /// Returns true if IssuerParameters instances are equal
        /// </summary>
        /// <param name="other">Instance of IssuerParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IssuerParameters other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Cty == other.Cty ||
                    this.Cty != null &&
                    this.Cty.Equals(other.Cty)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Cty != null)
                    hash = hash * 59 + this.Cty.GetHashCode();
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
