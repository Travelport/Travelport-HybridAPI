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
    /// BuildFromCatalogOfferingsRequest
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "@type")]
    [JsonSubtypes.KnownSubType(typeof(BuildFromCatalogOfferingsRequestAirChange), "BuildFromCatalogOfferingsRequestAirChange")]
    [JsonSubtypes.KnownSubType(typeof(BuildFromCatalogOfferingsRequestAir), "BuildFromCatalogOfferingsRequestAir")]
    public partial class BuildFromCatalogOfferingsRequest :  IEquatable<BuildFromCatalogOfferingsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildFromCatalogOfferingsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BuildFromCatalogOfferingsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildFromCatalogOfferingsRequest" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="catalogOfferingsIdentifier">Assigned Type: ctlg-1100:CatalogOfferings_ID (required).</param>
        /// <param name="catalogOfferingIdentifier">Assigned Type: ctlg-1100:CatalogOffering_ID (required).</param>
        /// <param name="productIdentifier">productIdentifier (required).</param>
        /// <param name="ancillaryOfferingIdentifier">ancillaryOfferingIdentifier.</param>
        /// <param name="extensionPoint">extensionPoint.</param>
        public BuildFromCatalogOfferingsRequest(string type = default(string), CatalogOfferingsIdentifier catalogOfferingsIdentifier = default(CatalogOfferingsIdentifier), CatalogOfferingIdentifier catalogOfferingIdentifier = default(CatalogOfferingIdentifier), List<ProductIdentifier> productIdentifier = default(List<ProductIdentifier>), List<AncillaryOfferingIdentifier> ancillaryOfferingIdentifier = default(List<AncillaryOfferingIdentifier>), Object extensionPoint = default(Object))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for BuildFromCatalogOfferingsRequest and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "catalogOfferingsIdentifier" is required (not null)
            if (catalogOfferingsIdentifier == null)
            {
                throw new InvalidDataException("catalogOfferingsIdentifier is a required property for BuildFromCatalogOfferingsRequest and cannot be null");
            }
            else
            {
                this.CatalogOfferingsIdentifier = catalogOfferingsIdentifier;
            }
            // to ensure "catalogOfferingIdentifier" is required (not null)
            if (catalogOfferingIdentifier == null)
            {
                throw new InvalidDataException("catalogOfferingIdentifier is a required property for BuildFromCatalogOfferingsRequest and cannot be null");
            }
            else
            {
                this.CatalogOfferingIdentifier = catalogOfferingIdentifier;
            }
            // to ensure "productIdentifier" is required (not null)
            if (productIdentifier == null)
            {
                throw new InvalidDataException("productIdentifier is a required property for BuildFromCatalogOfferingsRequest and cannot be null");
            }
            else
            {
                this.ProductIdentifier = productIdentifier;
            }
            this.AncillaryOfferingIdentifier = ancillaryOfferingIdentifier;
            this.ExtensionPoint = extensionPoint;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="@type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Assigned Type: ctlg-1100:CatalogOfferings_ID
        /// </summary>
        /// <value>Assigned Type: ctlg-1100:CatalogOfferings_ID</value>
        [DataMember(Name="CatalogOfferingsIdentifier", EmitDefaultValue=false)]
        public CatalogOfferingsIdentifier CatalogOfferingsIdentifier { get; set; }

        /// <summary>
        /// Assigned Type: ctlg-1100:CatalogOffering_ID
        /// </summary>
        /// <value>Assigned Type: ctlg-1100:CatalogOffering_ID</value>
        [DataMember(Name="CatalogOfferingIdentifier", EmitDefaultValue=false)]
        public CatalogOfferingIdentifier CatalogOfferingIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets ProductIdentifier
        /// </summary>
        [DataMember(Name="ProductIdentifier", EmitDefaultValue=false)]
        public List<ProductIdentifier> ProductIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets AncillaryOfferingIdentifier
        /// </summary>
        [DataMember(Name="AncillaryOfferingIdentifier", EmitDefaultValue=false)]
        public List<AncillaryOfferingIdentifier> AncillaryOfferingIdentifier { get; set; }

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
            sb.Append("class BuildFromCatalogOfferingsRequest {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CatalogOfferingsIdentifier: ").Append(CatalogOfferingsIdentifier).Append("\n");
            sb.Append("  CatalogOfferingIdentifier: ").Append(CatalogOfferingIdentifier).Append("\n");
            sb.Append("  ProductIdentifier: ").Append(ProductIdentifier).Append("\n");
            sb.Append("  AncillaryOfferingIdentifier: ").Append(AncillaryOfferingIdentifier).Append("\n");
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
            return this.Equals(input as BuildFromCatalogOfferingsRequest);
        }

        /// <summary>
        /// Returns true if BuildFromCatalogOfferingsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BuildFromCatalogOfferingsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuildFromCatalogOfferingsRequest input)
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
                    this.CatalogOfferingsIdentifier == input.CatalogOfferingsIdentifier ||
                    (this.CatalogOfferingsIdentifier != null &&
                    this.CatalogOfferingsIdentifier.Equals(input.CatalogOfferingsIdentifier))
                ) && 
                (
                    this.CatalogOfferingIdentifier == input.CatalogOfferingIdentifier ||
                    (this.CatalogOfferingIdentifier != null &&
                    this.CatalogOfferingIdentifier.Equals(input.CatalogOfferingIdentifier))
                ) && 
                (
                    this.ProductIdentifier == input.ProductIdentifier ||
                    this.ProductIdentifier != null &&
                    this.ProductIdentifier.SequenceEqual(input.ProductIdentifier)
                ) && 
                (
                    this.AncillaryOfferingIdentifier == input.AncillaryOfferingIdentifier ||
                    this.AncillaryOfferingIdentifier != null &&
                    this.AncillaryOfferingIdentifier.SequenceEqual(input.AncillaryOfferingIdentifier)
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
                if (this.CatalogOfferingsIdentifier != null)
                    hashCode = hashCode * 59 + this.CatalogOfferingsIdentifier.GetHashCode();
                if (this.CatalogOfferingIdentifier != null)
                    hashCode = hashCode * 59 + this.CatalogOfferingIdentifier.GetHashCode();
                if (this.ProductIdentifier != null)
                    hashCode = hashCode * 59 + this.ProductIdentifier.GetHashCode();
                if (this.AncillaryOfferingIdentifier != null)
                    hashCode = hashCode * 59 + this.AncillaryOfferingIdentifier.GetHashCode();
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