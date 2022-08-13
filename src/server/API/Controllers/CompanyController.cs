using Domain.Features.Company.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/companies")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly IMediator _mediator;
        
        public CompanyController(IMediator mediator)
        {
            _mediator = mediator;
            
        }


        [HttpGet()]
        public async Task<IActionResult> GetCompanies()
        {
            var result = await _mediator.Send(new GetCompanies());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCompanyById([FromRoute] Guid id)
        {
            var result = await _mediator.Send(new GetCompanyById() { Id = id });
            return Ok(result);
        }


        [HttpGet("{id}/branches")]
        public async Task<IActionResult> GetBranchesByCompanyId([FromRoute] Guid id)
        {
            var result = await _mediator.Send(new GetBranchesByCompanyId() { CompanyId = id });
            return Ok(result);
        }
    }
}
