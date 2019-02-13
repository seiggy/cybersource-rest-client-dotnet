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
    /// Ptsv2paymentsOrderInformationAmountDetails
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsOrderInformationAmountDetails :  IEquatable<Ptsv2paymentsOrderInformationAmountDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsOrderInformationAmountDetails" /> class.
        /// </summary>
        /// <param name="TotalAmount">Grand total for the order. You can include a decimal point (.), but no other special characters. CyberSource truncates the amount to the correct number of decimal places.  * CTV, FDCCompass, Paymentech (&lt;&#x3D; 12)  For processor-specific information, see the grand_total_amount field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) .</param>
        /// <param name="Currency">Currency used for the order. Use the three-character ISO Standard Currency Codes.  For an authorization reversal or a capture, you must use the same currency that you used in your request for Payment API. .</param>
        /// <param name="DiscountAmount">Total discount amount applied to the order.  For processor-specific information, see the order_discount_amount field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) .</param>
        /// <param name="DutyAmount">Total charges for any import or export duties included in the order.  For processor-specific information, see the duty_amount field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) .</param>
        /// <param name="TaxAmount">Total tax amount for all the items in the order.  For processor-specific information, see the total_tax_amount field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) .</param>
        /// <param name="NationalTaxIncluded">Flag that indicates whether a national tax is included in the order total.  Possible values:   - **0**: national tax not included  - **1**: national tax included  For processor-specific information, see the national_tax_indicator field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) .</param>
        /// <param name="TaxAppliedAfterDiscount">Flag that indicates how the merchant manages discounts.  Possible values:   - **0**: no invoice level discount included  - **1**: tax calculated on the postdiscount invoice total  - **2**: tax calculated on the prediscount invoice total  For processor-specific information, see the order_discount_management_indicator field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) .</param>
        /// <param name="TaxAppliedLevel">Flag that indicates how you calculate tax.  Possible values:   - **0**: net prices with tax calculated at line item level  - **1**: net prices with tax calculated at invoice level  - **2**: gross prices with tax provided at line item level  - **3**: gross prices with tax provided at invoice level  - **4**: no tax applies on the invoice for the transaction  For processor-specific information, see the tax_management_indicator field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) .</param>
        /// <param name="TaxTypeCode">For tax amounts that can be categorized as one tax type.  This field contains the tax type code that corresponds to the entry in the _lineItems.taxAmount_ field.  Possible values:   - **056**: sales tax (U.S only)  - **TX~**: all taxes (Canada only)   Note ~ &#x3D; space.  For processor-specific information, see the total_tax_type_code field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) .</param>
        /// <param name="FreightAmount">Total freight or shipping and handling charges for the order. When you include this field in your request, you must also include the **totalAmount** field.  For processor-specific information, see the freight_amount field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) .</param>
        /// <param name="ForeignAmount">Converted amount returned by the DCC service.  For processor-specific information, see the foreign_amount field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) .</param>
        /// <param name="ForeignCurrency">Billing currency returned by the DCC service.  For processor-specific information, see the foreign_currency field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) .</param>
        /// <param name="ExchangeRate">Exchange rate returned by the DCC service. Includes a decimal point and a maximum of 4 decimal places.  For processor-specific information, see the exchange_rate field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) .</param>
        /// <param name="ExchangeRateTimeStamp">Time stamp for the exchange rate. This value is returned by the DCC service.  Format: &#x60;YYYYMMDD~HH:MM&#x60;  where ~ denotes a space.  For processor-specific information, see the exchange_rate_timestamp field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) .</param>
        /// <param name="Surcharge">Surcharge.</param>
        /// <param name="SettlementAmount">This is a multicurrency field. It contains the transaction amount (field 4), converted to the Currency used to bill the cardholder’s account. .</param>
        /// <param name="SettlementCurrency">This is a multicurrency-only field. It contains a 3-digit numeric code that identifies the currency used by the issuer to bill the cardholder&#39;s account. .</param>
        /// <param name="AmexAdditionalAmounts">AmexAdditionalAmounts.</param>
        /// <param name="TaxDetails">TaxDetails.</param>
        public Ptsv2paymentsOrderInformationAmountDetails(string TotalAmount = default(string), string Currency = default(string), string DiscountAmount = default(string), string DutyAmount = default(string), string TaxAmount = default(string), string NationalTaxIncluded = default(string), string TaxAppliedAfterDiscount = default(string), string TaxAppliedLevel = default(string), string TaxTypeCode = default(string), string FreightAmount = default(string), string ForeignAmount = default(string), string ForeignCurrency = default(string), string ExchangeRate = default(string), string ExchangeRateTimeStamp = default(string), Ptsv2paymentsOrderInformationAmountDetailsSurcharge Surcharge = default(Ptsv2paymentsOrderInformationAmountDetailsSurcharge), string SettlementAmount = default(string), string SettlementCurrency = default(string), List<Ptsv2paymentsOrderInformationAmountDetailsAmexAdditionalAmounts> AmexAdditionalAmounts = default(List<Ptsv2paymentsOrderInformationAmountDetailsAmexAdditionalAmounts>), List<Ptsv2paymentsOrderInformationAmountDetailsTaxDetails> TaxDetails = default(List<Ptsv2paymentsOrderInformationAmountDetailsTaxDetails>))
        {
            this.TotalAmount = TotalAmount;
            this.Currency = Currency;
            this.DiscountAmount = DiscountAmount;
            this.DutyAmount = DutyAmount;
            this.TaxAmount = TaxAmount;
            this.NationalTaxIncluded = NationalTaxIncluded;
            this.TaxAppliedAfterDiscount = TaxAppliedAfterDiscount;
            this.TaxAppliedLevel = TaxAppliedLevel;
            this.TaxTypeCode = TaxTypeCode;
            this.FreightAmount = FreightAmount;
            this.ForeignAmount = ForeignAmount;
            this.ForeignCurrency = ForeignCurrency;
            this.ExchangeRate = ExchangeRate;
            this.ExchangeRateTimeStamp = ExchangeRateTimeStamp;
            this.Surcharge = Surcharge;
            this.SettlementAmount = SettlementAmount;
            this.SettlementCurrency = SettlementCurrency;
            this.AmexAdditionalAmounts = AmexAdditionalAmounts;
            this.TaxDetails = TaxDetails;
        }
        
        /// <summary>
        /// Grand total for the order. You can include a decimal point (.), but no other special characters. CyberSource truncates the amount to the correct number of decimal places.  * CTV, FDCCompass, Paymentech (&lt;&#x3D; 12)  For processor-specific information, see the grand_total_amount field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) 
        /// </summary>
        /// <value>Grand total for the order. You can include a decimal point (.), but no other special characters. CyberSource truncates the amount to the correct number of decimal places.  * CTV, FDCCompass, Paymentech (&lt;&#x3D; 12)  For processor-specific information, see the grand_total_amount field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) </value>
        [DataMember(Name="totalAmount", EmitDefaultValue=false)]
        public string TotalAmount { get; set; }

        /// <summary>
        /// Currency used for the order. Use the three-character ISO Standard Currency Codes.  For an authorization reversal or a capture, you must use the same currency that you used in your request for Payment API. 
        /// </summary>
        /// <value>Currency used for the order. Use the three-character ISO Standard Currency Codes.  For an authorization reversal or a capture, you must use the same currency that you used in your request for Payment API. </value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Total discount amount applied to the order.  For processor-specific information, see the order_discount_amount field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) 
        /// </summary>
        /// <value>Total discount amount applied to the order.  For processor-specific information, see the order_discount_amount field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) </value>
        [DataMember(Name="discountAmount", EmitDefaultValue=false)]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// Total charges for any import or export duties included in the order.  For processor-specific information, see the duty_amount field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) 
        /// </summary>
        /// <value>Total charges for any import or export duties included in the order.  For processor-specific information, see the duty_amount field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) </value>
        [DataMember(Name="dutyAmount", EmitDefaultValue=false)]
        public string DutyAmount { get; set; }

        /// <summary>
        /// Total tax amount for all the items in the order.  For processor-specific information, see the total_tax_amount field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) 
        /// </summary>
        /// <value>Total tax amount for all the items in the order.  For processor-specific information, see the total_tax_amount field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) </value>
        [DataMember(Name="taxAmount", EmitDefaultValue=false)]
        public string TaxAmount { get; set; }

        /// <summary>
        /// Flag that indicates whether a national tax is included in the order total.  Possible values:   - **0**: national tax not included  - **1**: national tax included  For processor-specific information, see the national_tax_indicator field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) 
        /// </summary>
        /// <value>Flag that indicates whether a national tax is included in the order total.  Possible values:   - **0**: national tax not included  - **1**: national tax included  For processor-specific information, see the national_tax_indicator field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) </value>
        [DataMember(Name="nationalTaxIncluded", EmitDefaultValue=false)]
        public string NationalTaxIncluded { get; set; }

        /// <summary>
        /// Flag that indicates how the merchant manages discounts.  Possible values:   - **0**: no invoice level discount included  - **1**: tax calculated on the postdiscount invoice total  - **2**: tax calculated on the prediscount invoice total  For processor-specific information, see the order_discount_management_indicator field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) 
        /// </summary>
        /// <value>Flag that indicates how the merchant manages discounts.  Possible values:   - **0**: no invoice level discount included  - **1**: tax calculated on the postdiscount invoice total  - **2**: tax calculated on the prediscount invoice total  For processor-specific information, see the order_discount_management_indicator field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) </value>
        [DataMember(Name="taxAppliedAfterDiscount", EmitDefaultValue=false)]
        public string TaxAppliedAfterDiscount { get; set; }

        /// <summary>
        /// Flag that indicates how you calculate tax.  Possible values:   - **0**: net prices with tax calculated at line item level  - **1**: net prices with tax calculated at invoice level  - **2**: gross prices with tax provided at line item level  - **3**: gross prices with tax provided at invoice level  - **4**: no tax applies on the invoice for the transaction  For processor-specific information, see the tax_management_indicator field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) 
        /// </summary>
        /// <value>Flag that indicates how you calculate tax.  Possible values:   - **0**: net prices with tax calculated at line item level  - **1**: net prices with tax calculated at invoice level  - **2**: gross prices with tax provided at line item level  - **3**: gross prices with tax provided at invoice level  - **4**: no tax applies on the invoice for the transaction  For processor-specific information, see the tax_management_indicator field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) </value>
        [DataMember(Name="taxAppliedLevel", EmitDefaultValue=false)]
        public string TaxAppliedLevel { get; set; }

        /// <summary>
        /// For tax amounts that can be categorized as one tax type.  This field contains the tax type code that corresponds to the entry in the _lineItems.taxAmount_ field.  Possible values:   - **056**: sales tax (U.S only)  - **TX~**: all taxes (Canada only)   Note ~ &#x3D; space.  For processor-specific information, see the total_tax_type_code field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) 
        /// </summary>
        /// <value>For tax amounts that can be categorized as one tax type.  This field contains the tax type code that corresponds to the entry in the _lineItems.taxAmount_ field.  Possible values:   - **056**: sales tax (U.S only)  - **TX~**: all taxes (Canada only)   Note ~ &#x3D; space.  For processor-specific information, see the total_tax_type_code field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) </value>
        [DataMember(Name="taxTypeCode", EmitDefaultValue=false)]
        public string TaxTypeCode { get; set; }

        /// <summary>
        /// Total freight or shipping and handling charges for the order. When you include this field in your request, you must also include the **totalAmount** field.  For processor-specific information, see the freight_amount field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) 
        /// </summary>
        /// <value>Total freight or shipping and handling charges for the order. When you include this field in your request, you must also include the **totalAmount** field.  For processor-specific information, see the freight_amount field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) </value>
        [DataMember(Name="freightAmount", EmitDefaultValue=false)]
        public string FreightAmount { get; set; }

        /// <summary>
        /// Converted amount returned by the DCC service.  For processor-specific information, see the foreign_amount field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) 
        /// </summary>
        /// <value>Converted amount returned by the DCC service.  For processor-specific information, see the foreign_amount field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) </value>
        [DataMember(Name="foreignAmount", EmitDefaultValue=false)]
        public string ForeignAmount { get; set; }

        /// <summary>
        /// Billing currency returned by the DCC service.  For processor-specific information, see the foreign_currency field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) 
        /// </summary>
        /// <value>Billing currency returned by the DCC service.  For processor-specific information, see the foreign_currency field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) </value>
        [DataMember(Name="foreignCurrency", EmitDefaultValue=false)]
        public string ForeignCurrency { get; set; }

        /// <summary>
        /// Exchange rate returned by the DCC service. Includes a decimal point and a maximum of 4 decimal places.  For processor-specific information, see the exchange_rate field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) 
        /// </summary>
        /// <value>Exchange rate returned by the DCC service. Includes a decimal point and a maximum of 4 decimal places.  For processor-specific information, see the exchange_rate field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) </value>
        [DataMember(Name="exchangeRate", EmitDefaultValue=false)]
        public string ExchangeRate { get; set; }

        /// <summary>
        /// Time stamp for the exchange rate. This value is returned by the DCC service.  Format: &#x60;YYYYMMDD~HH:MM&#x60;  where ~ denotes a space.  For processor-specific information, see the exchange_rate_timestamp field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) 
        /// </summary>
        /// <value>Time stamp for the exchange rate. This value is returned by the DCC service.  Format: &#x60;YYYYMMDD~HH:MM&#x60;  where ~ denotes a space.  For processor-specific information, see the exchange_rate_timestamp field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) </value>
        [DataMember(Name="exchangeRateTimeStamp", EmitDefaultValue=false)]
        public string ExchangeRateTimeStamp { get; set; }

        /// <summary>
        /// Gets or Sets Surcharge
        /// </summary>
        [DataMember(Name="surcharge", EmitDefaultValue=false)]
        public Ptsv2paymentsOrderInformationAmountDetailsSurcharge Surcharge { get; set; }

        /// <summary>
        /// This is a multicurrency field. It contains the transaction amount (field 4), converted to the Currency used to bill the cardholder’s account. 
        /// </summary>
        /// <value>This is a multicurrency field. It contains the transaction amount (field 4), converted to the Currency used to bill the cardholder’s account. </value>
        [DataMember(Name="settlementAmount", EmitDefaultValue=false)]
        public string SettlementAmount { get; set; }

        /// <summary>
        /// This is a multicurrency-only field. It contains a 3-digit numeric code that identifies the currency used by the issuer to bill the cardholder&#39;s account. 
        /// </summary>
        /// <value>This is a multicurrency-only field. It contains a 3-digit numeric code that identifies the currency used by the issuer to bill the cardholder&#39;s account. </value>
        [DataMember(Name="settlementCurrency", EmitDefaultValue=false)]
        public string SettlementCurrency { get; set; }

        /// <summary>
        /// Gets or Sets AmexAdditionalAmounts
        /// </summary>
        [DataMember(Name="amexAdditionalAmounts", EmitDefaultValue=false)]
        public List<Ptsv2paymentsOrderInformationAmountDetailsAmexAdditionalAmounts> AmexAdditionalAmounts { get; set; }

        /// <summary>
        /// Gets or Sets TaxDetails
        /// </summary>
        [DataMember(Name="taxDetails", EmitDefaultValue=false)]
        public List<Ptsv2paymentsOrderInformationAmountDetailsTaxDetails> TaxDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsOrderInformationAmountDetails {\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  DutyAmount: ").Append(DutyAmount).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  NationalTaxIncluded: ").Append(NationalTaxIncluded).Append("\n");
            sb.Append("  TaxAppliedAfterDiscount: ").Append(TaxAppliedAfterDiscount).Append("\n");
            sb.Append("  TaxAppliedLevel: ").Append(TaxAppliedLevel).Append("\n");
            sb.Append("  TaxTypeCode: ").Append(TaxTypeCode).Append("\n");
            sb.Append("  FreightAmount: ").Append(FreightAmount).Append("\n");
            sb.Append("  ForeignAmount: ").Append(ForeignAmount).Append("\n");
            sb.Append("  ForeignCurrency: ").Append(ForeignCurrency).Append("\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
            sb.Append("  ExchangeRateTimeStamp: ").Append(ExchangeRateTimeStamp).Append("\n");
            sb.Append("  Surcharge: ").Append(Surcharge).Append("\n");
            sb.Append("  SettlementAmount: ").Append(SettlementAmount).Append("\n");
            sb.Append("  SettlementCurrency: ").Append(SettlementCurrency).Append("\n");
            sb.Append("  AmexAdditionalAmounts: ").Append(AmexAdditionalAmounts).Append("\n");
            sb.Append("  TaxDetails: ").Append(TaxDetails).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsOrderInformationAmountDetails);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsOrderInformationAmountDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsOrderInformationAmountDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsOrderInformationAmountDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TotalAmount == other.TotalAmount ||
                    this.TotalAmount != null &&
                    this.TotalAmount.Equals(other.TotalAmount)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.DiscountAmount == other.DiscountAmount ||
                    this.DiscountAmount != null &&
                    this.DiscountAmount.Equals(other.DiscountAmount)
                ) && 
                (
                    this.DutyAmount == other.DutyAmount ||
                    this.DutyAmount != null &&
                    this.DutyAmount.Equals(other.DutyAmount)
                ) && 
                (
                    this.TaxAmount == other.TaxAmount ||
                    this.TaxAmount != null &&
                    this.TaxAmount.Equals(other.TaxAmount)
                ) && 
                (
                    this.NationalTaxIncluded == other.NationalTaxIncluded ||
                    this.NationalTaxIncluded != null &&
                    this.NationalTaxIncluded.Equals(other.NationalTaxIncluded)
                ) && 
                (
                    this.TaxAppliedAfterDiscount == other.TaxAppliedAfterDiscount ||
                    this.TaxAppliedAfterDiscount != null &&
                    this.TaxAppliedAfterDiscount.Equals(other.TaxAppliedAfterDiscount)
                ) && 
                (
                    this.TaxAppliedLevel == other.TaxAppliedLevel ||
                    this.TaxAppliedLevel != null &&
                    this.TaxAppliedLevel.Equals(other.TaxAppliedLevel)
                ) && 
                (
                    this.TaxTypeCode == other.TaxTypeCode ||
                    this.TaxTypeCode != null &&
                    this.TaxTypeCode.Equals(other.TaxTypeCode)
                ) && 
                (
                    this.FreightAmount == other.FreightAmount ||
                    this.FreightAmount != null &&
                    this.FreightAmount.Equals(other.FreightAmount)
                ) && 
                (
                    this.ForeignAmount == other.ForeignAmount ||
                    this.ForeignAmount != null &&
                    this.ForeignAmount.Equals(other.ForeignAmount)
                ) && 
                (
                    this.ForeignCurrency == other.ForeignCurrency ||
                    this.ForeignCurrency != null &&
                    this.ForeignCurrency.Equals(other.ForeignCurrency)
                ) && 
                (
                    this.ExchangeRate == other.ExchangeRate ||
                    this.ExchangeRate != null &&
                    this.ExchangeRate.Equals(other.ExchangeRate)
                ) && 
                (
                    this.ExchangeRateTimeStamp == other.ExchangeRateTimeStamp ||
                    this.ExchangeRateTimeStamp != null &&
                    this.ExchangeRateTimeStamp.Equals(other.ExchangeRateTimeStamp)
                ) && 
                (
                    this.Surcharge == other.Surcharge ||
                    this.Surcharge != null &&
                    this.Surcharge.Equals(other.Surcharge)
                ) && 
                (
                    this.SettlementAmount == other.SettlementAmount ||
                    this.SettlementAmount != null &&
                    this.SettlementAmount.Equals(other.SettlementAmount)
                ) && 
                (
                    this.SettlementCurrency == other.SettlementCurrency ||
                    this.SettlementCurrency != null &&
                    this.SettlementCurrency.Equals(other.SettlementCurrency)
                ) && 
                (
                    this.AmexAdditionalAmounts == other.AmexAdditionalAmounts ||
                    this.AmexAdditionalAmounts != null &&
                    this.AmexAdditionalAmounts.SequenceEqual(other.AmexAdditionalAmounts)
                ) && 
                (
                    this.TaxDetails == other.TaxDetails ||
                    this.TaxDetails != null &&
                    this.TaxDetails.SequenceEqual(other.TaxDetails)
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
                if (this.TotalAmount != null)
                    hash = hash * 59 + this.TotalAmount.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.DiscountAmount != null)
                    hash = hash * 59 + this.DiscountAmount.GetHashCode();
                if (this.DutyAmount != null)
                    hash = hash * 59 + this.DutyAmount.GetHashCode();
                if (this.TaxAmount != null)
                    hash = hash * 59 + this.TaxAmount.GetHashCode();
                if (this.NationalTaxIncluded != null)
                    hash = hash * 59 + this.NationalTaxIncluded.GetHashCode();
                if (this.TaxAppliedAfterDiscount != null)
                    hash = hash * 59 + this.TaxAppliedAfterDiscount.GetHashCode();
                if (this.TaxAppliedLevel != null)
                    hash = hash * 59 + this.TaxAppliedLevel.GetHashCode();
                if (this.TaxTypeCode != null)
                    hash = hash * 59 + this.TaxTypeCode.GetHashCode();
                if (this.FreightAmount != null)
                    hash = hash * 59 + this.FreightAmount.GetHashCode();
                if (this.ForeignAmount != null)
                    hash = hash * 59 + this.ForeignAmount.GetHashCode();
                if (this.ForeignCurrency != null)
                    hash = hash * 59 + this.ForeignCurrency.GetHashCode();
                if (this.ExchangeRate != null)
                    hash = hash * 59 + this.ExchangeRate.GetHashCode();
                if (this.ExchangeRateTimeStamp != null)
                    hash = hash * 59 + this.ExchangeRateTimeStamp.GetHashCode();
                if (this.Surcharge != null)
                    hash = hash * 59 + this.Surcharge.GetHashCode();
                if (this.SettlementAmount != null)
                    hash = hash * 59 + this.SettlementAmount.GetHashCode();
                if (this.SettlementCurrency != null)
                    hash = hash * 59 + this.SettlementCurrency.GetHashCode();
                if (this.AmexAdditionalAmounts != null)
                    hash = hash * 59 + this.AmexAdditionalAmounts.GetHashCode();
                if (this.TaxDetails != null)
                    hash = hash * 59 + this.TaxDetails.GetHashCode();
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
            // TotalAmount (string) maxLength
            if(this.TotalAmount != null && this.TotalAmount.Length > 19)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TotalAmount, length must be less than 19.", new [] { "TotalAmount" });
            }

            // Currency (string) maxLength
            if(this.Currency != null && this.Currency.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Currency, length must be less than 3.", new [] { "Currency" });
            }

            // DiscountAmount (string) maxLength
            if(this.DiscountAmount != null && this.DiscountAmount.Length > 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DiscountAmount, length must be less than 15.", new [] { "DiscountAmount" });
            }

            // DutyAmount (string) maxLength
            if(this.DutyAmount != null && this.DutyAmount.Length > 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DutyAmount, length must be less than 15.", new [] { "DutyAmount" });
            }

            // TaxAmount (string) maxLength
            if(this.TaxAmount != null && this.TaxAmount.Length > 12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TaxAmount, length must be less than 12.", new [] { "TaxAmount" });
            }

            // NationalTaxIncluded (string) maxLength
            if(this.NationalTaxIncluded != null && this.NationalTaxIncluded.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NationalTaxIncluded, length must be less than 1.", new [] { "NationalTaxIncluded" });
            }

            // TaxAppliedAfterDiscount (string) maxLength
            if(this.TaxAppliedAfterDiscount != null && this.TaxAppliedAfterDiscount.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TaxAppliedAfterDiscount, length must be less than 1.", new [] { "TaxAppliedAfterDiscount" });
            }

            // TaxAppliedLevel (string) maxLength
            if(this.TaxAppliedLevel != null && this.TaxAppliedLevel.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TaxAppliedLevel, length must be less than 1.", new [] { "TaxAppliedLevel" });
            }

            // TaxTypeCode (string) maxLength
            if(this.TaxTypeCode != null && this.TaxTypeCode.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TaxTypeCode, length must be less than 3.", new [] { "TaxTypeCode" });
            }

            // FreightAmount (string) maxLength
            if(this.FreightAmount != null && this.FreightAmount.Length > 13)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FreightAmount, length must be less than 13.", new [] { "FreightAmount" });
            }

            // ForeignAmount (string) maxLength
            if(this.ForeignAmount != null && this.ForeignAmount.Length > 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ForeignAmount, length must be less than 15.", new [] { "ForeignAmount" });
            }

            // ForeignCurrency (string) maxLength
            if(this.ForeignCurrency != null && this.ForeignCurrency.Length > 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ForeignCurrency, length must be less than 5.", new [] { "ForeignCurrency" });
            }

            // ExchangeRate (string) maxLength
            if(this.ExchangeRate != null && this.ExchangeRate.Length > 13)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExchangeRate, length must be less than 13.", new [] { "ExchangeRate" });
            }

            // ExchangeRateTimeStamp (string) maxLength
            if(this.ExchangeRateTimeStamp != null && this.ExchangeRateTimeStamp.Length > 14)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExchangeRateTimeStamp, length must be less than 14.", new [] { "ExchangeRateTimeStamp" });
            }

            // SettlementAmount (string) maxLength
            if(this.SettlementAmount != null && this.SettlementAmount.Length > 12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SettlementAmount, length must be less than 12.", new [] { "SettlementAmount" });
            }

            // SettlementCurrency (string) maxLength
            if(this.SettlementCurrency != null && this.SettlementCurrency.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SettlementCurrency, length must be less than 3.", new [] { "SettlementCurrency" });
            }

            yield break;
        }
    }

}
