using DataAccess.Entities;

namespace Domain.Features.Branch.DTOs
{
    public class GetBranchByIdDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public BranchStatus Status { get; set; }
        public CompanyDTO Company { get; set; }


        public class CompanyDTO
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
        }
    }
}
