using MediatR;

namespace Business.Handlers.Company.Queries
{
    public class GetCompanyById : IRequest<string>
    {
        public Guid Id { get; set; }
    }
}
