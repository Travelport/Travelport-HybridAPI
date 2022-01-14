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
    /// FlightDetail
    /// </summary>
    [DataContract]
    public partial class FlightDetail : Flight,  IEquatable<FlightDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlightDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FlightDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlightDetail" /> class.
        /// </summary>
        /// <param name="availabilitySourceCode">Assigned Type: ctar-1100:AvailabilitySourceCodeENUM.</param>
        /// <param name="extensionPointDetail">extensionPointDetail.</param>
        public FlightDetail(AvailabilitySourceCodeENUM availabilitySourceCode = default(AvailabilitySourceCodeENUM), ExtensionPointDetail extensionPointDetail = default(ExtensionPointDetail), string type = default(string), string id = default(string), string flightRef = default(string), Identifier identifier = default(Identifier), int? distance = default(int?), int? stops = default(int?), string duration = default(string), string carrier = default(string), string number = default(string), string operatingCarrier = default(string), string operatingCarrierName = default(string), string equipment = default(string), Departure departure = default(Departure), Arrival arrival = default(Arrival), List<IntermediateStop> intermediateStop = default(List<IntermediateStop>), bool? subjectToGovernmentApprovalInd = default(bool?), Object extensionPoint = default(Object)) : base(distance, stops, duration, carrier, number, operatingCarrier, operatingCarrierName, equipment, departure, arrival, intermediateStop, subjectToGovernmentApprovalInd, extensionPoint)
        {
            this.AvailabilitySourceCode = availabilitySourceCode;
            this.ExtensionPointDetail = extensionPointDetail;
        }
        
        /// <summary>
        /// Assigned Type: ctar-1100:AvailabilitySourceCodeENUM
        /// </summary>
        /// <value>Assigned Type: ctar-1100:AvailabilitySourceCodeENUM</value>
        [DataMember(Name="AvailabilitySourceCode", EmitDefaultValue=false)]
        public AvailabilitySourceCodeENUM AvailabilitySourceCode { get; set; }

        /// <summary>
        /// Gets or Sets ExtensionPointDetail
        /// </summary>
        [DataMember(Name="ExtensionPoint_Detail", EmitDefaultValue=false)]
        public ExtensionPointDetail ExtensionPointDetail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlightDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AvailabilitySourceCode: ").Append(AvailabilitySourceCode).Append("\n");
            sb.Append("  ExtensionPointDetail: ").Append(ExtensionPointDetail).Append("\n");
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
            return this.Equals(input as FlightDetail);
        }

        /// <summary>
        /// Returns true if FlightDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of FlightDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlightDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.AvailabilitySourceCode == input.AvailabilitySourceCode ||
                    (this.AvailabilitySourceCode != null &&
                    this.AvailabilitySourceCode.Equals(input.AvailabilitySourceCode))
                ) && base.Equals(input) && 
                (
                    this.ExtensionPointDetail == input.ExtensionPointDetail ||
                    (this.ExtensionPointDetail != null &&
                    this.ExtensionPointDetail.Equals(input.ExtensionPointDetail))
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
                if (this.AvailabilitySourceCode != null)
                    hashCode = hashCode * 59 + this.AvailabilitySourceCode.GetHashCode();
                if (this.ExtensionPointDetail != null)
                    hashCode = hashCode * 59 + this.ExtensionPointDetail.GetHashCode();
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
