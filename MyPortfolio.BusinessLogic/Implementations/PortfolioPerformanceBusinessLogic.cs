using MyPortfolio.BusinessLogic.Interfaces;
using MyPortfolio.DataAccess.Interfaces;
using MyPortfolio.DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPortfolio.BusinessLogic.Implementations
{
    public class PortfolioPerformanceBusinessLogic: IPortfolioPerformanceBusinessLogic
    {
        private IPortfolioPerformanceRepository _portfolioPerformanceRepository;
        public PortfolioPerformanceBusinessLogic(IPortfolioPerformanceRepository portfolioPerformanceRepository)
        {
            _portfolioPerformanceRepository = portfolioPerformanceRepository;
        }
        public async Task<PortfolioPerformanceSummary> GetTradesPerformanceSummary(List<Trade> trades)
        {
           return await _portfolioPerformanceRepository.GetTradesPerformanceSummary(trades);
        }
    }
}
