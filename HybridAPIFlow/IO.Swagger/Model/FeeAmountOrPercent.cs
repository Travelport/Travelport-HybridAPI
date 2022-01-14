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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// FeeAmountOrPercent
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "@type")]
    [JsonSubtypes.KnownSubType(typeof(FeeAmountOrPercentPercent), "FeeAmountOrPercentPercent")]
    [JsonSubtypes.KnownSubType(typeof(FeeAmountOrPercentAmount), "FeeAmountOrPercentAmount")]
    public partial class FeeAmountOrPercent :  IEquatable<FeeAmountOrPercent>, IValidatableObject
    {
        /// <summary>
        /// Type of commision like Full , Partial , Non -Paying , No- Show etc
        /// </summary>
        /// <value>Type of commision like Full , Partial , Non -Paying , No- Show etc</value>
        [DataMember(Name="application", EmitDefaultValue=false)]
        public CommissionEnum? Application { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeeAmountOrPercent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FeeAmountOrPercent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeeAmountOrPercent" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="application">Type of commision like Full , Partial , Non -Paying , No- Show etc.</param>
        /// <param name="extensionPoint">extensionPoint.</param>
        public FeeAmountOrPercent(string type = default(string), CommissionEnum? application = default(CommissionEnum?), Object extensionPoint = default(Object))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for FeeAmountOrPercent and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.Application = application;
            this.ExtensionPoint = extensionPoint;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="@type", EmitDefaultValue=false)]
        public string Type { get; set; }


        /// <summary>
        /// Gets or Sets ExtensionPoint
        /// </summary>
        [DataMember(Name="ExtensionPoint", EmitDefaultValue=false)]
        public Object ExtensionPoint { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeeAmountOrPercent {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  ExtensionPoint: ").Append(ExtensionPoint).Append("\n");
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
            return this.Equals(input as FeeAmountOrPercent);
        }

        /// <summary>
        /// Returns true if FeeAmountOrPercent instances are equal
        /// </summary>
        /// <param name="input">Instance of FeeAmountOrPercent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeeAmountOrPercent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Application == input.Application ||
                    (this.Application != null &&
                    this.Application.Equals(input.Application))
                ) && 
                (
                    this.ExtensionPoint == input.ExtensionPoint ||
                    (this.ExtensionPoint != null &&
                    this.ExtensionPoint.Equals(input.ExtensionPoint))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Application != null)
                    hashCode = hashCode * 59 + this.Application.GetHashCode();
                if (this.ExtensionPoint != null)
                    hashCode = hashCode * 59 + this.ExtensionPoint.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}