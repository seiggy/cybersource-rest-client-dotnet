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
    /// Ptsv2paymentsAggregatorInformationSubMerchant
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsAggregatorInformationSubMerchant :  IEquatable<Ptsv2paymentsAggregatorInformationSubMerchant>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsAggregatorInformationSubMerchant" /> class.
        /// </summary>
        /// <param name="CardAcceptorId">Unique identifier assigned by the payment card company to the sub-merchant..</param>
        /// <param name="Name">Sub-merchant’s business name..</param>
        /// <param name="Address1">First line of the sub-merchant’s street address..</param>
        /// <param name="Locality">Sub-merchant’s city..</param>
        /// <param name="AdministrativeArea">Sub-merchant’s state or province. Use the State, Province, and Territory Codes for the United States and Canada. .</param>
        /// <param name="Region">Sub-merchant’s region. Example &#x60;NE&#x60; indicates that the sub-merchant is in the northeast region..</param>
        /// <param name="PostalCode">Partial postal code for the sub-merchant’s address..</param>
        /// <param name="Country">Sub-merchant’s country. Use the two-character ISO Standard Country Codes..</param>
        /// <param name="Email">Sub-merchant’s email address.  **Maximum length for processors**   - American Express Direct: 40  - CyberSource through VisaNet: 40  - FDC Compass: 40  - FDC Nashville Global: 19 .</param>
        /// <param name="PhoneNumber">Sub-merchant’s telephone number.  **Maximum length for procesors**   - American Express Direct: 20  - CyberSource through VisaNet: 20  - FDC Compass: 13  - FDC Nashville Global: 10 .</param>
        public Ptsv2paymentsAggregatorInformationSubMerchant(string CardAcceptorId = default(string), string Name = default(string), string Address1 = default(string), string Locality = default(string), string AdministrativeArea = default(string), string Region = default(string), string PostalCode = default(string), string Country = default(string), string Email = default(string), string PhoneNumber = default(string))
        {
            this.CardAcceptorId = CardAcceptorId;
            this.Name = Name;
            this.Address1 = Address1;
            this.Locality = Locality;
            this.AdministrativeArea = AdministrativeArea;
            this.Region = Region;
            this.PostalCode = PostalCode;
            this.Country = Country;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
        }
        
        /// <summary>
        /// Unique identifier assigned by the payment card company to the sub-merchant.
        /// </summary>
        /// <value>Unique identifier assigned by the payment card company to the sub-merchant.</value>
        [DataMember(Name="cardAcceptorId", EmitDefaultValue=false)]
        public string CardAcceptorId { get; set; }

        /// <summary>
        /// Sub-merchant’s business name.
        /// </summary>
        /// <value>Sub-merchant’s business name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// First line of the sub-merchant’s street address.
        /// </summary>
        /// <value>First line of the sub-merchant’s street address.</value>
        [DataMember(Name="address1", EmitDefaultValue=false)]
        public string Address1 { get; set; }

        /// <summary>
        /// Sub-merchant’s city.
        /// </summary>
        /// <value>Sub-merchant’s city.</value>
        [DataMember(Name="locality", EmitDefaultValue=false)]
        public string Locality { get; set; }

        /// <summary>
        /// Sub-merchant’s state or province. Use the State, Province, and Territory Codes for the United States and Canada. 
        /// </summary>
        /// <value>Sub-merchant’s state or province. Use the State, Province, and Territory Codes for the United States and Canada. </value>
        [DataMember(Name="administrativeArea", EmitDefaultValue=false)]
        public string AdministrativeArea { get; set; }

        /// <summary>
        /// Sub-merchant’s region. Example &#x60;NE&#x60; indicates that the sub-merchant is in the northeast region.
        /// </summary>
        /// <value>Sub-merchant’s region. Example &#x60;NE&#x60; indicates that the sub-merchant is in the northeast region.</value>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public string Region { get; set; }

        /// <summary>
        /// Partial postal code for the sub-merchant’s address.
        /// </summary>
        /// <value>Partial postal code for the sub-merchant’s address.</value>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Sub-merchant’s country. Use the two-character ISO Standard Country Codes.
        /// </summary>
        /// <value>Sub-merchant’s country. Use the two-character ISO Standard Country Codes.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Sub-merchant’s email address.  **Maximum length for processors**   - American Express Direct: 40  - CyberSource through VisaNet: 40  - FDC Compass: 40  - FDC Nashville Global: 19 
        /// </summary>
        /// <value>Sub-merchant’s email address.  **Maximum length for processors**   - American Express Direct: 40  - CyberSource through VisaNet: 40  - FDC Compass: 40  - FDC Nashville Global: 19 </value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Sub-merchant’s telephone number.  **Maximum length for procesors**   - American Express Direct: 20  - CyberSource through VisaNet: 20  - FDC Compass: 13  - FDC Nashville Global: 10 
        /// </summary>
        /// <value>Sub-merchant’s telephone number.  **Maximum length for procesors**   - American Express Direct: 20  - CyberSource through VisaNet: 20  - FDC Compass: 13  - FDC Nashville Global: 10 </value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsAggregatorInformationSubMerchant {\n");
            sb.Append("  CardAcceptorId: ").Append(CardAcceptorId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  AdministrativeArea: ").Append(AdministrativeArea).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsAggregatorInformationSubMerchant);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsAggregatorInformationSubMerchant instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsAggregatorInformationSubMerchant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsAggregatorInformationSubMerchant other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CardAcceptorId == other.CardAcceptorId ||
                    this.CardAcceptorId != null &&
                    this.CardAcceptorId.Equals(other.CardAcceptorId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Address1 == other.Address1 ||
                    this.Address1 != null &&
                    this.Address1.Equals(other.Address1)
                ) && 
                (
                    this.Locality == other.Locality ||
                    this.Locality != null &&
                    this.Locality.Equals(other.Locality)
                ) && 
                (
                    this.AdministrativeArea == other.AdministrativeArea ||
                    this.AdministrativeArea != null &&
                    this.AdministrativeArea.Equals(other.AdministrativeArea)
                ) && 
                (
                    this.Region == other.Region ||
                    this.Region != null &&
                    this.Region.Equals(other.Region)
                ) && 
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
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
                if (this.CardAcceptorId != null)
                    hash = hash * 59 + this.CardAcceptorId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Address1 != null)
                    hash = hash * 59 + this.Address1.GetHashCode();
                if (this.Locality != null)
                    hash = hash * 59 + this.Locality.GetHashCode();
                if (this.AdministrativeArea != null)
                    hash = hash * 59 + this.AdministrativeArea.GetHashCode();
                if (this.Region != null)
                    hash = hash * 59 + this.Region.GetHashCode();
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
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
            // CardAcceptorId (string) maxLength
            if(this.CardAcceptorId != null && this.CardAcceptorId.Length > 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CardAcceptorId, length must be less than 15.", new [] { "CardAcceptorId" });
            }

            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 37)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 37.", new [] { "Name" });
            }

            // Address1 (string) maxLength
            if(this.Address1 != null && this.Address1.Length > 38)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Address1, length must be less than 38.", new [] { "Address1" });
            }

            // Locality (string) maxLength
            if(this.Locality != null && this.Locality.Length > 21)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Locality, length must be less than 21.", new [] { "Locality" });
            }

            // AdministrativeArea (string) maxLength
            if(this.AdministrativeArea != null && this.AdministrativeArea.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AdministrativeArea, length must be less than 3.", new [] { "AdministrativeArea" });
            }

            // Region (string) maxLength
            if(this.Region != null && this.Region.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Region, length must be less than 3.", new [] { "Region" });
            }

            // PostalCode (string) maxLength
            if(this.PostalCode != null && this.PostalCode.Length > 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PostalCode, length must be less than 15.", new [] { "PostalCode" });
            }

            // Country (string) maxLength
            if(this.Country != null && this.Country.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Country, length must be less than 3.", new [] { "Country" });
            }

            // Email (string) maxLength
            if(this.Email != null && this.Email.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, length must be less than 40.", new [] { "Email" });
            }

            // PhoneNumber (string) maxLength
            if(this.PhoneNumber != null && this.PhoneNumber.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PhoneNumber, length must be less than 20.", new [] { "PhoneNumber" });
            }

            yield break;
        }
    }

}
