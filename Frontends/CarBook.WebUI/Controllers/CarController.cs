using CarBook.Application.Features.Cars.Queries.GetAllCarsWithPriceAndBrand;
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
            ViewBag.ParentPage = "Araçlar";
            ViewBag.CurrentPage = "Araçlar";

            var values = await _httpClient.GetFromJsonAsync<IList<GetAllCarsWithPriceAndBrandQueryResponse>>("Cars/GetAllCarsWithPriceAndBrand");

            return View(values);
        }
    }
}
