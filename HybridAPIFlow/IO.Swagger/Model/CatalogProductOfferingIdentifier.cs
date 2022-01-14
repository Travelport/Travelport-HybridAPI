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
    /// CatalogProductOfferingIdentifier
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "@type")]
    public partial class CatalogProductOfferingIdentifier :  IEquatable<CatalogProductOfferingIdentifier>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogProductOfferingIdentifier" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CatalogProductOfferingIdentifier() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogProductOfferingIdentifier" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="id">Local indentifier within a given message for this object..</param>
        /// <param name="identifier">Assigned Type: c-1100:Identifier.</param>
        /// <param name="catalogProductOfferingRef">Used to reference another instance of this object in the same message.</param>
        public CatalogProductOfferingIdentifier(string type = default(string), string id = default(string), Identifier identifier = default(Identifier), string catalogProductOfferingRef = default(string))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for CatalogProductOfferingIdentifier and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.Id = id;
            this.Identifier = identifier;
            this.CatalogProductOfferingRef = catalogProductOfferingRef;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="@type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Local indentifier within a given message for this object.
        /// </summary>
        /// <value>Local indentifier within a given message for this object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Assigned Type: c-1100:Identifier
        /// </summary>
        /// <value>Assigned Type: c-1100:Identifier</value>
        [DataMember(Name="Identifier", EmitDefaultValue=false)]
        public Identifier Identifier { get; set; }

        /// <summary>
        /// Used to reference another instance of this object in the same message
        /// </summary>
        /// <value>Used to reference another instance of this object in the same message</value>
        [DataMember(Name="CatalogProductOfferingRef", EmitDefaultValue=false)]
        public string CatalogProductOfferingRef { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CatalogProductOfferingIdentifier {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  CatalogProductOfferingRef: ").Append(CatalogProductOfferingRef).Append("\n");
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
            return this.Equals(input as CatalogProductOfferingIdentifier);
        }

        /// <summary>
        /// Returns true if CatalogProductOfferingIdentifier instances are equal
        /// </summary>
        /// <param name="input">Instance of CatalogProductOfferingIdentifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CatalogProductOfferingIdentifier input)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.CatalogProductOfferingRef == input.CatalogProductOfferingRef ||
                    (this.CatalogProductOfferingRef != null &&
                    this.CatalogProductOfferingRef.Equals(input.CatalogProductOfferingRef))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.CatalogProductOfferingRef != null)
                    hashCode = hashCode * 59 + this.CatalogProductOfferingRef.GetHashCode();
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
