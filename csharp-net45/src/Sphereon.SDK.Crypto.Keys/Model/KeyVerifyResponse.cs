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
    /// The response of the sign request
    /// </summary>
    [DataContract]
    public partial class KeyVerifyResponse :  IEquatable<KeyVerifyResponse>, IValidatableObject
    {
        /// <summary>
        /// The signature algorithm used in the request
        /// </summary>
        /// <value>The signature algorithm used in the request</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AlgorithmEnum
        {
            
            /// <summary>
            /// Enum PS256 for "PS256"
            /// </summary>
            [EnumMember(Value = "PS256")]
            PS256,
            
            /// <summary>
            /// Enum PS384 for "PS384"
            /// </summary>
            [EnumMember(Value = "PS384")]
            PS384,
            
            /// <summary>
            /// Enum PS512 for "PS512"
            /// </summary>
            [EnumMember(Value = "PS512")]
            PS512,
            
            /// <summary>
            /// Enum RS256 for "RS256"
            /// </summary>
            [EnumMember(Value = "RS256")]
            RS256,
            
            /// <summary>
            /// Enum RS384 for "RS384"
            /// </summary>
            [EnumMember(Value = "RS384")]
            RS384,
            
            /// <summary>
            /// Enum RS512 for "RS512"
            /// </summary>
            [EnumMember(Value = "RS512")]
            RS512,
            
            /// <summary>
            /// Enum RSNULL for "RSNULL"
            /// </summary>
            [EnumMember(Value = "RSNULL")]
            RSNULL,
            
            /// <summary>
            /// Enum ES256 for "ES256"
            /// </summary>
            [EnumMember(Value = "ES256")]
            ES256,
            
            /// <summary>
            /// Enum ES384 for "ES384"
            /// </summary>
            [EnumMember(Value = "ES384")]
            ES384,
            
            /// <summary>
            /// Enum ES512 for "ES512"
            /// </summary>
            [EnumMember(Value = "ES512")]
            ES512,
            
            /// <summary>
            /// Enum ECDSA256 for "ECDSA256"
            /// </summary>
            [EnumMember(Value = "ECDSA256")]
            ECDSA256
        }

        /// <summary>
        /// The signature algorithm used in the request
        /// </summary>
        /// <value>The signature algorithm used in the request</value>
        [DataMember(Name="algorithm", EmitDefaultValue=false)]
        public AlgorithmEnum? Algorithm { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KeyVerifyResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public KeyVerifyResponse()
        {
        }
        
        /// <summary>
        /// The Key Id
        /// </summary>
        /// <value>The Key Id</value>
        [DataMember(Name="kid", EmitDefaultValue=false)]
        public string Kid { get; private set; }

        /// <summary>
        /// Whether the supplied signature matched the regenerated signature
        /// </summary>
        /// <value>Whether the supplied signature matched the regenerated signature</value>
        [DataMember(Name="verified", EmitDefaultValue=false)]
        public bool? Verified { get; private set; }

        /// <summary>
        /// The signature of the sign request in base 64 form
        /// </summary>
        /// <value>The signature of the sign request in base 64 form</value>
        [DataMember(Name="base64Signature", EmitDefaultValue=false)]
        public byte[] Base64Signature { get; private set; }


        /// <summary>
        /// The signature of the sign request in hex form
        /// </summary>
        /// <value>The signature of the sign request in hex form</value>
        [DataMember(Name="hexSignature", EmitDefaultValue=false)]
        public string HexSignature { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeyVerifyResponse {\n");
            sb.Append("  Kid: ").Append(Kid).Append("\n");
            sb.Append("  Verified: ").Append(Verified).Append("\n");
            sb.Append("  Base64Signature: ").Append(Base64Signature).Append("\n");
            sb.Append("  Algorithm: ").Append(Algorithm).Append("\n");
            sb.Append("  HexSignature: ").Append(HexSignature).Append("\n");
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
            return this.Equals(obj as KeyVerifyResponse);
        }

        /// <summary>
        /// Returns true if KeyVerifyResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of KeyVerifyResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KeyVerifyResponse other)
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
                    this.Verified == other.Verified ||
                    this.Verified != null &&
                    this.Verified.Equals(other.Verified)
                ) && 
                (
                    this.Base64Signature == other.Base64Signature ||
                    this.Base64Signature != null &&
                    this.Base64Signature.Equals(other.Base64Signature)
                ) && 
                (
                    this.Algorithm == other.Algorithm ||
                    this.Algorithm != null &&
                    this.Algorithm.Equals(other.Algorithm)
                ) && 
                (
                    this.HexSignature == other.HexSignature ||
                    this.HexSignature != null &&
                    this.HexSignature.Equals(other.HexSignature)
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
                if (this.Verified != null)
                    hash = hash * 59 + this.Verified.GetHashCode();
                if (this.Base64Signature != null)
                    hash = hash * 59 + this.Base64Signature.GetHashCode();
                if (this.Algorithm != null)
                    hash = hash * 59 + this.Algorithm.GetHashCode();
                if (this.HexSignature != null)
                    hash = hash * 59 + this.HexSignature.GetHashCode();
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
