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
    /// Defines BrandStatusEnum
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum BrandStatusEnum
    {
        
        /// <summary>
        /// Enum NotOffered for value: NotOffered
        /// </summary>
        [EnumMember(Value = "NotOffered")]
        NotOffered = 1,
        
        /// <summary>
        /// Enum SoldOut for value: SoldOut
        /// </summary>
        [EnumMember(Value = "SoldOut")]
        SoldOut = 2
    }

}
