using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tenders.Api.Application.Queries;
using Tenders.Api.Contracts.Endpoints;

namespace Tenders.Api.Controllers
{
    [ApiController]
    [Route("api/tenders")]
    public class TendersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TendersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("")]
        public async Task<IActionResult> FilterTendersAsync(GetTendersFilteredParameters parameters)
        {
            if (!ModelState.IsValid)
                return ValidationProblem(ModelState);

            var query = new FilterTendersQuery(parameters);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTender(GetTenderParameters parameters)
        {
            var query = new GetTenderQuery(parameters);
            var result = await _mediator.Send(query);

            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}
