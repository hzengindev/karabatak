using Domain.Features.Company.Queries;
using DataAccess;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Domain.Features.Company.DTOs;

namespace Domain.Features.Company.QueryHandlers
{
    public class GetCompanyByIdHandler : IRequestHandler<GetCompanyById, GetCompanyByIdDTO>
    {
        private readonly AppDbContext _ctx;

        public GetCompanyByIdHandler(AppDbContext appDbContext)
        {
            _ctx = appDbContext;
        }

        public async Task<GetCompanyByIdDTO> Handle(GetCompanyById request, CancellationToken cancellationToken)
        {
            var company = await _ctx.Companies
                .AsNoTracking()
                .FirstOrDefaultAsync(z => z.Id == request.Id);

            if (company is null)
                throw new Exception("There is no company.");

            GetCompanyByIdDTO result = new GetCompanyByIdDTO();
            result.Company = new CompanyDTO
            {
                Id = company.Id,
                Name = company.Name,
                APIKey = company.APIKey,
                UnitPrice = company.UnitPrice,
                Status = company.Status
            };

            return result;
        }
    }
}
