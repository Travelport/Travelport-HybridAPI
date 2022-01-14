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
    /// DepartureDetail
    /// </summary>
    [DataContract]
    public partial class DepartureDetail : Departure,  IEquatable<DepartureDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DepartureDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DepartureDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DepartureDetail" /> class.
        /// </summary>
        /// <param name="terminal">Assigned Type: c-1100:StringAlphaNumeric.</param>
        /// <param name="country">Assigned Type: c-1100:CountryCodeISO.</param>
        /// <param name="extensionPointDetail">extensionPointDetail.</param>
        public DepartureDetail(string terminal = default(string), string country = default(string), ExtensionPointDetail extensionPointDetail = default(ExtensionPointDetail), string type = "DepartureDetail", string location = default(string), DateTime? date = default(DateTime?), string time = default(string), Object extensionPoint = default(Object)) : base(type, location, date, time, extensionPoint)
        {
            this.Terminal = terminal;
            this.Country = country;
            this.ExtensionPointDetail = extensionPointDetail;
        }
        
        /// <summary>
        /// Assigned Type: c-1100:StringAlphaNumeric
        /// </summary>
        /// <value>Assigned Type: c-1100:StringAlphaNumeric</value>
        [DataMember(Name="terminal", EmitDefaultValue=false)]
        public string Terminal { get; set; }

        /// <summary>
        /// Assigned Type: c-1100:CountryCodeISO
        /// </summary>
        /// <value>Assigned Type: c-1100:CountryCodeISO</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets ExtensionPointDetail
        /// </summary>
        [DataMember(Name="ExtensionPoint_Detail", EmitDefaultValue=false)]
        public ExtensionPointDetail ExtensionPointDetail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DepartureDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Terminal: ").Append(Terminal).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  ExtensionPointDetail: ").Append(ExtensionPointDetail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as DepartureDetail);
        }

        /// <summary>
        /// Returns true if DepartureDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of DepartureDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DepartureDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Terminal == input.Terminal ||
                    (this.Terminal != null &&
                    this.Terminal.Equals(input.Terminal))
                ) && base.Equals(input) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && base.Equals(input) && 
                (
                    this.ExtensionPointDetail == input.ExtensionPointDetail ||
                    (this.ExtensionPointDetail != null &&
                    this.ExtensionPointDetail.Equals(input.ExtensionPointDetail))
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
                int hashCode = base.GetHashCode();
                if (this.Terminal != null)
                    hashCode = hashCode * 59 + this.Terminal.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.ExtensionPointDetail != null)
                    hashCode = hashCode * 59 + this.ExtensionPointDetail.GetHashCode();
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
            foreach(var x in BaseValidate(validationContext)) yield return x;
            // Terminal (string) maxLength
            if(this.Terminal != null && this.Terminal.Length > 4096)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Terminal, length must be less than 4096.", new [] { "Terminal" });
            }

            // Terminal (string) pattern
            Regex regexTerminal = new Regex(@"([0-9a-zA-Z]+)?", RegexOptions.CultureInvariant);
            if (false == regexTerminal.Match(this.Terminal).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Terminal, must match a pattern of " + regexTerminal, new [] { "Terminal" });
            }

            // Country (string) pattern
            Regex regexCountry = new Regex(@"[a-zA-Z]{2}", RegexOptions.CultureInvariant);
            if (false == regexCountry.Match(this.Country).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Country, must match a pattern of " + regexCountry, new [] { "Country" });
            }

            yield break;
        }
    }

}