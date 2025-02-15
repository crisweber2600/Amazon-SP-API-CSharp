/* 
 * Selling Partner API for Feeds
 *
 * The Selling Partner API for Feeds lets you upload data to Amazon on behalf of a selling partner.
 *
 * OpenAPI spec version: 2020-09-04
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace AmazonSpApiSDK.Models.Feeds
{
    /// <summary>
    /// CreateFeedSpecification
    /// </summary>
    [DataContract]
    public partial class CreateFeedSpecification : IEquatable<CreateFeedSpecification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFeedSpecification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateFeedSpecification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFeedSpecification" /> class.
        /// </summary>
        /// <param name="FeedType">The feed type. (required).</param>
        /// <param name="MarketplaceIds">A list of identifiers for marketplaces that you want the feed to be applied to. (required).</param>
        /// <param name="InputFeedDocumentId">The document identifier returned by the createFeedDocument operation. Encrypt and upload the feed document contents before calling the createFeed operation. (required).</param>
        /// <param name="FeedOptions">FeedOptions.</param>
        public CreateFeedSpecification(string FeedType = default(string), List<string> MarketplaceIds = default(List<string>), string InputFeedDocumentId = default(string), FeedOptions FeedOptions = default(FeedOptions))
        {
            // to ensure "FeedType" is required (not null)
            if (FeedType == null)
            {
                throw new InvalidDataException("FeedType is a required property for CreateFeedSpecification and cannot be null");
            }
            else
            {
                this.FeedType = FeedType;
            }
            // to ensure "MarketplaceIds" is required (not null)
            if (MarketplaceIds == null)
            {
                throw new InvalidDataException("MarketplaceIds is a required property for CreateFeedSpecification and cannot be null");
            }
            else
            {
                this.MarketplaceIds = MarketplaceIds;
            }
            // to ensure "InputFeedDocumentId" is required (not null)
            if (InputFeedDocumentId == null)
            {
                throw new InvalidDataException("InputFeedDocumentId is a required property for CreateFeedSpecification and cannot be null");
            }
            else
            {
                this.InputFeedDocumentId = InputFeedDocumentId;
            }
            this.FeedOptions = FeedOptions;
        }

        /// <summary>
        /// The feed type.
        /// </summary>
        /// <value>The feed type.</value>
        [DataMember(Name = "feedType", EmitDefaultValue = false)]
        public string FeedType { get; set; }

        /// <summary>
        /// A list of identifiers for marketplaces that you want the feed to be applied to.
        /// </summary>
        /// <value>A list of identifiers for marketplaces that you want the feed to be applied to.</value>
        [DataMember(Name = "marketplaceIds", EmitDefaultValue = false)]
        public List<string> MarketplaceIds { get; set; }

        /// <summary>
        /// The document identifier returned by the createFeedDocument operation. Encrypt and upload the feed document contents before calling the createFeed operation.
        /// </summary>
        /// <value>The document identifier returned by the createFeedDocument operation. Encrypt and upload the feed document contents before calling the createFeed operation.</value>
        [DataMember(Name = "inputFeedDocumentId", EmitDefaultValue = false)]
        public string InputFeedDocumentId { get; set; }

        /// <summary>
        /// Gets or Sets FeedOptions
        /// </summary>
        [DataMember(Name = "feedOptions", EmitDefaultValue = false)]
        public FeedOptions FeedOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFeedSpecification {\n");
            sb.Append("  FeedType: ").Append(FeedType).Append("\n");
            sb.Append("  MarketplaceIds: ").Append(MarketplaceIds).Append("\n");
            sb.Append("  InputFeedDocumentId: ").Append(InputFeedDocumentId).Append("\n");
            sb.Append("  FeedOptions: ").Append(FeedOptions).Append("\n");
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
            return this.Equals(input as CreateFeedSpecification);
        }

        /// <summary>
        /// Returns true if CreateFeedSpecification instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateFeedSpecification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateFeedSpecification input)
        {
            if (input == null)
                return false;

            return
                (
                    this.FeedType == input.FeedType ||
                    (this.FeedType != null &&
                    this.FeedType.Equals(input.FeedType))
                ) &&
                (
                    this.MarketplaceIds == input.MarketplaceIds ||
                    this.MarketplaceIds != null &&
                    this.MarketplaceIds.SequenceEqual(input.MarketplaceIds)
                ) &&
                (
                    this.InputFeedDocumentId == input.InputFeedDocumentId ||
                    (this.InputFeedDocumentId != null &&
                    this.InputFeedDocumentId.Equals(input.InputFeedDocumentId))
                ) &&
                (
                    this.FeedOptions == input.FeedOptions ||
                    (this.FeedOptions != null &&
                    this.FeedOptions.Equals(input.FeedOptions))
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
                if (this.FeedType != null)
                    hashCode = hashCode * 59 + this.FeedType.GetHashCode();
                if (this.MarketplaceIds != null)
                    hashCode = hashCode * 59 + this.MarketplaceIds.GetHashCode();
                if (this.InputFeedDocumentId != null)
                    hashCode = hashCode * 59 + this.InputFeedDocumentId.GetHashCode();
                if (this.FeedOptions != null)
                    hashCode = hashCode * 59 + this.FeedOptions.GetHashCode();
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
