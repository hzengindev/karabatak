using MediatR;

namespace Business.Handlers.Company.Queries
{
    public class GetCompanies : IRequest<List<string>>
    {
    }
}
