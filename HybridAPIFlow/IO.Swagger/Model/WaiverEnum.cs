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
    /// Type of Waiver like Death of Pessanger,illness Of Passenger, Death of Immediate Family Member  etc
    /// </summary>
    /// <value>Type of Waiver like Death of Pessanger,illness Of Passenger, Death of Immediate Family Member  etc</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum WaiverEnum
    {
        
        /// <summary>
        /// Enum DeathOfPassenger for value: DeathOfPassenger
        /// </summary>
        [EnumMember(Value = "DeathOfPassenger")]
        DeathOfPassenger = 1,
        
        /// <summary>
        /// Enum IllnessOfPassenger for value: IllnessOfPassenger
        /// </summary>
        [EnumMember(Value = "IllnessOfPassenger")]
        IllnessOfPassenger = 2,
        
        /// <summary>
        /// Enum DeathOfImmediateFamilyMember for value: DeathOfImmediateFamilyMember
        /// </summary>
        [EnumMember(Value = "DeathOfImmediateFamilyMember")]
        DeathOfImmediateFamilyMember = 3,
        
        /// <summary>
        /// Enum IllnessOfImmediateFamilyMember for value: IllnessOfImmediateFamilyMember
        /// </summary>
        [EnumMember(Value = "IllnessOfImmediateFamilyMember")]
        IllnessOfImmediateFamilyMember = 4,
        
        /// <summary>
        /// Enum TicketUpgrade for value: TicketUpgrade
        /// </summary>
        [EnumMember(Value = "TicketUpgrade")]
        TicketUpgrade = 5,
        
        /// <summary>
        /// Enum ScheduleChange for value: ScheduleChange
        /// </summary>
        [EnumMember(Value = "ScheduleChange")]
        ScheduleChange = 6
    }

}
