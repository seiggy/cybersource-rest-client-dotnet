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
    /// Ptsv2paymentsidcapturesOrderInformation
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsidcapturesOrderInformation :  IEquatable<Ptsv2paymentsidcapturesOrderInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsidcapturesOrderInformation" /> class.
        /// </summary>
        /// <param name="AmountDetails">AmountDetails.</param>
        /// <param name="BillTo">BillTo.</param>
        /// <param name="ShipTo">ShipTo.</param>
        /// <param name="LineItems">LineItems.</param>
        /// <param name="InvoiceDetails">InvoiceDetails.</param>
        /// <param name="ShippingDetails">ShippingDetails.</param>
        public Ptsv2paymentsidcapturesOrderInformation(Ptsv2paymentsidcapturesOrderInformationAmountDetails AmountDetails = default(Ptsv2paymentsidcapturesOrderInformationAmountDetails), Ptsv2paymentsidcapturesOrderInformationBillTo BillTo = default(Ptsv2paymentsidcapturesOrderInformationBillTo), Ptsv2paymentsidcapturesOrderInformationShipTo ShipTo = default(Ptsv2paymentsidcapturesOrderInformationShipTo), List<Ptsv2paymentsOrderInformationLineItems> LineItems = default(List<Ptsv2paymentsOrderInformationLineItems>), Ptsv2paymentsidcapturesOrderInformationInvoiceDetails InvoiceDetails = default(Ptsv2paymentsidcapturesOrderInformationInvoiceDetails), Ptsv2paymentsidcapturesOrderInformationShippingDetails ShippingDetails = default(Ptsv2paymentsidcapturesOrderInformationShippingDetails))
        {
            this.AmountDetails = AmountDetails;
            this.BillTo = BillTo;
            this.ShipTo = ShipTo;
            this.LineItems = LineItems;
            this.InvoiceDetails = InvoiceDetails;
            this.ShippingDetails = ShippingDetails;
        }
        
        /// <summary>
        /// Gets or Sets AmountDetails
        /// </summary>
        [DataMember(Name="amountDetails", EmitDefaultValue=false)]
        public Ptsv2paymentsidcapturesOrderInformationAmountDetails AmountDetails { get; set; }

        /// <summary>
        /// Gets or Sets BillTo
        /// </summary>
        [DataMember(Name="billTo", EmitDefaultValue=false)]
        public Ptsv2paymentsidcapturesOrderInformationBillTo BillTo { get; set; }

        /// <summary>
        /// Gets or Sets ShipTo
        /// </summary>
        [DataMember(Name="shipTo", EmitDefaultValue=false)]
        public Ptsv2paymentsidcapturesOrderInformationShipTo ShipTo { get; set; }

        /// <summary>
        /// Gets or Sets LineItems
        /// </summary>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<Ptsv2paymentsOrderInformationLineItems> LineItems { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceDetails
        /// </summary>
        [DataMember(Name="invoiceDetails", EmitDefaultValue=false)]
        public Ptsv2paymentsidcapturesOrderInformationInvoiceDetails InvoiceDetails { get; set; }

        /// <summary>
        /// Gets or Sets ShippingDetails
        /// </summary>
        [DataMember(Name="shippingDetails", EmitDefaultValue=false)]
        public Ptsv2paymentsidcapturesOrderInformationShippingDetails ShippingDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsidcapturesOrderInformation {\n");
            sb.Append("  AmountDetails: ").Append(AmountDetails).Append("\n");
            sb.Append("  BillTo: ").Append(BillTo).Append("\n");
            sb.Append("  ShipTo: ").Append(ShipTo).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  InvoiceDetails: ").Append(InvoiceDetails).Append("\n");
            sb.Append("  ShippingDetails: ").Append(ShippingDetails).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsidcapturesOrderInformation);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsidcapturesOrderInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsidcapturesOrderInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsidcapturesOrderInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AmountDetails == other.AmountDetails ||
                    this.AmountDetails != null &&
                    this.AmountDetails.Equals(other.AmountDetails)
                ) && 
                (
                    this.BillTo == other.BillTo ||
                    this.BillTo != null &&
                    this.BillTo.Equals(other.BillTo)
                ) && 
                (
                    this.ShipTo == other.ShipTo ||
                    this.ShipTo != null &&
                    this.ShipTo.Equals(other.ShipTo)
                ) && 
                (
                    this.LineItems == other.LineItems ||
                    this.LineItems != null &&
                    this.LineItems.SequenceEqual(other.LineItems)
                ) && 
                (
                    this.InvoiceDetails == other.InvoiceDetails ||
                    this.InvoiceDetails != null &&
                    this.InvoiceDetails.Equals(other.InvoiceDetails)
                ) && 
                (
                    this.ShippingDetails == other.ShippingDetails ||
                    this.ShippingDetails != null &&
                    this.ShippingDetails.Equals(other.ShippingDetails)
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
                if (this.AmountDetails != null)
                    hash = hash * 59 + this.AmountDetails.GetHashCode();
                if (this.BillTo != null)
                    hash = hash * 59 + this.BillTo.GetHashCode();
                if (this.ShipTo != null)
                    hash = hash * 59 + this.ShipTo.GetHashCode();
                if (this.LineItems != null)
                    hash = hash * 59 + this.LineItems.GetHashCode();
                if (this.InvoiceDetails != null)
                    hash = hash * 59 + this.InvoiceDetails.GetHashCode();
                if (this.ShippingDetails != null)
                    hash = hash * 59 + this.ShippingDetails.GetHashCode();
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
