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
    /// TssV2TransactionsPost201ResponseEmbeddedPointOfSaleInformationPartner
    /// </summary>
    [DataContract]
    public partial class TssV2TransactionsPost201ResponseEmbeddedPointOfSaleInformationPartner :  IEquatable<TssV2TransactionsPost201ResponseEmbeddedPointOfSaleInformationPartner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2TransactionsPost201ResponseEmbeddedPointOfSaleInformationPartner" /> class.
        /// </summary>
        /// <param name="OriginalTransactionId">Network transaction identifier (TID). You can use this value to identify a specific transaction when you are discussing the transaction with your processor. Not all processors provide this  value. .</param>
        public TssV2TransactionsPost201ResponseEmbeddedPointOfSaleInformationPartner(string OriginalTransactionId = default(string))
        {
            this.OriginalTransactionId = OriginalTransactionId;
        }
        
        /// <summary>
        /// Network transaction identifier (TID). You can use this value to identify a specific transaction when you are discussing the transaction with your processor. Not all processors provide this  value. 
        /// </summary>
        /// <value>Network transaction identifier (TID). You can use this value to identify a specific transaction when you are discussing the transaction with your processor. Not all processors provide this  value. </value>
        [DataMember(Name="originalTransactionId", EmitDefaultValue=false)]
        public string OriginalTransactionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2TransactionsPost201ResponseEmbeddedPointOfSaleInformationPartner {\n");
            sb.Append("  OriginalTransactionId: ").Append(OriginalTransactionId).Append("\n");
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
            return this.Equals(obj as TssV2TransactionsPost201ResponseEmbeddedPointOfSaleInformationPartner);
        }

        /// <summary>
        /// Returns true if TssV2TransactionsPost201ResponseEmbeddedPointOfSaleInformationPartner instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2TransactionsPost201ResponseEmbeddedPointOfSaleInformationPartner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2TransactionsPost201ResponseEmbeddedPointOfSaleInformationPartner other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OriginalTransactionId == other.OriginalTransactionId ||
                    this.OriginalTransactionId != null &&
                    this.OriginalTransactionId.Equals(other.OriginalTransactionId)
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
                if (this.OriginalTransactionId != null)
                    hash = hash * 59 + this.OriginalTransactionId.GetHashCode();
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
            // OriginalTransactionId (string) maxLength
            if(this.OriginalTransactionId != null && this.OriginalTransactionId.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OriginalTransactionId, length must be less than 50.", new [] { "OriginalTransactionId" });
            }

            yield break;
        }
    }

}
