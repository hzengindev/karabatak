using Business.Handlers.Company.Queries;
using DataAccess;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Business.Handlers.Company.QueryHandlers
{
    public class GetCompaniesHandler : IRequestHandler<GetCompanies, List<string>>
    {
        private readonly AppDbContext _ctx;

        public GetCompaniesHandler(AppDbContext appDbContext)
        {
            _ctx = appDbContext;
        }

        public async Task<List<string>> Handle(GetCompanies request, CancellationToken cancellationToken)
        {
            var branches = await _ctx.Companies.ToListAsync();
            return branches.Select(z => z.Name).ToList();
        }
    }
}
