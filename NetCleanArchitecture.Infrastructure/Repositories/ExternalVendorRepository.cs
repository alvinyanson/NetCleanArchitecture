
using NetCleanArchitecture.Core.Interfaces;
using NetCleanArchitecture.Core.Models;
using NetCleanArchitecture.Infrastructure.Services;

namespace NetCleanArchitecture.Infrastructure.Repositories
{
    public class ExternalVendorRepository : IExternalVendorRepository
    {
        private readonly ICoindeskHttpClientService _coindeskHttpClientService;
        private readonly IJokeHttpClientService _jokeHttpClientService;

        public ExternalVendorRepository(ICoindeskHttpClientService coindeskHttpClientService, IJokeHttpClientService jokeHttpClientService)
        {
            _coindeskHttpClientService = coindeskHttpClientService;
            _jokeHttpClientService = jokeHttpClientService;
        }

        public async Task<CoindeskData> GetData()
        {
            return await _coindeskHttpClientService.GetData();
        }

        public async Task<JokeData> GetJokeData()
        {
            return await _jokeHttpClientService.GetData();
        }
    }
}
