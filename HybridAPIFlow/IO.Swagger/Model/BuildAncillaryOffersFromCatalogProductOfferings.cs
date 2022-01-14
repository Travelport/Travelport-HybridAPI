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
    /// BuildAncillaryOffersFromCatalogProductOfferings
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "@type")]
    public partial class BuildAncillaryOffersFromCatalogProductOfferings :  IEquatable<BuildAncillaryOffersFromCatalogProductOfferings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildAncillaryOffersFromCatalogProductOfferings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BuildAncillaryOffersFromCatalogProductOfferings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildAncillaryOffersFromCatalogProductOfferings" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="catalogProductOfferingsIdentifier">Assigned Type: ctlg-1100:CatalogProductOfferings_ID (required).</param>
        /// <param name="catalogProductOfferingIdentifier">Assigned Type: ctlg-1100:CatalogProductOffering_ID (required).</param>
        /// <param name="productIdentifier">Assigned Type: ctlg-1100:Product_ID.</param>
        /// <param name="quantity">The quantity of ancillaries to be included in the Offer.</param>
        /// <param name="travelerIdentifierRef">Assigned Type: c-1100:TravelerIdentifierRef.</param>
        /// <param name="includeUnsellableAncillariesInd">If true, the response will include unsellable ancillary options.</param>
        /// <param name="extensionPoint">extensionPoint.</param>
        public BuildAncillaryOffersFromCatalogProductOfferings(string type = default(string), CatalogProductOfferingsIdentifier catalogProductOfferingsIdentifier = default(CatalogProductOfferingsIdentifier), CatalogProductOfferingIdentifier catalogProductOfferingIdentifier = default(CatalogProductOfferingIdentifier), ProductIdentifier productIdentifier = default(ProductIdentifier), int? quantity = default(int?), TravelerIdentifierRef travelerIdentifierRef = default(TravelerIdentifierRef), bool? includeUnsellableAncillariesInd = default(bool?), Object extensionPoint = default(Object))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for BuildAncillaryOffersFromCatalogProductOfferings and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "catalogProductOfferingsIdentifier" is required (not null)
            if (catalogProductOfferingsIdentifier == null)
            {
                throw new InvalidDataException("catalogProductOfferingsIdentifier is a required property for BuildAncillaryOffersFromCatalogProductOfferings and cannot be null");
            }
            else
            {
                this.CatalogProductOfferingsIdentifier = catalogProductOfferingsIdentifier;
            }
            // to ensure "catalogProductOfferingIdentifier" is required (not null)
            if (catalogProductOfferingIdentifier == null)
            {
                throw new InvalidDataException("catalogProductOfferingIdentifier is a required property for BuildAncillaryOffersFromCatalogProductOfferings and cannot be null");
            }
            else
            {
                this.CatalogProductOfferingIdentifier = catalogProductOfferingIdentifier;
            }
            this.ProductIdentifier = productIdentifier;
            this.Quantity = quantity;
            this.TravelerIdentifierRef = travelerIdentifierRef;
            this.IncludeUnsellableAncillariesInd = includeUnsellableAncillariesInd;
            this.ExtensionPoint = extensionPoint;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="@type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Assigned Type: ctlg-1100:CatalogProductOfferings_ID
        /// </summary>
        /// <value>Assigned Type: ctlg-1100:CatalogProductOfferings_ID</value>
        [DataMember(Name="CatalogProductOfferingsIdentifier", EmitDefaultValue=false)]
        public CatalogProductOfferingsIdentifier CatalogProductOfferingsIdentifier { get; set; }

        /// <summary>
        /// Assigned Type: ctlg-1100:CatalogProductOffering_ID
        /// </summary>
        /// <value>Assigned Type: ctlg-1100:CatalogProductOffering_ID</value>
        [DataMember(Name="CatalogProductOfferingIdentifier", EmitDefaultValue=false)]
        public CatalogProductOfferingIdentifier CatalogProductOfferingIdentifier { get; set; }

        /// <summary>
        /// Assigned Type: ctlg-1100:Product_ID
        /// </summary>
        /// <value>Assigned Type: ctlg-1100:Product_ID</value>
        [DataMember(Name="ProductIdentifier", EmitDefaultValue=false)]
        public ProductIdentifier ProductIdentifier { get; set; }

        /// <summary>
        /// The quantity of ancillaries to be included in the Offer
        /// </summary>
        /// <value>The quantity of ancillaries to be included in the Offer</value>
        [DataMember(Name="Quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Assigned Type: c-1100:TravelerIdentifierRef
        /// </summary>
        /// <value>Assigned Type: c-1100:TravelerIdentifierRef</value>
        [DataMember(Name="TravelerIdentifierRef", EmitDefaultValue=false)]
        public TravelerIdentifierRef TravelerIdentifierRef { get; set; }

        /// <summary>
        /// If true, the response will include unsellable ancillary options
        /// </summary>
        /// <value>If true, the response will include unsellable ancillary options</value>
        [DataMember(Name="includeUnsellableAncillariesInd", EmitDefaultValue=false)]
        public bool? IncludeUnsellableAncillariesInd { get; set; }

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
            sb.Append("class BuildAncillaryOffersFromCatalogProductOfferings {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CatalogProductOfferingsIdentifier: ").Append(CatalogProductOfferingsIdentifier).Append("\n");
            sb.Append("  CatalogProductOfferingIdentifier: ").Append(CatalogProductOfferingIdentifier).Append("\n");
            sb.Append("  ProductIdentifier: ").Append(ProductIdentifier).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  TravelerIdentifierRef: ").Append(TravelerIdentifierRef).Append("\n");
            sb.Append("  IncludeUnsellableAncillariesInd: ").Append(IncludeUnsellableAncillariesInd).Append("\n");
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
            return this.Equals(input as BuildAncillaryOffersFromCatalogProductOfferings);
        }

        /// <summary>
        /// Returns true if BuildAncillaryOffersFromCatalogProductOfferings instances are equal
        /// </summary>
        /// <param name="input">Instance of BuildAncillaryOffersFromCatalogProductOfferings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuildAncillaryOffersFromCatalogProductOfferings input)
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
                    this.CatalogProductOfferingsIdentifier == input.CatalogProductOfferingsIdentifier ||
                    (this.CatalogProductOfferingsIdentifier != null &&
                    this.CatalogProductOfferingsIdentifier.Equals(input.CatalogProductOfferingsIdentifier))
                ) && 
                (
                    this.CatalogProductOfferingIdentifier == input.CatalogProductOfferingIdentifier ||
                    (this.CatalogProductOfferingIdentifier != null &&
                    this.CatalogProductOfferingIdentifier.Equals(input.CatalogProductOfferingIdentifier))
                ) && 
                (
                    this.ProductIdentifier == input.ProductIdentifier ||
                    (this.ProductIdentifier != null &&
                    this.ProductIdentifier.Equals(input.ProductIdentifier))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.TravelerIdentifierRef == input.TravelerIdentifierRef ||
                    (this.TravelerIdentifierRef != null &&
                    this.TravelerIdentifierRef.Equals(input.TravelerIdentifierRef))
                ) && 
                (
                    this.IncludeUnsellableAncillariesInd == input.IncludeUnsellableAncillariesInd ||
                    (this.IncludeUnsellableAncillariesInd != null &&
                    this.IncludeUnsellableAncillariesInd.Equals(input.IncludeUnsellableAncillariesInd))
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
                if (this.CatalogProductOfferingsIdentifier != null)
                    hashCode = hashCode * 59 + this.CatalogProductOfferingsIdentifier.GetHashCode();
                if (this.CatalogProductOfferingIdentifier != null)
                    hashCode = hashCode * 59 + this.CatalogProductOfferingIdentifier.GetHashCode();
                if (this.ProductIdentifier != null)
                    hashCode = hashCode * 59 + this.ProductIdentifier.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.TravelerIdentifierRef != null)
                    hashCode = hashCode * 59 + this.TravelerIdentifierRef.GetHashCode();
                if (this.IncludeUnsellableAncillariesInd != null)
                    hashCode = hashCode * 59 + this.IncludeUnsellableAncillariesInd.GetHashCode();
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
            // Quantity (int?) minimum
            if(this.Quantity < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Quantity, must be a value greater than or equal to 0.", new [] { "Quantity" });
            }

            yield break;
        }
    }

}
