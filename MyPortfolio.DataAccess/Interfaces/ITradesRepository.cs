using MyPortfolio.DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPortfolio.DataAccess.Interfaces
{
    public interface ITradesRepository
    {
        public Task<List<Trade>> GetTrades(int portfolioId);
        public Task Add(int portfolioId, Trade newTrade);
    }
}
