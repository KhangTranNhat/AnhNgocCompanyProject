namespace AnhNgocPackaging.Presentation.Client.Base
{
    public abstract class BaseClientPageController : Controller
    {
        private const string CLIENT_PAGE_PATH = "~/Views/Client/Page/";
        protected IActionResult RenderPageView<TModel>(string pageName, TModel? model)
        {
            string viewPath = Path.Combine(CLIENT_PAGE_PATH, $"{pageName}.cshtml");
            return View(viewPath, model);
        }

        protected IActionResult RenderPageView(string pageName)
        {
            string viewPath = Path.Combine(CLIENT_PAGE_PATH, $"{pageName}.cshtml");
            return View(viewPath);
        }
    }

}
