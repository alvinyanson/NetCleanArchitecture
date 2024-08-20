
using MediatR;
using NetCleanArchitecture.Core.Interfaces;
using NetCleanArchitecture.Core.Models;

namespace NetCleanArchitecture.Application.Queries
{
    public record GetJokeDataQuery() : IRequest<JokeData>;

    public class GetJokeDataQueryHandler(IExternalVendorRepository externalVendorRepository) : IRequestHandler<GetJokeDataQuery, JokeData>
    {
        public async Task<JokeData> Handle(GetJokeDataQuery request, CancellationToken cancellationToken)
        {
            return await externalVendorRepository.GetJokeData();
        }
    }
}
