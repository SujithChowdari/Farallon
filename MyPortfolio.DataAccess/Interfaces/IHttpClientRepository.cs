using System.Threading.Tasks;

namespace MyPortfolio.DataAccess.Interfaces
{
    public interface IHttpClientRepository
    {
        public Task<T> GetAsync<T>(string url);
    }
}
