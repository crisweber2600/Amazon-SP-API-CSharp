/* 
 * Selling Partner API for Product Fees
 *
 * The Selling Partner API for Product Fees lets you programmatically retrieve estimated fees for a product. You can then account for those fees in your pricing.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace AmazonSpApiSDK.Models.ProductFees
{
    /// <summary>
    /// FeesEstimateRequest
    /// </summary>
    [DataContract]
    public partial class FeesEstimateRequest : IEquatable<FeesEstimateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeesEstimateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FeesEstimateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeesEstimateRequest" /> class.
        /// </summary>
        /// <param name="MarketplaceId">A marketplace identifier. (required).</param>
        /// <param name="IsAmazonFulfilled">When true, the offer is fulfilled by Amazon..</param>
        /// <param name="PriceToEstimateFees">The product price that the fee estimate is based on. (required).</param>
        /// <param name="Identifier">The product price on which the fee estimate is based. (required).</param>
        public FeesEstimateRequest(string MarketplaceId = default(string), bool? IsAmazonFulfilled = default(bool?), PriceToEstimateFees PriceToEstimateFees = default(PriceToEstimateFees), string Identifier = default(string))
        {
            // to ensure "MarketplaceId" is required (not null)
            if (MarketplaceId == null)
            {
                throw new InvalidDataException("MarketplaceId is a required property for FeesEstimateRequest and cannot be null");
            }
            else
            {
                this.MarketplaceId = MarketplaceId;
            }
            // to ensure "PriceToEstimateFees" is required (not null)
            if (PriceToEstimateFees == null)
            {
                throw new InvalidDataException("PriceToEstimateFees is a required property for FeesEstimateRequest and cannot be null");
            }
            else
            {
                this.PriceToEstimateFees = PriceToEstimateFees;
            }
            // to ensure "Identifier" is required (not null)
            if (Identifier == null)
            {
                throw new InvalidDataException("Identifier is a required property for FeesEstimateRequest and cannot be null");
            }
            else
            {
                this.Identifier = Identifier;
            }
            this.IsAmazonFulfilled = IsAmazonFulfilled;
        }

        /// <summary>
        /// A marketplace identifier.
        /// </summary>
        /// <value>A marketplace identifier.</value>
        [DataMember(Name = "MarketplaceId", EmitDefaultValue = false)]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// When true, the offer is fulfilled by Amazon.
        /// </summary>
        /// <value>When true, the offer is fulfilled by Amazon.</value>
        [DataMember(Name = "IsAmazonFulfilled", EmitDefaultValue = false)]
        public bool? IsAmazonFulfilled { get; set; }

        /// <summary>
        /// The product price that the fee estimate is based on.
        /// </summary>
        /// <value>The product price that the fee estimate is based on.</value>
        [DataMember(Name = "PriceToEstimateFees", EmitDefaultValue = false)]
        public PriceToEstimateFees PriceToEstimateFees { get; set; }

        /// <summary>
        /// The product price on which the fee estimate is based.
        /// </summary>
        /// <value>The product price on which the fee estimate is based.</value>
        [DataMember(Name = "Identifier", EmitDefaultValue = false)]
        public string Identifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeesEstimateRequest {\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
            sb.Append("  IsAmazonFulfilled: ").Append(IsAmazonFulfilled).Append("\n");
            sb.Append("  PriceToEstimateFees: ").Append(PriceToEstimateFees).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FeesEstimateRequest);
        }

        /// <summary>
        /// Returns true if FeesEstimateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of FeesEstimateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeesEstimateRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.MarketplaceId == input.MarketplaceId ||
                    (this.MarketplaceId != null &&
                    this.MarketplaceId.Equals(input.MarketplaceId))
                ) &&
                (
                    this.IsAmazonFulfilled == input.IsAmazonFulfilled ||
                    (this.IsAmazonFulfilled != null &&
                    this.IsAmazonFulfilled.Equals(input.IsAmazonFulfilled))
                ) &&
                (
                    this.PriceToEstimateFees == input.PriceToEstimateFees ||
                    (this.PriceToEstimateFees != null &&
                    this.PriceToEstimateFees.Equals(input.PriceToEstimateFees))
                ) &&
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.MarketplaceId != null)
                    hashCode = hashCode * 59 + this.MarketplaceId.GetHashCode();
                if (this.IsAmazonFulfilled != null)
                    hashCode = hashCode * 59 + this.IsAmazonFulfilled.GetHashCode();
                if (this.PriceToEstimateFees != null)
                    hashCode = hashCode * 59 + this.PriceToEstimateFees.GetHashCode();
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                return hashCode;
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
