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
    /// Restriction
    /// </summary>
    [DataContract]
    public partial class Restriction :  IEquatable<Restriction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Restriction" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        /// <param name="segmentSequenceList">Assigned Type: c-1100:SegmentSequenceList.</param>
        /// <param name="productRef">The productRef which the restriction applies to.</param>
        public Restriction(string value = default(string), List<int?> segmentSequenceList = default(List<int?>), List<string> productRef = default(List<string>))
        {
            this.Value = value;
            this.SegmentSequenceList = segmentSequenceList;
            this.ProductRef = productRef;
        }
        
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Assigned Type: c-1100:SegmentSequenceList
        /// </summary>
        /// <value>Assigned Type: c-1100:SegmentSequenceList</value>
        [DataMember(Name="segmentSequenceList", EmitDefaultValue=false)]
        public List<int?> SegmentSequenceList { get; set; }

        /// <summary>
        /// The productRef which the restriction applies to
        /// </summary>
        /// <value>The productRef which the restriction applies to</value>
        [DataMember(Name="productRef", EmitDefaultValue=false)]
        public List<string> ProductRef { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Restriction {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  SegmentSequenceList: ").Append(SegmentSequenceList).Append("\n");
            sb.Append("  ProductRef: ").Append(ProductRef).Append("\n");
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
            return this.Equals(input as Restriction);
        }

        /// <summary>
        /// Returns true if Restriction instances are equal
        /// </summary>
        /// <param name="input">Instance of Restriction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Restriction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.SegmentSequenceList == input.SegmentSequenceList ||
                    this.SegmentSequenceList != null &&
                    this.SegmentSequenceList.SequenceEqual(input.SegmentSequenceList)
                ) && 
                (
                    this.ProductRef == input.ProductRef ||
                    this.ProductRef != null &&
                    this.ProductRef.SequenceEqual(input.ProductRef)
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.SegmentSequenceList != null)
                    hashCode = hashCode * 59 + this.SegmentSequenceList.GetHashCode();
                if (this.ProductRef != null)
                    hashCode = hashCode * 59 + this.ProductRef.GetHashCode();
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
            // Value (string) maxLength
            if(this.Value != null && this.Value.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Value, length must be less than 128.", new [] { "Value" });
            }

            yield break;
        }
    }

}