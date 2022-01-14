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
    /// BuildFromReservationWorkbench
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "@type")]
    public partial class BuildFromReservationWorkbench :  IEquatable<BuildFromReservationWorkbench>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildFromReservationWorkbench" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BuildFromReservationWorkbench() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildFromReservationWorkbench" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="reservationIdentifier">Assigned Type: res-1100:Reservation_ID (required).</param>
        /// <param name="offerIdentifier">Assigned Type: ctlg-1100:Offer_ID.</param>
        /// <param name="productIdentifier">productIdentifier.</param>
        /// <param name="segmentSequenceList">The segmentSequence within the product the action is being requested for. Used when multiple flights exist within a product. Only one product may be selected with this option..</param>
        /// <param name="extensionPoint">extensionPoint.</param>
        public BuildFromReservationWorkbench(string type = default(string), ReservationIdentifier reservationIdentifier = default(ReservationIdentifier), OfferIdentifier offerIdentifier = default(OfferIdentifier), List<ProductIdentifier> productIdentifier = default(List<ProductIdentifier>), List<int?> segmentSequenceList = default(List<int?>), Object extensionPoint = default(Object))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for BuildFromReservationWorkbench and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "reservationIdentifier" is required (not null)
            if (reservationIdentifier == null)
            {
                throw new InvalidDataException("reservationIdentifier is a required property for BuildFromReservationWorkbench and cannot be null");
            }
            else
            {
                this.ReservationIdentifier = reservationIdentifier;
            }
            this.OfferIdentifier = offerIdentifier;
            this.ProductIdentifier = productIdentifier;
            this.SegmentSequenceList = segmentSequenceList;
            this.ExtensionPoint = extensionPoint;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="@type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Assigned Type: res-1100:Reservation_ID
        /// </summary>
        /// <value>Assigned Type: res-1100:Reservation_ID</value>
        [DataMember(Name="ReservationIdentifier", EmitDefaultValue=false)]
        public ReservationIdentifier ReservationIdentifier { get; set; }

        /// <summary>
        /// Assigned Type: ctlg-1100:Offer_ID
        /// </summary>
        /// <value>Assigned Type: ctlg-1100:Offer_ID</value>
        [DataMember(Name="OfferIdentifier", EmitDefaultValue=false)]
        public OfferIdentifier OfferIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets ProductIdentifier
        /// </summary>
        [DataMember(Name="ProductIdentifier", EmitDefaultValue=false)]
        public List<ProductIdentifier> ProductIdentifier { get; set; }

        /// <summary>
        /// The segmentSequence within the product the action is being requested for. Used when multiple flights exist within a product. Only one product may be selected with this option.
        /// </summary>
        /// <value>The segmentSequence within the product the action is being requested for. Used when multiple flights exist within a product. Only one product may be selected with this option.</value>
        [DataMember(Name="SegmentSequenceList", EmitDefaultValue=false)]
        public List<int?> SegmentSequenceList { get; set; }

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
            sb.Append("class BuildFromReservationWorkbench {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ReservationIdentifier: ").Append(ReservationIdentifier).Append("\n");
            sb.Append("  OfferIdentifier: ").Append(OfferIdentifier).Append("\n");
            sb.Append("  ProductIdentifier: ").Append(ProductIdentifier).Append("\n");
            sb.Append("  SegmentSequenceList: ").Append(SegmentSequenceList).Append("\n");
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
            return this.Equals(input as BuildFromReservationWorkbench);
        }

        /// <summary>
        /// Returns true if BuildFromReservationWorkbench instances are equal
        /// </summary>
        /// <param name="input">Instance of BuildFromReservationWorkbench to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuildFromReservationWorkbench input)
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
                    this.ReservationIdentifier == input.ReservationIdentifier ||
                    (this.ReservationIdentifier != null &&
                    this.ReservationIdentifier.Equals(input.ReservationIdentifier))
                ) && 
                (
                    this.OfferIdentifier == input.OfferIdentifier ||
                    (this.OfferIdentifier != null &&
                    this.OfferIdentifier.Equals(input.OfferIdentifier))
                ) && 
                (
                    this.ProductIdentifier == input.ProductIdentifier ||
                    this.ProductIdentifier != null &&
                    this.ProductIdentifier.SequenceEqual(input.ProductIdentifier)
                ) && 
                (
                    this.SegmentSequenceList == input.SegmentSequenceList ||
                    this.SegmentSequenceList != null &&
                    this.SegmentSequenceList.SequenceEqual(input.SegmentSequenceList)
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
                if (this.ReservationIdentifier != null)
                    hashCode = hashCode * 59 + this.ReservationIdentifier.GetHashCode();
                if (this.OfferIdentifier != null)
                    hashCode = hashCode * 59 + this.OfferIdentifier.GetHashCode();
                if (this.ProductIdentifier != null)
                    hashCode = hashCode * 59 + this.ProductIdentifier.GetHashCode();
                if (this.SegmentSequenceList != null)
                    hashCode = hashCode * 59 + this.SegmentSequenceList.GetHashCode();
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