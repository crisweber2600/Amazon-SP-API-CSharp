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
    /// A SAFE-T claim reimbursement on the seller&#39;s account.
    /// </summary>
    [DataContract]
    public partial class SAFETReimbursementEvent : IEquatable<SAFETReimbursementEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SAFETReimbursementEvent" /> class.
        /// </summary>
        /// <param name="PostedDate">The date and time when the financial event was posted..</param>
        /// <param name="SAFETClaimId">A SAFE-T claim identifier..</param>
        /// <param name="ReimbursedAmount">The amount of the reimbursement..</param>
        /// <param name="ReasonCode">Indicates why the seller was reimbursed..</param>
        /// <param name="SAFETReimbursementItemList">SAFETReimbursementItemList.</param>
        public SAFETReimbursementEvent(DateTime? PostedDate = default(DateTime?), string SAFETClaimId = default(string), Currency ReimbursedAmount = default(Currency), string ReasonCode = default(string), SAFETReimbursementItemList SAFETReimbursementItemList = default(SAFETReimbursementItemList))
        {
            this.PostedDate = PostedDate;
            this.SAFETClaimId = SAFETClaimId;
            this.ReimbursedAmount = ReimbursedAmount;
            this.ReasonCode = ReasonCode;
            this.SAFETReimbursementItemList = SAFETReimbursementItemList;
        }

        /// <summary>
        /// The date and time when the financial event was posted.
        /// </summary>
        /// <value>The date and time when the financial event was posted.</value>
        [DataMember(Name = "PostedDate", EmitDefaultValue = false)]
        public DateTime? PostedDate { get; set; }

        /// <summary>
        /// A SAFE-T claim identifier.
        /// </summary>
        /// <value>A SAFE-T claim identifier.</value>
        [DataMember(Name = "SAFETClaimId", EmitDefaultValue = false)]
        public string SAFETClaimId { get; set; }

        /// <summary>
        /// The amount of the reimbursement.
        /// </summary>
        /// <value>The amount of the reimbursement.</value>
        [DataMember(Name = "ReimbursedAmount", EmitDefaultValue = false)]
        public Currency ReimbursedAmount { get; set; }

        /// <summary>
        /// Indicates why the seller was reimbursed.
        /// </summary>
        /// <value>Indicates why the seller was reimbursed.</value>
        [DataMember(Name = "ReasonCode", EmitDefaultValue = false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// Gets or Sets SAFETReimbursementItemList
        /// </summary>
        [DataMember(Name = "SAFETReimbursementItemList", EmitDefaultValue = false)]
        public SAFETReimbursementItemList SAFETReimbursementItemList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SAFETReimbursementEvent {\n");
            sb.Append("  PostedDate: ").Append(PostedDate).Append("\n");
            sb.Append("  SAFETClaimId: ").Append(SAFETClaimId).Append("\n");
            sb.Append("  ReimbursedAmount: ").Append(ReimbursedAmount).Append("\n");
            sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
            sb.Append("  SAFETReimbursementItemList: ").Append(SAFETReimbursementItemList).Append("\n");
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
            return this.Equals(input as SAFETReimbursementEvent);
        }

        /// <summary>
        /// Returns true if SAFETReimbursementEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of SAFETReimbursementEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SAFETReimbursementEvent input)
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
                    this.SAFETClaimId == input.SAFETClaimId ||
                    (this.SAFETClaimId != null &&
                    this.SAFETClaimId.Equals(input.SAFETClaimId))
                ) &&
                (
                    this.ReimbursedAmount == input.ReimbursedAmount ||
                    (this.ReimbursedAmount != null &&
                    this.ReimbursedAmount.Equals(input.ReimbursedAmount))
                ) &&
                (
                    this.ReasonCode == input.ReasonCode ||
                    (this.ReasonCode != null &&
                    this.ReasonCode.Equals(input.ReasonCode))
                ) &&
                (
                    this.SAFETReimbursementItemList == input.SAFETReimbursementItemList ||
                    (this.SAFETReimbursementItemList != null &&
                    this.SAFETReimbursementItemList.Equals(input.SAFETReimbursementItemList))
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
                if (this.SAFETClaimId != null)
                    hashCode = hashCode * 59 + this.SAFETClaimId.GetHashCode();
                if (this.ReimbursedAmount != null)
                    hashCode = hashCode * 59 + this.ReimbursedAmount.GetHashCode();
                if (this.ReasonCode != null)
                    hashCode = hashCode * 59 + this.ReasonCode.GetHashCode();
                if (this.SAFETReimbursementItemList != null)
                    hashCode = hashCode * 59 + this.SAFETReimbursementItemList.GetHashCode();
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
