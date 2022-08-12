using Business.Handlers.Branch.DTOs;
using Business.Handlers.Branch.Queries;
using DataAccess;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Business.Handlers.Branch.QueryHandlers
{
    public class GetBranchByIdHandler : IRequestHandler<GetBranchById, GetBranchByIdDTO>
    {
        private readonly AppDbContext _ctx;

        public GetBranchByIdHandler(AppDbContext appDbContext)
        {
            _ctx = appDbContext;
        }

        public async Task<GetBranchByIdDTO> Handle(GetBranchById request, CancellationToken cancellationToken)
        {
            var branch = await _ctx.Branches
                .AsNoTracking()
                .Include(z => z.Company)
                .FirstOrDefaultAsync(z => z.Id == request.Id);

            if (branch is null)
                throw new Exception("There is no branch.");

            GetBranchByIdDTO result = new GetBranchByIdDTO();
            result.Branch = new BranchDTO
            {
                Id = branch.Id,
                Name = branch.Name,
                Status = branch.Status,
                Company = branch.Company is not null ? new CompanyDTO
                {
                    Id = branch.Company.Id,
                    Name = branch.Company.Name
                } : null
            };

            return result;
        }
    }
}
