using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
