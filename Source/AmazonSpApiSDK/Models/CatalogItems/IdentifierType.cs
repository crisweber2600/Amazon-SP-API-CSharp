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
using System.Runtime.Serialization;
using System.Text;

namespace AmazonSpApiSDK.Models.CatalogItems
{
    /// <summary>
    /// IdentifierType
    /// </summary>
    [DataContract]
    public partial class IdentifierType : IEquatable<IdentifierType>, IValidatableObject
    {
        public IdentifierType()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentifierType" /> class.
        /// </summary>
        /// <param name="MarketplaceASIN">Indicates the item is identified by MarketPlaceId and ASIN..</param>
        /// <param name="SKUIdentifier">Indicates the item is identified by MarketPlaceId, SellerId, and SellerSKU..</param>
        public IdentifierType(ASINIdentifier MarketplaceASIN = default(ASINIdentifier), SellerSKUIdentifier SKUIdentifier = default(SellerSKUIdentifier))
        {
            this.MarketplaceASIN = MarketplaceASIN;
            this.SKUIdentifier = SKUIdentifier;
        }

        /// <summary>
        /// Indicates the item is identified by MarketPlaceId and ASIN.
        /// </summary>
        /// <value>Indicates the item is identified by MarketPlaceId and ASIN.</value>
        [DataMember(Name = "MarketplaceASIN", EmitDefaultValue = false)]
        public ASINIdentifier MarketplaceASIN { get; set; }

        /// <summary>
        /// Indicates the item is identified by MarketPlaceId, SellerId, and SellerSKU.
        /// </summary>
        /// <value>Indicates the item is identified by MarketPlaceId, SellerId, and SellerSKU.</value>
        [DataMember(Name = "SKUIdentifier", EmitDefaultValue = false)]
        public SellerSKUIdentifier SKUIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdentifierType {\n");
            sb.Append("  MarketplaceASIN: ").Append(MarketplaceASIN).Append("\n");
            sb.Append("  SKUIdentifier: ").Append(SKUIdentifier).Append("\n");
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
            return this.Equals(input as IdentifierType);
        }

        /// <summary>
        /// Returns true if IdentifierType instances are equal
        /// </summary>
        /// <param name="input">Instance of IdentifierType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdentifierType input)
        {
            if (input == null)
                return false;

            return
                (
                    this.MarketplaceASIN == input.MarketplaceASIN ||
                    (this.MarketplaceASIN != null &&
                    this.MarketplaceASIN.Equals(input.MarketplaceASIN))
                ) &&
                (
                    this.SKUIdentifier == input.SKUIdentifier ||
                    (this.SKUIdentifier != null &&
                    this.SKUIdentifier.Equals(input.SKUIdentifier))
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
                if (this.MarketplaceASIN != null)
                    hashCode = hashCode * 59 + this.MarketplaceASIN.GetHashCode();
                if (this.SKUIdentifier != null)
                    hashCode = hashCode * 59 + this.SKUIdentifier.GetHashCode();
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
