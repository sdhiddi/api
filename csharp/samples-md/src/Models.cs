﻿/* 
 * 
 * Tradovate API, MarketData Samples
 *
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Tradovate.Services.Model;

namespace Tradovate.MarketData.Models
{
    [DataContract]
    public class ChartData
    {
        [DataMember(Name = "charts", EmitDefaultValue = false)]
        public List<Chart> Charts { get; set; }
    }

    [DataContract]
    public class Chart
    {
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public int Id { get; set; }

        [DataMember(Name = "td", EmitDefaultValue = true)]
        public int TradeDate { get; set; }

        [DataMember(Name = "bars", EmitDefaultValue = false)]
        public List<OHLC> Bars { get; set; }
    }

    [DataContract]
    public class HistogramData
    {
        [DataMember(Name = "histograms", EmitDefaultValue = false)]
        public List<Histogram> Histograms { get; set; }
    }

    [DataContract]
    public class DOMData
    {
        [DataMember(Name = "doms", EmitDefaultValue = false)]
        public List<DOM> Doms { get; set; }
    }

    [DataContract]
    public class QuoteData
    {
        [DataMember(Name = "quotes", EmitDefaultValue = false)]
        public List<Quote> Quotes { get; set; }
    }

    [DataContract]
    public class Quote
    {
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public DateTime Timestamp { get; set; }

        [DataMember(Name = "contractId", EmitDefaultValue = false)]
        public int ContractId { get; set; }

        [DataMember(Name = "entries", EmitDefaultValue = false)]
        public QuoteEntries Entries { get; set; }
    }

    [DataContract]
    public class QuoteEntries
    {
        [DataMember(EmitDefaultValue = false)]
        public PriceLevel Bid { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public PriceLevel Offer { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public PriceLevel Trade { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public PriceLevel OpeningPrice { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public PriceLevel SettlementPrice { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public PriceLevel TotalTradeVolume { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public PriceLevel EmptyBook { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public PriceLevel OpenInterest { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public PriceLevel HighPrice { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public PriceLevel LowPrice { get; set; }
    }
}
