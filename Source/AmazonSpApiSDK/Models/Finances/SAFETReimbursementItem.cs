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
    /// An item from a SAFE-T claim reimbursement.
    /// </summary>
    [DataContract]
    public partial class SAFETReimbursementItem : IEquatable<SAFETReimbursementItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SAFETReimbursementItem" /> class.
        /// </summary>
        /// <param name="ItemChargeList">A list of charges associated with the item..</param>
        /// <param name="ProductDescription">The description of the item as shown on the product detail page on the retail website..</param>
        /// <param name="Quantity">The number of units of the item being reimbursed..</param>
        public SAFETReimbursementItem(ChargeComponentList ItemChargeList = default(ChargeComponentList), string ProductDescription = default(string), string Quantity = default(string))
        {
            this.ItemChargeList = ItemChargeList;
            this.ProductDescription = ProductDescription;
            this.Quantity = Quantity;
        }

        /// <summary>
        /// A list of charges associated with the item.
        /// </summary>
        /// <value>A list of charges associated with the item.</value>
        [DataMember(Name = "itemChargeList", EmitDefaultValue = false)]
        public ChargeComponentList ItemChargeList { get; set; }

        /// <summary>
        /// The description of the item as shown on the product detail page on the retail website.
        /// </summary>
        /// <value>The description of the item as shown on the product detail page on the retail website.</value>
        [DataMember(Name = "productDescription", EmitDefaultValue = false)]
        public string ProductDescription { get; set; }

        /// <summary>
        /// The number of units of the item being reimbursed.
        /// </summary>
        /// <value>The number of units of the item being reimbursed.</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public string Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SAFETReimbursementItem {\n");
            sb.Append("  ItemChargeList: ").Append(ItemChargeList).Append("\n");
            sb.Append("  ProductDescription: ").Append(ProductDescription).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
            return this.Equals(input as SAFETReimbursementItem);
        }

        /// <summary>
        /// Returns true if SAFETReimbursementItem instances are equal
        /// </summary>
        /// <param name="input">Instance of SAFETReimbursementItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SAFETReimbursementItem input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ItemChargeList == input.ItemChargeList ||
                    (this.ItemChargeList != null &&
                    this.ItemChargeList.Equals(input.ItemChargeList))
                ) &&
                (
                    this.ProductDescription == input.ProductDescription ||
                    (this.ProductDescription != null &&
                    this.ProductDescription.Equals(input.ProductDescription))
                ) &&
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
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
                if (this.ItemChargeList != null)
                    hashCode = hashCode * 59 + this.ItemChargeList.GetHashCode();
                if (this.ProductDescription != null)
                    hashCode = hashCode * 59 + this.ProductDescription.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
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
