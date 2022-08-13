using Domain.Features.Company.Queries;
using DataAccess;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Domain.Features.Company.DTOs;

namespace Domain.Features.Company.QueryHandlers
{
    public class GetCompaniesHandler : IRequestHandler<GetCompanies, GetCompaniesDTO>
    {
        private readonly AppDbContext _ctx;

        public GetCompaniesHandler(AppDbContext appDbContext)
        {
            _ctx = appDbContext;
        }

        public async Task<GetCompaniesDTO> Handle(GetCompanies request, CancellationToken cancellationToken)
        {
            var branches = await _ctx.Companies.AsNoTracking().ToListAsync();

            GetCompaniesDTO result = new GetCompaniesDTO();
            result.Companies = branches.ConvertAll(z => new CompanyDTO
            {
                Id = z.Id,
                Name = z.Name,
                APIKey = z.APIKey,
                UnitPrice = z.UnitPrice,
                Status = z.Status
            });

            return result;
        }
    }
}
