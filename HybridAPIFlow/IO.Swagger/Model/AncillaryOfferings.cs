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
    /// AncillaryOfferings
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "@type")]
    [JsonSubtypes.KnownSubType(typeof(AncillaryOfferingsBuildFromCatalogProductOfferings), "AncillaryOfferingsBuildFromCatalogProductOfferings")]
    [JsonSubtypes.KnownSubType(typeof(AncillaryOfferingsBuildFromCatalogOfferings), "AncillaryOfferingsBuildFromCatalogOfferings")]
    [JsonSubtypes.KnownSubType(typeof(AncillaryOfferingsBuildFromReservationWorkbench), "AncillaryOfferingsBuildFromReservationWorkbench")]
    [JsonSubtypes.KnownSubType(typeof(AncillaryOfferingsBuildFromOffer), "AncillaryOfferingsBuildFromOffer")]
    public partial class AncillaryOfferings :  IEquatable<AncillaryOfferings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AncillaryOfferings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AncillaryOfferings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AncillaryOfferings" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="includeUnsellableAncillariesInd">If true, the response will include unsellable ancillary options.</param>
        /// <param name="extensionPoint">extensionPoint.</param>
        public AncillaryOfferings(string type = default(string), bool? includeUnsellableAncillariesInd = default(bool?), Object extensionPoint = default(Object))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for AncillaryOfferings and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.IncludeUnsellableAncillariesInd = includeUnsellableAncillariesInd;
            this.ExtensionPoint = extensionPoint;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="@type", EmitDefaultValue=false)]
        public string Type { get; set; }

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
            sb.Append("class AncillaryOfferings {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as AncillaryOfferings);
        }

        /// <summary>
        /// Returns true if AncillaryOfferings instances are equal
        /// </summary>
        /// <param name="input">Instance of AncillaryOfferings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AncillaryOfferings input)
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
            yield break;
        }
    }

}
