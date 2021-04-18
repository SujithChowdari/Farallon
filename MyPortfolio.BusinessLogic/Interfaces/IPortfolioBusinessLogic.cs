using MyPortfolio.DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPortfolio.BusinessLogic.Interfaces
{
    public interface IPortfolioBusinessLogic
    {
        public Task<List<Portfolio>> GetPortfolios();
        public Task<Portfolio> GetPortfolio(int id);
        public Task Add(Portfolio newPortfolio);
    }
}
