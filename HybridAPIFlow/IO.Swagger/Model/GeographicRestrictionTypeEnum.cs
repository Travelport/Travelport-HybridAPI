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
    /// Defines GeographicRestrictionTypeEnum
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum GeographicRestrictionTypeEnum
    {
        
        /// <summary>
        /// Enum Area for value: Area
        /// </summary>
        [EnumMember(Value = "Area")]
        Area = 1,
        
        /// <summary>
        /// Enum Airport for value: Airport
        /// </summary>
        [EnumMember(Value = "Airport")]
        Airport = 2,
        
        /// <summary>
        /// Enum City for value: City
        /// </summary>
        [EnumMember(Value = "City")]
        City = 3,
        
        /// <summary>
        /// Enum Country for value: Country
        /// </summary>
        [EnumMember(Value = "Country")]
        Country = 4,
        
        /// <summary>
        /// Enum StateProvince for value: StateProvince
        /// </summary>
        [EnumMember(Value = "StateProvince")]
        StateProvince = 5,
        
        /// <summary>
        /// Enum Zone for value: Zone
        /// </summary>
        [EnumMember(Value = "Zone")]
        Zone = 6
    }

}
