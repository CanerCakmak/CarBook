using CarBook.Application.Features.Banners.Commands.CreateBanner;
using CarBook.Application.Features.Banners.Commands.DeleteBanner;
using CarBook.Application.Features.Banners.Commands.RemoveBanner;
using CarBook.Application.Features.Banners.Commands.UpdateBanner;
using CarBook.Application.Features.Banners.Queries.GetBannerById;
using CarBook.Application.Features.Banners.Queries.GetAllBanners;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BannersController : Controller
    {
        private readonly IMediator _mediator;

        public BannersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBanners()
        {
            var response = await _mediator.Send(new GetAllBannersQueryRequest());
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBannerByID(int id)
        {
            var response = await _mediator.Send(new GetBannerByIdQueryRequest(id));

            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBanner(CreateBannerCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Hakkında Başarıyla Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBanner(UpdateBannerCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Hakkında Başarıyla Düzenlendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteBanner(DeleteBannerCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Hakkında Başarıyla Silindi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveBanner(RemoveBannerCommandRequest request)
        {
            await _mediator.Send(request);

            return Ok("Hakkında Başarıyla Sistemden Silindi");
        }

    }
}
