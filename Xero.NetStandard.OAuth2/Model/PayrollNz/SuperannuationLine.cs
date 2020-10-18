/* 
 * Xero Payroll NZ
 *
 * This is the Xero Payroll API for orgs in the NZ region.
 *
 * The version of the OpenAPI document: 2.3.6
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.PayrollNz
{
    /// <summary>
    /// SuperannuationLine
    /// </summary>
    [DataContract]
    public partial class SuperannuationLine :  IEquatable<SuperannuationLine>, IValidatableObject
    {
        
        /// <summary>
        /// Xero identifier for payroll superannucation type
        /// </summary>
        /// <value>Xero identifier for payroll superannucation type</value>
        [DataMember(Name="superannuationTypeID", EmitDefaultValue=false)]
        public Guid? SuperannuationTypeID { get; set; }

        /// <summary>
        /// Benefit display name
        /// </summary>
        /// <value>Benefit display name</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The amount of the superannuation line
        /// </summary>
        /// <value>The amount of the superannuation line</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Superannuation fixed amount
        /// </summary>
        /// <value>Superannuation fixed amount</value>
        [DataMember(Name="fixedAmount", EmitDefaultValue=false)]
        public decimal? FixedAmount { get; set; }

        /// <summary>
        /// Superannuation rate percentage
        /// </summary>
        /// <value>Superannuation rate percentage</value>
        [DataMember(Name="percentage", EmitDefaultValue=false)]
        public decimal? Percentage { get; set; }

        /// <summary>
        /// manual adjustment made
        /// </summary>
        /// <value>manual adjustment made</value>
        [DataMember(Name="manualAdjustment", EmitDefaultValue=false)]
        public bool? ManualAdjustment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SuperannuationLine {\n");
            sb.Append("  SuperannuationTypeID: ").Append(SuperannuationTypeID).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  FixedAmount: ").Append(FixedAmount).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
            sb.Append("  ManualAdjustment: ").Append(ManualAdjustment).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as SuperannuationLine);
        }

        /// <summary>
        /// Returns true if SuperannuationLine instances are equal
        /// </summary>
        /// <param name="input">Instance of SuperannuationLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SuperannuationLine input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SuperannuationTypeID == input.SuperannuationTypeID ||
                    (this.SuperannuationTypeID != null &&
                    this.SuperannuationTypeID.Equals(input.SuperannuationTypeID))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.FixedAmount == input.FixedAmount ||
                    this.FixedAmount.Equals(input.FixedAmount)
                ) && 
                (
                    this.Percentage == input.Percentage ||
                    this.Percentage.Equals(input.Percentage)
                ) && 
                (
                    this.ManualAdjustment == input.ManualAdjustment ||
                    this.ManualAdjustment.Equals(input.ManualAdjustment)
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
                if (this.SuperannuationTypeID != null)
                    hashCode = hashCode * 59 + this.SuperannuationTypeID.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                hashCode = hashCode * 59 + this.Amount.GetHashCode();
                hashCode = hashCode * 59 + this.FixedAmount.GetHashCode();
                hashCode = hashCode * 59 + this.Percentage.GetHashCode();
                hashCode = hashCode * 59 + this.ManualAdjustment.GetHashCode();
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