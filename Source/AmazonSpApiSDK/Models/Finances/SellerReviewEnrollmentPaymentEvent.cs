/* 
 * Selling Partner API for Finances
 *
 * The Selling Partner API for Finances helps you obtain financial information relevant to a seller's business. You can obtain financial events for a given order, financial event group, or date range without having to wait until a statement period closes. You can also obtain financial event groups for a given date range.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace AmazonSpApiSDK.Models.Finances
{
    /// <summary>
    /// A fee payment event for the Early Reviewer Program.
    /// </summary>
    [DataContract]
    public partial class SellerReviewEnrollmentPaymentEvent : IEquatable<SellerReviewEnrollmentPaymentEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SellerReviewEnrollmentPaymentEvent" /> class.
        /// </summary>
        /// <param name="PostedDate">The date and time when the financial event was posted..</param>
        /// <param name="EnrollmentId">An enrollment identifier..</param>
        /// <param name="ParentASIN">The Amazon Standard Identification Number (ASIN) of the item that was enrolled in the Early Reviewer Program..</param>
        /// <param name="FeeComponent">FeeComponent.</param>
        /// <param name="ChargeComponent">ChargeComponent.</param>
        /// <param name="TotalAmount">The FeeComponent value plus the ChargeComponent value..</param>
        public SellerReviewEnrollmentPaymentEvent(DateTime? PostedDate = default(DateTime?), string EnrollmentId = default(string), string ParentASIN = default(string), FeeComponent FeeComponent = default(FeeComponent), ChargeComponent ChargeComponent = default(ChargeComponent), Currency TotalAmount = default(Currency))
        {
            this.PostedDate = PostedDate;
            this.EnrollmentId = EnrollmentId;
            this.ParentASIN = ParentASIN;
            this.FeeComponent = FeeComponent;
            this.ChargeComponent = ChargeComponent;
            this.TotalAmount = TotalAmount;
        }

        /// <summary>
        /// The date and time when the financial event was posted.
        /// </summary>
        /// <value>The date and time when the financial event was posted.</value>
        [DataMember(Name = "PostedDate", EmitDefaultValue = false)]
        public DateTime? PostedDate { get; set; }

        /// <summary>
        /// An enrollment identifier.
        /// </summary>
        /// <value>An enrollment identifier.</value>
        [DataMember(Name = "EnrollmentId", EmitDefaultValue = false)]
        public string EnrollmentId { get; set; }

        /// <summary>
        /// The Amazon Standard Identification Number (ASIN) of the item that was enrolled in the Early Reviewer Program.
        /// </summary>
        /// <value>The Amazon Standard Identification Number (ASIN) of the item that was enrolled in the Early Reviewer Program.</value>
        [DataMember(Name = "ParentASIN", EmitDefaultValue = false)]
        public string ParentASIN { get; set; }

        /// <summary>
        /// Gets or Sets FeeComponent
        /// </summary>
        [DataMember(Name = "FeeComponent", EmitDefaultValue = false)]
        public FeeComponent FeeComponent { get; set; }

        /// <summary>
        /// Gets or Sets ChargeComponent
        /// </summary>
        [DataMember(Name = "ChargeComponent", EmitDefaultValue = false)]
        public ChargeComponent ChargeComponent { get; set; }

        /// <summary>
        /// The FeeComponent value plus the ChargeComponent value.
        /// </summary>
        /// <value>The FeeComponent value plus the ChargeComponent value.</value>
        [DataMember(Name = "TotalAmount", EmitDefaultValue = false)]
        public Currency TotalAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SellerReviewEnrollmentPaymentEvent {\n");
            sb.Append("  PostedDate: ").Append(PostedDate).Append("\n");
            sb.Append("  EnrollmentId: ").Append(EnrollmentId).Append("\n");
            sb.Append("  ParentASIN: ").Append(ParentASIN).Append("\n");
            sb.Append("  FeeComponent: ").Append(FeeComponent).Append("\n");
            sb.Append("  ChargeComponent: ").Append(ChargeComponent).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
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
            return this.Equals(input as SellerReviewEnrollmentPaymentEvent);
        }

        /// <summary>
        /// Returns true if SellerReviewEnrollmentPaymentEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of SellerReviewEnrollmentPaymentEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SellerReviewEnrollmentPaymentEvent input)
        {
            if (input == null)
                return false;

            return
                (
                    this.PostedDate == input.PostedDate ||
                    (this.PostedDate != null &&
                    this.PostedDate.Equals(input.PostedDate))
                ) &&
                (
                    this.EnrollmentId == input.EnrollmentId ||
                    (this.EnrollmentId != null &&
                    this.EnrollmentId.Equals(input.EnrollmentId))
                ) &&
                (
                    this.ParentASIN == input.ParentASIN ||
                    (this.ParentASIN != null &&
                    this.ParentASIN.Equals(input.ParentASIN))
                ) &&
                (
                    this.FeeComponent == input.FeeComponent ||
                    (this.FeeComponent != null &&
                    this.FeeComponent.Equals(input.FeeComponent))
                ) &&
                (
                    this.ChargeComponent == input.ChargeComponent ||
                    (this.ChargeComponent != null &&
                    this.ChargeComponent.Equals(input.ChargeComponent))
                ) &&
                (
                    this.TotalAmount == input.TotalAmount ||
                    (this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount))
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
                if (this.PostedDate != null)
                    hashCode = hashCode * 59 + this.PostedDate.GetHashCode();
                if (this.EnrollmentId != null)
                    hashCode = hashCode * 59 + this.EnrollmentId.GetHashCode();
                if (this.ParentASIN != null)
                    hashCode = hashCode * 59 + this.ParentASIN.GetHashCode();
                if (this.FeeComponent != null)
                    hashCode = hashCode * 59 + this.FeeComponent.GetHashCode();
                if (this.ChargeComponent != null)
                    hashCode = hashCode * 59 + this.ChargeComponent.GetHashCode();
                if (this.TotalAmount != null)
                    hashCode = hashCode * 59 + this.TotalAmount.GetHashCode();
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
