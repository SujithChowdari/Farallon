using MyPortfolio.DataAccess.Interfaces;
using MyPortfolio.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.DataAccess.Implementations
{
    public class PortfolioPerformanceRepository: IPortfolioPerformanceRepository
    {
        private IStockInformationRepository _stockInformationRepository;
        public PortfolioPerformanceRepository(IStockInformationRepository stockInformationRepository)
        {
            _stockInformationRepository = stockInformationRepository;
        }

        /// <summary>
        /// This method is to consolidated all the trade entries and get/set each symbol's current and previous close price
        /// </summary>
        /// <param name="trades">list of trades in current portfolio</param>
        /// <returns>portfolio performance summary</returns>
        public async Task<PortfolioPerformanceSummary> GetTradesPerformanceSummary(List<Trade> trades)
        {
            var portfolioPerformanceSummary = new PortfolioPerformanceSummary();
            Dictionary<string, PortfolioPerformance> portfolioPerformances = new Dictionary<string, PortfolioPerformance>();

            for(int i=0; i<trades.Count; i++)
            { 
                var ticker = trades[i].Ticker;
                if (!portfolioPerformances.ContainsKey(ticker))
                {
                    portfolioPerformances.Add(ticker, new PortfolioPerformance()
                    {
                        Ticker = ticker,
                        Cost = trades[i].Cost,
                        Quantity = trades[i].Quantity,
                        Date = DateTime.Now,
                    });
                }
                else
                {
                    var existingPortfolioPerformanceData = portfolioPerformances[ticker];
                    existingPortfolioPerformanceData.Cost += trades[i].Cost;
                    existingPortfolioPerformanceData.Quantity += trades[i].Quantity;
                }
            }
            
            // Get PrevClose and Current price for each ticker/symbol
            foreach(var ticker in portfolioPerformances.Keys)
            {
                var tickerStockData = await _stockInformationRepository.GetStockQuote(ticker);
                if(tickerStockData != null)
                {
                    portfolioPerformances[ticker].CurrentPrice = tickerStockData.CurrentPrice;
                    portfolioPerformances[ticker].PreviousClosePrice = tickerStockData.PreviousClosePrice;
                }               
            }

            portfolioPerformanceSummary.PortfolioPerformances = portfolioPerformances.Values.ToList();
            return portfolioPerformanceSummary;
        }
    }
}
