/* 
 * Selling Partner API for Shipping
 *
 * Provides programmatic access to Amazon Shipping APIs.
 *
 * OpenAPI spec version: v1
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

namespace AmazonSpApiSDK.Models.Shipping
{
    /// <summary>
    /// Container specification for checking the service rate.
    /// </summary>
    [DataContract]
    public partial class ContainerSpecification : IEquatable<ContainerSpecification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerSpecification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContainerSpecification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerSpecification" /> class.
        /// </summary>
        /// <param name="Dimensions">The length, width, and height of the container. (required).</param>
        /// <param name="Weight">The weight of the container. (required).</param>
        public ContainerSpecification(Dimensions Dimensions = default(Dimensions), Weight Weight = default(Weight))
        {
            // to ensure "Dimensions" is required (not null)
            if (Dimensions == null)
            {
                throw new InvalidDataException("Dimensions is a required property for ContainerSpecification and cannot be null");
            }
            else
            {
                this.Dimensions = Dimensions;
            }
            // to ensure "Weight" is required (not null)
            if (Weight == null)
            {
                throw new InvalidDataException("Weight is a required property for ContainerSpecification and cannot be null");
            }
            else
            {
                this.Weight = Weight;
            }
        }

        /// <summary>
        /// The length, width, and height of the container.
        /// </summary>
        /// <value>The length, width, and height of the container.</value>
        [DataMember(Name = "dimensions", EmitDefaultValue = false)]
        public Dimensions Dimensions { get; set; }

        /// <summary>
        /// The weight of the container.
        /// </summary>
        /// <value>The weight of the container.</value>
        [DataMember(Name = "weight", EmitDefaultValue = false)]
        public Weight Weight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContainerSpecification {\n");
            sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
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
            return this.Equals(input as ContainerSpecification);
        }

        /// <summary>
        /// Returns true if ContainerSpecification instances are equal
        /// </summary>
        /// <param name="input">Instance of ContainerSpecification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContainerSpecification input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Dimensions == input.Dimensions ||
                    (this.Dimensions != null &&
                    this.Dimensions.Equals(input.Dimensions))
                ) &&
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
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
                if (this.Dimensions != null)
                    hashCode = hashCode * 59 + this.Dimensions.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
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
