using MyPortfolio.BusinessLogic.Interfaces;
using MyPortfolio.DataAccess.Interfaces;
using MyPortfolio.DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPortfolio.BusinessLogic.Implementations
{
    public class PortfolioBusinessLogic : IPortfolioBusinessLogic
    {
        private IPortfolioRepository _portfolioRepository;
        public PortfolioBusinessLogic(IPortfolioRepository portfolioRepository)
        {
            _portfolioRepository = portfolioRepository;
        }
        /// <summary>
        /// Get all the Portfolio from the store
        /// </summary>
        /// <returns>Portfolio collection</returns>
        public async Task<List<Portfolio>> GetPortfolios()
        {
            return await _portfolioRepository.GetPortfolios();
        }

        /// <summary>
        /// Get a Portfolio from the store
        /// </summary>
        /// <returns>Portfolio object</returns>
        public async Task<Portfolio> GetPortfolio(int id)
        {
            return await _portfolioRepository.GetPortfolio(id);
        }

        /// <summary>
        /// Adds a new Portfolio
        /// </summary>
        /// <param name="newPortfolio">Portfolio object</param>
        /// <returns></returns>
        public async Task Add(Portfolio newPortfolio)
        {
            await _portfolioRepository.Add(newPortfolio);
        }
    }
}
