using CarBook.Application.Features.CarPrices.Queries.GetAllCarPricesWithCar;
using CarBook.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class CarPriceController : Controller
    {
        private readonly HttpClient _httpClient = HttpClientInstance.CreateClient();
        public IActionResult Index()
        {
            var values = _httpClient.GetFromJsonAsync<IList<GetAllCarPricesWithCarQueryResponse>>("CarPrices/GetAllCarPricesWithCarQueryRequest");

            return View(values);
        }
    }
}
