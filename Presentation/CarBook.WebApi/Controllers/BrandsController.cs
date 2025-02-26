using CarBook.Application.Features.Brands.Commands.CreateBrand;
using CarBook.Application.Features.Brands.Commands.DeleteBrand;
using CarBook.Application.Features.Brands.Commands.RemoveBrand;
using CarBook.Application.Features.Brands.Commands.UpdateBrand;
using CarBook.Application.Features.Brands.Queries.GetAllBrands;
using CarBook.Application.Features.Brands.Queries.GetBrandById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BrandBook.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BrandsController : Controller
    {
        private readonly IMediator _mediator;

        public BrandsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBrands()
        {
            var response = await _mediator.Send(new GetAllBrandsQueryRequest());
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBrandByID(int id)
        {
            var response = await _mediator.Send(new GetBrandByIdQueryRequest(id));

            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBrand(CreateBrandCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Marka Başarıyla Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBrand(UpdateBrandCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Marka Başarıyla Düzenlendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteBrand(DeleteBrandCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Marka Başarıyla Silindi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveBrand(RemoveBrandCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Marka Başarıyla Sistemden Silindi");
        }

    }
}
