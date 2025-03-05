using CarBook.Application.Features.CarPrices.Commands.CreateCarPrice;
using CarBook.Application.Features.CarPrices.Queries.GetAllCarPricesWithCar;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CarPricesController : Controller
    {
        private readonly IMediator _mediator;

        public CarPricesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCarPricesWithCarQueryRequest()
        {
            var response = await _mediator.Send(new GetAllCarPricesWithCarQueryRequest());
            return Ok(response);
        }

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetCarPricesByID(int id)
        //{
        //    var response = await _mediator.Send(new GetCarPriceByIdQueryRequest(id));

        //    return Ok(response);
        //}
        [HttpPost]
        public async Task<IActionResult> CreateCarPrices(CreateCarPriceCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Hakkında Başarıyla Eklendi");
        }
        //[HttpPut]
        //public async Task<IActionResult> UpdateCarPrices(UpdateCarPriceCommandRequest request)
        //{
        //    await _mediator.Send(request);

        //    return Ok("Hakkında Başarıyla Düzenlendi");
        //}
        //[HttpDelete]
        //public async Task<IActionResult> DeleteCarPrices(DeleteCarPriceCommandRequest request)
        //{
        //    await _mediator.Send(request);

        //    return Ok("Hakkında Başarıyla Silindi");
        //}
        //[HttpDelete]
        //public async Task<IActionResult> RemoveCarPrices(RemoveCarPriceCommandRequest request)
        //{
        //    await _mediator.Send(request);

        //    return Ok("Hakkında Başarıyla Sistemden Silindi");
        //}

    }
}


