using CarBook.Application.Features.Blogs.Queries.GetAllBlogs;
using CarBook.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class AboutController : Controller
    {
        private readonly HttpClient _httpClient = HttpClientInstance.CreateClient();
        public IActionResult Index()
        {
            ViewBag.ParentPage = "Hakkında";
            ViewBag.CurrentPage = "Vizyonumuz & Misyonumuz";

            return View();
        }
    }
}
