using MyPortfolio.DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPortfolio.DataAccess.Interfaces
{
    public interface IPortfolioRepository
    {
        public Task<List<Portfolio>> GetPortfolios();
        public Task<Portfolio> GetPortfolio(int Id);
        public Task Add(Portfolio newPortfolio);
    }
}
