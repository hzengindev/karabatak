using MediatR;

namespace Business.Handlers.Branch.Queries
{
    public class GetBranchesByCompanyId : IRequest<List<string>>
    {
        public Guid CompanyId { get; set; }
    }
}
