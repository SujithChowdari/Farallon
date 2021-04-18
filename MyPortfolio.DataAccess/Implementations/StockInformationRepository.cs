using MyPortfolio.DataAccess.Interfaces;
using MyPortfolio.DataAccess.Models;
using System.Configuration;
using System.Threading.Tasks;

namespace MyPortfolio.DataAccess.Implementations
{   
    public class StockInformationRepository: IStockInformationRepository
    {
        private string ApiKey;
        private string BaseApiUrl;
        private IHttpClientRepository _httpClientRepository;


        public StockInformationRepository(IHttpClientRepository httpClientRepository)
        {
            _httpClientRepository = httpClientRepository;

            ApiKey = ConfigurationManager.AppSettings["ApiKey"];
            BaseApiUrl = ConfigurationManager.AppSettings["BaseApiUrl"] + $"&apikey={ApiKey}";
        }

        public async Task<StockQuote> GetStockQuote(string ticker)
        {
            var quote = await _httpClientRepository.GetAsync<Quote>(BaseApiUrl + $"&symbol={ticker}");

            if (quote != null) return quote.StockQuote;

            return null;
        }

    }
}
