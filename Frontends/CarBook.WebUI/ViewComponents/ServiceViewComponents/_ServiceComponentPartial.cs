using CarBook.WebUI.DTOs.ServiceDtos;
using CarBook.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace CarBook.WebUI.ViewComponents.ServiceViewComponents
{
    public class _ServiceComponentPartial : ViewComponent
    {
        private readonly HttpClient _httpClient = HttpClientInstance.CreateClient();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var services = await _httpClient.GetFromJsonAsync<IList<ServiceDtoResponse>>("Services/GetAllServices");
            
            var service = services.FirstOrDefault();
            return View(service);
        }
    }
}
