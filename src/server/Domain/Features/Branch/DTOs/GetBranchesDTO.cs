using DataAccess.Entities;

namespace Domain.Features.Branch.DTOs
{
    public class GetBranchesDTO
    {
        public List<BranchDTO> Branches { get; set; } = new List<BranchDTO>();

        public class BranchDTO
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public BranchStatus Status { get; set; }
            public CompanyDTO Company { get; set; }
        }

        public class CompanyDTO
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
        }
    }
}
