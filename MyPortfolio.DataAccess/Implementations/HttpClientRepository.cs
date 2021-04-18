using MyPortfolio.DataAccess.Interfaces;
using Newtonsoft.Json;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyPortfolio.DataAccess.Implementations
{
    public class HttpClientRepository: IHttpClientRepository
    {
        static HttpClient client = new HttpClient();
        public async Task<T> GetAsync<T>(string url)
        {
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var contentStream = await response.Content.ReadAsStreamAsync();

                using (var streamReader = new StreamReader(contentStream))
                {
                    using (var jsonReader = new JsonTextReader(streamReader))
                    {
                        JsonSerializer serializer = new JsonSerializer();

                        try
                        {
                           return serializer.Deserialize<T>(jsonReader);                            
                        }
                        catch (JsonReaderException)
                        {
                            throw; // This depends on how we want to bubble up errors in the application
                            // log the exception details
                        }
                    }
                }
            }

            return default;
        }
    }
}
