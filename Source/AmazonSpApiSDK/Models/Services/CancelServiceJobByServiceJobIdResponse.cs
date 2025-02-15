/* 
 * Selling Partner API for Services
 *
 * With the Services API, you can build applications that help service providers get and modify their service orders.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace AmazonSpApiSDK.Models.Services
{
    /// <summary>
    /// Response schema for CancelServiceJobByServiceJobId operation.
    /// </summary>
    [DataContract]
    public partial class CancelServiceJobByServiceJobIdResponse : IEquatable<CancelServiceJobByServiceJobIdResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelServiceJobByServiceJobIdResponse" /> class.
        /// </summary>
        /// <param name="Errors">Encountered errors for the CancelServiceJobByServiceJobId operation..</param>
        public CancelServiceJobByServiceJobIdResponse(ErrorList Errors = default(ErrorList))
        {
            this.Errors = Errors;
        }

        /// <summary>
        /// Encountered errors for the CancelServiceJobByServiceJobId operation.
        /// </summary>
        /// <value>Encountered errors for the CancelServiceJobByServiceJobId operation.</value>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public ErrorList Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CancelServiceJobByServiceJobIdResponse {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return this.Equals(input as CancelServiceJobByServiceJobIdResponse);
        }

        /// <summary>
        /// Returns true if CancelServiceJobByServiceJobIdResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CancelServiceJobByServiceJobIdResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CancelServiceJobByServiceJobIdResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Errors == input.Errors ||
                    (this.Errors != null &&
                    this.Errors.Equals(input.Errors))
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
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
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
