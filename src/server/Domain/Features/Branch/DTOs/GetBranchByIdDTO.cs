using Entities;

namespace Domain.Features.Branch.DTOs
{
    public class GetBranchByIdDTO
    {
        public BranchDTO Branch { get; set; } = new BranchDTO();
    }
}
