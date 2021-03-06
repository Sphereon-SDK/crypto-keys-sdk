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
    /// KeyDecryptResponse
    /// </summary>
    [DataContract]
    public partial class KeyDecryptResponse :  IEquatable<KeyDecryptResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KeyDecryptResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public KeyDecryptResponse()
        {
        }
        
        /// <summary>
        /// The Key Id
        /// </summary>
        /// <value>The Key Id</value>
        [DataMember(Name="kid", EmitDefaultValue=false)]
        public string Kid { get; private set; }

        /// <summary>
        /// The decrypted value in base64url format
        /// </summary>
        /// <value>The decrypted value in base64url format</value>
        [DataMember(Name="decrypted", EmitDefaultValue=false)]
        public byte[] Decrypted { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeyDecryptResponse {\n");
            sb.Append("  Kid: ").Append(Kid).Append("\n");
            sb.Append("  Decrypted: ").Append(Decrypted).Append("\n");
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
            return this.Equals(obj as KeyDecryptResponse);
        }

        /// <summary>
        /// Returns true if KeyDecryptResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of KeyDecryptResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KeyDecryptResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Kid == other.Kid ||
                    this.Kid != null &&
                    this.Kid.Equals(other.Kid)
                ) && 
                (
                    this.Decrypted == other.Decrypted ||
                    this.Decrypted != null &&
                    this.Decrypted.Equals(other.Decrypted)
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
                if (this.Kid != null)
                    hash = hash * 59 + this.Kid.GetHashCode();
                if (this.Decrypted != null)
                    hash = hash * 59 + this.Decrypted.GetHashCode();
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
