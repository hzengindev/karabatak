using Domain.Features.Branch.DTOs;
using MediatR;

namespace Domain.Features.Branch.Queries
{
    public class GetBranches : IRequest<GetBranchesDTO>
    {
    }   
}
