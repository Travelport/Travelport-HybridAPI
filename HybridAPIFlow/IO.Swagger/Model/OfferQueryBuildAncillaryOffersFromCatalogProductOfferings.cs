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
    /// OfferQueryBuildAncillaryOffersFromCatalogProductOfferings
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "@type")]
    public partial class OfferQueryBuildAncillaryOffersFromCatalogProductOfferings :  IEquatable<OfferQueryBuildAncillaryOffersFromCatalogProductOfferings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferQueryBuildAncillaryOffersFromCatalogProductOfferings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OfferQueryBuildAncillaryOffersFromCatalogProductOfferings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferQueryBuildAncillaryOffersFromCatalogProductOfferings" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="buildAncillaryOffersFromCatalogProductOfferings">buildAncillaryOffersFromCatalogProductOfferings (required).</param>
        /// <param name="extensionPoint">extensionPoint.</param>
        public OfferQueryBuildAncillaryOffersFromCatalogProductOfferings(string type = default(string), List<BuildAncillaryOffersFromCatalogProductOfferings> buildAncillaryOffersFromCatalogProductOfferings = default(List<BuildAncillaryOffersFromCatalogProductOfferings>), Object extensionPoint = default(Object))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for OfferQueryBuildAncillaryOffersFromCatalogProductOfferings and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "buildAncillaryOffersFromCatalogProductOfferings" is required (not null)
            if (buildAncillaryOffersFromCatalogProductOfferings == null)
            {
                throw new InvalidDataException("buildAncillaryOffersFromCatalogProductOfferings is a required property for OfferQueryBuildAncillaryOffersFromCatalogProductOfferings and cannot be null");
            }
            else
            {
                this.BuildAncillaryOffersFromCatalogProductOfferings = buildAncillaryOffersFromCatalogProductOfferings;
            }
            this.ExtensionPoint = extensionPoint;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="@type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets BuildAncillaryOffersFromCatalogProductOfferings
        /// </summary>
        [DataMember(Name="BuildAncillaryOffersFromCatalogProductOfferings", EmitDefaultValue=false)]
        public List<BuildAncillaryOffersFromCatalogProductOfferings> BuildAncillaryOffersFromCatalogProductOfferings { get; set; }

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
            sb.Append("class OfferQueryBuildAncillaryOffersFromCatalogProductOfferings {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  BuildAncillaryOffersFromCatalogProductOfferings: ").Append(BuildAncillaryOffersFromCatalogProductOfferings).Append("\n");
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
            return this.Equals(input as OfferQueryBuildAncillaryOffersFromCatalogProductOfferings);
        }

        /// <summary>
        /// Returns true if OfferQueryBuildAncillaryOffersFromCatalogProductOfferings instances are equal
        /// </summary>
        /// <param name="input">Instance of OfferQueryBuildAncillaryOffersFromCatalogProductOfferings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OfferQueryBuildAncillaryOffersFromCatalogProductOfferings input)
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
                    this.BuildAncillaryOffersFromCatalogProductOfferings == input.BuildAncillaryOffersFromCatalogProductOfferings ||
                    this.BuildAncillaryOffersFromCatalogProductOfferings != null &&
                    this.BuildAncillaryOffersFromCatalogProductOfferings.SequenceEqual(input.BuildAncillaryOffersFromCatalogProductOfferings)
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
                if (this.BuildAncillaryOffersFromCatalogProductOfferings != null)
                    hashCode = hashCode * 59 + this.BuildAncillaryOffersFromCatalogProductOfferings.GetHashCode();
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
