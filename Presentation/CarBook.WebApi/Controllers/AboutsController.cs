using CarBook.Application.Features.Abouts.Commands.CreateAbout;
using CarBook.Application.Features.Abouts.Commands.DeleteAbout;
using CarBook.Application.Features.Abouts.Commands.RemoveAbout;
using CarBook.Application.Features.Abouts.Commands.UpdateAbout;
using CarBook.Application.Features.Abouts.Queries.GetAboutById;
using CarBook.Application.Features.Abouts.Queries.GetAllAbouts;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AboutsController : Controller
    {
        private readonly IMediator _mediator;

        public AboutsController(IMediator mediator)
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
        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Hakkında Başarıyla Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAbout(UpdateAboutCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Hakkında Başarıyla Düzenlendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAbout(DeleteAboutCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Hakkında Başarıyla Silindi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveAbout(RemoveAboutCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Hakkında Başarıyla Sistemden Silindi");
        }

    }
}
