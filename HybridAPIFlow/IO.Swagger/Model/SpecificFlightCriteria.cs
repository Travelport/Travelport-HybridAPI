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
    /// SpecificFlightCriteria
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "@type")]
    public partial class SpecificFlightCriteria :  IEquatable<SpecificFlightCriteria>, IValidatableObject
    {
        /// <summary>
        /// Cabin
        /// </summary>
        /// <value>Cabin</value>
        [DataMember(Name="cabin", EmitDefaultValue=false)]
        public CabinAirEnum? Cabin { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecificFlightCriteria" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SpecificFlightCriteria() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecificFlightCriteria" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="carrier">Assigned Type: c-1100:AirlineCode (required).</param>
        /// <param name="flightNumber">Assigned Type: c-1100:FlightNumber (required).</param>
        /// <param name="departureDate">date of departure (required).</param>
        /// <param name="departureTime">Assigned Type: ota2:LocalTime.</param>
        /// <param name="arrivalDate">Arrival date.</param>
        /// <param name="arrivalTime">Assigned Type: ota2:LocalTime.</param>
        /// <param name="from">Assigned Type: c-1100:AirportCodeIATA (required).</param>
        /// <param name="to">Assigned Type: c-1100:AirportCodeIATA (required).</param>
        /// <param name="cabin">Cabin.</param>
        /// <param name="classOfService">Assigned Type: c-1100:ClassOfService.</param>
        /// <param name="brandTier">Assigned Type: c-1100:NumberSingleDigit.</param>
        /// <param name="segmentSequence">Assigned Type: c-1100:SegmentSequence (required).</param>
        /// <param name="boundFlightsInd">if true indicates that the flight availability was polled (availability check) using connecting segments. If false, flights were polled as point to point segments..</param>
        /// <param name="extensionPoint">extensionPoint.</param>
        public SpecificFlightCriteria(string type = default(string), string carrier = default(string), string flightNumber = default(string), DateTime? departureDate = default(DateTime?), string departureTime = default(string), DateTime? arrivalDate = default(DateTime?), string arrivalTime = default(string), string from = default(string), string to = default(string), CabinAirEnum? cabin = default(CabinAirEnum?), string classOfService = default(string), int? brandTier = default(int?), int? segmentSequence = default(int?), bool? boundFlightsInd = default(bool?), Object extensionPoint = default(Object))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for SpecificFlightCriteria and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "carrier" is required (not null)
            if (carrier == null)
            {
                throw new InvalidDataException("carrier is a required property for SpecificFlightCriteria and cannot be null");
            }
            else
            {
                this.Carrier = carrier;
            }
            // to ensure "flightNumber" is required (not null)
            if (flightNumber == null)
            {
                throw new InvalidDataException("flightNumber is a required property for SpecificFlightCriteria and cannot be null");
            }
            else
            {
                this.FlightNumber = flightNumber;
            }
            // to ensure "departureDate" is required (not null)
            if (departureDate == null)
            {
                throw new InvalidDataException("departureDate is a required property for SpecificFlightCriteria and cannot be null");
            }
            else
            {
                this.DepartureDate = departureDate;
            }
            // to ensure "from" is required (not null)
            if (from == null)
            {
                throw new InvalidDataException("from is a required property for SpecificFlightCriteria and cannot be null");
            }
            else
            {
                this.From = from;
            }
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new InvalidDataException("to is a required property for SpecificFlightCriteria and cannot be null");
            }
            else
            {
                this.To = to;
            }
            // to ensure "segmentSequence" is required (not null)
            if (segmentSequence == null)
            {
                throw new InvalidDataException("segmentSequence is a required property for SpecificFlightCriteria and cannot be null");
            }
            else
            {
                this.SegmentSequence = segmentSequence;
            }
            this.DepartureTime = departureTime;
            this.ArrivalDate = arrivalDate;
            this.ArrivalTime = arrivalTime;
            this.Cabin = cabin;
            this.ClassOfService = classOfService;
            this.BrandTier = brandTier;
            this.BoundFlightsInd = boundFlightsInd;
            this.ExtensionPoint = extensionPoint;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="@type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Assigned Type: c-1100:AirlineCode
        /// </summary>
        /// <value>Assigned Type: c-1100:AirlineCode</value>
        [DataMember(Name="carrier", EmitDefaultValue=false)]
        public string Carrier { get; set; }

        /// <summary>
        /// Assigned Type: c-1100:FlightNumber
        /// </summary>
        /// <value>Assigned Type: c-1100:FlightNumber</value>
        [DataMember(Name="flightNumber", EmitDefaultValue=false)]
        public string FlightNumber { get; set; }

        /// <summary>
        /// date of departure
        /// </summary>
        /// <value>date of departure</value>
        [DataMember(Name="departureDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? DepartureDate { get; set; }

        /// <summary>
        /// Assigned Type: ota2:LocalTime
        /// </summary>
        /// <value>Assigned Type: ota2:LocalTime</value>
        [DataMember(Name="departureTime", EmitDefaultValue=false)]
        public string DepartureTime { get; set; }

        /// <summary>
        /// Arrival date
        /// </summary>
        /// <value>Arrival date</value>
        [DataMember(Name="arrivalDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? ArrivalDate { get; set; }

        /// <summary>
        /// Assigned Type: ota2:LocalTime
        /// </summary>
        /// <value>Assigned Type: ota2:LocalTime</value>
        [DataMember(Name="arrivalTime", EmitDefaultValue=false)]
        public string ArrivalTime { get; set; }

        /// <summary>
        /// Assigned Type: c-1100:AirportCodeIATA
        /// </summary>
        /// <value>Assigned Type: c-1100:AirportCodeIATA</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public string From { get; set; }

        /// <summary>
        /// Assigned Type: c-1100:AirportCodeIATA
        /// </summary>
        /// <value>Assigned Type: c-1100:AirportCodeIATA</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public string To { get; set; }


        /// <summary>
        /// Assigned Type: c-1100:ClassOfService
        /// </summary>
        /// <value>Assigned Type: c-1100:ClassOfService</value>
        [DataMember(Name="classOfService", EmitDefaultValue=false)]
        public string ClassOfService { get; set; }

        /// <summary>
        /// Assigned Type: c-1100:NumberSingleDigit
        /// </summary>
        /// <value>Assigned Type: c-1100:NumberSingleDigit</value>
        [DataMember(Name="brandTier", EmitDefaultValue=false)]
        public int? BrandTier { get; set; }

        /// <summary>
        /// Assigned Type: c-1100:SegmentSequence
        /// </summary>
        /// <value>Assigned Type: c-1100:SegmentSequence</value>
        [DataMember(Name="segmentSequence", EmitDefaultValue=false)]
        public int? SegmentSequence { get; set; }

        /// <summary>
        /// if true indicates that the flight availability was polled (availability check) using connecting segments. If false, flights were polled as point to point segments.
        /// </summary>
        /// <value>if true indicates that the flight availability was polled (availability check) using connecting segments. If false, flights were polled as point to point segments.</value>
        [DataMember(Name="boundFlightsInd", EmitDefaultValue=false)]
        public bool? BoundFlightsInd { get; set; }

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
            sb.Append("class SpecificFlightCriteria {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Carrier: ").Append(Carrier).Append("\n");
            sb.Append("  FlightNumber: ").Append(FlightNumber).Append("\n");
            sb.Append("  DepartureDate: ").Append(DepartureDate).Append("\n");
            sb.Append("  DepartureTime: ").Append(DepartureTime).Append("\n");
            sb.Append("  ArrivalDate: ").Append(ArrivalDate).Append("\n");
            sb.Append("  ArrivalTime: ").Append(ArrivalTime).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Cabin: ").Append(Cabin).Append("\n");
            sb.Append("  ClassOfService: ").Append(ClassOfService).Append("\n");
            sb.Append("  BrandTier: ").Append(BrandTier).Append("\n");
            sb.Append("  SegmentSequence: ").Append(SegmentSequence).Append("\n");
            sb.Append("  BoundFlightsInd: ").Append(BoundFlightsInd).Append("\n");
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
            return this.Equals(input as SpecificFlightCriteria);
        }

        /// <summary>
        /// Returns true if SpecificFlightCriteria instances are equal
        /// </summary>
        /// <param name="input">Instance of SpecificFlightCriteria to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpecificFlightCriteria input)
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
                    this.Carrier == input.Carrier ||
                    (this.Carrier != null &&
                    this.Carrier.Equals(input.Carrier))
                ) && 
                (
                    this.FlightNumber == input.FlightNumber ||
                    (this.FlightNumber != null &&
                    this.FlightNumber.Equals(input.FlightNumber))
                ) && 
                (
                    this.DepartureDate == input.DepartureDate ||
                    (this.DepartureDate != null &&
                    this.DepartureDate.Equals(input.DepartureDate))
                ) && 
                (
                    this.DepartureTime == input.DepartureTime ||
                    (this.DepartureTime != null &&
                    this.DepartureTime.Equals(input.DepartureTime))
                ) && 
                (
                    this.ArrivalDate == input.ArrivalDate ||
                    (this.ArrivalDate != null &&
                    this.ArrivalDate.Equals(input.ArrivalDate))
                ) && 
                (
                    this.ArrivalTime == input.ArrivalTime ||
                    (this.ArrivalTime != null &&
                    this.ArrivalTime.Equals(input.ArrivalTime))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.Cabin == input.Cabin ||
                    (this.Cabin != null &&
                    this.Cabin.Equals(input.Cabin))
                ) && 
                (
                    this.ClassOfService == input.ClassOfService ||
                    (this.ClassOfService != null &&
                    this.ClassOfService.Equals(input.ClassOfService))
                ) && 
                (
                    this.BrandTier == input.BrandTier ||
                    (this.BrandTier != null &&
                    this.BrandTier.Equals(input.BrandTier))
                ) && 
                (
                    this.SegmentSequence == input.SegmentSequence ||
                    (this.SegmentSequence != null &&
                    this.SegmentSequence.Equals(input.SegmentSequence))
                ) && 
                (
                    this.BoundFlightsInd == input.BoundFlightsInd ||
                    (this.BoundFlightsInd != null &&
                    this.BoundFlightsInd.Equals(input.BoundFlightsInd))
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
                if (this.Carrier != null)
                    hashCode = hashCode * 59 + this.Carrier.GetHashCode();
                if (this.FlightNumber != null)
                    hashCode = hashCode * 59 + this.FlightNumber.GetHashCode();
                if (this.DepartureDate != null)
                    hashCode = hashCode * 59 + this.DepartureDate.GetHashCode();
                if (this.DepartureTime != null)
                    hashCode = hashCode * 59 + this.DepartureTime.GetHashCode();
                if (this.ArrivalDate != null)
                    hashCode = hashCode * 59 + this.ArrivalDate.GetHashCode();
                if (this.ArrivalTime != null)
                    hashCode = hashCode * 59 + this.ArrivalTime.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Cabin != null)
                    hashCode = hashCode * 59 + this.Cabin.GetHashCode();
                if (this.ClassOfService != null)
                    hashCode = hashCode * 59 + this.ClassOfService.GetHashCode();
                if (this.BrandTier != null)
                    hashCode = hashCode * 59 + this.BrandTier.GetHashCode();
                if (this.SegmentSequence != null)
                    hashCode = hashCode * 59 + this.SegmentSequence.GetHashCode();
                if (this.BoundFlightsInd != null)
                    hashCode = hashCode * 59 + this.BoundFlightsInd.GetHashCode();
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
            // Carrier (string) pattern
            Regex regexCarrier = new Regex(@"([a-zA-Z0-9]{2,3})", RegexOptions.CultureInvariant);
            if (false == regexCarrier.Match(this.Carrier).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Carrier, must match a pattern of " + regexCarrier, new [] { "Carrier" });
            }

            // FlightNumber (string) pattern
            Regex regexFlightNumber = new Regex(@"[0-9]{1,4}[A-Z]?|OPEN|ARNK", RegexOptions.CultureInvariant);
            if (false == regexFlightNumber.Match(this.FlightNumber).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FlightNumber, must match a pattern of " + regexFlightNumber, new [] { "FlightNumber" });
            }

            // DepartureTime (string) pattern
            Regex regexDepartureTime = new Regex(@"(([01]\\d|2[0-3])((:?)[0-5]\\d)?|24\\:?00)((:?)[0-5]\\d)?([\\.,]\\d+(?!:))?", RegexOptions.CultureInvariant);
            if (false == regexDepartureTime.Match(this.DepartureTime).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DepartureTime, must match a pattern of " + regexDepartureTime, new [] { "DepartureTime" });
            }

            // ArrivalTime (string) pattern
            Regex regexArrivalTime = new Regex(@"(([01]\\d|2[0-3])((:?)[0-5]\\d)?|24\\:?00)((:?)[0-5]\\d)?([\\.,]\\d+(?!:))?", RegexOptions.CultureInvariant);
            if (false == regexArrivalTime.Match(this.ArrivalTime).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ArrivalTime, must match a pattern of " + regexArrivalTime, new [] { "ArrivalTime" });
            }

            // From (string) maxLength
            if(this.From != null && this.From.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for From, length must be less than 3.", new [] { "From" });
            }

            // From (string) minLength
            if(this.From != null && this.From.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for From, length must be greater than 3.", new [] { "From" });
            }

            // From (string) pattern
            Regex regexFrom = new Regex(@"([a-zA-Z]{3})", RegexOptions.CultureInvariant);
            if (false == regexFrom.Match(this.From).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for From, must match a pattern of " + regexFrom, new [] { "From" });
            }

            // To (string) maxLength
            if(this.To != null && this.To.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for To, length must be less than 3.", new [] { "To" });
            }

            // To (string) minLength
            if(this.To != null && this.To.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for To, length must be greater than 3.", new [] { "To" });
            }

            // To (string) pattern
            Regex regexTo = new Regex(@"([a-zA-Z]{3})", RegexOptions.CultureInvariant);
            if (false == regexTo.Match(this.To).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for To, must match a pattern of " + regexTo, new [] { "To" });
            }

            // ClassOfService (string) maxLength
            if(this.ClassOfService != null && this.ClassOfService.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClassOfService, length must be less than 2.", new [] { "ClassOfService" });
            }

            // ClassOfService (string) minLength
            if(this.ClassOfService != null && this.ClassOfService.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClassOfService, length must be greater than 1.", new [] { "ClassOfService" });
            }

            // ClassOfService (string) pattern
            Regex regexClassOfService = new Regex(@"([a-zA-Z0-9]{1,2})", RegexOptions.CultureInvariant);
            if (false == regexClassOfService.Match(this.ClassOfService).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClassOfService, must match a pattern of " + regexClassOfService, new [] { "ClassOfService" });
            }

            yield break;
        }
    }

}