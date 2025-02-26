using CarBook.WebUI.DTOs.CarDtos;
using CarBook.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class CarController : Controller
    {
        private readonly HttpClient _httpClient = HttpClientInstance.CreateClient();
        public async Task<IActionResult> Index()
        {
            var values = await _httpClient.GetFromJsonAsync<IList<GetAllCarsWithBrandDto>>("Cars/GetAllCarsWithBrand");

            return View(values);
        }
    }
}
