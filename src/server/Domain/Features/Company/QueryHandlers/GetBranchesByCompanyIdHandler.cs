using Domain.Features.Company.Queries;
using DataAccess;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Domain.Features.Company.DTOs;

namespace Domain.Features.Company.QueryHandlers
{
    public class GetBranchesByCompanyIdHandler : IRequestHandler<GetBranchesByCompanyId, GetBranchesByCompanyIdDTO>
    {
        private readonly AppDbContext _ctx;

        public GetBranchesByCompanyIdHandler(AppDbContext appDbContext)
        {
            _ctx = appDbContext;
        }

        public async Task<GetBranchesByCompanyIdDTO> Handle(GetBranchesByCompanyId request, CancellationToken cancellationToken)
        {
            var branches = await _ctx.Branches
                .AsNoTracking()
                .Where(z => z.CompanyId == request.CompanyId)
                .ToListAsync();

            GetBranchesByCompanyIdDTO result = new GetBranchesByCompanyIdDTO();
            result.Branches = branches.ConvertAll(z => new GetBranchesByCompanyIdDTO.BranchDTO
            {
                Id = z.Id,
                Name = z.Name,
                Status = z.Status
            });

            return result;
        }
    }
}
