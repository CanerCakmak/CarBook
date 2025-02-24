using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.LayoutViewComponents
{
    public class _MainCoverLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
