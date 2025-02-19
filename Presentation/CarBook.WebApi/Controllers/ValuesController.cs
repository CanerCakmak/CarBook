using CarBook.Application.Features.Abouts.Queries.GetAboutById;
using CarBook.Application.Features.Abouts.Queries.GetAllAbouts;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ValuesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAbouts()
        {
            var response = await _mediator.Send(new GetAllAboutsQueryRequest());
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAboutByID(int id)
        {
            var response = await _mediator.Send(new GetAboutByIdQueryRequest(id));

            return Ok(response);
        }

    }
}
