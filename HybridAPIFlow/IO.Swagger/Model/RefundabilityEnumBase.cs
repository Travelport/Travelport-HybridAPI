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
    /// Defines RefundabilityEnum_Base
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum RefundabilityEnumBase
    {
        
        /// <summary>
        /// Enum Refundable for value: Refundable
        /// </summary>
        [EnumMember(Value = "Refundable")]
        Refundable = 1,
        
        /// <summary>
        /// Enum NonRefundable for value: NonRefundable
        /// </summary>
        [EnumMember(Value = "NonRefundable")]
        NonRefundable = 2,
        
        /// <summary>
        /// Enum Reusable for value: Reusable
        /// </summary>
        [EnumMember(Value = "Reusable")]
        Reusable = 3,
        
        /// <summary>
        /// Enum Other for value: Other_
        /// </summary>
        [EnumMember(Value = "Other_")]
        Other = 4
    }

}
