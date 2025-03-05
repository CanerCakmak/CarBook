using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.HomeViewComponents
{
    public class _HomeStatisticsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
