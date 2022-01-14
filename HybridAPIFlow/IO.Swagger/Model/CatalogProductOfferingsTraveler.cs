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
    /// CatalogProductOfferingsTraveler
    /// </summary>
    [DataContract]
    public partial class CatalogProductOfferingsTraveler : CatalogProductOfferings,  IEquatable<CatalogProductOfferingsTraveler>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogProductOfferingsTraveler" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CatalogProductOfferingsTraveler() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogProductOfferingsTraveler" /> class.
        /// </summary>
        /// <param name="travelerIdentifierRef">travelerIdentifierRef (required).</param>
        /// <param name="extensionPointCustom">extensionPointCustom.</param>
        public CatalogProductOfferingsTraveler(List<TravelerIdentifierRef> travelerIdentifierRef = default(List<TravelerIdentifierRef>), ExtensionPointCustom extensionPointCustom = default(ExtensionPointCustom), string type = default(string), string id = default(string), Identifier identifier = default(Identifier), List<CatalogProductOfferingID> catalogProductOffering = default(List<CatalogProductOfferingID>), List<UpsellOfferingID> upsellOffering = default(List<UpsellOfferingID>), Object extensionPoint = default(Object)) : base(catalogProductOffering, upsellOffering, extensionPoint)
        {
            // to ensure "travelerIdentifierRef" is required (not null)
            if (travelerIdentifierRef == null)
            {
                throw new InvalidDataException("travelerIdentifierRef is a required property for CatalogProductOfferingsTraveler and cannot be null");
            }
            else
            {
                this.TravelerIdentifierRef = travelerIdentifierRef;
            }
            this.ExtensionPointCustom = extensionPointCustom;
        }
        
        /// <summary>
        /// Gets or Sets TravelerIdentifierRef
        /// </summary>
        [DataMember(Name="TravelerIdentifierRef", EmitDefaultValue=false)]
        public List<TravelerIdentifierRef> TravelerIdentifierRef { get; set; }

        /// <summary>
        /// Gets or Sets ExtensionPointCustom
        /// </summary>
        [DataMember(Name="ExtensionPoint_Custom", EmitDefaultValue=false)]
        public ExtensionPointCustom ExtensionPointCustom { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CatalogProductOfferingsTraveler {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  TravelerIdentifierRef: ").Append(TravelerIdentifierRef).Append("\n");
            sb.Append("  ExtensionPointCustom: ").Append(ExtensionPointCustom).Append("\n");
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
            return this.Equals(input as CatalogProductOfferingsTraveler);
        }

        /// <summary>
        /// Returns true if CatalogProductOfferingsTraveler instances are equal
        /// </summary>
        /// <param name="input">Instance of CatalogProductOfferingsTraveler to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CatalogProductOfferingsTraveler input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.TravelerIdentifierRef == input.TravelerIdentifierRef ||
                    this.TravelerIdentifierRef != null &&
                    this.TravelerIdentifierRef.SequenceEqual(input.TravelerIdentifierRef)
                ) && base.Equals(input) && 
                (
                    this.ExtensionPointCustom == input.ExtensionPointCustom ||
                    (this.ExtensionPointCustom != null &&
                    this.ExtensionPointCustom.Equals(input.ExtensionPointCustom))
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
                if (this.TravelerIdentifierRef != null)
                    hashCode = hashCode * 59 + this.TravelerIdentifierRef.GetHashCode();
                if (this.ExtensionPointCustom != null)
                    hashCode = hashCode * 59 + this.ExtensionPointCustom.GetHashCode();
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
