using Entities;

namespace Business.Handlers.Branch.DTOs
{
    public class BranchDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public BranchStatus Status { get; set; }
        public CompanyDTO Company { get; set; }
    }
}
