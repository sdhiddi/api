/* 
 * Tradovate API
 *
 * Tradovate API
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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

namespace Tradovate.Services.Model
{
    /// <summary>
    /// OHLC
    /// </summary>
    [DataContract]
    public partial class OHLC :  IEquatable<OHLC>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OHLC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OHLC() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OHLC" /> class.
        /// </summary>
        /// <param name="Timestamp">Timestamp (required).</param>
        /// <param name="Open">Open (required).</param>
        /// <param name="High">High (required).</param>
        /// <param name="Low">Low (required).</param>
        /// <param name="Close">Close (required).</param>
        /// <param name="UpVolume">UpVolume (required).</param>
        /// <param name="DownVolume">DownVolume (required).</param>
        /// <param name="UpTicks">UpTicks (required).</param>
        /// <param name="DownTicks">DownTicks (required).</param>
        /// <param name="Histogram">Histogram.</param>
        /// <param name="BidVolume">BidVolume.</param>
        /// <param name="OfferVolume">OfferVolume.</param>
        public OHLC(DateTime? Timestamp = default(DateTime?), double? Open = default(double?), double? High = default(double?), double? Low = default(double?), double? Close = default(double?), int? UpVolume = default(int?), int? DownVolume = default(int?), int? UpTicks = default(int?), int? DownTicks = default(int?), string Histogram = default(string), int? BidVolume = default(int?), int? OfferVolume = default(int?))
        {
            // to ensure "Timestamp" is required (not null)
            if (Timestamp == null)
            {
                throw new InvalidDataException("Timestamp is a required property for OHLC and cannot be null");
            }
            else
            {
                this.Timestamp = Timestamp;
            }
            // to ensure "Open" is required (not null)
            if (Open == null)
            {
                throw new InvalidDataException("Open is a required property for OHLC and cannot be null");
            }
            else
            {
                this.Open = Open;
            }
            // to ensure "High" is required (not null)
            if (High == null)
            {
                throw new InvalidDataException("High is a required property for OHLC and cannot be null");
            }
            else
            {
                this.High = High;
            }
            // to ensure "Low" is required (not null)
            if (Low == null)
            {
                throw new InvalidDataException("Low is a required property for OHLC and cannot be null");
            }
            else
            {
                this.Low = Low;
            }
            // to ensure "Close" is required (not null)
            if (Close == null)
            {
                throw new InvalidDataException("Close is a required property for OHLC and cannot be null");
            }
            else
            {
                this.Close = Close;
            }
            // to ensure "UpVolume" is required (not null)
            if (UpVolume == null)
            {
                throw new InvalidDataException("UpVolume is a required property for OHLC and cannot be null");
            }
            else
            {
                this.UpVolume = UpVolume;
            }
            // to ensure "DownVolume" is required (not null)
            if (DownVolume == null)
            {
                throw new InvalidDataException("DownVolume is a required property for OHLC and cannot be null");
            }
            else
            {
                this.DownVolume = DownVolume;
            }
            // to ensure "UpTicks" is required (not null)
            if (UpTicks == null)
            {
                throw new InvalidDataException("UpTicks is a required property for OHLC and cannot be null");
            }
            else
            {
                this.UpTicks = UpTicks;
            }
            // to ensure "DownTicks" is required (not null)
            if (DownTicks == null)
            {
                throw new InvalidDataException("DownTicks is a required property for OHLC and cannot be null");
            }
            else
            {
                this.DownTicks = DownTicks;
            }
            this.Histogram = Histogram;
            this.BidVolume = BidVolume;
            this.OfferVolume = OfferVolume;
        }
        
        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }
        /// <summary>
        /// Gets or Sets Open
        /// </summary>
        [DataMember(Name="open", EmitDefaultValue=false)]
        public double? Open { get; set; }
        /// <summary>
        /// Gets or Sets High
        /// </summary>
        [DataMember(Name="high", EmitDefaultValue=false)]
        public double? High { get; set; }
        /// <summary>
        /// Gets or Sets Low
        /// </summary>
        [DataMember(Name="low", EmitDefaultValue=false)]
        public double? Low { get; set; }
        /// <summary>
        /// Gets or Sets Close
        /// </summary>
        [DataMember(Name="close", EmitDefaultValue=false)]
        public double? Close { get; set; }
        /// <summary>
        /// Gets or Sets UpVolume
        /// </summary>
        [DataMember(Name="upVolume", EmitDefaultValue=false)]
        public int? UpVolume { get; set; }
        /// <summary>
        /// Gets or Sets DownVolume
        /// </summary>
        [DataMember(Name="downVolume", EmitDefaultValue=false)]
        public int? DownVolume { get; set; }
        /// <summary>
        /// Gets or Sets UpTicks
        /// </summary>
        [DataMember(Name="upTicks", EmitDefaultValue=false)]
        public int? UpTicks { get; set; }
        /// <summary>
        /// Gets or Sets DownTicks
        /// </summary>
        [DataMember(Name="downTicks", EmitDefaultValue=false)]
        public int? DownTicks { get; set; }
        /// <summary>
        /// Gets or Sets Histogram
        /// </summary>
        [DataMember(Name="histogram", EmitDefaultValue=false)]
        public string Histogram { get; set; }
        /// <summary>
        /// Gets or Sets BidVolume
        /// </summary>
        [DataMember(Name="bidVolume", EmitDefaultValue=false)]
        public int? BidVolume { get; set; }
        /// <summary>
        /// Gets or Sets OfferVolume
        /// </summary>
        [DataMember(Name="offerVolume", EmitDefaultValue=false)]
        public int? OfferVolume { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OHLC {\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Open: ").Append(Open).Append("\n");
            sb.Append("  High: ").Append(High).Append("\n");
            sb.Append("  Low: ").Append(Low).Append("\n");
            sb.Append("  Close: ").Append(Close).Append("\n");
            sb.Append("  UpVolume: ").Append(UpVolume).Append("\n");
            sb.Append("  DownVolume: ").Append(DownVolume).Append("\n");
            sb.Append("  UpTicks: ").Append(UpTicks).Append("\n");
            sb.Append("  DownTicks: ").Append(DownTicks).Append("\n");
            sb.Append("  Histogram: ").Append(Histogram).Append("\n");
            sb.Append("  BidVolume: ").Append(BidVolume).Append("\n");
            sb.Append("  OfferVolume: ").Append(OfferVolume).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as OHLC);
        }

        /// <summary>
        /// Returns true if OHLC instances are equal
        /// </summary>
        /// <param name="other">Instance of OHLC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OHLC other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    this.Open == other.Open ||
                    this.Open != null &&
                    this.Open.Equals(other.Open)
                ) && 
                (
                    this.High == other.High ||
                    this.High != null &&
                    this.High.Equals(other.High)
                ) && 
                (
                    this.Low == other.Low ||
                    this.Low != null &&
                    this.Low.Equals(other.Low)
                ) && 
                (
                    this.Close == other.Close ||
                    this.Close != null &&
                    this.Close.Equals(other.Close)
                ) && 
                (
                    this.UpVolume == other.UpVolume ||
                    this.UpVolume != null &&
                    this.UpVolume.Equals(other.UpVolume)
                ) && 
                (
                    this.DownVolume == other.DownVolume ||
                    this.DownVolume != null &&
                    this.DownVolume.Equals(other.DownVolume)
                ) && 
                (
                    this.UpTicks == other.UpTicks ||
                    this.UpTicks != null &&
                    this.UpTicks.Equals(other.UpTicks)
                ) && 
                (
                    this.DownTicks == other.DownTicks ||
                    this.DownTicks != null &&
                    this.DownTicks.Equals(other.DownTicks)
                ) && 
                (
                    this.Histogram == other.Histogram ||
                    this.Histogram != null &&
                    this.Histogram.Equals(other.Histogram)
                ) && 
                (
                    this.BidVolume == other.BidVolume ||
                    this.BidVolume != null &&
                    this.BidVolume.Equals(other.BidVolume)
                ) && 
                (
                    this.OfferVolume == other.OfferVolume ||
                    this.OfferVolume != null &&
                    this.OfferVolume.Equals(other.OfferVolume)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                if (this.Open != null)
                    hash = hash * 59 + this.Open.GetHashCode();
                if (this.High != null)
                    hash = hash * 59 + this.High.GetHashCode();
                if (this.Low != null)
                    hash = hash * 59 + this.Low.GetHashCode();
                if (this.Close != null)
                    hash = hash * 59 + this.Close.GetHashCode();
                if (this.UpVolume != null)
                    hash = hash * 59 + this.UpVolume.GetHashCode();
                if (this.DownVolume != null)
                    hash = hash * 59 + this.DownVolume.GetHashCode();
                if (this.UpTicks != null)
                    hash = hash * 59 + this.UpTicks.GetHashCode();
                if (this.DownTicks != null)
                    hash = hash * 59 + this.DownTicks.GetHashCode();
                if (this.Histogram != null)
                    hash = hash * 59 + this.Histogram.GetHashCode();
                if (this.BidVolume != null)
                    hash = hash * 59 + this.BidVolume.GetHashCode();
                if (this.OfferVolume != null)
                    hash = hash * 59 + this.OfferVolume.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
