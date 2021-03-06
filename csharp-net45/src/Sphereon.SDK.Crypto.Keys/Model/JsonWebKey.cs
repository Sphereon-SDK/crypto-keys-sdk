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
    /// Json Web Key as specified in http://tools.ietf.org/html/draft-ietf-jose-json-web-key-18
    /// </summary>
    [DataContract]
    public partial class JsonWebKey :  IEquatable<JsonWebKey>, IValidatableObject
    {
        /// <summary>
        /// Elliptic curve name. see JsonWebKeyCurveName
        /// </summary>
        /// <value>Elliptic curve name. see JsonWebKeyCurveName</value>
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
        /// Key type
        /// </summary>
        /// <value>Key type</value>
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
        /// Elliptic curve name. see JsonWebKeyCurveName
        /// </summary>
        /// <value>Elliptic curve name. see JsonWebKeyCurveName</value>
        [DataMember(Name="crv", EmitDefaultValue=false)]
        public CrvEnum? Crv { get; set; }
        /// <summary>
        /// Key type
        /// </summary>
        /// <value>Key type</value>
        [DataMember(Name="kty", EmitDefaultValue=false)]
        public KtyEnum? Kty { get; set; }
        /// <summary>
        /// Supported operations
        /// </summary>
        /// <value>Supported operations</value>
        [DataMember(Name="key_ops", EmitDefaultValue=false)]
        public List<KeyOpsEnum> KeyOps { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonWebKey" /> class.
        /// </summary>
        /// <param name="D">RSA private exponent.</param>
        /// <param name="E">RSA public exponent.</param>
        /// <param name="Crv">Elliptic curve name. see JsonWebKeyCurveName.</param>
        /// <param name="Kid">Key id.</param>
        /// <param name="K">Symmetric key.</param>
        /// <param name="Dp">RSA Private Key Parameter.</param>
        /// <param name="Dq">RSA Private Key Parameter.</param>
        /// <param name="N">RSA modulus.</param>
        /// <param name="P">RSA secret prime.</param>
        /// <param name="Kty">Key type.</param>
        /// <param name="Q">RSA secret prime, with p &lt; q.</param>
        /// <param name="T">HSM Token, used with Bring Your Own Key.</param>
        /// <param name="KeyOps">Supported operations.</param>
        /// <param name="Qi">RSA Private Key Parameter.</param>
        /// <param name="X">X component of an EC public key.</param>
        /// <param name="Y">Y component of an EC public key..</param>
        public JsonWebKey(byte[] D = default(byte[]), byte[] E = default(byte[]), CrvEnum? Crv = default(CrvEnum?), string Kid = default(string), byte[] K = default(byte[]), byte[] Dp = default(byte[]), byte[] Dq = default(byte[]), byte[] N = default(byte[]), byte[] P = default(byte[]), KtyEnum? Kty = default(KtyEnum?), byte[] Q = default(byte[]), byte[] T = default(byte[]), List<KeyOpsEnum> KeyOps = default(List<KeyOpsEnum>), byte[] Qi = default(byte[]), byte[] X = default(byte[]), byte[] Y = default(byte[]))
        {
            this.D = D;
            this.E = E;
            this.Crv = Crv;
            this.Kid = Kid;
            this.K = K;
            this.Dp = Dp;
            this.Dq = Dq;
            this.N = N;
            this.P = P;
            this.Kty = Kty;
            this.Q = Q;
            this.T = T;
            this.KeyOps = KeyOps;
            this.Qi = Qi;
            this.X = X;
            this.Y = Y;
        }
        
        /// <summary>
        /// RSA private exponent
        /// </summary>
        /// <value>RSA private exponent</value>
        [DataMember(Name="d", EmitDefaultValue=false)]
        public byte[] D { get; set; }

        /// <summary>
        /// RSA public exponent
        /// </summary>
        /// <value>RSA public exponent</value>
        [DataMember(Name="e", EmitDefaultValue=false)]
        public byte[] E { get; set; }


        /// <summary>
        /// Key id
        /// </summary>
        /// <value>Key id</value>
        [DataMember(Name="kid", EmitDefaultValue=false)]
        public string Kid { get; set; }

        /// <summary>
        /// Symmetric key
        /// </summary>
        /// <value>Symmetric key</value>
        [DataMember(Name="k", EmitDefaultValue=false)]
        public byte[] K { get; set; }

        /// <summary>
        /// RSA Private Key Parameter
        /// </summary>
        /// <value>RSA Private Key Parameter</value>
        [DataMember(Name="dp", EmitDefaultValue=false)]
        public byte[] Dp { get; set; }

        /// <summary>
        /// RSA Private Key Parameter
        /// </summary>
        /// <value>RSA Private Key Parameter</value>
        [DataMember(Name="dq", EmitDefaultValue=false)]
        public byte[] Dq { get; set; }

        /// <summary>
        /// RSA modulus
        /// </summary>
        /// <value>RSA modulus</value>
        [DataMember(Name="n", EmitDefaultValue=false)]
        public byte[] N { get; set; }

        /// <summary>
        /// RSA secret prime
        /// </summary>
        /// <value>RSA secret prime</value>
        [DataMember(Name="p", EmitDefaultValue=false)]
        public byte[] P { get; set; }


        /// <summary>
        /// RSA secret prime, with p &lt; q
        /// </summary>
        /// <value>RSA secret prime, with p &lt; q</value>
        [DataMember(Name="q", EmitDefaultValue=false)]
        public byte[] Q { get; set; }

        /// <summary>
        /// HSM Token, used with Bring Your Own Key
        /// </summary>
        /// <value>HSM Token, used with Bring Your Own Key</value>
        [DataMember(Name="t", EmitDefaultValue=false)]
        public byte[] T { get; set; }


        /// <summary>
        /// RSA Private Key Parameter
        /// </summary>
        /// <value>RSA Private Key Parameter</value>
        [DataMember(Name="qi", EmitDefaultValue=false)]
        public byte[] Qi { get; set; }

        /// <summary>
        /// X component of an EC public key
        /// </summary>
        /// <value>X component of an EC public key</value>
        [DataMember(Name="x", EmitDefaultValue=false)]
        public byte[] X { get; set; }

        /// <summary>
        /// Y component of an EC public key.
        /// </summary>
        /// <value>Y component of an EC public key.</value>
        [DataMember(Name="y", EmitDefaultValue=false)]
        public byte[] Y { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonWebKey {\n");
            sb.Append("  D: ").Append(D).Append("\n");
            sb.Append("  E: ").Append(E).Append("\n");
            sb.Append("  Crv: ").Append(Crv).Append("\n");
            sb.Append("  Kid: ").Append(Kid).Append("\n");
            sb.Append("  K: ").Append(K).Append("\n");
            sb.Append("  Dp: ").Append(Dp).Append("\n");
            sb.Append("  Dq: ").Append(Dq).Append("\n");
            sb.Append("  N: ").Append(N).Append("\n");
            sb.Append("  P: ").Append(P).Append("\n");
            sb.Append("  Kty: ").Append(Kty).Append("\n");
            sb.Append("  Q: ").Append(Q).Append("\n");
            sb.Append("  T: ").Append(T).Append("\n");
            sb.Append("  KeyOps: ").Append(KeyOps).Append("\n");
            sb.Append("  Qi: ").Append(Qi).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
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
            return this.Equals(obj as JsonWebKey);
        }

        /// <summary>
        /// Returns true if JsonWebKey instances are equal
        /// </summary>
        /// <param name="other">Instance of JsonWebKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonWebKey other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.D == other.D ||
                    this.D != null &&
                    this.D.Equals(other.D)
                ) && 
                (
                    this.E == other.E ||
                    this.E != null &&
                    this.E.Equals(other.E)
                ) && 
                (
                    this.Crv == other.Crv ||
                    this.Crv != null &&
                    this.Crv.Equals(other.Crv)
                ) && 
                (
                    this.Kid == other.Kid ||
                    this.Kid != null &&
                    this.Kid.Equals(other.Kid)
                ) && 
                (
                    this.K == other.K ||
                    this.K != null &&
                    this.K.Equals(other.K)
                ) && 
                (
                    this.Dp == other.Dp ||
                    this.Dp != null &&
                    this.Dp.Equals(other.Dp)
                ) && 
                (
                    this.Dq == other.Dq ||
                    this.Dq != null &&
                    this.Dq.Equals(other.Dq)
                ) && 
                (
                    this.N == other.N ||
                    this.N != null &&
                    this.N.Equals(other.N)
                ) && 
                (
                    this.P == other.P ||
                    this.P != null &&
                    this.P.Equals(other.P)
                ) && 
                (
                    this.Kty == other.Kty ||
                    this.Kty != null &&
                    this.Kty.Equals(other.Kty)
                ) && 
                (
                    this.Q == other.Q ||
                    this.Q != null &&
                    this.Q.Equals(other.Q)
                ) && 
                (
                    this.T == other.T ||
                    this.T != null &&
                    this.T.Equals(other.T)
                ) && 
                (
                    this.KeyOps == other.KeyOps ||
                    this.KeyOps != null &&
                    this.KeyOps.SequenceEqual(other.KeyOps)
                ) && 
                (
                    this.Qi == other.Qi ||
                    this.Qi != null &&
                    this.Qi.Equals(other.Qi)
                ) && 
                (
                    this.X == other.X ||
                    this.X != null &&
                    this.X.Equals(other.X)
                ) && 
                (
                    this.Y == other.Y ||
                    this.Y != null &&
                    this.Y.Equals(other.Y)
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
                if (this.D != null)
                    hash = hash * 59 + this.D.GetHashCode();
                if (this.E != null)
                    hash = hash * 59 + this.E.GetHashCode();
                if (this.Crv != null)
                    hash = hash * 59 + this.Crv.GetHashCode();
                if (this.Kid != null)
                    hash = hash * 59 + this.Kid.GetHashCode();
                if (this.K != null)
                    hash = hash * 59 + this.K.GetHashCode();
                if (this.Dp != null)
                    hash = hash * 59 + this.Dp.GetHashCode();
                if (this.Dq != null)
                    hash = hash * 59 + this.Dq.GetHashCode();
                if (this.N != null)
                    hash = hash * 59 + this.N.GetHashCode();
                if (this.P != null)
                    hash = hash * 59 + this.P.GetHashCode();
                if (this.Kty != null)
                    hash = hash * 59 + this.Kty.GetHashCode();
                if (this.Q != null)
                    hash = hash * 59 + this.Q.GetHashCode();
                if (this.T != null)
                    hash = hash * 59 + this.T.GetHashCode();
                if (this.KeyOps != null)
                    hash = hash * 59 + this.KeyOps.GetHashCode();
                if (this.Qi != null)
                    hash = hash * 59 + this.Qi.GetHashCode();
                if (this.X != null)
                    hash = hash * 59 + this.X.GetHashCode();
                if (this.Y != null)
                    hash = hash * 59 + this.Y.GetHashCode();
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
