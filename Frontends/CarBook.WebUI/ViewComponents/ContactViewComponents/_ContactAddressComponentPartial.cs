using CarBook.WebUI.DTOs.FooterDtos;
using CarBook.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.ContactViewComponents
{
    public class _ContactAddressComponentPartial : ViewComponent
    {
        private readonly HttpClient _httpClient = HttpClientInstance.CreateClient();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _httpClient.GetFromJsonAsync<IList<FooterAddressDto>>("Footers/GetAllFooters");

            return View(values);
        }
    }
}
