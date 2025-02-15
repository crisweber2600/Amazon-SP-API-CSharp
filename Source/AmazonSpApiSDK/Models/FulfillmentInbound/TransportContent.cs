/* 
 * Selling Partner API for Fulfillment Inbound
 *
 * The Selling Partner API for Fulfillment Inbound lets you create applications that create and update inbound shipments of inventory to Amazon's fulfillment network.
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

namespace AmazonSpApiSDK.Models.FulfillmentInbound
{
    /// <summary>
    /// Inbound shipment information, including carrier details, shipment status, and the workflow status for a request for shipment with an Amazon-partnered carrier.
    /// </summary>
    [DataContract]
    public partial class TransportContent : IEquatable<TransportContent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransportContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransportContent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransportContent" /> class.
        /// </summary>
        /// <param name="TransportHeader">TransportHeader (required).</param>
        /// <param name="TransportDetails">TransportDetails (required).</param>
        /// <param name="TransportResult">TransportResult (required).</param>
        public TransportContent(TransportHeader TransportHeader = default(TransportHeader), TransportDetailOutput TransportDetails = default(TransportDetailOutput), TransportResult TransportResult = default(TransportResult))
        {
            // to ensure "TransportHeader" is required (not null)
            if (TransportHeader == null)
            {
                throw new InvalidDataException("TransportHeader is a required property for TransportContent and cannot be null");
            }
            else
            {
                this.TransportHeader = TransportHeader;
            }
            // to ensure "TransportDetails" is required (not null)
            if (TransportDetails == null)
            {
                throw new InvalidDataException("TransportDetails is a required property for TransportContent and cannot be null");
            }
            else
            {
                this.TransportDetails = TransportDetails;
            }
            // to ensure "TransportResult" is required (not null)
            if (TransportResult == null)
            {
                throw new InvalidDataException("TransportResult is a required property for TransportContent and cannot be null");
            }
            else
            {
                this.TransportResult = TransportResult;
            }
        }

        /// <summary>
        /// Gets or Sets TransportHeader
        /// </summary>
        [DataMember(Name = "TransportHeader", EmitDefaultValue = false)]
        public TransportHeader TransportHeader { get; set; }

        /// <summary>
        /// Gets or Sets TransportDetails
        /// </summary>
        [DataMember(Name = "TransportDetails", EmitDefaultValue = false)]
        public TransportDetailOutput TransportDetails { get; set; }

        /// <summary>
        /// Gets or Sets TransportResult
        /// </summary>
        [DataMember(Name = "TransportResult", EmitDefaultValue = false)]
        public TransportResult TransportResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransportContent {\n");
            sb.Append("  TransportHeader: ").Append(TransportHeader).Append("\n");
            sb.Append("  TransportDetails: ").Append(TransportDetails).Append("\n");
            sb.Append("  TransportResult: ").Append(TransportResult).Append("\n");
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
            return this.Equals(input as TransportContent);
        }

        /// <summary>
        /// Returns true if TransportContent instances are equal
        /// </summary>
        /// <param name="input">Instance of TransportContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransportContent input)
        {
            if (input == null)
                return false;

            return
                (
                    this.TransportHeader == input.TransportHeader ||
                    (this.TransportHeader != null &&
                    this.TransportHeader.Equals(input.TransportHeader))
                ) &&
                (
                    this.TransportDetails == input.TransportDetails ||
                    (this.TransportDetails != null &&
                    this.TransportDetails.Equals(input.TransportDetails))
                ) &&
                (
                    this.TransportResult == input.TransportResult ||
                    (this.TransportResult != null &&
                    this.TransportResult.Equals(input.TransportResult))
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
                if (this.TransportHeader != null)
                    hashCode = hashCode * 59 + this.TransportHeader.GetHashCode();
                if (this.TransportDetails != null)
                    hashCode = hashCode * 59 + this.TransportDetails.GetHashCode();
                if (this.TransportResult != null)
                    hashCode = hashCode * 59 + this.TransportResult.GetHashCode();
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
