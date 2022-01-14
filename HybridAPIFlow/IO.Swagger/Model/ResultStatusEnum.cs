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
    /// The status of an error or warning
    /// </summary>
    /// <value>The status of an error or warning</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ResultStatusEnum
    {
        
        /// <summary>
        /// Enum Notprocessed for value: Not processed
        /// </summary>
        [EnumMember(Value = "Not processed")]
        Notprocessed = 1,
        
        /// <summary>
        /// Enum Incomplete for value: Incomplete
        /// </summary>
        [EnumMember(Value = "Incomplete")]
        Incomplete = 2,
        
        /// <summary>
        /// Enum Complete for value: Complete
        /// </summary>
        [EnumMember(Value = "Complete")]
        Complete = 3,
        
        /// <summary>
        /// Enum Unknown for value: Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown = 4
    }

}