/* 
 * Selling Partner API for Pricing
 *
 * The Selling Partner API for Pricing helps you programmatically retrieve product pricing and offer information for Amazon Marketplace products.
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

namespace AmazonSpApiSDK.Models.ProductPricing
{
    /// <summary>
    /// The state and country from where the item is shipped.
    /// </summary>
    [DataContract]
    public partial class ShipsFromType : IEquatable<ShipsFromType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipsFromType" /> class.
        /// </summary>
        /// <param name="State">The state from where the item is shipped..</param>
        /// <param name="Country">The country from where the item is shipped..</param>
        public ShipsFromType(string State = default(string), string Country = default(string))
        {
            this.State = State;
            this.Country = Country;
        }

        /// <summary>
        /// The state from where the item is shipped.
        /// </summary>
        /// <value>The state from where the item is shipped.</value>
        [DataMember(Name = "State", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// The country from where the item is shipped.
        /// </summary>
        /// <value>The country from where the item is shipped.</value>
        [DataMember(Name = "Country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShipsFromType {\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(input as ShipsFromType);
        }

        /// <summary>
        /// Returns true if ShipsFromType instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipsFromType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipsFromType input)
        {
            if (input == null)
                return false;

            return
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) &&
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
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
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
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
