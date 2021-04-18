using MyPortfolio.DataAccess.Models;
using System.Threading.Tasks;

namespace MyPortfolio.DataAccess.Interfaces
{
    public interface IStockInformationRepository
    {
        public Task<StockQuote> GetStockQuote(string ticker);
    }
}
