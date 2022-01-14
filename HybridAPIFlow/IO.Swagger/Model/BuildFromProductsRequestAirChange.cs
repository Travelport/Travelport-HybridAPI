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
    /// BuildFromProductsRequestAirChange
    /// </summary>
    [DataContract]
    public partial class BuildFromProductsRequestAirChange : BuildFromProductsRequest,  IEquatable<BuildFromProductsRequestAirChange>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildFromProductsRequestAirChange" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BuildFromProductsRequestAirChange() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildFromProductsRequestAirChange" /> class.
        /// </summary>
        /// <param name="pricingModifiersAirChange">Assigned Type: ctar-1100:PricingModifiersAirChange.</param>
        /// <param name="productCriteriaAir">Assigned Type: ctar-1100:ProductCriteriaAir (required).</param>
        /// <param name="extensionPointChoice">extensionPointChoice.</param>
        public BuildFromProductsRequestAirChange(PricingModifiersAirChange pricingModifiersAirChange = default(PricingModifiersAirChange), ProductCriteriaAir productCriteriaAir = default(ProductCriteriaAir), ExtensionPointChoice extensionPointChoice = default(ExtensionPointChoice), string type = "BuildFromProductsRequestAirChange", Object extensionPoint = default(Object)) : base(type, extensionPoint)
        {
            // to ensure "productCriteriaAir" is required (not null)
            if (productCriteriaAir == null)
            {
                throw new InvalidDataException("productCriteriaAir is a required property for BuildFromProductsRequestAirChange and cannot be null");
            }
            else
            {
                this.ProductCriteriaAir = productCriteriaAir;
            }
            this.PricingModifiersAirChange = pricingModifiersAirChange;
            this.ExtensionPointChoice = extensionPointChoice;
        }
        
        /// <summary>
        /// Assigned Type: ctar-1100:PricingModifiersAirChange
        /// </summary>
        /// <value>Assigned Type: ctar-1100:PricingModifiersAirChange</value>
        [DataMember(Name="PricingModifiersAirChange", EmitDefaultValue=false)]
        public PricingModifiersAirChange PricingModifiersAirChange { get; set; }

        /// <summary>
        /// Assigned Type: ctar-1100:ProductCriteriaAir
        /// </summary>
        /// <value>Assigned Type: ctar-1100:ProductCriteriaAir</value>
        [DataMember(Name="ProductCriteriaAir", EmitDefaultValue=false)]
        public ProductCriteriaAir ProductCriteriaAir { get; set; }

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
            sb.Append("class BuildFromProductsRequestAirChange {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  PricingModifiersAirChange: ").Append(PricingModifiersAirChange).Append("\n");
            sb.Append("  ProductCriteriaAir: ").Append(ProductCriteriaAir).Append("\n");
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
            return this.Equals(input as BuildFromProductsRequestAirChange);
        }

        /// <summary>
        /// Returns true if BuildFromProductsRequestAirChange instances are equal
        /// </summary>
        /// <param name="input">Instance of BuildFromProductsRequestAirChange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuildFromProductsRequestAirChange input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.PricingModifiersAirChange == input.PricingModifiersAirChange ||
                    (this.PricingModifiersAirChange != null &&
                    this.PricingModifiersAirChange.Equals(input.PricingModifiersAirChange))
                ) && base.Equals(input) && 
                (
                    this.ProductCriteriaAir == input.ProductCriteriaAir ||
                    (this.ProductCriteriaAir != null &&
                    this.ProductCriteriaAir.Equals(input.ProductCriteriaAir))
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
                if (this.PricingModifiersAirChange != null)
                    hashCode = hashCode * 59 + this.PricingModifiersAirChange.GetHashCode();
                if (this.ProductCriteriaAir != null)
                    hashCode = hashCode * 59 + this.ProductCriteriaAir.GetHashCode();
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