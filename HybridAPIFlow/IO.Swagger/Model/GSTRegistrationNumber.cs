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
    /// The GST Registration Number for this Organization
    /// </summary>
    [DataContract]
    public partial class GSTRegistrationNumber :  IEquatable<GSTRegistrationNumber>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GSTRegistrationNumber" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GSTRegistrationNumber() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GSTRegistrationNumber" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        /// <param name="telephone">Assigned Type: c-1100:StringTiny.</param>
        /// <param name="address">Assigned Type: c-1100:StringShort.</param>
        /// <param name="country">Assigned Type: c-1100:CountryCodeISO (required).</param>
        /// <param name="companyName">Assigned Type: c-1100:String.</param>
        /// <param name="email">Assigned Type: c-1100:StringShort.</param>
        public GSTRegistrationNumber(string value = default(string), string telephone = default(string), string address = default(string), string country = default(string), string companyName = default(string), string email = default(string))
        {
            // to ensure "country" is required (not null)
            if (country == null)
            {
                throw new InvalidDataException("country is a required property for GSTRegistrationNumber and cannot be null");
            }
            else
            {
                this.Country = country;
            }
            this.Value = value;
            this.Telephone = telephone;
            this.Address = address;
            this.CompanyName = companyName;
            this.Email = email;
        }
        
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Assigned Type: c-1100:StringTiny
        /// </summary>
        /// <value>Assigned Type: c-1100:StringTiny</value>
        [DataMember(Name="telephone", EmitDefaultValue=false)]
        public string Telephone { get; set; }

        /// <summary>
        /// Assigned Type: c-1100:StringShort
        /// </summary>
        /// <value>Assigned Type: c-1100:StringShort</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Assigned Type: c-1100:CountryCodeISO
        /// </summary>
        /// <value>Assigned Type: c-1100:CountryCodeISO</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Assigned Type: c-1100:String
        /// </summary>
        /// <value>Assigned Type: c-1100:String</value>
        [DataMember(Name="companyName", EmitDefaultValue=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Assigned Type: c-1100:StringShort
        /// </summary>
        /// <value>Assigned Type: c-1100:StringShort</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GSTRegistrationNumber {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Telephone: ").Append(Telephone).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
            return this.Equals(input as GSTRegistrationNumber);
        }

        /// <summary>
        /// Returns true if GSTRegistrationNumber instances are equal
        /// </summary>
        /// <param name="input">Instance of GSTRegistrationNumber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GSTRegistrationNumber input)
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
                    this.Telephone == input.Telephone ||
                    (this.Telephone != null &&
                    this.Telephone.Equals(input.Telephone))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
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
                if (this.Telephone != null)
                    hashCode = hashCode * 59 + this.Telephone.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
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
            // Value (string) maxLength
            if(this.Value != null && this.Value.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Value, length must be less than 512.", new [] { "Value" });
            }

            // Telephone (string) maxLength
            if(this.Telephone != null && this.Telephone.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Telephone, length must be less than 32.", new [] { "Telephone" });
            }

            // Address (string) maxLength
            if(this.Address != null && this.Address.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Address, length must be less than 128.", new [] { "Address" });
            }

            // Country (string) pattern
            Regex regexCountry = new Regex(@"[a-zA-Z]{2}", RegexOptions.CultureInvariant);
            if (false == regexCountry.Match(this.Country).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Country, must match a pattern of " + regexCountry, new [] { "Country" });
            }

            // CompanyName (string) maxLength
            if(this.CompanyName != null && this.CompanyName.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CompanyName, length must be less than 512.", new [] { "CompanyName" });
            }

            // Email (string) maxLength
            if(this.Email != null && this.Email.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, length must be less than 128.", new [] { "Email" });
            }

            yield break;
        }
    }

}