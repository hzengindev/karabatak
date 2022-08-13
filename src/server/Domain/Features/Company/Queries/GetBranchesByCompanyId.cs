using MediatR;

namespace Domain.Features.Company.Queries
{
    public class GetBranchesByCompanyId : IRequest<List<string>>
    {
        public Guid CompanyId { get; set; }
    }
}
