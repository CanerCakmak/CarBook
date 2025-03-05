using CarBook.Application.Features.Cars.Commands.CreateCar;
using CarBook.Application.Features.Cars.Commands.DeleteCar;
using CarBook.Application.Features.Cars.Commands.RemoveCar;
using CarBook.Application.Features.Cars.Commands.UpdateCar;
using CarBook.Application.Features.Cars.Queries.GetCarById;
using CarBook.Application.Features.Cars.Queries.GetAllCarsWithBrand;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using CarBook.Application.Features.Brands.Commands.CreateBrand;
using CarBook.Application.Features.Cars.Queries.GetCarsWithBrandByCount;
using CarBook.Application.Features.Cars.Queries.GetAllCarsWithPriceAndBrand;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CarsController : Controller
    {
        private readonly IMediator _mediator;

        public CarsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCarsWithBrand()
        {
            var response = await _mediator.Send(new GetAllCarsWithBrandQueryRequest());
            return Ok(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCarsWithPriceAndBrand()
        {
            var response = await _mediator.Send(new GetAllCarsWithPriceAndBrandQueryRequest());
            return Ok(response);
        }
        
        [HttpGet]
        public async Task<IActionResult> GetCarsWithBrandByCount(int count =12)
        {
            var response = await _mediator.Send(new GetCarsWithBrandByCountQueryRequest(count));
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCarByID(int id)
        {
            var response = await _mediator.Send(new GetCarByIdQueryRequest(id));

            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCar(CreateCarCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Araba Başarıyla Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCar(UpdateCarCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Araç Başarıyla Düzenlendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCar(DeleteCarCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Araç Başarıyla Silindi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveCar(RemoveCarCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Araç Başarıyla Sistemden Silindi");
        }

    }
}
