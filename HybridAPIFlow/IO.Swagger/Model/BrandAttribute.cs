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
    /// BrandAttribute
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "@type")]
    [JsonSubtypes.KnownSubType(typeof(BrandAttributeCompleteInfo), "BrandAttributeCompleteInfo")]
    public partial class BrandAttribute :  IEquatable<BrandAttribute>, IValidatableObject
    {
        /// <summary>
        /// The Travelport classification used for a category of ancillaries such as Seat, Bags, etc. This is an initial list that will be added to.
        /// </summary>
        /// <value>The Travelport classification used for a category of ancillaries such as Seat, Bags, etc. This is an initial list that will be added to.</value>
        [DataMember(Name="classification", EmitDefaultValue=false)]
        public BrandClassificationEnum Classification { get; set; }
        /// <summary>
        /// whether this attribute is included, chargeable, etc.
        /// </summary>
        /// <value>whether this attribute is included, chargeable, etc.</value>
        [DataMember(Name="inclusion", EmitDefaultValue=false)]
        public BrandInclusionEnum Inclusion { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BrandAttribute" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BrandAttribute() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BrandAttribute" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="classification">The Travelport classification used for a category of ancillaries such as Seat, Bags, etc. This is an initial list that will be added to. (required).</param>
        /// <param name="inclusion">whether this attribute is included, chargeable, etc. (required).</param>
        /// <param name="matchedAttributeInd">if true, this is a matched attribute..</param>
        /// <param name="extensionPoint">extensionPoint.</param>
        public BrandAttribute(string type = default(string), BrandClassificationEnum classification = default(BrandClassificationEnum), BrandInclusionEnum inclusion = default(BrandInclusionEnum), bool? matchedAttributeInd = default(bool?), Object extensionPoint = default(Object))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for BrandAttribute and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "classification" is required (not null)
            if (classification == null)
            {
                throw new InvalidDataException("classification is a required property for BrandAttribute and cannot be null");
            }
            else
            {
                this.Classification = classification;
            }
            // to ensure "inclusion" is required (not null)
            if (inclusion == null)
            {
                throw new InvalidDataException("inclusion is a required property for BrandAttribute and cannot be null");
            }
            else
            {
                this.Inclusion = inclusion;
            }
            this.MatchedAttributeInd = matchedAttributeInd;
            this.ExtensionPoint = extensionPoint;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="@type", EmitDefaultValue=false)]
        public string Type { get; set; }



        /// <summary>
        /// if true, this is a matched attribute.
        /// </summary>
        /// <value>if true, this is a matched attribute.</value>
        [DataMember(Name="matchedAttributeInd", EmitDefaultValue=false)]
        public bool? MatchedAttributeInd { get; set; }

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
            sb.Append("class BrandAttribute {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Classification: ").Append(Classification).Append("\n");
            sb.Append("  Inclusion: ").Append(Inclusion).Append("\n");
            sb.Append("  MatchedAttributeInd: ").Append(MatchedAttributeInd).Append("\n");
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
            return this.Equals(input as BrandAttribute);
        }

        /// <summary>
        /// Returns true if BrandAttribute instances are equal
        /// </summary>
        /// <param name="input">Instance of BrandAttribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrandAttribute input)
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
                    this.Classification == input.Classification ||
                    (this.Classification != null &&
                    this.Classification.Equals(input.Classification))
                ) && 
                (
                    this.Inclusion == input.Inclusion ||
                    (this.Inclusion != null &&
                    this.Inclusion.Equals(input.Inclusion))
                ) && 
                (
                    this.MatchedAttributeInd == input.MatchedAttributeInd ||
                    (this.MatchedAttributeInd != null &&
                    this.MatchedAttributeInd.Equals(input.MatchedAttributeInd))
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
                if (this.Classification != null)
                    hashCode = hashCode * 59 + this.Classification.GetHashCode();
                if (this.Inclusion != null)
                    hashCode = hashCode * 59 + this.Inclusion.GetHashCode();
                if (this.MatchedAttributeInd != null)
                    hashCode = hashCode * 59 + this.MatchedAttributeInd.GetHashCode();
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