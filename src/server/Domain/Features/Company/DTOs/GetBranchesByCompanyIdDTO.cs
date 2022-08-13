using DataAccess.Entities;

namespace Domain.Features.Company.DTOs
{
    public class GetBranchesByCompanyIdDTO
    {
        public List<BranchDTO> Branches { get; set; } = new List<BranchDTO>();

        public class BranchDTO
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public BranchStatus Status { get; set; }
        }
    }
}
