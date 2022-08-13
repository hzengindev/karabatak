using Domain.Features.Company.DTOs;
using MediatR;

namespace Domain.Features.Company.Queries
{
    public class GetCompanies : IRequest<GetCompaniesDTO>
    {
    }
}
