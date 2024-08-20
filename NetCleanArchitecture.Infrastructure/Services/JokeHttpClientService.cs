
using NetCleanArchitecture.Core.Models;
using System.Net.Http.Json;

namespace NetCleanArchitecture.Infrastructure.Services
{
    public class JokeHttpClientService : IJokeHttpClientService
    {
        private readonly HttpClient _httpClient;

        public JokeHttpClientService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<JokeData> GetData()
        {
            return await _httpClient.GetFromJsonAsync<JokeData>("random_joke");
        }
    }
}
