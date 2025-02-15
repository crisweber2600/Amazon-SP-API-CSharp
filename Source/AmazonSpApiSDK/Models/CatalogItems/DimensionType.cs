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
    /// The dimension type attribute of an item.
    /// </summary>
    [DataContract]
    public partial class DimensionType : IEquatable<DimensionType>, IValidatableObject
    {
        public DimensionType()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DimensionType" /> class.
        /// </summary>
        /// <param name="Height">The height attribute of the dimension..</param>
        /// <param name="Length">The length attribute of the dimension..</param>
        /// <param name="Width">The width attribute of the dimension..</param>
        /// <param name="Weight">The weight attribute of the dimension..</param>
        public DimensionType(DecimalWithUnits Height = default(DecimalWithUnits), DecimalWithUnits Length = default(DecimalWithUnits), DecimalWithUnits Width = default(DecimalWithUnits), DecimalWithUnits Weight = default(DecimalWithUnits))
        {
            this.Height = Height;
            this.Length = Length;
            this.Width = Width;
            this.Weight = Weight;
        }

        /// <summary>
        /// The height attribute of the dimension.
        /// </summary>
        /// <value>The height attribute of the dimension.</value>
        [DataMember(Name = "Height", EmitDefaultValue = false)]
        public DecimalWithUnits Height { get; set; }

        /// <summary>
        /// The length attribute of the dimension.
        /// </summary>
        /// <value>The length attribute of the dimension.</value>
        [DataMember(Name = "Length", EmitDefaultValue = false)]
        public DecimalWithUnits Length { get; set; }

        /// <summary>
        /// The width attribute of the dimension.
        /// </summary>
        /// <value>The width attribute of the dimension.</value>
        [DataMember(Name = "Width", EmitDefaultValue = false)]
        public DecimalWithUnits Width { get; set; }

        /// <summary>
        /// The weight attribute of the dimension.
        /// </summary>
        /// <value>The weight attribute of the dimension.</value>
        [DataMember(Name = "Weight", EmitDefaultValue = false)]
        public DecimalWithUnits Weight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DimensionType {\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
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
            return this.Equals(input as DimensionType);
        }

        /// <summary>
        /// Returns true if DimensionType instances are equal
        /// </summary>
        /// <param name="input">Instance of DimensionType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DimensionType input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) &&
                (
                    this.Length == input.Length ||
                    (this.Length != null &&
                    this.Length.Equals(input.Length))
                ) &&
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
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
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Length != null)
                    hashCode = hashCode * 59 + this.Length.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
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
