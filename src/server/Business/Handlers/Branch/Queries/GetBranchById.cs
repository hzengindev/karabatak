using Business.Handlers.Branch.DTOs;
using MediatR;

namespace Business.Handlers.Branch.Queries
{
    public class GetBranchById : IRequest<GetBranchByIdDTO>
    {
        public Guid Id { get; set; }
    }
}
