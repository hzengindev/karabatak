using Business.Handlers.Branch.DTOs;
using Business.Handlers.Branch.Queries;
using DataAccess;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Business.Handlers.Branch.QueryHandlers
{
    public class GetBranchesHandler : IRequestHandler<GetBranches, GetBranchesDTO>
    {
        private readonly AppDbContext _ctx;

        public GetBranchesHandler(AppDbContext appDbContext)
        {
            _ctx = appDbContext;
        }

        public async Task<GetBranchesDTO> Handle(GetBranches request, CancellationToken cancellationToken)
        {
            var branches = await _ctx.Branches
                .AsNoTracking()
                .Include(z => z.Company)
                .ToListAsync();

            GetBranchesDTO result = new GetBranchesDTO();
            result.Branches = branches.ConvertAll(z => new BranchDTO
            {
                Id = z.Id,
                Name = z.Name,
                Status = z.Status,
                Company = z.Company is not null ? new CompanyDTO
                {
                    Id = z.Company.Id,
                    Name = z.Company.Name
                } : null
            });

            return result;
        }
    }
}
