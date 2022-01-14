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
    /// PricingModifiersAir
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "@type")]
    [JsonSubtypes.KnownSubType(typeof(PricingModifiersAirDetail), "PricingModifiersAirDetail")]
    public partial class PricingModifiersAir :  IEquatable<PricingModifiersAir>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PricingModifiersAir" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PricingModifiersAir() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PricingModifiersAir" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="currencyCode">Assigned Type: c-1100:CurrencyCodeISO.</param>
        /// <param name="fareSelection">Assigned Type: ctar-1100:FareSelection.</param>
        /// <param name="organizationInformation">Assigned Type: ctar-1100:OrganizationInformation.</param>
        /// <param name="taxExemption">Assigned Type: ctar-1100:TaxExemption.</param>
        /// <param name="promotionalCode">promotionalCode.</param>
        /// <param name="sellCity">Overrides the sell city of the requestor..</param>
        /// <param name="ticketCity">Overrides the ticket city of the requestor..</param>
        /// <param name="includeSplitPaymentInd">If true, split payment (split ticket) offerings/offers will be returned.</param>
        /// <param name="extensionPoint">extensionPoint.</param>
        public PricingModifiersAir(string type = default(string), string currencyCode = default(string), FareSelection fareSelection = default(FareSelection), OrganizationInformation organizationInformation = default(OrganizationInformation), TaxExemption taxExemption = default(TaxExemption), List<PromotionalCode> promotionalCode = default(List<PromotionalCode>), string sellCity = default(string), string ticketCity = default(string), bool? includeSplitPaymentInd = default(bool?), Object extensionPoint = default(Object))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for PricingModifiersAir and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.CurrencyCode = currencyCode;
            this.FareSelection = fareSelection;
            this.OrganizationInformation = organizationInformation;
            this.TaxExemption = taxExemption;
            this.PromotionalCode = promotionalCode;
            this.SellCity = sellCity;
            this.TicketCity = ticketCity;
            this.IncludeSplitPaymentInd = includeSplitPaymentInd;
            this.ExtensionPoint = extensionPoint;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="@type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Assigned Type: c-1100:CurrencyCodeISO
        /// </summary>
        /// <value>Assigned Type: c-1100:CurrencyCodeISO</value>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Assigned Type: ctar-1100:FareSelection
        /// </summary>
        /// <value>Assigned Type: ctar-1100:FareSelection</value>
        [DataMember(Name="FareSelection", EmitDefaultValue=false)]
        public FareSelection FareSelection { get; set; }

        /// <summary>
        /// Assigned Type: ctar-1100:OrganizationInformation
        /// </summary>
        /// <value>Assigned Type: ctar-1100:OrganizationInformation</value>
        [DataMember(Name="OrganizationInformation", EmitDefaultValue=false)]
        public OrganizationInformation OrganizationInformation { get; set; }

        /// <summary>
        /// Assigned Type: ctar-1100:TaxExemption
        /// </summary>
        /// <value>Assigned Type: ctar-1100:TaxExemption</value>
        [DataMember(Name="TaxExemption", EmitDefaultValue=false)]
        public TaxExemption TaxExemption { get; set; }

        /// <summary>
        /// Gets or Sets PromotionalCode
        /// </summary>
        [DataMember(Name="PromotionalCode", EmitDefaultValue=false)]
        public List<PromotionalCode> PromotionalCode { get; set; }

        /// <summary>
        /// Overrides the sell city of the requestor.
        /// </summary>
        /// <value>Overrides the sell city of the requestor.</value>
        [DataMember(Name="SellCity", EmitDefaultValue=false)]
        public string SellCity { get; set; }

        /// <summary>
        /// Overrides the ticket city of the requestor.
        /// </summary>
        /// <value>Overrides the ticket city of the requestor.</value>
        [DataMember(Name="TicketCity", EmitDefaultValue=false)]
        public string TicketCity { get; set; }

        /// <summary>
        /// If true, split payment (split ticket) offerings/offers will be returned
        /// </summary>
        /// <value>If true, split payment (split ticket) offerings/offers will be returned</value>
        [DataMember(Name="includeSplitPaymentInd", EmitDefaultValue=false)]
        public bool? IncludeSplitPaymentInd { get; set; }

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
            sb.Append("class PricingModifiersAir {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  FareSelection: ").Append(FareSelection).Append("\n");
            sb.Append("  OrganizationInformation: ").Append(OrganizationInformation).Append("\n");
            sb.Append("  TaxExemption: ").Append(TaxExemption).Append("\n");
            sb.Append("  PromotionalCode: ").Append(PromotionalCode).Append("\n");
            sb.Append("  SellCity: ").Append(SellCity).Append("\n");
            sb.Append("  TicketCity: ").Append(TicketCity).Append("\n");
            sb.Append("  IncludeSplitPaymentInd: ").Append(IncludeSplitPaymentInd).Append("\n");
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
            return this.Equals(input as PricingModifiersAir);
        }

        /// <summary>
        /// Returns true if PricingModifiersAir instances are equal
        /// </summary>
        /// <param name="input">Instance of PricingModifiersAir to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PricingModifiersAir input)
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
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.FareSelection == input.FareSelection ||
                    (this.FareSelection != null &&
                    this.FareSelection.Equals(input.FareSelection))
                ) && 
                (
                    this.OrganizationInformation == input.OrganizationInformation ||
                    (this.OrganizationInformation != null &&
                    this.OrganizationInformation.Equals(input.OrganizationInformation))
                ) && 
                (
                    this.TaxExemption == input.TaxExemption ||
                    (this.TaxExemption != null &&
                    this.TaxExemption.Equals(input.TaxExemption))
                ) && 
                (
                    this.PromotionalCode == input.PromotionalCode ||
                    this.PromotionalCode != null &&
                    this.PromotionalCode.SequenceEqual(input.PromotionalCode)
                ) && 
                (
                    this.SellCity == input.SellCity ||
                    (this.SellCity != null &&
                    this.SellCity.Equals(input.SellCity))
                ) && 
                (
                    this.TicketCity == input.TicketCity ||
                    (this.TicketCity != null &&
                    this.TicketCity.Equals(input.TicketCity))
                ) && 
                (
                    this.IncludeSplitPaymentInd == input.IncludeSplitPaymentInd ||
                    (this.IncludeSplitPaymentInd != null &&
                    this.IncludeSplitPaymentInd.Equals(input.IncludeSplitPaymentInd))
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
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.FareSelection != null)
                    hashCode = hashCode * 59 + this.FareSelection.GetHashCode();
                if (this.OrganizationInformation != null)
                    hashCode = hashCode * 59 + this.OrganizationInformation.GetHashCode();
                if (this.TaxExemption != null)
                    hashCode = hashCode * 59 + this.TaxExemption.GetHashCode();
                if (this.PromotionalCode != null)
                    hashCode = hashCode * 59 + this.PromotionalCode.GetHashCode();
                if (this.SellCity != null)
                    hashCode = hashCode * 59 + this.SellCity.GetHashCode();
                if (this.TicketCity != null)
                    hashCode = hashCode * 59 + this.TicketCity.GetHashCode();
                if (this.IncludeSplitPaymentInd != null)
                    hashCode = hashCode * 59 + this.IncludeSplitPaymentInd.GetHashCode();
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
            // CurrencyCode (string) pattern
            Regex regexCurrencyCode = new Regex(@"[a-zA-Z]{3}", RegexOptions.CultureInvariant);
            if (false == regexCurrencyCode.Match(this.CurrencyCode).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CurrencyCode, must match a pattern of " + regexCurrencyCode, new [] { "CurrencyCode" });
            }

            // SellCity (string) maxLength
            if(this.SellCity != null && this.SellCity.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SellCity, length must be less than 3.", new [] { "SellCity" });
            }

            // SellCity (string) minLength
            if(this.SellCity != null && this.SellCity.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SellCity, length must be greater than 3.", new [] { "SellCity" });
            }

            // SellCity (string) pattern
            Regex regexSellCity = new Regex(@"([a-zA-Z]{3})", RegexOptions.CultureInvariant);
            if (false == regexSellCity.Match(this.SellCity).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SellCity, must match a pattern of " + regexSellCity, new [] { "SellCity" });
            }

            // TicketCity (string) maxLength
            if(this.TicketCity != null && this.TicketCity.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TicketCity, length must be less than 3.", new [] { "TicketCity" });
            }

            // TicketCity (string) minLength
            if(this.TicketCity != null && this.TicketCity.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TicketCity, length must be greater than 3.", new [] { "TicketCity" });
            }

            // TicketCity (string) pattern
            Regex regexTicketCity = new Regex(@"([a-zA-Z]{3})", RegexOptions.CultureInvariant);
            if (false == regexTicketCity.Match(this.TicketCity).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TicketCity, must match a pattern of " + regexTicketCity, new [] { "TicketCity" });
            }

            yield break;
        }
    }

}
