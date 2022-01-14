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
    /// Defines CarrierPreferenceTypeEnum
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CarrierPreferenceTypeEnum
    {
        
        /// <summary>
        /// Enum Preferred for value: Preferred
        /// </summary>
        [EnumMember(Value = "Preferred")]
        Preferred = 1,
        
        /// <summary>
        /// Enum Permitted for value: Permitted
        /// </summary>
        [EnumMember(Value = "Permitted")]
        Permitted = 2,
        
        /// <summary>
        /// Enum Prohibited for value: Prohibited
        /// </summary>
        [EnumMember(Value = "Prohibited")]
        Prohibited = 3
    }

}
