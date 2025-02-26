using CarBook.Application.Features.Footers.Commands.CreateFooter;
using CarBook.Application.Features.Footers.Commands.DeleteFooter;
using CarBook.Application.Features.Footers.Commands.RemoveFooter;
using CarBook.Application.Features.Footers.Commands.UpdateFooter;
using CarBook.Application.Features.Footers.Queries.GetFooterById;
using CarBook.Application.Features.Footers.Queries.GetAllFooters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FootersController : Controller
    {
        private readonly IMediator _mediator;

        public FootersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllFooters()
        {
            var response = await _mediator.Send(new GetAllFootersQueryRequest());
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFooterByID(int id)
        {
            var response = await _mediator.Send(new GetFooterByIdQueryRequest(id));

            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> CreateFooter(CreateFooterCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Alt Bilgi Başarıyla Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateFooter(UpdateFooterCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Alt Bilgi Başarıyla Düzenlendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteFooter(DeleteFooterCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Alt Bilgi Başarıyla Silindi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveFooter(RemoveFooterCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Alt Bilgi Başarıyla Sistemden Silindi");
        }

    }
}
