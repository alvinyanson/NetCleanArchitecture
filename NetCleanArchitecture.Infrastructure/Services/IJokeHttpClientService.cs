using NetCleanArchitecture.Core.Models;

namespace NetCleanArchitecture.Infrastructure.Services
{
    public interface IJokeHttpClientService
    {
        Task<JokeData> GetData();
    }
}