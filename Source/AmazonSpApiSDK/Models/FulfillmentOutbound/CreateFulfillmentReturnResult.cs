/* 
 * Selling Partner API for Fulfillment Outbound
 *
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
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

namespace AmazonSpApiSDK.Models.FulfillmentOutbound
{
    /// <summary>
    /// CreateFulfillmentReturnResult
    /// </summary>
    [DataContract]
    public partial class CreateFulfillmentReturnResult : IEquatable<CreateFulfillmentReturnResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFulfillmentReturnResult" /> class.
        /// </summary>
        /// <param name="ReturnItemList">ReturnItemList.</param>
        /// <param name="InvalidReturnItemList">InvalidReturnItemList.</param>
        /// <param name="ReturnAuthorizationList">ReturnAuthorizationList.</param>
        public CreateFulfillmentReturnResult(ReturnItemList ReturnItemList = default(ReturnItemList), InvalidReturnItemList InvalidReturnItemList = default(InvalidReturnItemList), ReturnAuthorizationList ReturnAuthorizationList = default(ReturnAuthorizationList))
        {
            this.ReturnItemList = ReturnItemList;
            this.InvalidReturnItemList = InvalidReturnItemList;
            this.ReturnAuthorizationList = ReturnAuthorizationList;
        }

        /// <summary>
        /// Gets or Sets ReturnItemList
        /// </summary>
        [DataMember(Name = "ReturnItemList", EmitDefaultValue = false)]
        public ReturnItemList ReturnItemList { get; set; }

        /// <summary>
        /// Gets or Sets InvalidReturnItemList
        /// </summary>
        [DataMember(Name = "InvalidReturnItemList", EmitDefaultValue = false)]
        public InvalidReturnItemList InvalidReturnItemList { get; set; }

        /// <summary>
        /// Gets or Sets ReturnAuthorizationList
        /// </summary>
        [DataMember(Name = "ReturnAuthorizationList", EmitDefaultValue = false)]
        public ReturnAuthorizationList ReturnAuthorizationList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFulfillmentReturnResult {\n");
            sb.Append("  ReturnItemList: ").Append(ReturnItemList).Append("\n");
            sb.Append("  InvalidReturnItemList: ").Append(InvalidReturnItemList).Append("\n");
            sb.Append("  ReturnAuthorizationList: ").Append(ReturnAuthorizationList).Append("\n");
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
            return this.Equals(input as CreateFulfillmentReturnResult);
        }

        /// <summary>
        /// Returns true if CreateFulfillmentReturnResult instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateFulfillmentReturnResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateFulfillmentReturnResult input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ReturnItemList == input.ReturnItemList ||
                    (this.ReturnItemList != null &&
                    this.ReturnItemList.Equals(input.ReturnItemList))
                ) &&
                (
                    this.InvalidReturnItemList == input.InvalidReturnItemList ||
                    (this.InvalidReturnItemList != null &&
                    this.InvalidReturnItemList.Equals(input.InvalidReturnItemList))
                ) &&
                (
                    this.ReturnAuthorizationList == input.ReturnAuthorizationList ||
                    (this.ReturnAuthorizationList != null &&
                    this.ReturnAuthorizationList.Equals(input.ReturnAuthorizationList))
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
                if (this.ReturnItemList != null)
                    hashCode = hashCode * 59 + this.ReturnItemList.GetHashCode();
                if (this.InvalidReturnItemList != null)
                    hashCode = hashCode * 59 + this.InvalidReturnItemList.GetHashCode();
                if (this.ReturnAuthorizationList != null)
                    hashCode = hashCode * 59 + this.ReturnAuthorizationList.GetHashCode();
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
