using Domain.Features.Company.DTOs;
using MediatR;

namespace Domain.Features.Company.Queries
{
    public class GetCompanyById : IRequest<GetCompanyByIdDTO>
    {
        public Guid Id { get; set; }
    }
}
