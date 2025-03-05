using CarBook.Application.Features.Authors.Commands.CreateAuthor;
using CarBook.Application.Features.Authors.Commands.DeleteAuthor;
using CarBook.Application.Features.Authors.Commands.RemoveAuthor;
using CarBook.Application.Features.Authors.Commands.UpdateAuthor;
using CarBook.Application.Features.Authors.Queries.GetAuthorById;
using CarBook.Application.Features.Authors.Queries.GetAllAuthors;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthorsController : Controller
    {
        private readonly IMediator _mediator;

        public AuthorsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAuthors()
        {
            var response = await _mediator.Send(new GetAllAuthorsQueryRequest());
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthorByID(int id)
        {
            var response = await _mediator.Send(new GetAuthorByIdQueryRequest(id));

            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAuthor(CreateAuthorCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Yazar Başarıyla Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAuthor(UpdateAuthorCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Yazar Başarıyla Düzenlendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAuthor(DeleteAuthorCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Yazar Başarıyla Silindi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveAuthor(RemoveAuthorCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Yazar Başarıyla Sistemden Silindi");
        }

    }
}
