using CarBook.WebUI.DTOs.BannerDtos;
using CarBook.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.HomeViewComponents
{
    public class _HomeCoverComponentPartial : ViewComponent
    {
        private readonly HttpClient _httpClient = HttpClientInstance.CreateClient();
        public async  Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _httpClient.GetFromJsonAsync<IList<BannerDto>>("Banners/GetAllBanners");
            return View(values);
        }
    }
}
