using Business.Handlers.Branch.Queries;
using DataAccess;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Business.Handlers.Branch.QueryHandlers
{
    public class GetBranchesByCompanyIdHandler : IRequestHandler<GetBranchesByCompanyId, List<string>>
    {
        private readonly AppDbContext _ctx;

        public GetBranchesByCompanyIdHandler(AppDbContext appDbContext)
        {
            _ctx = appDbContext;
        }

        public async Task<List<string>> Handle(GetBranchesByCompanyId request, CancellationToken cancellationToken)
        {
            var branches = await _ctx.Branches.Where(z => z.CompanyId == request.CompanyId).ToListAsync();
            return branches.Select(z => z.Name).ToList();
        }
    }
}
