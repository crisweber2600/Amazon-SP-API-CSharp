/* 
 * Selling Partner API for Notifications
 *
 * The Selling Partner API for Notifications lets you subscribe to notifications that are relevant to a selling partner's business. Using this API you can create a destination to receive notifications, subscribe to notifications, delete notification subscriptions, and more.
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

namespace AmazonSpApiSDK.Models.Notifications
{
    /// <summary>
    /// Represents a destination created when you call the createDestination operation.
    /// </summary>
    [DataContract]
    public partial class Destination : IEquatable<Destination>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Destination" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Destination() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Destination" /> class.
        /// </summary>
        /// <param name="Name">The developer-defined name for this destination. (required).</param>
        /// <param name="DestinationId">The destination identifier generated when you created the destination. (required).</param>
        /// <param name="Resource">The resource that will receive notifications associated with this destination. (required).</param>
        public Destination(string Name = default(string), string DestinationId = default(string), DestinationResource Resource = default(DestinationResource))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for Destination and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "DestinationId" is required (not null)
            if (DestinationId == null)
            {
                throw new InvalidDataException("DestinationId is a required property for Destination and cannot be null");
            }
            else
            {
                this.DestinationId = DestinationId;
            }
            // to ensure "Resource" is required (not null)
            if (Resource == null)
            {
                throw new InvalidDataException("Resource is a required property for Destination and cannot be null");
            }
            else
            {
                this.Resource = Resource;
            }
        }

        /// <summary>
        /// The developer-defined name for this destination.
        /// </summary>
        /// <value>The developer-defined name for this destination.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The destination identifier generated when you created the destination.
        /// </summary>
        /// <value>The destination identifier generated when you created the destination.</value>
        [DataMember(Name = "destinationId", EmitDefaultValue = false)]
        public string DestinationId { get; set; }

        /// <summary>
        /// The resource that will receive notifications associated with this destination.
        /// </summary>
        /// <value>The resource that will receive notifications associated with this destination.</value>
        [DataMember(Name = "resource", EmitDefaultValue = false)]
        public DestinationResource Resource { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Destination {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DestinationId: ").Append(DestinationId).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
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
            return this.Equals(input as Destination);
        }

        /// <summary>
        /// Returns true if Destination instances are equal
        /// </summary>
        /// <param name="input">Instance of Destination to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Destination input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) &&
                (
                    this.DestinationId == input.DestinationId ||
                    (this.DestinationId != null &&
                    this.DestinationId.Equals(input.DestinationId))
                ) &&
                (
                    this.Resource == input.Resource ||
                    (this.Resource != null &&
                    this.Resource.Equals(input.Resource))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DestinationId != null)
                    hashCode = hashCode * 59 + this.DestinationId.GetHashCode();
                if (this.Resource != null)
                    hashCode = hashCode * 59 + this.Resource.GetHashCode();
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 256.", new[] { "Name" });
            }

            yield break;
        }
    }

}
