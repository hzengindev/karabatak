using Entities;

namespace Domain.Features.Company.DTOs
{
    public class CompanyDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string APIKey { get; set; }
        public decimal UnitPrice { get; set; }
        public CompanyStatus Status { get; set; }
    }
}
