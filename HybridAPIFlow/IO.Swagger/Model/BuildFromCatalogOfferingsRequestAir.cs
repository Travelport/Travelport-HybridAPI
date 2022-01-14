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
    /// BuildFromCatalogOfferingsRequestAir
    /// </summary>
    [DataContract]
    public partial class BuildFromCatalogOfferingsRequestAir : BuildFromCatalogOfferingsRequest,  IEquatable<BuildFromCatalogOfferingsRequestAir>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildFromCatalogOfferingsRequestAir" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BuildFromCatalogOfferingsRequestAir() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildFromCatalogOfferingsRequestAir" /> class.
        /// </summary>
        /// <param name="pricingModifiersAir">Assigned Type: ctar-1100:PricingModifiersAir.</param>
        /// <param name="segmentSequence">The segmentSequence within the product the action is being requested for. Used when multiple flights exist within a product. Only one product may be selected with this option..</param>
        /// <param name="extensionPointChoice">extensionPointChoice.</param>
        public BuildFromCatalogOfferingsRequestAir(PricingModifiersAir pricingModifiersAir = default(PricingModifiersAir), List<int?> segmentSequence = default(List<int?>), ExtensionPointChoice extensionPointChoice = default(ExtensionPointChoice), string type = "BuildFromCatalogOfferingsRequestAir", CatalogOfferingsIdentifier catalogOfferingsIdentifier = default(CatalogOfferingsIdentifier), CatalogOfferingIdentifier catalogOfferingIdentifier = default(CatalogOfferingIdentifier), List<ProductIdentifier> productIdentifier = default(List<ProductIdentifier>), List<AncillaryOfferingIdentifier> ancillaryOfferingIdentifier = default(List<AncillaryOfferingIdentifier>), Object extensionPoint = default(Object)) : base(type, catalogOfferingsIdentifier, catalogOfferingIdentifier, productIdentifier, ancillaryOfferingIdentifier, extensionPoint)
        {
            this.PricingModifiersAir = pricingModifiersAir;
            this.SegmentSequence = segmentSequence;
            this.ExtensionPointChoice = extensionPointChoice;
        }
        
        /// <summary>
        /// Assigned Type: ctar-1100:PricingModifiersAir
        /// </summary>
        /// <value>Assigned Type: ctar-1100:PricingModifiersAir</value>
        [DataMember(Name="PricingModifiersAir", EmitDefaultValue=false)]
        public PricingModifiersAir PricingModifiersAir { get; set; }

        /// <summary>
        /// The segmentSequence within the product the action is being requested for. Used when multiple flights exist within a product. Only one product may be selected with this option.
        /// </summary>
        /// <value>The segmentSequence within the product the action is being requested for. Used when multiple flights exist within a product. Only one product may be selected with this option.</value>
        [DataMember(Name="SegmentSequence", EmitDefaultValue=false)]
        public List<int?> SegmentSequence { get; set; }

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
            sb.Append("class BuildFromCatalogOfferingsRequestAir {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  PricingModifiersAir: ").Append(PricingModifiersAir).Append("\n");
            sb.Append("  SegmentSequence: ").Append(SegmentSequence).Append("\n");
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
            return this.Equals(input as BuildFromCatalogOfferingsRequestAir);
        }

        /// <summary>
        /// Returns true if BuildFromCatalogOfferingsRequestAir instances are equal
        /// </summary>
        /// <param name="input">Instance of BuildFromCatalogOfferingsRequestAir to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuildFromCatalogOfferingsRequestAir input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.PricingModifiersAir == input.PricingModifiersAir ||
                    (this.PricingModifiersAir != null &&
                    this.PricingModifiersAir.Equals(input.PricingModifiersAir))
                ) && base.Equals(input) && 
                (
                    this.SegmentSequence == input.SegmentSequence ||
                    this.SegmentSequence != null &&
                    this.SegmentSequence.SequenceEqual(input.SegmentSequence)
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
                if (this.PricingModifiersAir != null)
                    hashCode = hashCode * 59 + this.PricingModifiersAir.GetHashCode();
                if (this.SegmentSequence != null)
                    hashCode = hashCode * 59 + this.SegmentSequence.GetHashCode();
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
