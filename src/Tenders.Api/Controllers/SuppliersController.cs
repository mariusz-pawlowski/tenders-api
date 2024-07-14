using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tenders.Api.Application.Queries;
using Tenders.Api.Contracts.Endpoints;

namespace Tenders.Api.Controllers
{
    [ApiController]
    [Route("api/suppliers")]
    public class SuppliersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SuppliersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}/tenders")]
        public async Task<IActionResult> GetTendersForSuplier(GetTendersForSupplierParameters parameters)
        {
            if (!ModelState.IsValid)
                return ValidationProblem(ModelState);

            var query = new GetTendersForSupplierQuery(parameters);
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
