using MediatR;
using Microsoft.AspNetCore.Mvc;
using VerticalSliceArchitecture.Features.Requirements;

namespace VerticalSliceArchitecture.Features.Consoles
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequirementsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public RequirementsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetAllRequirements.RequirementResult>>> GetRequirementsAsync()
        {
            var result = await _mediator.Send(new GetAllRequirements.GetRequirementsQuery());

            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}
