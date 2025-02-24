using CarBook.WebUI.DTOs.AboutDtos;
using CarBook.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents.AboutViewComponents
{
    public class _AboutUsComponentPartial : ViewComponent
    {
        private readonly HttpClient _httpClient = HttpClientInstance.CreateClient();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _httpClient.GetFromJsonAsync<IList<AboutDtoResponse>>("Abouts/GetAllAbouts");
 
            return View(values);
        }
    }
}
