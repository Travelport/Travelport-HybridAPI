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
    /// PriceBreakdownAncillary
    /// </summary>
    [DataContract]
    public partial class PriceBreakdownAncillary : PriceBreakdown,  IEquatable<PriceBreakdownAncillary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PriceBreakdownAncillary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PriceBreakdownAncillary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PriceBreakdownAncillary" /> class.
        /// </summary>
        /// <param name="quantity">The quantity of ancillary items included in this PriceBreakdown.</param>
        /// <param name="description">Assigned Type: ctan-1100:AncillaryDescription.</param>
        /// <param name="extensionPointChoice">extensionPointChoice.</param>
        public PriceBreakdownAncillary(int? quantity = default(int?), AncillaryDescription description = default(AncillaryDescription), ExtensionPointChoice extensionPointChoice = default(ExtensionPointChoice), string type = "PriceBreakdownAncillary", Amount amount = default(Amount), Commission commission = default(Commission), Object extensionPoint = default(Object)) : base(type, amount, commission, extensionPoint)
        {
            this.Quantity = quantity;
            this.Description = description;
            this.ExtensionPointChoice = extensionPointChoice;
        }
        
        /// <summary>
        /// The quantity of ancillary items included in this PriceBreakdown
        /// </summary>
        /// <value>The quantity of ancillary items included in this PriceBreakdown</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Assigned Type: ctan-1100:AncillaryDescription
        /// </summary>
        /// <value>Assigned Type: ctan-1100:AncillaryDescription</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public AncillaryDescription Description { get; set; }

        /// <summary>
        /// Gets or Sets ExtensionPointChoice
        /// </summary>
        [DataMember(Name="ExtensionPoint_Choice", EmitDefaultValue=false)]
        public ExtensionPointChoice ExtensionPointChoice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PriceBreakdownAncillary {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExtensionPointChoice: ").Append(ExtensionPointChoice).Append("\n");
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
            return this.Equals(input as PriceBreakdownAncillary);
        }

        /// <summary>
        /// Returns true if PriceBreakdownAncillary instances are equal
        /// </summary>
        /// <param name="input">Instance of PriceBreakdownAncillary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PriceBreakdownAncillary input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.ExtensionPointChoice == input.ExtensionPointChoice ||
                    (this.ExtensionPointChoice != null &&
                    this.ExtensionPointChoice.Equals(input.ExtensionPointChoice))
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
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ExtensionPointChoice != null)
                    hashCode = hashCode * 59 + this.ExtensionPointChoice.GetHashCode();
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
            yield break;
        }
    }

}