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
    /// CreateKeyRequest
    /// </summary>
    [DataContract]
    public partial class CreateKeyRequest :  IEquatable<CreateKeyRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Kty
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum KtyEnum
        {
            
            /// <summary>
            /// Enum EC for "EC"
            /// </summary>
            [EnumMember(Value = "EC")]
            EC,
            
            /// <summary>
            /// Enum RSA for "RSA"
            /// </summary>
            [EnumMember(Value = "RSA")]
            RSA,
            
            /// <summary>
            /// Enum OCT for "OCT"
            /// </summary>
            [EnumMember(Value = "OCT")]
            OCT
        }

        /// <summary>
        /// Gets or Sets Crv
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CrvEnum
        {
            
            /// <summary>
            /// Enum P256 for "P_256"
            /// </summary>
            [EnumMember(Value = "P_256")]
            P256,
            
            /// <summary>
            /// Enum P384 for "P_384"
            /// </summary>
            [EnumMember(Value = "P_384")]
            P384,
            
            /// <summary>
            /// Enum P521 for "P_521"
            /// </summary>
            [EnumMember(Value = "P_521")]
            P521,
            
            /// <summary>
            /// Enum SECP256K1 for "SECP256K1"
            /// </summary>
            [EnumMember(Value = "SECP256K1")]
            SECP256K1
        }


        /// <summary>
        /// Gets or Sets KeyOps
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum KeyOpsEnum
        {
            
            /// <summary>
            /// Enum ENCRYPT for "ENCRYPT"
            /// </summary>
            [EnumMember(Value = "ENCRYPT")]
            ENCRYPT,
            
            /// <summary>
            /// Enum DECRYPT for "DECRYPT"
            /// </summary>
            [EnumMember(Value = "DECRYPT")]
            DECRYPT,
            
            /// <summary>
            /// Enum SIGN for "SIGN"
            /// </summary>
            [EnumMember(Value = "SIGN")]
            SIGN,
            
            /// <summary>
            /// Enum VERIFY for "VERIFY"
            /// </summary>
            [EnumMember(Value = "VERIFY")]
            VERIFY,
            
            /// <summary>
            /// Enum WRAPKEY for "WRAP_KEY"
            /// </summary>
            [EnumMember(Value = "WRAP_KEY")]
            WRAPKEY,
            
            /// <summary>
            /// Enum UNWRAPKEY for "UNWRAP_KEY"
            /// </summary>
            [EnumMember(Value = "UNWRAP_KEY")]
            UNWRAPKEY
        }

        /// <summary>
        /// Gets or Sets Kty
        /// </summary>
        [DataMember(Name="kty", EmitDefaultValue=false)]
        public KtyEnum? Kty { get; set; }
        /// <summary>
        /// Gets or Sets Crv
        /// </summary>
        [DataMember(Name="crv", EmitDefaultValue=false)]
        public CrvEnum? Crv { get; set; }
        /// <summary>
        /// Gets or Sets KeyOps
        /// </summary>
        [DataMember(Name="key_ops", EmitDefaultValue=false)]
        public List<KeyOpsEnum> KeyOps { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKeyRequest" /> class.
        /// </summary>
        /// <param name="Kty">Kty.</param>
        /// <param name="ApplicationMetadata">ApplicationMetadata.</param>
        /// <param name="Crv">Crv.</param>
        /// <param name="KeyOps">KeyOps.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Attributes">Attributes.</param>
        /// <param name="KeySize">KeySize.</param>
        public CreateKeyRequest(KtyEnum? Kty = default(KtyEnum?), Dictionary<string, string> ApplicationMetadata = default(Dictionary<string, string>), CrvEnum? Crv = default(CrvEnum?), List<KeyOpsEnum> KeyOps = default(List<KeyOpsEnum>), string Name = default(string), Attributes Attributes = default(Attributes), int? KeySize = default(int?))
        {
            this.Kty = Kty;
            this.ApplicationMetadata = ApplicationMetadata;
            this.Crv = Crv;
            this.KeyOps = KeyOps;
            this.Name = Name;
            this.Attributes = Attributes;
            this.KeySize = KeySize;
        }
        

        /// <summary>
        /// Gets or Sets ApplicationMetadata
        /// </summary>
        [DataMember(Name="applicationMetadata", EmitDefaultValue=false)]
        public Dictionary<string, string> ApplicationMetadata { get; set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Attributes Attributes { get; set; }

        /// <summary>
        /// Gets or Sets KeySize
        /// </summary>
        [DataMember(Name="key_size", EmitDefaultValue=false)]
        public int? KeySize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateKeyRequest {\n");
            sb.Append("  Kty: ").Append(Kty).Append("\n");
            sb.Append("  ApplicationMetadata: ").Append(ApplicationMetadata).Append("\n");
            sb.Append("  Crv: ").Append(Crv).Append("\n");
            sb.Append("  KeyOps: ").Append(KeyOps).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  KeySize: ").Append(KeySize).Append("\n");
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
            return this.Equals(obj as CreateKeyRequest);
        }

        /// <summary>
        /// Returns true if CreateKeyRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateKeyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateKeyRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Kty == other.Kty ||
                    this.Kty != null &&
                    this.Kty.Equals(other.Kty)
                ) && 
                (
                    this.ApplicationMetadata == other.ApplicationMetadata ||
                    this.ApplicationMetadata != null &&
                    this.ApplicationMetadata.SequenceEqual(other.ApplicationMetadata)
                ) && 
                (
                    this.Crv == other.Crv ||
                    this.Crv != null &&
                    this.Crv.Equals(other.Crv)
                ) && 
                (
                    this.KeyOps == other.KeyOps ||
                    this.KeyOps != null &&
                    this.KeyOps.SequenceEqual(other.KeyOps)
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
                    this.KeySize == other.KeySize ||
                    this.KeySize != null &&
                    this.KeySize.Equals(other.KeySize)
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
                if (this.Kty != null)
                    hash = hash * 59 + this.Kty.GetHashCode();
                if (this.ApplicationMetadata != null)
                    hash = hash * 59 + this.ApplicationMetadata.GetHashCode();
                if (this.Crv != null)
                    hash = hash * 59 + this.Crv.GetHashCode();
                if (this.KeyOps != null)
                    hash = hash * 59 + this.KeyOps.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();
                if (this.KeySize != null)
                    hash = hash * 59 + this.KeySize.GetHashCode();
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
