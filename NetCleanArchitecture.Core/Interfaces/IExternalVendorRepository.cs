
using NetCleanArchitecture.Core.Models;

namespace NetCleanArchitecture.Core.Interfaces
{
    public interface IExternalVendorRepository
    {
        Task<CoindeskData> GetData();

        Task<JokeData> GetJokeData();
    }
}
