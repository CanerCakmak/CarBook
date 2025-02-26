using CarBook.WebUI.DTOs.ServiceDtos;
using CarBook.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
