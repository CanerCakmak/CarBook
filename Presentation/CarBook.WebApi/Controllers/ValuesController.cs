using CarBook.Application.Features.Abouts.Commands.CreateAbout;
using CarBook.Application.Features.Abouts.Commands.DeleteAbout;
using CarBook.Application.Features.Abouts.Commands.RemoveAbout;
using CarBook.Application.Features.Abouts.Commands.UpdateAbout;
using CarBook.Application.Features.Abouts.Queries.GetAboutById;
using CarBook.Application.Features.Abouts.Queries.GetAllAbouts;
using CarBook.Application.Features.CarPrices.Queries.GetAllCarPricesWithCar;
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
        public async Task<IActionResult> GetAllPricesWithCar()
        {
            var response = await _mediator.Send(new GetAllCarPricesWithCarQueryRequest());
            return Ok(response);
        }


    }
}
