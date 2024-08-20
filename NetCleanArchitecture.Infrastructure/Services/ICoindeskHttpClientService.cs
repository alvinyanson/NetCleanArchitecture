using NetCleanArchitecture.Core.Models;

namespace NetCleanArchitecture.Infrastructure.Services
{
    public interface ICoindeskHttpClientService
    {
        Task<CoindeskData> GetData();
    }
}