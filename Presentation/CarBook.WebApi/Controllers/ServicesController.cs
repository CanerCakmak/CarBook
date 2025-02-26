using CarBook.Application.Features.Services.Commands.CreateService;
using CarBook.Application.Features.Services.Commands.DeleteService;
using CarBook.Application.Features.Services.Commands.RemoveService;
using CarBook.Application.Features.Services.Commands.UpdateService;
using CarBook.Application.Features.Services.Queries.GetServiceById;
using CarBook.Application.Features.Services.Queries.GetAllServices;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ServicesController : Controller
    {
        private readonly IMediator _mediator;

        public ServicesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllServices()
        {
            var response = await _mediator.Send(new GetAllServicesQueryRequest());
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetServiceByID(int id)
        {
            var response = await _mediator.Send(new GetServiceByIdQueryRequest(id));

            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Hizmet Başarıyla Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateService(UpdateServiceCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Hizmet Başarıyla Düzenlendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteService(DeleteServiceCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Hizmet Başarıyla Silindi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveService(RemoveServiceCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Hizmet Başarıyla Sistemden Silindi");
        }

    }
}
