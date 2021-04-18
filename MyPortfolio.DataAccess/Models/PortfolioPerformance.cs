using System;
using System.ComponentModel;

namespace MyPortfolio.DataAccess.Models
{
    public class PortfolioPerformance
    {
        public string Ticker { get; set; }

        public DateTime Date { get; set; }

        public float Cost { get; set; }

        public int Quantity { get; set; }       

        [DisplayName("Price")]
        public float CurrentPrice { get; set; }


        [DisplayName("Prev Close")]
        public float PreviousClosePrice { get; set; }


        [DisplayName("Market Value")]
        public float MarketValue 
        {
            get { return CurrentPrice * Quantity; }
        }

        [Browsable(false)]
        public float MarketValueAtPreviousClose
        {
            get { return PreviousClosePrice * Quantity; }
        }

        [DisplayName("Daily P&L")]
        public float DailyProfitAndLoss
        {
            get { return MarketValue - MarketValueAtPreviousClose; }
        }

        [DisplayName("Inception P&L")]
        public float InceptionProfitAndLoss
        {
            get { return MarketValue - Cost; }
        }
    }
}
