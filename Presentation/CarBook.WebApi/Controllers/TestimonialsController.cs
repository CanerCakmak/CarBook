using CarBook.Application.Features.Testimonials.Commands.CreateTestimonial;
using CarBook.Application.Features.Testimonials.Commands.DeleteTestimonial;
using CarBook.Application.Features.Testimonials.Commands.RemoveTestimonial;
using CarBook.Application.Features.Testimonials.Commands.UpdateTestimonial;
using CarBook.Application.Features.Testimonials.Queries.GetTestimonialById;
using CarBook.Application.Features.Testimonials.Queries.GetAllTestimonials;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TestimonialsController : Controller
    {
        private readonly IMediator _mediator;

        public TestimonialsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTestimonials()
        {
            var response = await _mediator.Send(new GetAllTestimonialsQueryRequest());
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTestimonialByID(int id)
        {
            var response = await _mediator.Send(new GetTestimonialByIdQueryRequest(id));

            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Hakkında Başarıyla Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Hakkında Başarıyla Düzenlendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteTestimonial(DeleteTestimonialCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Hakkında Başarıyla Silindi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveTestimonial(RemoveTestimonialCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Hakkında Başarıyla Sistemden Silindi");
        }

    }
}
