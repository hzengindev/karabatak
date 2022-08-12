using MediatR;

namespace Business.Handlers.Company.Queries
{
    public class GetBranchesByCompanyId : IRequest<List<string>>
    {
        public Guid CompanyId { get; set; }
    }
}
