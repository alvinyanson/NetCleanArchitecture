using MediatR;
using NetCleanArchitecture.Core.Interfaces;
using NetCleanArchitecture.Core.Models;

namespace NetCleanArchitecture.Application.Queries
{
    public record GetCoinDeskDataQuery() : IRequest<CoindeskData>;

    public class GetCoinDeskDataQueryHandler(IExternalVendorRepository externalVendorRepository) : IRequestHandler<GetCoinDeskDataQuery, CoindeskData>
    {
        public async Task<CoindeskData> Handle(GetCoinDeskDataQuery request, CancellationToken cancellationToken)
        {
            return await externalVendorRepository.GetData();
        }
    }
}
