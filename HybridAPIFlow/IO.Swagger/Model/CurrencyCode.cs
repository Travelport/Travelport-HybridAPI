/* 
 * CatalogProductOfferingsResource
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 11.1.0
 * 
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// The currency code to which any conversion rates will apply
    /// </summary>
    [DataContract]
    public partial class CurrencyCode :  IEquatable<CurrencyCode>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyCode" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CurrencyCode() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyCode" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        /// <param name="codeAuthority">Assigned Type: c-1100:CodeContext (required).</param>
        /// <param name="decimalPlace">Assigned Type: c-1100:CurrencyMinorUnit (required).</param>
        /// <param name="decimalAuthority">Assigned Type: c-1100:CodeContext.</param>
        public CurrencyCode(string value = default(string), string codeAuthority = default(string), int? decimalPlace = default(int?), string decimalAuthority = default(string))
        {
            // to ensure "codeAuthority" is required (not null)
            if (codeAuthority == null)
            {
                throw new InvalidDataException("codeAuthority is a required property for CurrencyCode and cannot be null");
            }
            else
            {
                this.CodeAuthority = codeAuthority;
            }
            // to ensure "decimalPlace" is required (not null)
            if (decimalPlace == null)
            {
                throw new InvalidDataException("decimalPlace is a required property for CurrencyCode and cannot be null");
            }
            else
            {
                this.DecimalPlace = decimalPlace;
            }
            this.Value = value;
            this.DecimalAuthority = decimalAuthority;
        }
        
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Assigned Type: c-1100:CodeContext
        /// </summary>
        /// <value>Assigned Type: c-1100:CodeContext</value>
        [DataMember(Name="codeAuthority", EmitDefaultValue=false)]
        public string CodeAuthority { get; set; }

        /// <summary>
        /// Assigned Type: c-1100:CurrencyMinorUnit
        /// </summary>
        /// <value>Assigned Type: c-1100:CurrencyMinorUnit</value>
        [DataMember(Name="decimalPlace", EmitDefaultValue=false)]
        public int? DecimalPlace { get; set; }

        /// <summary>
        /// Assigned Type: c-1100:CodeContext
        /// </summary>
        /// <value>Assigned Type: c-1100:CodeContext</value>
        [DataMember(Name="decimalAuthority", EmitDefaultValue=false)]
        public string DecimalAuthority { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CurrencyCode {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  CodeAuthority: ").Append(CodeAuthority).Append("\n");
            sb.Append("  DecimalPlace: ").Append(DecimalPlace).Append("\n");
            sb.Append("  DecimalAuthority: ").Append(DecimalAuthority).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CurrencyCode);
        }

        /// <summary>
        /// Returns true if CurrencyCode instances are equal
        /// </summary>
        /// <param name="input">Instance of CurrencyCode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CurrencyCode input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.CodeAuthority == input.CodeAuthority ||
                    (this.CodeAuthority != null &&
                    this.CodeAuthority.Equals(input.CodeAuthority))
                ) && 
                (
                    this.DecimalPlace == input.DecimalPlace ||
                    (this.DecimalPlace != null &&
                    this.DecimalPlace.Equals(input.DecimalPlace))
                ) && 
                (
                    this.DecimalAuthority == input.DecimalAuthority ||
                    (this.DecimalAuthority != null &&
                    this.DecimalAuthority.Equals(input.DecimalAuthority))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.CodeAuthority != null)
                    hashCode = hashCode * 59 + this.CodeAuthority.GetHashCode();
                if (this.DecimalPlace != null)
                    hashCode = hashCode * 59 + this.DecimalPlace.GetHashCode();
                if (this.DecimalAuthority != null)
                    hashCode = hashCode * 59 + this.DecimalAuthority.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Value (string) pattern
            Regex regexValue = new Regex(@"[a-zA-Z]{3}", RegexOptions.CultureInvariant);
            if (false == regexValue.Match(this.Value).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Value, must match a pattern of " + regexValue, new [] { "Value" });
            }

            // CodeAuthority (string) maxLength
            if(this.CodeAuthority != null && this.CodeAuthority.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CodeAuthority, length must be less than 32.", new [] { "CodeAuthority" });
            }

            // DecimalPlace (int?) minimum
            if(this.DecimalPlace < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DecimalPlace, must be a value greater than or equal to 0.", new [] { "DecimalPlace" });
            }

            // DecimalAuthority (string) maxLength
            if(this.DecimalAuthority != null && this.DecimalAuthority.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DecimalAuthority, length must be less than 32.", new [] { "DecimalAuthority" });
            }

            yield break;
        }
    }

}