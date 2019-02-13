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
    /// PtsV2PaymentsPost201ResponseLinks
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsPost201ResponseLinks :  IEquatable<PtsV2PaymentsPost201ResponseLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsPost201ResponseLinks" /> class.
        /// </summary>
        /// <param name="Self">Self.</param>
        /// <param name="Reversal">Reversal.</param>
        /// <param name="Capture">Capture.</param>
        public PtsV2PaymentsPost201ResponseLinks(PtsV2PaymentsPost201ResponseLinksSelf Self = default(PtsV2PaymentsPost201ResponseLinksSelf), PtsV2PaymentsPost201ResponseLinksSelf Reversal = default(PtsV2PaymentsPost201ResponseLinksSelf), PtsV2PaymentsPost201ResponseLinksSelf Capture = default(PtsV2PaymentsPost201ResponseLinksSelf))
        {
            this.Self = Self;
            this.Reversal = Reversal;
            this.Capture = Capture;
        }
        
        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseLinksSelf Self { get; set; }

        /// <summary>
        /// Gets or Sets Reversal
        /// </summary>
        [DataMember(Name="reversal", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseLinksSelf Reversal { get; set; }

        /// <summary>
        /// Gets or Sets Capture
        /// </summary>
        [DataMember(Name="capture", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseLinksSelf Capture { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsPost201ResponseLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Reversal: ").Append(Reversal).Append("\n");
            sb.Append("  Capture: ").Append(Capture).Append("\n");
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
            return this.Equals(obj as PtsV2PaymentsPost201ResponseLinks);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsPost201ResponseLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsPost201ResponseLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsPost201ResponseLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Self == other.Self ||
                    this.Self != null &&
                    this.Self.Equals(other.Self)
                ) && 
                (
                    this.Reversal == other.Reversal ||
                    this.Reversal != null &&
                    this.Reversal.Equals(other.Reversal)
                ) && 
                (
                    this.Capture == other.Capture ||
                    this.Capture != null &&
                    this.Capture.Equals(other.Capture)
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
                if (this.Reversal != null)
                    hash = hash * 59 + this.Reversal.GetHashCode();
                if (this.Capture != null)
                    hash = hash * 59 + this.Capture.GetHashCode();
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
