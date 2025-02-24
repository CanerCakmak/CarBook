using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.LayoutViewComponents
{
    public class _ScriptLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
