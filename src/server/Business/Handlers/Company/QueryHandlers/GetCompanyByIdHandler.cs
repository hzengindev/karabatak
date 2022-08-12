using Business.Handlers.Company.Queries;
using DataAccess;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Business.Handlers.Company.QueryHandlers
{
    public class GetCompanyByIdHandler : IRequestHandler<GetCompanyById, string>
    {
        private readonly AppDbContext _ctx;

        public GetCompanyByIdHandler(AppDbContext appDbContext)
        {
            _ctx = appDbContext;
        }

        public async Task<string> Handle(GetCompanyById request, CancellationToken cancellationToken)
        {
            var branch = await _ctx.Companies.FirstAsync(z => z.Id == request.Id);
            return branch.Name;
        }
    }
}
