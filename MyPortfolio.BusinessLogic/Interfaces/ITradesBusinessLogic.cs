using MyPortfolio.DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPortfolio.BusinessLogic.Interfaces
{
    public interface ITradesBusinessLogic
    {
        public Task<List<Trade>> GetTrades(int portfolioId);
        public Task Add(int portfolioId,Trade newTrade);
    }
}
