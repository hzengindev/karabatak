using Domain.Features.Company.DTOs;
using MediatR;

namespace Domain.Features.Company.Queries
{
    public class GetBranchesByCompanyId : IRequest<GetBranchesByCompanyIdDTO>
    {
        public Guid CompanyId { get; set; }
    }
}
