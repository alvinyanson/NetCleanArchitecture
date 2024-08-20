
using NetCleanArchitecture.Core.Models;
using System.Net.Http.Json;

namespace NetCleanArchitecture.Infrastructure.Services
{
    public class CoindeskHttpClientService : ICoindeskHttpClientService
    {
        private readonly HttpClient _httpClient;

        public CoindeskHttpClientService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<CoindeskData> GetData()
        {
            return await _httpClient.GetFromJsonAsync<CoindeskData>("bpi/currentprice.json");
        }
    }
}
