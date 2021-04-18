using MyPortfolio.DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPortfolio.BusinessLogic.Interfaces
{
    public interface IPortfolioPerformanceBusinessLogic
    {
        public Task<PortfolioPerformanceSummary> GetTradesPerformanceSummary(List<Trade> trades);
    }
}
