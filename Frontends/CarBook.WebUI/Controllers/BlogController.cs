using CarBook.Application.Features.Blogs.Queries.GetAllBlogs;
using CarBook.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly HttpClient _httpClient = HttpClientInstance.CreateClient();
        public async Task<IActionResult> Index()
        {
            ViewBag.ParentPage = "Blog";
            ViewBag.CurrentPage = "Bloglarımız";

            var values = await _httpClient.GetFromJsonAsync<IList<GetAllBlogsWithAuthorQueryResponse>>("Blogs/GetAllBlogsWithAuthor");

            return View(values);
        }
    }
}
