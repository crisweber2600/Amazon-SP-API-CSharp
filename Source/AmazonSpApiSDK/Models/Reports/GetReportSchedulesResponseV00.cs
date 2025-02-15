/* 
 * Selling Partner API for Reports
 *
 * The Selling Partner API for Reports lets you retrieve and manage a variety of reports that can help selling partners manage their businesses.
 *
 * OpenAPI spec version: 2020-09-04
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace AmazonSpApiSDK.Models.Reports
{
    /// <summary>
    /// The response for the getReportSchedules operation.
    /// </summary>
    [DataContract]
    public partial class GetReportSchedulesResponseV00 : IEquatable<GetReportSchedulesResponseV00>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportSchedulesResponseV00" /> class.
        /// </summary>
        /// <param name="ReportSchedules">The ReportSchedules for the getReportSchedules operation..</param>
        /// <param name="Errors">Errors.</param>
        public GetReportSchedulesResponseV00(ReportScheduleList ReportSchedules = default(ReportScheduleList), ErrorList Errors = default(ErrorList))
        {
            this.ReportSchedules = ReportSchedules;
            this.Errors = Errors;
        }
        public GetReportSchedulesResponseV00()
        {
            this.ReportSchedules = default(ReportScheduleList);
            this.Errors = default(ErrorList);
        }
        /// <summary>
        /// The ReportSchedules for the getReportSchedules operation.
        /// </summary>
        /// <value>The ReportSchedules for the getReportSchedules operation.</value>
        [DataMember(Name = "reportSchedules", EmitDefaultValue = false)]
        public ReportScheduleList ReportSchedules { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public ErrorList Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetReportSchedulesResponseV00 {\n");
            sb.Append("  ReportSchedules: ").Append(ReportSchedules).Append("\n");
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
            return this.Equals(input as GetReportSchedulesResponseV00);
        }

        /// <summary>
        /// Returns true if GetReportSchedulesResponseV00 instances are equal
        /// </summary>
        /// <param name="input">Instance of GetReportSchedulesResponseV00 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetReportSchedulesResponseV00 input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ReportSchedules == input.ReportSchedules ||
                    (this.ReportSchedules != null &&
                    this.ReportSchedules.Equals(input.ReportSchedules))
                ) &&
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
                if (this.ReportSchedules != null)
                    hashCode = hashCode * 59 + this.ReportSchedules.GetHashCode();
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
