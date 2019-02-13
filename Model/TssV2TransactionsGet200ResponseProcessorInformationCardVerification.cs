/* 
 * CyberSource Flex API
 *
 * Simple PAN tokenization service
 *
 * OpenAPI spec version: 0.0.1
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
using SwaggerDateConverter = cybersource-rest-client-dotnet.Client.SwaggerDateConverter;

namespace cybersource-rest-client-dotnet.Model
{
    /// <summary>
    /// TssV2TransactionsGet200ResponseProcessorInformationCardVerification
    /// </summary>
    [DataContract]
    public partial class TssV2TransactionsGet200ResponseProcessorInformationCardVerification :  IEquatable<TssV2TransactionsGet200ResponseProcessorInformationCardVerification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2TransactionsGet200ResponseProcessorInformationCardVerification" /> class.
        /// </summary>
        /// <param name="ResultCode">CVN result code. .</param>
        public TssV2TransactionsGet200ResponseProcessorInformationCardVerification(string ResultCode = default(string))
        {
            this.ResultCode = ResultCode;
        }
        
        /// <summary>
        /// CVN result code. 
        /// </summary>
        /// <value>CVN result code. </value>
        [DataMember(Name="resultCode", EmitDefaultValue=false)]
        public string ResultCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2TransactionsGet200ResponseProcessorInformationCardVerification {\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as TssV2TransactionsGet200ResponseProcessorInformationCardVerification);
        }

        /// <summary>
        /// Returns true if TssV2TransactionsGet200ResponseProcessorInformationCardVerification instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2TransactionsGet200ResponseProcessorInformationCardVerification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2TransactionsGet200ResponseProcessorInformationCardVerification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ResultCode == other.ResultCode ||
                    this.ResultCode != null &&
                    this.ResultCode.Equals(other.ResultCode)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ResultCode != null)
                    hash = hash * 59 + this.ResultCode.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // ResultCode (string) maxLength
            if(this.ResultCode != null && this.ResultCode.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ResultCode, length must be less than 1.", new [] { "ResultCode" });
            }

            yield break;
        }
    }

}
