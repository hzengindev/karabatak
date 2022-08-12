using Business.Handlers.Branch.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/branches")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly IMediator _mediator;
        
        public BranchController(IMediator mediator)
        {
            _mediator = mediator;
            
        }

        [HttpGet()]
        public async Task<IActionResult> GetBranches()
        {
            var result = await _mediator.Send(new GetBranches());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBranchById([FromRoute] Guid id)
        {
            var result = await _mediator.Send(new GetBranchById() { Id = id });
            return Ok(result);
        }

        //[HttpGet("company/{id}")]
        //public async Task<IActionResult> GetBranchesByCompanyId([FromRoute] Guid id)
        //{
        //    var result = await _mediator.Send(new GetBranchesByCompanyId() { CompanyId = id });
        //    return Ok(result);
        //}
    }
}
