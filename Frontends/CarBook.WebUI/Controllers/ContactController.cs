using CarBook.WebUI.DTOs.ContactDtos;
using CarBook.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly HttpClient _httpClient = HttpClientInstance.CreateClient();
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.ParentPage = "İletişim";
            ViewBag.CurrentPage = "İletişim";

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateContactDto model)
        {
            var responseMessage = await _httpClient.PostAsJsonAsync("Contacts/CreateContact" , model);
            if (responseMessage.IsSuccessStatusCode)
                return RedirectToAction("Index");

            return View(model);
        }
    }
}
