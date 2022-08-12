using Entities;

namespace Business.Handlers.Branch.DTOs
{
    public class GetBranchByIdDTO
    {
        public BranchDTO Branch { get; set; } = new BranchDTO();
    }
}
