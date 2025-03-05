using CarBook.Application.Features.Prices.Commands.CreatePrice;
using CarBook.Application.Features.Prices.Queries.GetAllPrices;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PricesController : Controller
    {
        private readonly IMediator _mediator;

        public PricesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPrices()
        {
            var response = await _mediator.Send(new GetAllPricesQueryRequest());
            return Ok(response);
        }

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetPriceByID(int id)
        //{
        //    var response = await _mediator.Send(new GetPriceByIdQueryRequest(id));

        //    return Ok(response);
        //}
        [HttpPost]
        public async Task<IActionResult> CreatePrice(CreatePriceCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Ücret Dilimi Başarıyla Eklendi");
        }
        //[HttpPut]
        //public async Task<IActionResult> UpdatePrice(UpdatePriceCommandRequest request)
        //{
        //    await _mediator.Send(request);

        //    return Ok("Hakkında Başarıyla Düzenlendi");
        //}
        //[HttpDelete]
        //public async Task<IActionResult> DeletePrice(DeletePriceCommandRequest request)
        //{
        //    await _mediator.Send(request);

        //    return Ok("Hakkında Başarıyla Silindi");
        //}
        //[HttpDelete]
        //public async Task<IActionResult> RemovePrice(RemovePriceCommandRequest request)
        //{
        //    await _mediator.Send(request);

        //    return Ok("Hakkında Başarıyla Sistemden Silindi");
        //}

    }
}
