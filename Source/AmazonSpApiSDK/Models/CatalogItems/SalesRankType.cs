/* 
 * Selling Partner API for Catalog Items
 *
 * The Selling Partner API for Catalog Items helps you programmatically retrieve item details for items in the catalog.
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

namespace AmazonSpApiSDK.Models.CatalogItems
{
    /// <summary>
    /// SalesRankType
    /// </summary>
    [DataContract]
    public partial class SalesRankType : IEquatable<SalesRankType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesRankType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SalesRankType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesRankType" /> class.
        /// </summary>
        /// <param name="ProductCategoryId">Identifies the item category from which the sales rank is taken. (required).</param>
        /// <param name="Rank">The sales rank of the item within the item category. (required).</param>
        public SalesRankType(string ProductCategoryId = default(string), int? Rank = default(int?))
        {
            // to ensure "ProductCategoryId" is required (not null)
            if (ProductCategoryId == null)
            {
                throw new InvalidDataException("ProductCategoryId is a required property for SalesRankType and cannot be null");
            }
            else
            {
                this.ProductCategoryId = ProductCategoryId;
            }
            // to ensure "Rank" is required (not null)
            if (Rank == null)
            {
                throw new InvalidDataException("Rank is a required property for SalesRankType and cannot be null");
            }
            else
            {
                this.Rank = Rank;
            }
        }

        /// <summary>
        /// Identifies the item category from which the sales rank is taken.
        /// </summary>
        /// <value>Identifies the item category from which the sales rank is taken.</value>
        [DataMember(Name = "ProductCategoryId", EmitDefaultValue = false)]
        public string ProductCategoryId { get; set; }

        /// <summary>
        /// The sales rank of the item within the item category.
        /// </summary>
        /// <value>The sales rank of the item within the item category.</value>
        [DataMember(Name = "Rank", EmitDefaultValue = false)]
        public int? Rank { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SalesRankType {\n");
            sb.Append("  ProductCategoryId: ").Append(ProductCategoryId).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
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
            return this.Equals(input as SalesRankType);
        }

        /// <summary>
        /// Returns true if SalesRankType instances are equal
        /// </summary>
        /// <param name="input">Instance of SalesRankType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesRankType input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ProductCategoryId == input.ProductCategoryId ||
                    (this.ProductCategoryId != null &&
                    this.ProductCategoryId.Equals(input.ProductCategoryId))
                ) &&
                (
                    this.Rank == input.Rank ||
                    (this.Rank != null &&
                    this.Rank.Equals(input.Rank))
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
                if (this.ProductCategoryId != null)
                    hashCode = hashCode * 59 + this.ProductCategoryId.GetHashCode();
                if (this.Rank != null)
                    hashCode = hashCode * 59 + this.Rank.GetHashCode();
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
