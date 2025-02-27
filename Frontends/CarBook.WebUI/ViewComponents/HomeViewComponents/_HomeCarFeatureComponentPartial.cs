using CarBook.WebUI.DTOs.CarDtos;
using CarBook.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CarBook.WebUI.ViewComponents.HomeViewComponents
{
    public class _HomeCarFeatureComponentPartial : ViewComponent
    {
        private readonly HttpClient _httpClient = HttpClientInstance.CreateClient();
        public async Task<IViewComponentResult> InvokeAsync(int count = 5)
        {
            var values = await _httpClient.GetFromJsonAsync<IList<GetCarsWithBrandDto>>($"Cars/GetCarsWithBrandByCount?count={count}");

            return View(values);
        }
    }
}
