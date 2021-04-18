using MyPortfolio.DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPortfolio.DataAccess.Interfaces
{
    public interface IPortfolioPerformanceRepository
    {
        public Task<PortfolioPerformanceSummary> GetTradesPerformanceSummary(List<Trade> trades);
    }
}
