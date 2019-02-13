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
    /// PtsV2PaymentsReversalsPost201ResponseLinks
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsReversalsPost201ResponseLinks :  IEquatable<PtsV2PaymentsReversalsPost201ResponseLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsReversalsPost201ResponseLinks" /> class.
        /// </summary>
        /// <param name="Self">Self.</param>
        public PtsV2PaymentsReversalsPost201ResponseLinks(PtsV2PaymentsPost201ResponseLinksSelf Self = default(PtsV2PaymentsPost201ResponseLinksSelf))
        {
            this.Self = Self;
        }
        
        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseLinksSelf Self { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsReversalsPost201ResponseLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
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
            return this.Equals(obj as PtsV2PaymentsReversalsPost201ResponseLinks);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsReversalsPost201ResponseLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsReversalsPost201ResponseLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsReversalsPost201ResponseLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Self == other.Self ||
                    this.Self != null &&
                    this.Self.Equals(other.Self)
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
                if (this.Self != null)
                    hash = hash * 59 + this.Self.GetHashCode();
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
            yield break;
        }
    }

}
