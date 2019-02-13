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
    /// TssV2TransactionsGet200Response
    /// </summary>
    [DataContract]
    public partial class TssV2TransactionsGet200Response :  IEquatable<TssV2TransactionsGet200Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2TransactionsGet200Response" /> class.
        /// </summary>
        /// <param name="Id">An unique identification number assigned by CyberSource to identify the submitted request..</param>
        /// <param name="RootId">Payment Request Id.</param>
        /// <param name="ReconciliationId">The reconciliation id for the submitted transaction. This value is not returned for all processors. .</param>
        /// <param name="MerchantId">The description for this field is not available..</param>
        /// <param name="Status">The status of the submitted transaction..</param>
        /// <param name="SubmitTimeUtc">Time of request in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60;  Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC. .</param>
        /// <param name="ApplicationInformation">ApplicationInformation.</param>
        /// <param name="BuyerInformation">BuyerInformation.</param>
        /// <param name="ClientReferenceInformation">ClientReferenceInformation.</param>
        /// <param name="ConsumerAuthenticationInformation">ConsumerAuthenticationInformation.</param>
        /// <param name="DeviceInformation">DeviceInformation.</param>
        /// <param name="ErrorInformation">ErrorInformation.</param>
        /// <param name="InstallmentInformation">InstallmentInformation.</param>
        /// <param name="FraudMarkingInformation">FraudMarkingInformation.</param>
        /// <param name="MerchantDefinedInformation">The description for this field is not available..</param>
        /// <param name="MerchantInformation">MerchantInformation.</param>
        /// <param name="OrderInformation">OrderInformation.</param>
        /// <param name="PaymentInformation">PaymentInformation.</param>
        /// <param name="ProcessingInformation">ProcessingInformation.</param>
        /// <param name="ProcessorInformation">ProcessorInformation.</param>
        /// <param name="PointOfSaleInformation">PointOfSaleInformation.</param>
        /// <param name="RiskInformation">RiskInformation.</param>
        /// <param name="SenderInformation">SenderInformation.</param>
        /// <param name="Links">Links.</param>
        public TssV2TransactionsGet200Response(string Id = default(string), string RootId = default(string), string ReconciliationId = default(string), string MerchantId = default(string), string Status = default(string), string SubmitTimeUtc = default(string), TssV2TransactionsGet200ResponseApplicationInformation ApplicationInformation = default(TssV2TransactionsGet200ResponseApplicationInformation), TssV2TransactionsGet200ResponseBuyerInformation BuyerInformation = default(TssV2TransactionsGet200ResponseBuyerInformation), TssV2TransactionsGet200ResponseClientReferenceInformation ClientReferenceInformation = default(TssV2TransactionsGet200ResponseClientReferenceInformation), TssV2TransactionsGet200ResponseConsumerAuthenticationInformation ConsumerAuthenticationInformation = default(TssV2TransactionsGet200ResponseConsumerAuthenticationInformation), TssV2TransactionsGet200ResponseDeviceInformation DeviceInformation = default(TssV2TransactionsGet200ResponseDeviceInformation), TssV2TransactionsGet200ResponseErrorInformation ErrorInformation = default(TssV2TransactionsGet200ResponseErrorInformation), TssV2TransactionsGet200ResponseInstallmentInformation InstallmentInformation = default(TssV2TransactionsGet200ResponseInstallmentInformation), TssV2TransactionsGet200ResponseFraudMarkingInformation FraudMarkingInformation = default(TssV2TransactionsGet200ResponseFraudMarkingInformation), List<TssV2TransactionsGet200ResponseMerchantDefinedInformation> MerchantDefinedInformation = default(List<TssV2TransactionsGet200ResponseMerchantDefinedInformation>), TssV2TransactionsGet200ResponseMerchantInformation MerchantInformation = default(TssV2TransactionsGet200ResponseMerchantInformation), TssV2TransactionsGet200ResponseOrderInformation OrderInformation = default(TssV2TransactionsGet200ResponseOrderInformation), TssV2TransactionsGet200ResponsePaymentInformation PaymentInformation = default(TssV2TransactionsGet200ResponsePaymentInformation), TssV2TransactionsGet200ResponseProcessingInformation ProcessingInformation = default(TssV2TransactionsGet200ResponseProcessingInformation), TssV2TransactionsGet200ResponseProcessorInformation ProcessorInformation = default(TssV2TransactionsGet200ResponseProcessorInformation), TssV2TransactionsGet200ResponsePointOfSaleInformation PointOfSaleInformation = default(TssV2TransactionsGet200ResponsePointOfSaleInformation), TssV2TransactionsGet200ResponseRiskInformation RiskInformation = default(TssV2TransactionsGet200ResponseRiskInformation), TssV2TransactionsGet200ResponseSenderInformation SenderInformation = default(TssV2TransactionsGet200ResponseSenderInformation), PtsV2PaymentsReversalsPost201ResponseLinks Links = default(PtsV2PaymentsReversalsPost201ResponseLinks))
        {
            this.Id = Id;
            this.RootId = RootId;
            this.ReconciliationId = ReconciliationId;
            this.MerchantId = MerchantId;
            this.Status = Status;
            this.SubmitTimeUtc = SubmitTimeUtc;
            this.ApplicationInformation = ApplicationInformation;
            this.BuyerInformation = BuyerInformation;
            this.ClientReferenceInformation = ClientReferenceInformation;
            this.ConsumerAuthenticationInformation = ConsumerAuthenticationInformation;
            this.DeviceInformation = DeviceInformation;
            this.ErrorInformation = ErrorInformation;
            this.InstallmentInformation = InstallmentInformation;
            this.FraudMarkingInformation = FraudMarkingInformation;
            this.MerchantDefinedInformation = MerchantDefinedInformation;
            this.MerchantInformation = MerchantInformation;
            this.OrderInformation = OrderInformation;
            this.PaymentInformation = PaymentInformation;
            this.ProcessingInformation = ProcessingInformation;
            this.ProcessorInformation = ProcessorInformation;
            this.PointOfSaleInformation = PointOfSaleInformation;
            this.RiskInformation = RiskInformation;
            this.SenderInformation = SenderInformation;
            this.Links = Links;
        }
        
        /// <summary>
        /// An unique identification number assigned by CyberSource to identify the submitted request.
        /// </summary>
        /// <value>An unique identification number assigned by CyberSource to identify the submitted request.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Payment Request Id
        /// </summary>
        /// <value>Payment Request Id</value>
        [DataMember(Name="rootId", EmitDefaultValue=false)]
        public string RootId { get; set; }

        /// <summary>
        /// The reconciliation id for the submitted transaction. This value is not returned for all processors. 
        /// </summary>
        /// <value>The reconciliation id for the submitted transaction. This value is not returned for all processors. </value>
        [DataMember(Name="reconciliationId", EmitDefaultValue=false)]
        public string ReconciliationId { get; set; }

        /// <summary>
        /// The description for this field is not available.
        /// </summary>
        /// <value>The description for this field is not available.</value>
        [DataMember(Name="merchantId", EmitDefaultValue=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// The status of the submitted transaction.
        /// </summary>
        /// <value>The status of the submitted transaction.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Time of request in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60;  Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC. 
        /// </summary>
        /// <value>Time of request in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60;  Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC. </value>
        [DataMember(Name="submitTimeUtc", EmitDefaultValue=false)]
        public string SubmitTimeUtc { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationInformation
        /// </summary>
        [DataMember(Name="applicationInformation", EmitDefaultValue=false)]
        public TssV2TransactionsGet200ResponseApplicationInformation ApplicationInformation { get; set; }

        /// <summary>
        /// Gets or Sets BuyerInformation
        /// </summary>
        [DataMember(Name="buyerInformation", EmitDefaultValue=false)]
        public TssV2TransactionsGet200ResponseBuyerInformation BuyerInformation { get; set; }

        /// <summary>
        /// Gets or Sets ClientReferenceInformation
        /// </summary>
        [DataMember(Name="clientReferenceInformation", EmitDefaultValue=false)]
        public TssV2TransactionsGet200ResponseClientReferenceInformation ClientReferenceInformation { get; set; }

        /// <summary>
        /// Gets or Sets ConsumerAuthenticationInformation
        /// </summary>
        [DataMember(Name="consumerAuthenticationInformation", EmitDefaultValue=false)]
        public TssV2TransactionsGet200ResponseConsumerAuthenticationInformation ConsumerAuthenticationInformation { get; set; }

        /// <summary>
        /// Gets or Sets DeviceInformation
        /// </summary>
        [DataMember(Name="deviceInformation", EmitDefaultValue=false)]
        public TssV2TransactionsGet200ResponseDeviceInformation DeviceInformation { get; set; }

        /// <summary>
        /// Gets or Sets ErrorInformation
        /// </summary>
        [DataMember(Name="errorInformation", EmitDefaultValue=false)]
        public TssV2TransactionsGet200ResponseErrorInformation ErrorInformation { get; set; }

        /// <summary>
        /// Gets or Sets InstallmentInformation
        /// </summary>
        [DataMember(Name="installmentInformation", EmitDefaultValue=false)]
        public TssV2TransactionsGet200ResponseInstallmentInformation InstallmentInformation { get; set; }

        /// <summary>
        /// Gets or Sets FraudMarkingInformation
        /// </summary>
        [DataMember(Name="fraudMarkingInformation", EmitDefaultValue=false)]
        public TssV2TransactionsGet200ResponseFraudMarkingInformation FraudMarkingInformation { get; set; }

        /// <summary>
        /// The description for this field is not available.
        /// </summary>
        /// <value>The description for this field is not available.</value>
        [DataMember(Name="merchantDefinedInformation", EmitDefaultValue=false)]
        public List<TssV2TransactionsGet200ResponseMerchantDefinedInformation> MerchantDefinedInformation { get; set; }

        /// <summary>
        /// Gets or Sets MerchantInformation
        /// </summary>
        [DataMember(Name="merchantInformation", EmitDefaultValue=false)]
        public TssV2TransactionsGet200ResponseMerchantInformation MerchantInformation { get; set; }

        /// <summary>
        /// Gets or Sets OrderInformation
        /// </summary>
        [DataMember(Name="orderInformation", EmitDefaultValue=false)]
        public TssV2TransactionsGet200ResponseOrderInformation OrderInformation { get; set; }

        /// <summary>
        /// Gets or Sets PaymentInformation
        /// </summary>
        [DataMember(Name="paymentInformation", EmitDefaultValue=false)]
        public TssV2TransactionsGet200ResponsePaymentInformation PaymentInformation { get; set; }

        /// <summary>
        /// Gets or Sets ProcessingInformation
        /// </summary>
        [DataMember(Name="processingInformation", EmitDefaultValue=false)]
        public TssV2TransactionsGet200ResponseProcessingInformation ProcessingInformation { get; set; }

        /// <summary>
        /// Gets or Sets ProcessorInformation
        /// </summary>
        [DataMember(Name="processorInformation", EmitDefaultValue=false)]
        public TssV2TransactionsGet200ResponseProcessorInformation ProcessorInformation { get; set; }

        /// <summary>
        /// Gets or Sets PointOfSaleInformation
        /// </summary>
        [DataMember(Name="pointOfSaleInformation", EmitDefaultValue=false)]
        public TssV2TransactionsGet200ResponsePointOfSaleInformation PointOfSaleInformation { get; set; }

        /// <summary>
        /// Gets or Sets RiskInformation
        /// </summary>
        [DataMember(Name="riskInformation", EmitDefaultValue=false)]
        public TssV2TransactionsGet200ResponseRiskInformation RiskInformation { get; set; }

        /// <summary>
        /// Gets or Sets SenderInformation
        /// </summary>
        [DataMember(Name="senderInformation", EmitDefaultValue=false)]
        public TssV2TransactionsGet200ResponseSenderInformation SenderInformation { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public PtsV2PaymentsReversalsPost201ResponseLinks Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2TransactionsGet200Response {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RootId: ").Append(RootId).Append("\n");
            sb.Append("  ReconciliationId: ").Append(ReconciliationId).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SubmitTimeUtc: ").Append(SubmitTimeUtc).Append("\n");
            sb.Append("  ApplicationInformation: ").Append(ApplicationInformation).Append("\n");
            sb.Append("  BuyerInformation: ").Append(BuyerInformation).Append("\n");
            sb.Append("  ClientReferenceInformation: ").Append(ClientReferenceInformation).Append("\n");
            sb.Append("  ConsumerAuthenticationInformation: ").Append(ConsumerAuthenticationInformation).Append("\n");
            sb.Append("  DeviceInformation: ").Append(DeviceInformation).Append("\n");
            sb.Append("  ErrorInformation: ").Append(ErrorInformation).Append("\n");
            sb.Append("  InstallmentInformation: ").Append(InstallmentInformation).Append("\n");
            sb.Append("  FraudMarkingInformation: ").Append(FraudMarkingInformation).Append("\n");
            sb.Append("  MerchantDefinedInformation: ").Append(MerchantDefinedInformation).Append("\n");
            sb.Append("  MerchantInformation: ").Append(MerchantInformation).Append("\n");
            sb.Append("  OrderInformation: ").Append(OrderInformation).Append("\n");
            sb.Append("  PaymentInformation: ").Append(PaymentInformation).Append("\n");
            sb.Append("  ProcessingInformation: ").Append(ProcessingInformation).Append("\n");
            sb.Append("  ProcessorInformation: ").Append(ProcessorInformation).Append("\n");
            sb.Append("  PointOfSaleInformation: ").Append(PointOfSaleInformation).Append("\n");
            sb.Append("  RiskInformation: ").Append(RiskInformation).Append("\n");
            sb.Append("  SenderInformation: ").Append(SenderInformation).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(obj as TssV2TransactionsGet200Response);
        }

        /// <summary>
        /// Returns true if TssV2TransactionsGet200Response instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2TransactionsGet200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2TransactionsGet200Response other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.RootId == other.RootId ||
                    this.RootId != null &&
                    this.RootId.Equals(other.RootId)
                ) && 
                (
                    this.ReconciliationId == other.ReconciliationId ||
                    this.ReconciliationId != null &&
                    this.ReconciliationId.Equals(other.ReconciliationId)
                ) && 
                (
                    this.MerchantId == other.MerchantId ||
                    this.MerchantId != null &&
                    this.MerchantId.Equals(other.MerchantId)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.SubmitTimeUtc == other.SubmitTimeUtc ||
                    this.SubmitTimeUtc != null &&
                    this.SubmitTimeUtc.Equals(other.SubmitTimeUtc)
                ) && 
                (
                    this.ApplicationInformation == other.ApplicationInformation ||
                    this.ApplicationInformation != null &&
                    this.ApplicationInformation.Equals(other.ApplicationInformation)
                ) && 
                (
                    this.BuyerInformation == other.BuyerInformation ||
                    this.BuyerInformation != null &&
                    this.BuyerInformation.Equals(other.BuyerInformation)
                ) && 
                (
                    this.ClientReferenceInformation == other.ClientReferenceInformation ||
                    this.ClientReferenceInformation != null &&
                    this.ClientReferenceInformation.Equals(other.ClientReferenceInformation)
                ) && 
                (
                    this.ConsumerAuthenticationInformation == other.ConsumerAuthenticationInformation ||
                    this.ConsumerAuthenticationInformation != null &&
                    this.ConsumerAuthenticationInformation.Equals(other.ConsumerAuthenticationInformation)
                ) && 
                (
                    this.DeviceInformation == other.DeviceInformation ||
                    this.DeviceInformation != null &&
                    this.DeviceInformation.Equals(other.DeviceInformation)
                ) && 
                (
                    this.ErrorInformation == other.ErrorInformation ||
                    this.ErrorInformation != null &&
                    this.ErrorInformation.Equals(other.ErrorInformation)
                ) && 
                (
                    this.InstallmentInformation == other.InstallmentInformation ||
                    this.InstallmentInformation != null &&
                    this.InstallmentInformation.Equals(other.InstallmentInformation)
                ) && 
                (
                    this.FraudMarkingInformation == other.FraudMarkingInformation ||
                    this.FraudMarkingInformation != null &&
                    this.FraudMarkingInformation.Equals(other.FraudMarkingInformation)
                ) && 
                (
                    this.MerchantDefinedInformation == other.MerchantDefinedInformation ||
                    this.MerchantDefinedInformation != null &&
                    this.MerchantDefinedInformation.SequenceEqual(other.MerchantDefinedInformation)
                ) && 
                (
                    this.MerchantInformation == other.MerchantInformation ||
                    this.MerchantInformation != null &&
                    this.MerchantInformation.Equals(other.MerchantInformation)
                ) && 
                (
                    this.OrderInformation == other.OrderInformation ||
                    this.OrderInformation != null &&
                    this.OrderInformation.Equals(other.OrderInformation)
                ) && 
                (
                    this.PaymentInformation == other.PaymentInformation ||
                    this.PaymentInformation != null &&
                    this.PaymentInformation.Equals(other.PaymentInformation)
                ) && 
                (
                    this.ProcessingInformation == other.ProcessingInformation ||
                    this.ProcessingInformation != null &&
                    this.ProcessingInformation.Equals(other.ProcessingInformation)
                ) && 
                (
                    this.ProcessorInformation == other.ProcessorInformation ||
                    this.ProcessorInformation != null &&
                    this.ProcessorInformation.Equals(other.ProcessorInformation)
                ) && 
                (
                    this.PointOfSaleInformation == other.PointOfSaleInformation ||
                    this.PointOfSaleInformation != null &&
                    this.PointOfSaleInformation.Equals(other.PointOfSaleInformation)
                ) && 
                (
                    this.RiskInformation == other.RiskInformation ||
                    this.RiskInformation != null &&
                    this.RiskInformation.Equals(other.RiskInformation)
                ) && 
                (
                    this.SenderInformation == other.SenderInformation ||
                    this.SenderInformation != null &&
                    this.SenderInformation.Equals(other.SenderInformation)
                ) && 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.RootId != null)
                    hash = hash * 59 + this.RootId.GetHashCode();
                if (this.ReconciliationId != null)
                    hash = hash * 59 + this.ReconciliationId.GetHashCode();
                if (this.MerchantId != null)
                    hash = hash * 59 + this.MerchantId.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.SubmitTimeUtc != null)
                    hash = hash * 59 + this.SubmitTimeUtc.GetHashCode();
                if (this.ApplicationInformation != null)
                    hash = hash * 59 + this.ApplicationInformation.GetHashCode();
                if (this.BuyerInformation != null)
                    hash = hash * 59 + this.BuyerInformation.GetHashCode();
                if (this.ClientReferenceInformation != null)
                    hash = hash * 59 + this.ClientReferenceInformation.GetHashCode();
                if (this.ConsumerAuthenticationInformation != null)
                    hash = hash * 59 + this.ConsumerAuthenticationInformation.GetHashCode();
                if (this.DeviceInformation != null)
                    hash = hash * 59 + this.DeviceInformation.GetHashCode();
                if (this.ErrorInformation != null)
                    hash = hash * 59 + this.ErrorInformation.GetHashCode();
                if (this.InstallmentInformation != null)
                    hash = hash * 59 + this.InstallmentInformation.GetHashCode();
                if (this.FraudMarkingInformation != null)
                    hash = hash * 59 + this.FraudMarkingInformation.GetHashCode();
                if (this.MerchantDefinedInformation != null)
                    hash = hash * 59 + this.MerchantDefinedInformation.GetHashCode();
                if (this.MerchantInformation != null)
                    hash = hash * 59 + this.MerchantInformation.GetHashCode();
                if (this.OrderInformation != null)
                    hash = hash * 59 + this.OrderInformation.GetHashCode();
                if (this.PaymentInformation != null)
                    hash = hash * 59 + this.PaymentInformation.GetHashCode();
                if (this.ProcessingInformation != null)
                    hash = hash * 59 + this.ProcessingInformation.GetHashCode();
                if (this.ProcessorInformation != null)
                    hash = hash * 59 + this.ProcessorInformation.GetHashCode();
                if (this.PointOfSaleInformation != null)
                    hash = hash * 59 + this.PointOfSaleInformation.GetHashCode();
                if (this.RiskInformation != null)
                    hash = hash * 59 + this.RiskInformation.GetHashCode();
                if (this.SenderInformation != null)
                    hash = hash * 59 + this.SenderInformation.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
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
            // Id (string) maxLength
            if(this.Id != null && this.Id.Length > 26)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be less than 26.", new [] { "Id" });
            }

            // RootId (string) maxLength
            if(this.RootId != null && this.RootId.Length > 26)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RootId, length must be less than 26.", new [] { "RootId" });
            }

            // ReconciliationId (string) maxLength
            if(this.ReconciliationId != null && this.ReconciliationId.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReconciliationId, length must be less than 60.", new [] { "ReconciliationId" });
            }

            yield break;
        }
    }

}
