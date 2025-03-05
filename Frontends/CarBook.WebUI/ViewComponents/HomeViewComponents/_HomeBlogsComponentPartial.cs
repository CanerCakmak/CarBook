using CarBook.WebUI.DTOs.BlogDtos;
using CarBook.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.HomeViewComponents
{
    public class _HomeBlogsComponentPartial : ViewComponent
    {
        private readonly HttpClient _httpClient = HttpClientInstance.CreateClient();
        public async Task<IViewComponentResult> InvokeAsync(int count = 3)
        {
            var blogs = await _httpClient.GetFromJsonAsync<IList<BlogWithAuthorResponse>>("Blogs/GetAllBlogsWithAuthor");

            if (blogs != null)
            {
                blogs.OrderByDescending(x => x.CreatedAt);
                blogs.Take(count);

                return View(blogs);
            }

            return View();
        }
    }
}
