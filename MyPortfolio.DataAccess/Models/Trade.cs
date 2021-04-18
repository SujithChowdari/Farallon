using System;
using System.ComponentModel;

namespace MyPortfolio.DataAccess.Models
{
    public class Trade
    {
        [Browsable(false)]
        public int Id { get; set; }

        public string Ticker { get; set; }

        [DisplayName("Trade Date")]
        public DateTime TradeDate { get; set; }

        [DisplayName("Buy/Sell")]
        public TradeType TradeType { get; set; }

        public int Quantity { get; set; }

        public float Price { get; set; }

        /// <summary>
        /// This is added to address the use case of allowing "Sell" which this app not supporting now
        /// </summary>
        [Browsable(false)]
        public int ParentTradeId { get; set; }

        public float Cost { get { return Quantity * Price; } }

        [Browsable(false)]
        public int PortfolioId { get; set; }
    }
}
