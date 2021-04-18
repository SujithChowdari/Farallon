using MyPortfolio.BusinessLogic.Interfaces;
using MyPortfolio.DataAccess.Interfaces;
using MyPortfolio.DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPortfolio.BusinessLogic.Implementations
{
    public class TradesBusinessLogic : ITradesBusinessLogic
    {
        private ITradesRepository _tradesRepository;
        public TradesBusinessLogic(ITradesRepository tradesRepository)
        {
            _tradesRepository = tradesRepository;
        }
        /// <summary>
        /// Get all the trades from the store
        /// </summary>
        /// <returns>Trade collection</returns>
        public async Task<List<Trade>> GetTrades(int portfolioId)
        {
            return await _tradesRepository.GetTrades(portfolioId);
        }

        /// <summary>
        /// Adds a new trade
        /// </summary>
        /// <param name="newTrade">Trade object</param>
        /// <returns></returns>
        public async Task Add(int portfolioId, Trade newTrade)
        {
            await _tradesRepository.Add(portfolioId, newTrade);
        }
    }
}
