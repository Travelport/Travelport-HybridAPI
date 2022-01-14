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
    /// ConnectionPreferencesAir
    /// </summary>
    [DataContract]
    public partial class ConnectionPreferencesAir : ConnectionPreferences,  IEquatable<ConnectionPreferencesAir>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionPreferencesAir" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConnectionPreferencesAir() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionPreferencesAir" /> class.
        /// </summary>
        /// <param name="flightType">Assigned Type: ctar-1100:FlightType.</param>
        /// <param name="extensionPointChoice">extensionPointChoice.</param>
        public ConnectionPreferencesAir(FlightType flightType = default(FlightType), ExtensionPointChoice extensionPointChoice = default(ExtensionPointChoice), string type = "ConnectionPreferencesAir", List<int?> legSequence = default(List<int?>), string maxConnectionDuration = default(string), string maxOvernightDuration = default(string), List<string> connectionPoint = default(List<string>), Object extensionPoint = default(Object)) : base(type, legSequence, maxConnectionDuration, maxOvernightDuration, connectionPoint, extensionPoint)
        {
            this.FlightType = flightType;
            this.ExtensionPointChoice = extensionPointChoice;
        }
        
        /// <summary>
        /// Assigned Type: ctar-1100:FlightType
        /// </summary>
        /// <value>Assigned Type: ctar-1100:FlightType</value>
        [DataMember(Name="FlightType", EmitDefaultValue=false)]
        public FlightType FlightType { get; set; }

        /// <summary>
        /// Gets or Sets ExtensionPointChoice
        /// </summary>
        [DataMember(Name="ExtensionPoint_Choice", EmitDefaultValue=false)]
        public ExtensionPointChoice ExtensionPointChoice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectionPreferencesAir {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  FlightType: ").Append(FlightType).Append("\n");
            sb.Append("  ExtensionPointChoice: ").Append(ExtensionPointChoice).Append("\n");
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
            return this.Equals(input as ConnectionPreferencesAir);
        }

        /// <summary>
        /// Returns true if ConnectionPreferencesAir instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectionPreferencesAir to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectionPreferencesAir input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.FlightType == input.FlightType ||
                    (this.FlightType != null &&
                    this.FlightType.Equals(input.FlightType))
                ) && base.Equals(input) && 
                (
                    this.ExtensionPointChoice == input.ExtensionPointChoice ||
                    (this.ExtensionPointChoice != null &&
                    this.ExtensionPointChoice.Equals(input.ExtensionPointChoice))
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
                if (this.FlightType != null)
                    hashCode = hashCode * 59 + this.FlightType.GetHashCode();
                if (this.ExtensionPointChoice != null)
                    hashCode = hashCode * 59 + this.ExtensionPointChoice.GetHashCode();
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
