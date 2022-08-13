using Domain.Features.Branch.DTOs;
using MediatR;

namespace Domain.Features.Branch.Queries
{
    public class GetBranchById : IRequest<GetBranchByIdDTO>
    {
        public Guid Id { get; set; }
    }
}
